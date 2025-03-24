
namespace Encrypt_Decrypt
{
    partial class frmEncryptDecrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncryptDecrypt));
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.btnEncrypt = new MetroFramework.Controls.MetroButton();
            this.lblValue = new MetroFramework.Controls.MetroLabel();
            this.lblEncrypted = new MetroFramework.Controls.MetroLabel();
            this.lblDecrypted = new MetroFramework.Controls.MetroLabel();
            this.txtDecrypted = new MetroFramework.Controls.MetroTextBox();
            this.txtEncrypted = new MetroFramework.Controls.MetroTextBox();
            this.btnDecrypt = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(484, 1);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(119, 79);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(508, 25);
            this.txtValue.TabIndex = 4;
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEncrypt.Location = new System.Drawing.Point(552, 197);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseCustomBackColor = true;
            this.btnEncrypt.UseCustomForeColor = true;
            this.btnEncrypt.UseSelectable = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(23, 85);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(46, 19);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value :";
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Location = new System.Drawing.Point(23, 120);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(75, 19);
            this.lblEncrypted.TabIndex = 2;
            this.lblEncrypted.Text = "Encrypted :";
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(23, 155);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(77, 19);
            this.lblDecrypted.TabIndex = 3;
            this.lblDecrypted.Text = "Decrypted :";
            // 
            // txtDecrypted
            // 
            // 
            // 
            // 
            this.txtDecrypted.CustomButton.Image = null;
            this.txtDecrypted.CustomButton.Location = new System.Drawing.Point(484, 1);
            this.txtDecrypted.CustomButton.Name = "";
            this.txtDecrypted.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDecrypted.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDecrypted.CustomButton.TabIndex = 1;
            this.txtDecrypted.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDecrypted.CustomButton.UseSelectable = true;
            this.txtDecrypted.CustomButton.Visible = false;
            this.txtDecrypted.Enabled = false;
            this.txtDecrypted.Lines = new string[0];
            this.txtDecrypted.Location = new System.Drawing.Point(119, 149);
            this.txtDecrypted.MaxLength = 32767;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.PasswordChar = '\0';
            this.txtDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDecrypted.SelectedText = "";
            this.txtDecrypted.SelectionLength = 0;
            this.txtDecrypted.SelectionStart = 0;
            this.txtDecrypted.ShortcutsEnabled = true;
            this.txtDecrypted.Size = new System.Drawing.Size(508, 25);
            this.txtDecrypted.TabIndex = 6;
            this.txtDecrypted.UseSelectable = true;
            this.txtDecrypted.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDecrypted.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEncrypted
            // 
            // 
            // 
            // 
            this.txtEncrypted.CustomButton.Image = null;
            this.txtEncrypted.CustomButton.Location = new System.Drawing.Point(484, 1);
            this.txtEncrypted.CustomButton.Name = "";
            this.txtEncrypted.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEncrypted.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEncrypted.CustomButton.TabIndex = 1;
            this.txtEncrypted.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEncrypted.CustomButton.UseSelectable = true;
            this.txtEncrypted.CustomButton.Visible = false;
            this.txtEncrypted.Enabled = false;
            this.txtEncrypted.Lines = new string[0];
            this.txtEncrypted.Location = new System.Drawing.Point(119, 114);
            this.txtEncrypted.MaxLength = 32767;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.PasswordChar = '\0';
            this.txtEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEncrypted.SelectedText = "";
            this.txtEncrypted.SelectionLength = 0;
            this.txtEncrypted.SelectionStart = 0;
            this.txtEncrypted.ShortcutsEnabled = true;
            this.txtEncrypted.Size = new System.Drawing.Size(508, 25);
            this.txtEncrypted.TabIndex = 5;
            this.txtEncrypted.UseSelectable = true;
            this.txtEncrypted.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEncrypted.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDecrypt.Location = new System.Drawing.Point(460, 197);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseCustomBackColor = true;
            this.btnDecrypt.UseCustomForeColor = true;
            this.btnDecrypt.UseSelectable = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // frmEncryptDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 248);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.lblEncrypted);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEncryptDecrypt";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Encrypt-Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtValue;
        private MetroFramework.Controls.MetroButton btnEncrypt;
        private MetroFramework.Controls.MetroLabel lblValue;
        private MetroFramework.Controls.MetroLabel lblEncrypted;
        private MetroFramework.Controls.MetroLabel lblDecrypted;
        private MetroFramework.Controls.MetroTextBox txtDecrypted;
        private MetroFramework.Controls.MetroTextBox txtEncrypted;
        private MetroFramework.Controls.MetroButton btnDecrypt;
    }
}

