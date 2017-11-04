using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Minesweeper
{
    public partial class Main : Form
    {
        private Panel lastPanel;
        private int gameplayTime;
        private int[,] map;
        private int[,] mapState;
        private PictureBox[,] mapDisplay;

        private WindowsMediaPlayer music = new WindowsMediaPlayer();

        public Main()
        {
            InitializeComponent();
            lastPanel = pMainMenu;
            music.currentPlaylist.appendItem(music.newMedia("assets\\hotto dogu.mp3"));
            toggleMusic();
        }

        private void toggleMusic()
        {
            if (isMusicOn())
            {
                musicOnoffToolStripMenuItem.Text = "Music on/off (off)";
                music.controls.stop();
            } else
            {
                musicOnoffToolStripMenuItem.Text = "Music on/off (on)";
                music.controls.play();
            }
        }

        private bool isMusicOn()
        {
            return musicOnoffToolStripMenuItem.Text == "Music on/off (on)";
        }

        private void switchToPanel(Panel p)
        {
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                if (panel.Visible && panel != pAuthor && panel != pRules)
                {
                    lastPanel = panel;
                }

                panel.Visible = panel == p;
            }

            if (p == pGame)
            {
                this.Width = mapState.GetLength(0) * 16 + 34;
                this.Height = mapState.GetLength(1) * 16 + 111;
            } else
            {
                this.Size = new Size(550, 500);
            }
        }

        private void returnToPreviousPanel()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                panel.Visible = panel == lastPanel;
            }

            if (lastPanel == pGame)
            {
                this.Width = mapState.GetLength(0) * 16 + 34;
                this.Height = mapState.GetLength(1) * 16 + 111;
            }
            else
            {
                this.Size = new Size(550, 500);
            }
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToPanel(pRules);
        }

        private void bRulesReturn_Click(object sender, EventArgs e)
        {
            returnToPreviousPanel();
        }

        private void bAuthorReturn_Click(object sender, EventArgs e)
        {
            returnToPreviousPanel();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToPanel(pAuthor);
        }

        private void setMaxBombsNumber(object sender, EventArgs e)
        {
            nudBombs.Maximum = nudRows.Value * nudColumns.Value - 1;
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            gameplayTime = 0;
            displayTime();
            timer1.Start();
            restartGameToolStripMenuItem.Enabled = true;
            tbBombsCounter.Text = nudBombs.Value.ToString();
            int width = (int) nudColumns.Value;
            int height = (int) nudRows.Value;
            mapState = new int[width, height];
            displayMap(width, height);
            map = null;
            switchToPanel(pGame);
        }

        private void bPlayAgain_Click(object sender, EventArgs e)
        {
            restartGameToolStripMenuItem.Enabled = false;
            switchToPanel(pMainMenu);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameplayTime += 1;
            displayTime();
        }

        private void displayTime()
        {
            tbTimer.Text = string.Format("{0:D2}:{1:D2}", gameplayTime/60, gameplayTime%60);
        }

        private void generateMap(int width, int height, int bombs, int xFirst, int yFirst)
        {
            map = new int[width, height];

            Random rnd = new Random();
            while (bombs > 0)
            {
                int x = rnd.Next(0, width);
                int y = rnd.Next(0, height);
                if (map[x, y] == 0 && (x != xFirst || y != yFirst))
                {
                    map[x, y] = 9;
                    bombs--;
                }
            }

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (map[x, y] != 9)
                    {
                        map[x, y] = countNearbyBombs(x, y);
                    }
                }
            }
        }

        private void displayMap(int width, int height)
        {
            mapDisplay = new PictureBox[width, height];
            pTiles.Controls.Clear();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PictureBox tile = new PictureBox();
                    tile.Location = new Point(16 * x + pTiles.Padding.Left, 16 * y);
                    tile.Size = new Size(16, 16);
                    tile.Image = tiles.Images[10];
                    tile.Click += new System.EventHandler(this.reveal);
                    pTiles.Controls.Add(tile);
                    mapDisplay[x, y] = tile;
                }
            }
        }

        private void reveal(object sender, EventArgs e)
        {
            if (sender is PictureBox tile)
            {
                int x = tile.Location.X / 16,
                    y = tile.Location.Y / 16;

                if(map == null)
                {
                    generateMap((int)nudColumns.Value, (int)nudRows.Value, (int)nudBombs.Value, x, y);
                }

                MouseEventArgs me = (MouseEventArgs)e;
                if (me.Button == MouseButtons.Right)
                {
                    if (mapState[x, y] == 0)
                    {
                        mapState[x, y] = 2;
                        tile.Image = tiles.Images[11];
                        tbBombsCounter.Text = (Convert.ToInt16(tbBombsCounter.Text) - 1).ToString();
                    } else if (mapState[x, y] == 2)
                    {
                        mapState[x, y] = 0;
                        tile.Image = tiles.Images[10];
                        tbBombsCounter.Text = (Convert.ToInt16(tbBombsCounter.Text) + 1).ToString();
                    }
                } else
                {
                    if (mapState[x, y] == 0)
                    {
                        // Bomb
                        if (map[x, y] == 9)
                        {
                            revealBombs(x,y);
                            this.Refresh();
                            System.Threading.Thread.Sleep(3000);
                            switchToPanel(pLose);
                        }
                        else
                        {
                            recursiveReveal(x, y);
                            checkWinConditions();
                        }
                    }
                }
            }
        }

        private void recursiveReveal(int x, int y)
        {
            int width = map.GetLength(0) - 1;
            int height = map.GetLength(1) - 1;

            if (x >= 0 && y >= 0 && x <= width && y <= height)
            {
                int img = map[x, y];

                // already revealed / flagged
                if(mapState[x, y] != 0)
                {
                    return;
                }

                mapDisplay[x, y].Image = tiles.Images[img];
                mapState[x, y] = 1;

                if (img == 0)
                {
                    recursiveReveal(x - 1, y - 1);
                    recursiveReveal(x, y - 1 );
                    recursiveReveal(x + 1, y - 1);
                    recursiveReveal(x - 1, y);
                    recursiveReveal(x + 1, y);
                    recursiveReveal(x - 1, y + 1);
                    recursiveReveal(x, y + 1);
                    recursiveReveal(x + 1, y + 1);
                }
            }
        }

        private int countNearbyBombs(int x, int y)
        {
            int bombs = 0;
            int width = map.GetLength(0) - 1;
            int height = map.GetLength(1) - 1;

            if (x > 0 && y > 0 && map[x - 1, y - 1] == 9)
            {
                bombs++;
            }
            if (y > 0 && map[x, y - 1] == 9)
            {
                bombs++;
            }
            if (x < width && y > 0 && map[x + 1, y - 1] == 9)
            {
                bombs++;
            }
            if (x > 0 && map[x-1, y] == 9)
            {
                bombs++;
            }
            if (x < width && map[x + 1, y] == 9)
            {
                bombs++;
            }
            if (x > 0 && y < height && map[x - 1, y + 1] == 9)
            {
                bombs++;
            }
            if (y < height && map[x, y + 1] == 9)
            {
                bombs++;
            }
            if (x < width && y < height && map[x + 1, y + 1] == 9)
            {
                bombs++;
            }

            return bombs;
        }

        private void checkWinConditions()
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (map[x, y] != 9 && mapState[x, y] != 1)
                    {
                        return;
                    }
                }
            }

            revealBombs();
            this.Refresh();
            System.Threading.Thread.Sleep(3000);
            var player = new System.Media.SoundPlayer("assets\\win.wav");
            player.Play();
            switchToPanel(pWin);
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void musicOnoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleMusic();
        }

        private void revealBombs(int redX=-1, int redY=-1)
        {
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if(map[x,y] == 9)
                    {
                        if(x==redX && y==redY)
                        {
                            mapDisplay[x, y].Image = tiles.Images[12];
                        }
                        else
                        {
                            mapDisplay[x, y].Image = tiles.Images[9];
                        } 
                    }
                }
            }
        }

        private void addSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Music Files (*.mp3, *.wav)|*.mp3;*.wav";
            if (file.ShowDialog() == DialogResult.OK)
            {
                music.currentPlaylist.appendItem(music.newMedia(file.FileName));
                nextSongToolStripMenuItem.Enabled = true;
                previousSongToolStripMenuItem.Enabled = true;
            }
        }

        private void nextSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music.controls.next();
        }

        private void previousSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            music.controls.previous();
        }
    }
}
