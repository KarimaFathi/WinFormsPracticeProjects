namespace CryptoKeyManager
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
            this.lbCurrentDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtAfterEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtBeforeEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEncrypTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDecryptProgress = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.txtAfterDecrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtBeforeDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDecrypTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbTrackValue = new System.Windows.Forms.Label();
            this.lbEncryptProgress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCurrentDate
            // 
            this.lbCurrentDate.AutoSize = true;
            this.lbCurrentDate.ForeColor = System.Drawing.Color.Indigo;
            this.lbCurrentDate.Location = new System.Drawing.Point(26, 54);
            this.lbCurrentDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCurrentDate.Name = "lbCurrentDate";
            this.lbCurrentDate.Size = new System.Drawing.Size(0, 34);
            this.lbCurrentDate.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lbTitle.Location = new System.Drawing.Point(350, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(355, 43);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Secure Crypt";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.lbEncryptProgress);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.txtAfterEncrypt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEncrypt);
            this.panel1.Controls.Add(this.txtBeforeEncrypt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbEncrypTitle);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 448);
            this.panel1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 42);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // txtAfterEncrypt
            // 
            this.txtAfterEncrypt.Location = new System.Drawing.Point(25, 359);
            this.txtAfterEncrypt.Name = "txtAfterEncrypt";
            this.txtAfterEncrypt.Size = new System.Drawing.Size(293, 41);
            this.txtAfterEncrypt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(70, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encryption Text :";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnEncrypt.Location = new System.Drawing.Point(90, 235);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(162, 47);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtBeforeEncrypt
            // 
            this.txtBeforeEncrypt.Location = new System.Drawing.Point(25, 145);
            this.txtBeforeEncrypt.Name = "txtBeforeEncrypt";
            this.txtBeforeEncrypt.Size = new System.Drawing.Size(293, 41);
            this.txtBeforeEncrypt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(121, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text :";
            // 
            // lbEncrypTitle
            // 
            this.lbEncrypTitle.AutoSize = true;
            this.lbEncrypTitle.Font = new System.Drawing.Font("Swis721 BlkEx BT", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncrypTitle.ForeColor = System.Drawing.Color.Linen;
            this.lbEncrypTitle.Location = new System.Drawing.Point(79, 24);
            this.lbEncrypTitle.Name = "lbEncrypTitle";
            this.lbEncrypTitle.Size = new System.Drawing.Size(255, 39);
            this.lbEncrypTitle.TabIndex = 0;
            this.lbEncrypTitle.Text = "Encryption";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.lbDecryptProgress);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.txtAfterDecrypt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.txtBeforeDecrypt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbDecrypTitle);
            this.panel2.Location = new System.Drawing.Point(547, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 449);
            this.panel2.TabIndex = 3;
            // 
            // lbDecryptProgress
            // 
            this.lbDecryptProgress.AutoSize = true;
            this.lbDecryptProgress.ForeColor = System.Drawing.Color.White;
            this.lbDecryptProgress.Location = new System.Drawing.Point(171, 207);
            this.lbDecryptProgress.Name = "lbDecryptProgress";
            this.lbDecryptProgress.Size = new System.Drawing.Size(0, 34);
            this.lbDecryptProgress.TabIndex = 8;
            this.lbDecryptProgress.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(40, 241);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(282, 42);
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Visible = false;
            // 
            // txtAfterDecrypt
            // 
            this.txtAfterDecrypt.Location = new System.Drawing.Point(40, 369);
            this.txtAfterDecrypt.Name = "txtAfterDecrypt";
            this.txtAfterDecrypt.Size = new System.Drawing.Size(293, 41);
            this.txtAfterDecrypt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(84, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Decryption Text :";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Purple;
            this.btnDecrypt.Location = new System.Drawing.Point(105, 236);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(162, 47);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtBeforeDecrypt
            // 
            this.txtBeforeDecrypt.Location = new System.Drawing.Point(40, 143);
            this.txtBeforeDecrypt.Name = "txtBeforeDecrypt";
            this.txtBeforeDecrypt.Size = new System.Drawing.Size(293, 41);
            this.txtBeforeDecrypt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(136, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text :";
            // 
            // lbDecrypTitle
            // 
            this.lbDecrypTitle.AutoSize = true;
            this.lbDecrypTitle.Font = new System.Drawing.Font("Swis721 BlkEx BT", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecrypTitle.ForeColor = System.Drawing.Color.Linen;
            this.lbDecrypTitle.Location = new System.Drawing.Point(91, 25);
            this.lbDecrypTitle.Name = "lbDecrypTitle";
            this.lbDecrypTitle.Size = new System.Drawing.Size(261, 39);
            this.lbDecrypTitle.TabIndex = 1;
            this.lbDecrypTitle.Text = "Decryption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(377, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Encryption Key";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(439, 217);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(69, 307);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbTrackValue
            // 
            this.lbTrackValue.AutoSize = true;
            this.lbTrackValue.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrackValue.ForeColor = System.Drawing.Color.Indigo;
            this.lbTrackValue.Location = new System.Drawing.Point(438, 166);
            this.lbTrackValue.Name = "lbTrackValue";
            this.lbTrackValue.Size = new System.Drawing.Size(37, 43);
            this.lbTrackValue.TabIndex = 6;
            this.lbTrackValue.Text = "?";
            // 
            // lbEncryptProgress
            // 
            this.lbEncryptProgress.AutoSize = true;
            this.lbEncryptProgress.ForeColor = System.Drawing.Color.White;
            this.lbEncryptProgress.Location = new System.Drawing.Point(164, 196);
            this.lbEncryptProgress.Name = "lbEncryptProgress";
            this.lbEncryptProgress.Size = new System.Drawing.Size(0, 34);
            this.lbEncryptProgress.TabIndex = 7;
            this.lbEncryptProgress.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(960, 631);
            this.Controls.Add(this.lbTrackValue);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbCurrentDate);
            this.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "CryptoKey Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEncrypTitle;
        private System.Windows.Forms.Label lbDecrypTitle;
        private System.Windows.Forms.TextBox txtBeforeEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBeforeDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAfterEncrypt;
        private System.Windows.Forms.TextBox txtAfterDecrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbTrackValue;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lbDecryptProgress;
        private System.Windows.Forms.Label lbEncryptProgress;
    }
}

