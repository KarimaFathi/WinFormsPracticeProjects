namespace MathGame
{
    partial class Form3
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
            this.lbRound = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRoundValue = new System.Windows.Forms.Label();
            this.lbLevelValue = new System.Windows.Forms.Label();
            this.lbOperatorChoice = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbRightAnswer = new System.Windows.Forms.Label();
            this.lbPlayerAnswer = new System.Windows.Forms.Label();
            this.lbOperand1 = new System.Windows.Forms.Label();
            this.lbOperator = new System.Windows.Forms.Label();
            this.lbOperand2 = new System.Windows.Forms.Label();
            this.lbEqual = new System.Windows.Forms.Label();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRound.ForeColor = System.Drawing.Color.Chocolate;
            this.lbRound.Location = new System.Drawing.Point(42, 41);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(159, 29);
            this.lbRound.TabIndex = 0;
            this.lbRound.Text = "Round       :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(42, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Level         :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(42, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operator   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(42, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time         :";
            // 
            // lbRoundValue
            // 
            this.lbRoundValue.AutoSize = true;
            this.lbRoundValue.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoundValue.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbRoundValue.Location = new System.Drawing.Point(232, 41);
            this.lbRoundValue.Name = "lbRoundValue";
            this.lbRoundValue.Size = new System.Drawing.Size(29, 29);
            this.lbRoundValue.TabIndex = 5;
            this.lbRoundValue.Text = "0";
            // 
            // lbLevelValue
            // 
            this.lbLevelValue.AutoSize = true;
            this.lbLevelValue.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelValue.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbLevelValue.Location = new System.Drawing.Point(232, 112);
            this.lbLevelValue.Name = "lbLevelValue";
            this.lbLevelValue.Size = new System.Drawing.Size(29, 29);
            this.lbLevelValue.TabIndex = 6;
            this.lbLevelValue.Text = "0";
            // 
            // lbOperatorChoice
            // 
            this.lbOperatorChoice.AutoSize = true;
            this.lbOperatorChoice.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperatorChoice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbOperatorChoice.Location = new System.Drawing.Point(232, 189);
            this.lbOperatorChoice.Name = "lbOperatorChoice";
            this.lbOperatorChoice.Size = new System.Drawing.Size(29, 29);
            this.lbOperatorChoice.TabIndex = 7;
            this.lbOperatorChoice.Text = "0";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbTimer.Location = new System.Drawing.Point(232, 268);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(29, 29);
            this.lbTimer.TabIndex = 8;
            this.lbTimer.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(872, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "Right Answer :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(872, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 34);
            this.label9.TabIndex = 10;
            this.label9.Text = "Player Answer :";
            // 
            // lbRightAnswer
            // 
            this.lbRightAnswer.AutoSize = true;
            this.lbRightAnswer.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightAnswer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbRightAnswer.Location = new System.Drawing.Point(968, 112);
            this.lbRightAnswer.Name = "lbRightAnswer";
            this.lbRightAnswer.Size = new System.Drawing.Size(33, 34);
            this.lbRightAnswer.TabIndex = 11;
            this.lbRightAnswer.Text = "0";
            // 
            // lbPlayerAnswer
            // 
            this.lbPlayerAnswer.AutoSize = true;
            this.lbPlayerAnswer.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerAnswer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbPlayerAnswer.Location = new System.Drawing.Point(968, 268);
            this.lbPlayerAnswer.Name = "lbPlayerAnswer";
            this.lbPlayerAnswer.Size = new System.Drawing.Size(33, 34);
            this.lbPlayerAnswer.TabIndex = 12;
            this.lbPlayerAnswer.Text = "0";
            // 
            // lbOperand1
            // 
            this.lbOperand1.AutoSize = true;
            this.lbOperand1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperand1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbOperand1.Location = new System.Drawing.Point(388, 382);
            this.lbOperand1.Name = "lbOperand1";
            this.lbOperand1.Size = new System.Drawing.Size(45, 57);
            this.lbOperand1.TabIndex = 14;
            this.lbOperand1.Text = "x";
            this.lbOperand1.Visible = false;
            // 
            // lbOperator
            // 
            this.lbOperator.AutoSize = true;
            this.lbOperator.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperator.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbOperator.Location = new System.Drawing.Point(495, 382);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(49, 57);
            this.lbOperator.TabIndex = 15;
            this.lbOperator.Text = "?";
            this.lbOperator.Visible = false;
            // 
            // lbOperand2
            // 
            this.lbOperand2.AutoSize = true;
            this.lbOperand2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperand2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbOperand2.Location = new System.Drawing.Point(606, 382);
            this.lbOperand2.Name = "lbOperand2";
            this.lbOperand2.Size = new System.Drawing.Size(46, 57);
            this.lbOperand2.TabIndex = 16;
            this.lbOperand2.Text = "y";
            this.lbOperand2.Visible = false;
            // 
            // lbEqual
            // 
            this.lbEqual.AutoSize = true;
            this.lbEqual.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEqual.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbEqual.Location = new System.Drawing.Point(714, 382);
            this.lbEqual.Name = "lbEqual";
            this.lbEqual.Size = new System.Drawing.Size(65, 57);
            this.lbEqual.TabIndex = 17;
            this.lbEqual.Text = "=";
            this.lbEqual.Visible = false;
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Font = new System.Drawing.Font("Swis721 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAnswer.ForeColor = System.Drawing.Color.Purple;
            this.txtBoxAnswer.Location = new System.Drawing.Point(376, 473);
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(393, 51);
            this.txtBoxAnswer.TabIndex = 18;
            this.txtBoxAnswer.Visible = false;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackColor = System.Drawing.Color.SeaShell;
            this.btnCheckAnswer.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCheckAnswer.Location = new System.Drawing.Point(376, 530);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(393, 68);
            this.btnCheckAnswer.TabIndex = 19;
            this.btnCheckAnswer.Text = "Check answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = false;
            this.btnCheckAnswer.Visible = false;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("Swis721 Blk BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(24, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 54);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaShell;
            this.button3.Font = new System.Drawing.Font("Swis721 Blk BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button3.Location = new System.Drawing.Point(875, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 21;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaShell;
            this.button4.Font = new System.Drawing.Font("Swis721 Blk BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button4.Location = new System.Drawing.Point(1011, 634);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 54);
            this.button4.TabIndex = 22;
            this.button4.Text = "Result";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.Color.MintCream;
            this.btnNextQuestion.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNextQuestion.Location = new System.Drawing.Point(790, 468);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(361, 64);
            this.btnNextQuestion.TabIndex = 23;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Visible = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Thistle;
            this.btnStart.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Purple;
            this.btnStart.Location = new System.Drawing.Point(376, 413);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(393, 68);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MathGame.Properties.Resources.mathematics_stationery_clipart_md_1_;
            this.pictureBox1.Location = new System.Drawing.Point(379, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1174, 720);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.lbEqual);
            this.Controls.Add(this.lbOperand2);
            this.Controls.Add(this.lbOperator);
            this.Controls.Add(this.lbOperand1);
            this.Controls.Add(this.lbPlayerAnswer);
            this.Controls.Add(this.lbRightAnswer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbOperatorChoice);
            this.Controls.Add(this.lbLevelValue);
            this.Controls.Add(this.lbRoundValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRound);
            this.Name = "Form3";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRoundValue;
        private System.Windows.Forms.Label lbLevelValue;
        private System.Windows.Forms.Label lbOperatorChoice;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbRightAnswer;
        private System.Windows.Forms.Label lbPlayerAnswer;
        private System.Windows.Forms.Label lbOperand1;
        private System.Windows.Forms.Label lbOperator;
        private System.Windows.Forms.Label lbOperand2;
        private System.Windows.Forms.Label lbEqual;
        private System.Windows.Forms.TextBox txtBoxAnswer;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
    }
}