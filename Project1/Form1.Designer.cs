namespace WinFormsPracticeProjects
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
            this.lbResult = new System.Windows.Forms.Label();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnMix = new System.Windows.Forms.RadioButton();
            this.btnNumbers = new System.Windows.Forms.RadioButton();
            this.btnSymbols = new System.Windows.Forms.RadioButton();
            this.btnLetters = new System.Windows.Forms.RadioButton();
            this.cmsLetterCase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSmallLetters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCapitalLetters = new System.Windows.Forms.ToolStripMenuItem();
            this.DigitsNumberTextBox = new System.Windows.Forms.TextBox();
            this.lbNumbOfDigits = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpOptions.SuspendLayout();
            this.cmsLetterCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Swis721 BlkEx BT", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(251, 51);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(983, 52);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Random Characters Generator";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.SkyBlue;
            this.lbResult.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbResult.Location = new System.Drawing.Point(16, 145);
            this.lbResult.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(151, 40);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "Result :";
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.Transparent;
            this.lbShowResult.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbShowResult.Location = new System.Drawing.Point(172, 147);
            this.lbShowResult.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(151, 40);
            this.lbShowResult.TabIndex = 2;
            this.lbShowResult.Click += new System.EventHandler(this.bShowResult_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnMix);
            this.grpOptions.Controls.Add(this.btnNumbers);
            this.grpOptions.Controls.Add(this.btnSymbols);
            this.grpOptions.Controls.Add(this.btnLetters);
            this.grpOptions.Controls.Add(this.DigitsNumberTextBox);
            this.grpOptions.Controls.Add(this.lbNumbOfDigits);
            this.grpOptions.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptions.Location = new System.Drawing.Point(23, 267);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(567, 305);
            this.grpOptions.TabIndex = 3;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // btnMix
            // 
            this.btnMix.AutoSize = true;
            this.btnMix.Enabled = false;
            this.btnMix.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMix.ForeColor = System.Drawing.Color.White;
            this.btnMix.Location = new System.Drawing.Point(352, 234);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(93, 39);
            this.btnMix.TabIndex = 7;
            this.btnMix.TabStop = true;
            this.btnMix.Text = "Mix";
            this.btnMix.UseVisualStyleBackColor = true;
            // 
            // btnNumbers
            // 
            this.btnNumbers.AutoSize = true;
            this.btnNumbers.Enabled = false;
            this.btnNumbers.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbers.ForeColor = System.Drawing.Color.White;
            this.btnNumbers.Location = new System.Drawing.Point(352, 149);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(174, 39);
            this.btnNumbers.TabIndex = 6;
            this.btnNumbers.TabStop = true;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = true;
            // 
            // btnSymbols
            // 
            this.btnSymbols.AutoSize = true;
            this.btnSymbols.Enabled = false;
            this.btnSymbols.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSymbols.ForeColor = System.Drawing.Color.White;
            this.btnSymbols.Location = new System.Drawing.Point(64, 234);
            this.btnSymbols.Name = "btnSymbols";
            this.btnSymbols.Size = new System.Drawing.Size(168, 39);
            this.btnSymbols.TabIndex = 5;
            this.btnSymbols.TabStop = true;
            this.btnSymbols.Text = "Symbols";
            this.btnSymbols.UseVisualStyleBackColor = true;
            // 
            // btnLetters
            // 
            this.btnLetters.AutoSize = true;
            this.btnLetters.ContextMenuStrip = this.cmsLetterCase;
            this.btnLetters.Enabled = false;
            this.btnLetters.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetters.ForeColor = System.Drawing.Color.White;
            this.btnLetters.Location = new System.Drawing.Point(64, 149);
            this.btnLetters.Name = "btnLetters";
            this.btnLetters.Size = new System.Drawing.Size(146, 39);
            this.btnLetters.TabIndex = 4;
            this.btnLetters.TabStop = true;
            this.btnLetters.Text = "Letters";
            this.btnLetters.UseVisualStyleBackColor = true;
            // 
            // cmsLetterCase
            // 
            this.cmsLetterCase.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLetterCase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSmallLetters,
            this.tsmCapitalLetters});
            this.cmsLetterCase.Name = "contextMenuStrip1";
            this.cmsLetterCase.Size = new System.Drawing.Size(196, 68);
            // 
            // tsmSmallLetters
            // 
            this.tsmSmallLetters.Name = "tsmSmallLetters";
            this.tsmSmallLetters.Size = new System.Drawing.Size(195, 32);
            this.tsmSmallLetters.Text = "Small Letters";
            this.tsmSmallLetters.Click += new System.EventHandler(this.tsmSmallLetters_Click);
            // 
            // tsmCapitalLetters
            // 
            this.tsmCapitalLetters.Name = "tsmCapitalLetters";
            this.tsmCapitalLetters.Size = new System.Drawing.Size(195, 32);
            this.tsmCapitalLetters.Text = "Capital Letters";
            this.tsmCapitalLetters.Click += new System.EventHandler(this.tsmCapitalLetters_Click);
            // 
            // DigitsNumberTextBox
            // 
            this.DigitsNumberTextBox.Location = new System.Drawing.Point(352, 63);
            this.DigitsNumberTextBox.Name = "DigitsNumberTextBox";
            this.DigitsNumberTextBox.Size = new System.Drawing.Size(189, 42);
            this.DigitsNumberTextBox.TabIndex = 3;
            this.DigitsNumberTextBox.TextChanged += new System.EventHandler(this.txtNumberOfDigits_TextChanged);
            this.DigitsNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumberOfDigits_Validating);
            // 
            // lbNumbOfDigits
            // 
            this.lbNumbOfDigits.AutoSize = true;
            this.lbNumbOfDigits.BackColor = System.Drawing.Color.SkyBlue;
            this.lbNumbOfDigits.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbOfDigits.ForeColor = System.Drawing.Color.White;
            this.lbNumbOfDigits.Location = new System.Drawing.Point(20, 66);
            this.lbNumbOfDigits.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbNumbOfDigits.Name = "lbNumbOfDigits";
            this.lbNumbOfDigits.Size = new System.Drawing.Size(293, 35);
            this.lbNumbOfDigits.TabIndex = 2;
            this.lbNumbOfDigits.Text = "Number of digits :";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gold;
            this.btnGenerate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(618, 373);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(189, 51);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(854, 373);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 51);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(733, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 51);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 584);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Random Characters Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.cmsLetterCase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lbNumbOfDigits;
        private System.Windows.Forms.TextBox DigitsNumberTextBox;
        private System.Windows.Forms.RadioButton btnMix;
        private System.Windows.Forms.RadioButton btnNumbers;
        private System.Windows.Forms.RadioButton btnSymbols;
        private System.Windows.Forms.RadioButton btnLetters;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip cmsLetterCase;
        private System.Windows.Forms.ToolStripMenuItem tsmSmallLetters;
        private System.Windows.Forms.ToolStripMenuItem tsmCapitalLetters;
    }
}

