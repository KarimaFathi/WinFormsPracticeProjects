namespace RandomKeysGenerator
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rdMix = new System.Windows.Forms.RadioButton();
            this.rdCapitalLetters = new System.Windows.Forms.RadioButton();
            this.rdSmallLetters = new System.Windows.Forms.RadioButton();
            this.KeysNumberTextBox = new System.Windows.Forms.TextBox();
            this.lbNumbOfDigits = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxShowResult = new System.Windows.Forms.TextBox();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(920, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 61);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1036, 447);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(184, 61);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gold;
            this.btnGenerate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(815, 447);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(192, 61);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rdMix);
            this.grpOptions.Controls.Add(this.rdCapitalLetters);
            this.grpOptions.Controls.Add(this.rdSmallLetters);
            this.grpOptions.Controls.Add(this.KeysNumberTextBox);
            this.grpOptions.Controls.Add(this.lbNumbOfDigits);
            this.grpOptions.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptions.Location = new System.Drawing.Point(57, 361);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(721, 305);
            this.grpOptions.TabIndex = 10;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // rdMix
            // 
            this.rdMix.AutoSize = true;
            this.rdMix.Enabled = false;
            this.rdMix.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMix.ForeColor = System.Drawing.Color.White;
            this.rdMix.Location = new System.Drawing.Point(307, 239);
            this.rdMix.Name = "rdMix";
            this.rdMix.Size = new System.Drawing.Size(93, 39);
            this.rdMix.TabIndex = 7;
            this.rdMix.TabStop = true;
            this.rdMix.Text = "Mix";
            this.rdMix.UseVisualStyleBackColor = true;
            // 
            // rdCapitalLetters
            // 
            this.rdCapitalLetters.AutoSize = true;
            this.rdCapitalLetters.Enabled = false;
            this.rdCapitalLetters.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCapitalLetters.ForeColor = System.Drawing.Color.White;
            this.rdCapitalLetters.Location = new System.Drawing.Point(406, 152);
            this.rdCapitalLetters.Name = "rdCapitalLetters";
            this.rdCapitalLetters.Size = new System.Drawing.Size(257, 39);
            this.rdCapitalLetters.TabIndex = 6;
            this.rdCapitalLetters.TabStop = true;
            this.rdCapitalLetters.Text = "Capital letters";
            this.rdCapitalLetters.UseVisualStyleBackColor = true;
            // 
            // rdSmallLetters
            // 
            this.rdSmallLetters.AutoSize = true;
            this.rdSmallLetters.Enabled = false;
            this.rdSmallLetters.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSmallLetters.ForeColor = System.Drawing.Color.White;
            this.rdSmallLetters.Location = new System.Drawing.Point(64, 152);
            this.rdSmallLetters.Name = "rdSmallLetters";
            this.rdSmallLetters.Size = new System.Drawing.Size(247, 39);
            this.rdSmallLetters.TabIndex = 4;
            this.rdSmallLetters.TabStop = true;
            this.rdSmallLetters.Text = " Small letters";
            this.rdSmallLetters.UseVisualStyleBackColor = true;
            // 
            // KeysNumberTextBox
            // 
            this.KeysNumberTextBox.Location = new System.Drawing.Point(420, 66);
            this.KeysNumberTextBox.Name = "KeysNumberTextBox";
            this.KeysNumberTextBox.Size = new System.Drawing.Size(189, 42);
            this.KeysNumberTextBox.TabIndex = 3;
            this.KeysNumberTextBox.TextChanged += new System.EventHandler(this.txtNumberOfKeys_TextChanged);
            // 
            // lbNumbOfDigits
            // 
            this.lbNumbOfDigits.AutoSize = true;
            this.lbNumbOfDigits.BackColor = System.Drawing.Color.SkyBlue;
            this.lbNumbOfDigits.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbOfDigits.ForeColor = System.Drawing.Color.White;
            this.lbNumbOfDigits.Location = new System.Drawing.Point(67, 69);
            this.lbNumbOfDigits.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbNumbOfDigits.Name = "lbNumbOfDigits";
            this.lbNumbOfDigits.Size = new System.Drawing.Size(279, 35);
            this.lbNumbOfDigits.TabIndex = 2;
            this.lbNumbOfDigits.Text = "Number of keys :";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.SkyBlue;
            this.lbResult.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbResult.Location = new System.Drawing.Point(68, 149);
            this.lbResult.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(151, 40);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Result :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Swis721 BlkEx BT", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(303, 37);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(780, 52);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Random Keys Generator";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxShowResult
            // 
            this.textBoxShowResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShowResult.ForeColor = System.Drawing.Color.Navy;
            this.textBoxShowResult.Location = new System.Drawing.Point(298, 149);
            this.textBoxShowResult.Name = "textBoxShowResult";
            this.textBoxShowResult.Size = new System.Drawing.Size(982, 38);
            this.textBoxShowResult.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 711);
            this.Controls.Add(this.textBoxShowResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rdMix;
        private System.Windows.Forms.RadioButton rdCapitalLetters;
        private System.Windows.Forms.RadioButton rdSmallLetters;
        private System.Windows.Forms.TextBox KeysNumberTextBox;
        private System.Windows.Forms.Label lbNumbOfDigits;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxShowResult;
    }
}

