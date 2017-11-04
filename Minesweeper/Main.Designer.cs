namespace Minesweeper
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicOnoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMainMenu = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.nudBombs = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bPlay = new System.Windows.Forms.Button();
            this.pRules = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bRulesReturn = new System.Windows.Forms.Button();
            this.lRulesText = new System.Windows.Forms.Label();
            this.lRules = new System.Windows.Forms.Label();
            this.pAuthor = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bAuthorReturn = new System.Windows.Forms.Button();
            this.pGame = new System.Windows.Forms.Panel();
            this.tbBombsCounter = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.pTiles = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pWin = new System.Windows.Forms.Panel();
            this.bQuitW = new System.Windows.Forms.Button();
            this.bPlayAgainW = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pLose = new System.Windows.Forms.Panel();
            this.bQuitL = new System.Windows.Forms.Button();
            this.bPlayAgainL = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tiles = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.pMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.pRules.SuspendLayout();
            this.pAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pGame.SuspendLayout();
            this.pWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pLose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicOnoffToolStripMenuItem,
            this.restartGameToolStripMenuItem,
            this.endGameToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // musicOnoffToolStripMenuItem
            // 
            this.musicOnoffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextSongToolStripMenuItem,
            this.previousSongToolStripMenuItem,
            this.addSongToolStripMenuItem});
            this.musicOnoffToolStripMenuItem.Name = "musicOnoffToolStripMenuItem";
            this.musicOnoffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.musicOnoffToolStripMenuItem.Text = "Music on/off";
            this.musicOnoffToolStripMenuItem.Click += new System.EventHandler(this.musicOnoffToolStripMenuItem_Click);
            // 
            // nextSongToolStripMenuItem
            // 
            this.nextSongToolStripMenuItem.Enabled = false;
            this.nextSongToolStripMenuItem.Name = "nextSongToolStripMenuItem";
            this.nextSongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nextSongToolStripMenuItem.Text = "Next Song";
            this.nextSongToolStripMenuItem.Click += new System.EventHandler(this.nextSongToolStripMenuItem_Click);
            // 
            // previousSongToolStripMenuItem
            // 
            this.previousSongToolStripMenuItem.Enabled = false;
            this.previousSongToolStripMenuItem.Name = "previousSongToolStripMenuItem";
            this.previousSongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.previousSongToolStripMenuItem.Text = "Previous Song";
            this.previousSongToolStripMenuItem.Click += new System.EventHandler(this.previousSongToolStripMenuItem_Click);
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addSongToolStripMenuItem.Text = "Add Song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.addSongToolStripMenuItem_Click);
            // 
            // restartGameToolStripMenuItem
            // 
            this.restartGameToolStripMenuItem.Enabled = false;
            this.restartGameToolStripMenuItem.Name = "restartGameToolStripMenuItem";
            this.restartGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartGameToolStripMenuItem.Text = "Restart game";
            this.restartGameToolStripMenuItem.Click += new System.EventHandler(this.bPlayAgain_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endGameToolStripMenuItem.Text = "End game";
            this.endGameToolStripMenuItem.Click += new System.EventHandler(this.bQuit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.rulesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // pMainMenu
            // 
            this.pMainMenu.BackColor = System.Drawing.Color.Silver;
            this.pMainMenu.Controls.Add(this.label8);
            this.pMainMenu.Controls.Add(this.nudBombs);
            this.pMainMenu.Controls.Add(this.label7);
            this.pMainMenu.Controls.Add(this.nudColumns);
            this.pMainMenu.Controls.Add(this.label6);
            this.pMainMenu.Controls.Add(this.nudRows);
            this.pMainMenu.Controls.Add(this.label5);
            this.pMainMenu.Controls.Add(this.label4);
            this.pMainMenu.Controls.Add(this.label3);
            this.pMainMenu.Controls.Add(this.label2);
            this.pMainMenu.Controls.Add(this.bPlay);
            this.pMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainMenu.Location = new System.Drawing.Point(0, 24);
            this.pMainMenu.Name = "pMainMenu";
            this.pMainMenu.Size = new System.Drawing.Size(534, 437);
            this.pMainMenu.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Source Code Pro Semibold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(79, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(380, 42);
            this.label8.TabIndex = 10;
            this.label8.Text = "Please press the button below when you are ready to start your uniqe adventure";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudBombs
            // 
            this.nudBombs.Location = new System.Drawing.Point(287, 216);
            this.nudBombs.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudBombs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBombs.Name = "nudBombs";
            this.nudBombs.Size = new System.Drawing.Size(120, 20);
            this.nudBombs.TabIndex = 9;
            this.nudBombs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(127, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "number of bombs:";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(287, 186);
            this.nudColumns.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudColumns.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(120, 20);
            this.nudColumns.TabIndex = 7;
            this.nudColumns.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.setMaxBombsNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(127, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "number of columns:";
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(287, 154);
            this.nudRows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(120, 20);
            this.nudRows.TabIndex = 5;
            this.nudRows.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.setMaxBombsNumber);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(215, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Please define:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(127, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "number of rows:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Code Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(127, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Design the rules of your own game!\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to Minesweeper!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bPlay
            // 
            this.bPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bPlay.Location = new System.Drawing.Point(224, 372);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(75, 23);
            this.bPlay.TabIndex = 0;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // pRules
            // 
            this.pRules.BackColor = System.Drawing.Color.Silver;
            this.pRules.Controls.Add(this.label11);
            this.pRules.Controls.Add(this.label10);
            this.pRules.Controls.Add(this.label9);
            this.pRules.Controls.Add(this.label1);
            this.pRules.Controls.Add(this.bRulesReturn);
            this.pRules.Controls.Add(this.lRulesText);
            this.pRules.Controls.Add(this.lRules);
            this.pRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRules.Location = new System.Drawing.Point(0, 24);
            this.pRules.Name = "pRules";
            this.pRules.Size = new System.Drawing.Size(534, 437);
            this.pRules.TabIndex = 1;
            this.pRules.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(11, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(509, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Good luck and have fun! :)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(13, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(509, 55);
            this.label10.TabIndex = 5;
            this.label10.Text = "Keep moving through a process of elimination. As you go around the board, flag po" +
    "tential mines. If you find that you\'ve flagged more mines than the game allows, " +
    "go back and re-evaluate them. ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(13, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(509, 55);
            this.label9.TabIndex = 4;
            this.label9.Text = " Use all of the numbers in a given area to figure out where the mines are. Elimin" +
    "ate squares that can\'t possibly contain mines by left clicking.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click any squares you like.  As you uncover tiles, you will see numbers revealed." +
    " A number means that there are that number of bombs touching that tile (both sid" +
    "es, top/bottom, and diagonally). ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bRulesReturn
            // 
            this.bRulesReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bRulesReturn.Location = new System.Drawing.Point(197, 402);
            this.bRulesReturn.Name = "bRulesReturn";
            this.bRulesReturn.Size = new System.Drawing.Size(125, 23);
            this.bRulesReturn.TabIndex = 2;
            this.bRulesReturn.Text = "Return";
            this.bRulesReturn.UseVisualStyleBackColor = true;
            this.bRulesReturn.Click += new System.EventHandler(this.bRulesReturn_Click);
            // 
            // lRulesText
            // 
            this.lRulesText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lRulesText.Font = new System.Drawing.Font("Source Code Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRulesText.Location = new System.Drawing.Point(12, 61);
            this.lRulesText.Name = "lRulesText";
            this.lRulesText.Size = new System.Drawing.Size(509, 35);
            this.lRulesText.TabIndex = 1;
            this.lRulesText.Text = "The number in the upper-left corner denotes the number of mines on the board. The" +
    " number beside it is the timer. ";
            this.lRulesText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lRules
            // 
            this.lRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lRules.AutoSize = true;
            this.lRules.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRules.Location = new System.Drawing.Point(227, 10);
            this.lRules.Name = "lRules";
            this.lRules.Size = new System.Drawing.Size(72, 35);
            this.lRules.TabIndex = 0;
            this.lRules.Text = "Rules";
            this.lRules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pAuthor
            // 
            this.pAuthor.BackColor = System.Drawing.Color.Silver;
            this.pAuthor.Controls.Add(this.label19);
            this.pAuthor.Controls.Add(this.label18);
            this.pAuthor.Controls.Add(this.label17);
            this.pAuthor.Controls.Add(this.label16);
            this.pAuthor.Controls.Add(this.label15);
            this.pAuthor.Controls.Add(this.label14);
            this.pAuthor.Controls.Add(this.label13);
            this.pAuthor.Controls.Add(this.label12);
            this.pAuthor.Controls.Add(this.pictureBox1);
            this.pAuthor.Controls.Add(this.bAuthorReturn);
            this.pAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAuthor.Location = new System.Drawing.Point(0, 24);
            this.pAuthor.Name = "pAuthor";
            this.pAuthor.Size = new System.Drawing.Size(534, 437);
            this.pAuthor.TabIndex = 4;
            this.pAuthor.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(280, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(196, 19);
            this.label19.TabIndex = 9;
            this.label19.Text = "class: 3B profile math-phys-it";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(268, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(215, 19);
            this.label18.TabIndex = 8;
            this.label18.Text = "name of school: VLO in Gdańsk";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(275, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 19);
            this.label17.TabIndex = 7;
            this.label17.Text = "phone number: 123-456-789*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(344, 380);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "*some fake data to fill the gaps";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(267, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(216, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "e-mail: maja.sugier@mail.com*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(285, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "date of birth: 01-01-1999*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(266, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "name and surname: Maja Sugier";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(346, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 28);
            this.label12.TabIndex = 2;
            this.label12.Text = "Author";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bAuthorReturn
            // 
            this.bAuthorReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bAuthorReturn.Location = new System.Drawing.Point(224, 402);
            this.bAuthorReturn.Name = "bAuthorReturn";
            this.bAuthorReturn.Size = new System.Drawing.Size(75, 23);
            this.bAuthorReturn.TabIndex = 0;
            this.bAuthorReturn.Text = "Return";
            this.bAuthorReturn.UseVisualStyleBackColor = true;
            this.bAuthorReturn.Click += new System.EventHandler(this.bAuthorReturn_Click);
            // 
            // pGame
            // 
            this.pGame.BackColor = System.Drawing.Color.Silver;
            this.pGame.Controls.Add(this.tbBombsCounter);
            this.pGame.Controls.Add(this.tbTimer);
            this.pGame.Controls.Add(this.pTiles);
            this.pGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGame.Location = new System.Drawing.Point(0, 24);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(534, 437);
            this.pGame.TabIndex = 11;
            this.pGame.Visible = false;
            // 
            // tbBombsCounter
            // 
            this.tbBombsCounter.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tbBombsCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBombsCounter.Enabled = false;
            this.tbBombsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBombsCounter.Location = new System.Drawing.Point(12, 6);
            this.tbBombsCounter.Name = "tbBombsCounter";
            this.tbBombsCounter.ReadOnly = true;
            this.tbBombsCounter.Size = new System.Drawing.Size(48, 26);
            this.tbBombsCounter.TabIndex = 2;
            this.tbBombsCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimer
            // 
            this.tbTimer.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimer.Enabled = false;
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTimer.Location = new System.Drawing.Point(474, 6);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(48, 26);
            this.tbTimer.TabIndex = 0;
            this.tbTimer.Text = "00:00";
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pTiles
            // 
            this.pTiles.AutoSize = true;
            this.pTiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTiles.Location = new System.Drawing.Point(0, 38);
            this.pTiles.Margin = new System.Windows.Forms.Padding(0);
            this.pTiles.Name = "pTiles";
            this.pTiles.Padding = new System.Windows.Forms.Padding(10);
            this.pTiles.Size = new System.Drawing.Size(20, 20);
            this.pTiles.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pWin
            // 
            this.pWin.BackColor = System.Drawing.Color.Silver;
            this.pWin.Controls.Add(this.bQuitW);
            this.pWin.Controls.Add(this.bPlayAgainW);
            this.pWin.Controls.Add(this.pictureBox3);
            this.pWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWin.Location = new System.Drawing.Point(0, 24);
            this.pWin.Name = "pWin";
            this.pWin.Size = new System.Drawing.Size(534, 437);
            this.pWin.TabIndex = 1;
            this.pWin.Visible = false;
            // 
            // bQuitW
            // 
            this.bQuitW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bQuitW.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitW.Location = new System.Drawing.Point(381, 392);
            this.bQuitW.Name = "bQuitW";
            this.bQuitW.Size = new System.Drawing.Size(75, 23);
            this.bQuitW.TabIndex = 2;
            this.bQuitW.Text = "Quit";
            this.bQuitW.UseVisualStyleBackColor = true;
            this.bQuitW.Click += new System.EventHandler(this.bQuit_Click);
            // 
            // bPlayAgainW
            // 
            this.bPlayAgainW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bPlayAgainW.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlayAgainW.Location = new System.Drawing.Point(82, 392);
            this.bPlayAgainW.Name = "bPlayAgainW";
            this.bPlayAgainW.Size = new System.Drawing.Size(75, 23);
            this.bPlayAgainW.TabIndex = 1;
            this.bPlayAgainW.Text = "Play Again!";
            this.bPlayAgainW.UseVisualStyleBackColor = true;
            this.bPlayAgainW.Click += new System.EventHandler(this.bPlayAgain_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(534, 437);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pLose
            // 
            this.pLose.BackColor = System.Drawing.Color.Silver;
            this.pLose.Controls.Add(this.bQuitL);
            this.pLose.Controls.Add(this.bPlayAgainL);
            this.pLose.Controls.Add(this.pictureBox2);
            this.pLose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLose.Location = new System.Drawing.Point(0, 24);
            this.pLose.Name = "pLose";
            this.pLose.Size = new System.Drawing.Size(534, 437);
            this.pLose.TabIndex = 12;
            this.pLose.Visible = false;
            // 
            // bQuitL
            // 
            this.bQuitL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bQuitL.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitL.Location = new System.Drawing.Point(414, 207);
            this.bQuitL.Name = "bQuitL";
            this.bQuitL.Size = new System.Drawing.Size(75, 23);
            this.bQuitL.TabIndex = 2;
            this.bQuitL.Text = "Quit...";
            this.bQuitL.UseVisualStyleBackColor = true;
            this.bQuitL.Click += new System.EventHandler(this.bQuit_Click);
            // 
            // bPlayAgainL
            // 
            this.bPlayAgainL.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlayAgainL.Location = new System.Drawing.Point(45, 207);
            this.bPlayAgainL.Name = "bPlayAgainL";
            this.bPlayAgainL.Size = new System.Drawing.Size(75, 23);
            this.bPlayAgainL.TabIndex = 1;
            this.bPlayAgainL.Text = "Play Again!";
            this.bPlayAgainL.UseVisualStyleBackColor = true;
            this.bPlayAgainL.Click += new System.EventHandler(this.bPlayAgain_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(534, 437);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tiles
            // 
            this.tiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tiles.ImageStream")));
            this.tiles.TransparentColor = System.Drawing.Color.Transparent;
            this.tiles.Images.SetKeyName(0, "tile_upside-down.png");
            this.tiles.Images.SetKeyName(1, "1.png");
            this.tiles.Images.SetKeyName(2, "2.png");
            this.tiles.Images.SetKeyName(3, "3.png");
            this.tiles.Images.SetKeyName(4, "4.png");
            this.tiles.Images.SetKeyName(5, "5.png");
            this.tiles.Images.SetKeyName(6, "6.png");
            this.tiles.Images.SetKeyName(7, "7.png");
            this.tiles.Images.SetKeyName(8, "8.png");
            this.tiles.Images.SetKeyName(9, "bomb.png");
            this.tiles.Images.SetKeyName(10, "tile.png");
            this.tiles.Images.SetKeyName(11, "flag.png");
            this.tiles.Images.SetKeyName(12, "bomb_red.png");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.pWin);
            this.Controls.Add(this.pGame);
            this.Controls.Add(this.pAuthor);
            this.Controls.Add(this.pLose);
            this.Controls.Add(this.pRules);
            this.Controls.Add(this.pMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Minesweeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMainMenu.ResumeLayout(false);
            this.pMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.pRules.ResumeLayout(false);
            this.pRules.PerformLayout();
            this.pAuthor.ResumeLayout(false);
            this.pAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pGame.ResumeLayout(false);
            this.pGame.PerformLayout();
            this.pWin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pLose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicOnoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.Panel pMainMenu;
        private System.Windows.Forms.Panel pRules;
        private System.Windows.Forms.Label lRules;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRulesReturn;
        private System.Windows.Forms.Label lRulesText;
        private System.Windows.Forms.Panel pAuthor;
        private System.Windows.Forms.Button bAuthorReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBombs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pGame;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pWin;
        private System.Windows.Forms.Panel pLose;
        private System.Windows.Forms.ImageList tiles;
        private System.Windows.Forms.Panel pTiles;
        private System.Windows.Forms.Button bQuitL;
        private System.Windows.Forms.Button bPlayAgainL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbBombsCounter;
        private System.Windows.Forms.Button bQuitW;
        private System.Windows.Forms.Button bPlayAgainW;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem nextSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
    }
}

