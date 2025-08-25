namespace MatrixNumberGame
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumberToFind = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lbRightAnswer = new System.Windows.Forms.Label();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txBoxAnswer = new System.Windows.Forms.TextBox();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.LightPink;
            this.lbTitle.Location = new System.Drawing.Point(487, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(431, 42);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Repeated Numbers Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many times does this number appear in the matrix?";
            // 
            // lbNumberToFind
            // 
            this.lbNumberToFind.AutoSize = true;
            this.lbNumberToFind.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberToFind.ForeColor = System.Drawing.Color.LightPink;
            this.lbNumberToFind.Location = new System.Drawing.Point(674, 170);
            this.lbNumberToFind.Name = "lbNumberToFind";
            this.lbNumberToFind.Size = new System.Drawing.Size(30, 37);
            this.lbNumberToFind.TabIndex = 2;
            this.lbNumberToFind.Text = "?";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel.Controls.Add(this.lbRightAnswer);
            this.panel.Controls.Add(this.lbShowResult);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.btnSet);
            this.panel.Controls.Add(this.btnCheck);
            this.panel.Controls.Add(this.txBoxAnswer);
            this.panel.Controls.Add(this.lbAnswer);
            this.panel.ForeColor = System.Drawing.Color.Black;
            this.panel.Location = new System.Drawing.Point(-3, 223);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1511, 682);
            this.panel.TabIndex = 3;
            // 
            // lbRightAnswer
            // 
            this.lbRightAnswer.AutoSize = true;
            this.lbRightAnswer.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightAnswer.Location = new System.Drawing.Point(35, 271);
            this.lbRightAnswer.Name = "lbRightAnswer";
            this.lbRightAnswer.Size = new System.Drawing.Size(0, 37);
            this.lbRightAnswer.TabIndex = 35;
            // 
            // lbShowResult
            // 
            this.lbShowResult.AutoSize = true;
            this.lbShowResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowResult.Location = new System.Drawing.Point(40, 180);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(31, 47);
            this.lbShowResult.TabIndex = 34;
            this.lbShowResult.Text = " ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LightPink;
            this.btnExit.Location = new System.Drawing.Point(1318, 575);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 48);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.Black;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.LightPink;
            this.btnSet.Location = new System.Drawing.Point(686, 575);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(147, 48);
            this.btnSet.TabIndex = 32;
            this.btnSet.Text = " Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Black;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.LightPink;
            this.btnCheck.Location = new System.Drawing.Point(92, 575);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(147, 48);
            this.btnCheck.TabIndex = 31;
            this.btnCheck.Text = " Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txBoxAnswer
            // 
            this.txBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxAnswer.Location = new System.Drawing.Point(127, 530);
            this.txBoxAnswer.Name = "txBoxAnswer";
            this.txBoxAnswer.Size = new System.Drawing.Size(119, 30);
            this.txBoxAnswer.TabIndex = 30;
            this.txBoxAnswer.TextChanged += new System.EventHandler(this.txBoxAnswer_TextChanged);
            this.txBoxAnswer.Validating += new System.ComponentModel.CancelEventHandler(this.txBoxAnswer_Validating);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer.ForeColor = System.Drawing.Color.Black;
            this.lbAnswer.Location = new System.Drawing.Point(15, 525);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(116, 30);
            this.lbAnswer.TabIndex = 4;
            this.lbAnswer.Text = "Answer : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1443, 840);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbNumberToFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Repeated Numbers Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumberToFind;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txBoxAnswer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Label lbRightAnswer;
    }
}

