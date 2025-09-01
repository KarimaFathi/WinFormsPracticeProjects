namespace RockPapperScissors
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdScissors = new System.Windows.Forms.RadioButton();
            this.rdPaper = new System.Windows.Forms.RadioButton();
            this.rdRock = new System.Windows.Forms.RadioButton();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.txtBoxNumberOfRounds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbFinalWinner = new System.Windows.Forms.Label();
            this.lbFinalDrawTimes = new System.Windows.Forms.Label();
            this.lbFinalComputerWonTimes = new System.Windows.Forms.Label();
            this.lbFinalPlayerWonTimes = new System.Windows.Forms.Label();
            this.lbFinalGameRounds = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRoundCounter = new System.Windows.Forms.Label();
            this.lbComputerWinCounter = new System.Windows.Forms.Label();
            this.lbDrawCounter = new System.Windows.Forms.Label();
            this.lbPlayerWinCounter = new System.Windows.Forms.Label();
            this.lbComputer = new System.Windows.Forms.Label();
            this.lbDraw = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.picBoxComputer = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.lbRound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRestartGame);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbWinner);
            this.panel1.Controls.Add(this.lbWin);
            this.panel1.Controls.Add(this.txtBoxNumberOfRounds);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 664);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Azure;
            this.btnClose.Location = new System.Drawing.Point(113, 569);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(197, 58);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRestartGame.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Azure;
            this.btnRestartGame.Location = new System.Drawing.Point(217, 474);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(203, 58);
            this.btnRestartGame.TabIndex = 6;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnStartGame.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Azure;
            this.btnStartGame.Location = new System.Drawing.Point(14, 474);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(186, 58);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start ";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.rdScissors);
            this.panel3.Controls.Add(this.rdPaper);
            this.panel3.Controls.Add(this.rdRock);
            this.panel3.Enabled = false;
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(0, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 90);
            this.panel3.TabIndex = 4;
            // 
            // rdScissors
            // 
            this.rdScissors.AutoSize = true;
            this.rdScissors.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdScissors.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdScissors.Location = new System.Drawing.Point(297, 33);
            this.rdScissors.Name = "rdScissors";
            this.rdScissors.Size = new System.Drawing.Size(127, 28);
            this.rdScissors.TabIndex = 2;
            this.rdScissors.TabStop = true;
            this.rdScissors.Text = "Scissors";
            this.rdScissors.UseVisualStyleBackColor = true;
            this.rdScissors.CheckedChanged += new System.EventHandler(this.rdScissors_CheckedChanged);
            // 
            // rdPaper
            // 
            this.rdPaper.AutoSize = true;
            this.rdPaper.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPaper.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdPaper.Location = new System.Drawing.Point(163, 33);
            this.rdPaper.Name = "rdPaper";
            this.rdPaper.Size = new System.Drawing.Size(100, 28);
            this.rdPaper.TabIndex = 1;
            this.rdPaper.TabStop = true;
            this.rdPaper.Text = "Paper";
            this.rdPaper.UseVisualStyleBackColor = true;
            this.rdPaper.CheckedChanged += new System.EventHandler(this.rdPaper_CheckedChanged);
            // 
            // rdRock
            // 
            this.rdRock.AutoSize = true;
            this.rdRock.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdRock.Location = new System.Drawing.Point(29, 33);
            this.rdRock.Name = "rdRock";
            this.rdRock.Size = new System.Drawing.Size(96, 28);
            this.rdRock.TabIndex = 0;
            this.rdRock.TabStop = true;
            this.rdRock.Text = " Rock";
            this.rdRock.UseVisualStyleBackColor = true;
            this.rdRock.CheckedChanged += new System.EventHandler(this.rdRock_CheckedChanged);
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Swis721 Blk BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbWinner.Location = new System.Drawing.Point(132, 262);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(220, 39);
            this.lbWinner.TabIndex = 3;
            this.lbWinner.Text = "In Progress";
            // 
            // lbWin
            // 
            this.lbWin.AutoSize = true;
            this.lbWin.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin.ForeColor = System.Drawing.Color.Gold;
            this.lbWin.Location = new System.Drawing.Point(131, 176);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(168, 44);
            this.lbWin.TabIndex = 2;
            this.lbWin.Text = "Winner ";
            // 
            // txtBoxNumberOfRounds
            // 
            this.txtBoxNumberOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumberOfRounds.Location = new System.Drawing.Point(123, 100);
            this.txtBoxNumberOfRounds.Name = "txtBoxNumberOfRounds";
            this.txtBoxNumberOfRounds.Size = new System.Drawing.Size(176, 30);
            this.txtBoxNumberOfRounds.TabIndex = 1;
            this.txtBoxNumberOfRounds.TextChanged += new System.EventHandler(this.txtBoxNumberOfRounds_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many rounds you want to play ?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lbRoundCounter);
            this.panel2.Controls.Add(this.lbComputerWinCounter);
            this.panel2.Controls.Add(this.lbDrawCounter);
            this.panel2.Controls.Add(this.lbPlayerWinCounter);
            this.panel2.Controls.Add(this.lbComputer);
            this.panel2.Controls.Add(this.lbDraw);
            this.panel2.Controls.Add(this.lbPlayer);
            this.panel2.Controls.Add(this.picBoxComputer);
            this.panel2.Controls.Add(this.picBoxPlayer);
            this.panel2.Controls.Add(this.lbRound);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(454, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 664);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFinalWinner);
            this.groupBox1.Controls.Add(this.lbFinalDrawTimes);
            this.groupBox1.Controls.Add(this.lbFinalComputerWonTimes);
            this.groupBox1.Controls.Add(this.lbFinalPlayerWonTimes);
            this.groupBox1.Controls.Add(this.lbFinalGameRounds);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Swis721 Blk BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(58, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 266);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Final Scores";
            this.groupBox1.Visible = false;
            // 
            // lbFinalWinner
            // 
            this.lbFinalWinner.AutoSize = true;
            this.lbFinalWinner.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalWinner.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbFinalWinner.Location = new System.Drawing.Point(297, 230);
            this.lbFinalWinner.Name = "lbFinalWinner";
            this.lbFinalWinner.Size = new System.Drawing.Size(29, 29);
            this.lbFinalWinner.TabIndex = 23;
            this.lbFinalWinner.Text = "0";
            // 
            // lbFinalDrawTimes
            // 
            this.lbFinalDrawTimes.AutoSize = true;
            this.lbFinalDrawTimes.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalDrawTimes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbFinalDrawTimes.Location = new System.Drawing.Point(297, 180);
            this.lbFinalDrawTimes.Name = "lbFinalDrawTimes";
            this.lbFinalDrawTimes.Size = new System.Drawing.Size(29, 29);
            this.lbFinalDrawTimes.TabIndex = 22;
            this.lbFinalDrawTimes.Text = "0";
            // 
            // lbFinalComputerWonTimes
            // 
            this.lbFinalComputerWonTimes.AutoSize = true;
            this.lbFinalComputerWonTimes.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalComputerWonTimes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbFinalComputerWonTimes.Location = new System.Drawing.Point(297, 136);
            this.lbFinalComputerWonTimes.Name = "lbFinalComputerWonTimes";
            this.lbFinalComputerWonTimes.Size = new System.Drawing.Size(29, 29);
            this.lbFinalComputerWonTimes.TabIndex = 21;
            this.lbFinalComputerWonTimes.Text = "0";
            // 
            // lbFinalPlayerWonTimes
            // 
            this.lbFinalPlayerWonTimes.AutoSize = true;
            this.lbFinalPlayerWonTimes.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalPlayerWonTimes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbFinalPlayerWonTimes.Location = new System.Drawing.Point(297, 91);
            this.lbFinalPlayerWonTimes.Name = "lbFinalPlayerWonTimes";
            this.lbFinalPlayerWonTimes.Size = new System.Drawing.Size(29, 29);
            this.lbFinalPlayerWonTimes.TabIndex = 20;
            this.lbFinalPlayerWonTimes.Text = "0";
            // 
            // lbFinalGameRounds
            // 
            this.lbFinalGameRounds.AutoSize = true;
            this.lbFinalGameRounds.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalGameRounds.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbFinalGameRounds.Location = new System.Drawing.Point(297, 45);
            this.lbFinalGameRounds.Name = "lbFinalGameRounds";
            this.lbFinalGameRounds.Size = new System.Drawing.Size(29, 29);
            this.lbFinalGameRounds.TabIndex = 17;
            this.lbFinalGameRounds.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(9, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Final winner               : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(9, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Draw times                 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(9, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Computer won times  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Player won times       : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(9, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Game rounds             : ";
            // 
            // lbRoundCounter
            // 
            this.lbRoundCounter.AutoSize = true;
            this.lbRoundCounter.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoundCounter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbRoundCounter.Location = new System.Drawing.Point(427, 284);
            this.lbRoundCounter.Name = "lbRoundCounter";
            this.lbRoundCounter.Size = new System.Drawing.Size(43, 44);
            this.lbRoundCounter.TabIndex = 18;
            this.lbRoundCounter.Text = "0";
            // 
            // lbComputerWinCounter
            // 
            this.lbComputerWinCounter.AutoSize = true;
            this.lbComputerWinCounter.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerWinCounter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbComputerWinCounter.Location = new System.Drawing.Point(814, 111);
            this.lbComputerWinCounter.Name = "lbComputerWinCounter";
            this.lbComputerWinCounter.Size = new System.Drawing.Size(29, 29);
            this.lbComputerWinCounter.TabIndex = 17;
            this.lbComputerWinCounter.Text = "0";
            // 
            // lbDrawCounter
            // 
            this.lbDrawCounter.AutoSize = true;
            this.lbDrawCounter.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrawCounter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDrawCounter.Location = new System.Drawing.Point(504, 111);
            this.lbDrawCounter.Name = "lbDrawCounter";
            this.lbDrawCounter.Size = new System.Drawing.Size(29, 29);
            this.lbDrawCounter.TabIndex = 16;
            this.lbDrawCounter.Text = "0";
            // 
            // lbPlayerWinCounter
            // 
            this.lbPlayerWinCounter.AutoSize = true;
            this.lbPlayerWinCounter.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerWinCounter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPlayerWinCounter.Location = new System.Drawing.Point(234, 112);
            this.lbPlayerWinCounter.Name = "lbPlayerWinCounter";
            this.lbPlayerWinCounter.Size = new System.Drawing.Size(29, 29);
            this.lbPlayerWinCounter.TabIndex = 15;
            this.lbPlayerWinCounter.Text = "0";
            // 
            // lbComputer
            // 
            this.lbComputer.AutoSize = true;
            this.lbComputer.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbComputer.Location = new System.Drawing.Point(651, 111);
            this.lbComputer.Name = "lbComputer";
            this.lbComputer.Size = new System.Drawing.Size(154, 29);
            this.lbComputer.TabIndex = 14;
            this.lbComputer.Text = "Computer :";
            // 
            // lbDraw
            // 
            this.lbDraw.AutoSize = true;
            this.lbDraw.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDraw.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDraw.Location = new System.Drawing.Point(392, 111);
            this.lbDraw.Name = "lbDraw";
            this.lbDraw.Size = new System.Drawing.Size(95, 29);
            this.lbDraw.TabIndex = 13;
            this.lbDraw.Text = "Draw :";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbPlayer.Location = new System.Drawing.Point(110, 111);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(118, 29);
            this.lbPlayer.TabIndex = 12;
            this.lbPlayer.Text = "Player : ";
            // 
            // picBoxComputer
            // 
            this.picBoxComputer.Image = ((System.Drawing.Image)(resources.GetObject("picBoxComputer.Image")));
            this.picBoxComputer.Location = new System.Drawing.Point(636, 196);
            this.picBoxComputer.Name = "picBoxComputer";
            this.picBoxComputer.Size = new System.Drawing.Size(207, 149);
            this.picBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxComputer.TabIndex = 11;
            this.picBoxComputer.TabStop = false;
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPlayer.Image")));
            this.picBoxPlayer.Location = new System.Drawing.Point(63, 196);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(207, 149);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPlayer.TabIndex = 10;
            this.picBoxPlayer.TabStop = false;
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRound.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbRound.Location = new System.Drawing.Point(391, 227);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(120, 34);
            this.lbRound.TabIndex = 9;
            this.lbRound.Text = "Round ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(220, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(520, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rock Paper Scissor Game";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1352, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.TextBox txtBoxNumberOfRounds;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.RadioButton rdScissors;
        private System.Windows.Forms.RadioButton rdPaper;
        private System.Windows.Forms.RadioButton rdRock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.PictureBox picBoxComputer;
        private System.Windows.Forms.Label lbComputer;
        private System.Windows.Forms.Label lbDraw;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label lbRoundCounter;
        private System.Windows.Forms.Label lbComputerWinCounter;
        private System.Windows.Forms.Label lbDrawCounter;
        private System.Windows.Forms.Label lbPlayerWinCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbFinalWinner;
        private System.Windows.Forms.Label lbFinalDrawTimes;
        private System.Windows.Forms.Label lbFinalComputerWonTimes;
        private System.Windows.Forms.Label lbFinalPlayerWonTimes;
        private System.Windows.Forms.Label lbFinalGameRounds;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}