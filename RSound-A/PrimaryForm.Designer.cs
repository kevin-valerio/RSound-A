namespace RSound_A
{
    partial class PrimaryForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            this.RSoundA = new FlatUI.FormSkin();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.checkExportSound = new FlatUI.FlatToggle();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.statusLbl = new FlatUI.FlatAlertBox();
            this.importBtn = new FlatUI.FlatButton();
            this.btnCrypt = new FlatUI.FlatButton();
            this.txtBoxSoundPath = new FlatUI.FlatTextBox();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.flatNumeric1 = new FlatUI.FlatNumeric();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatButton1 = new FlatUI.FlatButton();
            this.RSoundA.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RSoundA
            // 
            this.RSoundA.BackColor = System.Drawing.Color.White;
            this.RSoundA.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.RSoundA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.RSoundA.Controls.Add(this.flatGroupBox2);
            this.RSoundA.Controls.Add(this.flatLabel1);
            this.RSoundA.Controls.Add(this.checkExportSound);
            this.RSoundA.Controls.Add(this.flatGroupBox1);
            this.RSoundA.Controls.Add(this.flatMini1);
            this.RSoundA.Controls.Add(this.flatClose1);
            this.RSoundA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSoundA.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.RSoundA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RSoundA.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.RSoundA.HeaderMaximize = false;
            this.RSoundA.Location = new System.Drawing.Point(0, 0);
            this.RSoundA.Name = "RSoundA";
            this.RSoundA.Size = new System.Drawing.Size(395, 596);
            this.RSoundA.TabIndex = 0;
            this.RSoundA.Text = "R Sound A";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(199, 238);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(154, 20);
            this.flatLabel1.TabIndex = 21;
            this.flatLabel1.Text = "Also export the sound";
            // 
            // checkExportSound
            // 
            this.checkExportSound.BackColor = System.Drawing.Color.Transparent;
            this.checkExportSound.Checked = true;
            this.checkExportSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkExportSound.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkExportSound.Location = new System.Drawing.Point(203, 261);
            this.checkExportSound.Name = "checkExportSound";
            this.checkExportSound.Options = FlatUI.FlatToggle._Options.Style2;
            this.checkExportSound.Size = new System.Drawing.Size(76, 33);
            this.checkExportSound.TabIndex = 20;
            this.checkExportSound.Text = "flatToggle1";
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox1.Controls.Add(this.statusLbl);
            this.flatGroupBox1.Controls.Add(this.importBtn);
            this.flatGroupBox1.Controls.Add(this.btnCrypt);
            this.flatGroupBox1.Controls.Add(this.txtBoxSoundPath);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(12, 55);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(366, 245);
            this.flatGroupBox1.TabIndex = 17;
            this.flatGroupBox1.Text = "Import your sound";
            // 
            // statusLbl
            // 
            this.statusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.statusLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusLbl.kind = FlatUI.FlatAlertBox._Kind.Info;
            this.statusLbl.Location = new System.Drawing.Point(17, 87);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(324, 42);
            this.statusLbl.TabIndex = 19;
            this.statusLbl.Text = "You need to import a sound";
            this.statusLbl.Visible = false;
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.Transparent;
            this.importBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.importBtn.Location = new System.Drawing.Point(17, 148);
            this.importBtn.Name = "importBtn";
            this.importBtn.Rounded = false;
            this.importBtn.Size = new System.Drawing.Size(154, 32);
            this.importBtn.TabIndex = 15;
            this.importBtn.Text = "Browse .wav file";
            this.importBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // btnCrypt
            // 
            this.btnCrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnCrypt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrypt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCrypt.Location = new System.Drawing.Point(187, 148);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Rounded = false;
            this.btnCrypt.Size = new System.Drawing.Size(154, 32);
            this.btnCrypt.TabIndex = 16;
            this.btnCrypt.Text = "Crypt the sound";
            this.btnCrypt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click_1);
            // 
            // txtBoxSoundPath
            // 
            this.txtBoxSoundPath.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSoundPath.FocusOnHover = false;
            this.txtBoxSoundPath.Location = new System.Drawing.Point(17, 41);
            this.txtBoxSoundPath.MaxLength = 32767;
            this.txtBoxSoundPath.Multiline = false;
            this.txtBoxSoundPath.Name = "txtBoxSoundPath";
            this.txtBoxSoundPath.ReadOnly = false;
            this.txtBoxSoundPath.Size = new System.Drawing.Size(324, 29);
            this.txtBoxSoundPath.TabIndex = 14;
            this.txtBoxSoundPath.Text = "C:\\";
            this.txtBoxSoundPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSoundPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxSoundPath.UseSystemPasswordChar = false;
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(350, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 11;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(374, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 10;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox2.Controls.Add(this.flatButton1);
            this.flatGroupBox2.Controls.Add(this.flatLabel2);
            this.flatGroupBox2.Controls.Add(this.flatNumeric1);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(12, 306);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(371, 278);
            this.flatGroupBox2.TabIndex = 22;
            this.flatGroupBox2.Text = "Testing RSA";
            // 
            // flatNumeric1
            // 
            this.flatNumeric1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatNumeric1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatNumeric1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatNumeric1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatNumeric1.ForeColor = System.Drawing.Color.White;
            this.flatNumeric1.Location = new System.Drawing.Point(160, 50);
            this.flatNumeric1.Maximum = ((long)(9999999));
            this.flatNumeric1.Minimum = ((long)(0));
            this.flatNumeric1.Name = "flatNumeric1";
            this.flatNumeric1.Size = new System.Drawing.Size(75, 30);
            this.flatNumeric1.TabIndex = 0;
            this.flatNumeric1.Text = "flatNumeric1";
            this.flatNumeric1.Value = ((long)(0));
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(13, 57);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(129, 20);
            this.flatLabel2.TabIndex = 23;
            this.flatLabel2.Text = "Number to crypt : ";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(17, 224);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(223, 32);
            this.flatButton1.TabIndex = 24;
            this.flatButton1.Text = "Build encrypted message";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 596);
            this.Controls.Add(this.RSoundA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrimaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSound-A";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.RSoundA.ResumeLayout(false);
            this.RSoundA.PerformLayout();
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox2.ResumeLayout(false);
            this.flatGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin RSoundA;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatTextBox txtBoxSoundPath;
        private FlatUI.FlatButton btnCrypt;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatButton importBtn;
        private FlatUI.FlatAlertBox statusLbl;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatToggle checkExportSound;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatNumeric flatNumeric1;
    }
}

