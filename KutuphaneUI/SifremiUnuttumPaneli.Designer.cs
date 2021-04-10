
namespace KutuphaneUI
{
    partial class SifremiUnuttumPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttumPaneli));
            this.panelUstMenu = new System.Windows.Forms.Panel();
            this.ButtonSifremiUnuttumGeri = new FontAwesome.Sharp.IconButton();
            this.labelFormGirisPanelOturumAc = new System.Windows.Forms.Label();
            this.labelFormGirisPanelCizgi1 = new System.Windows.Forms.Label();
            this.textBoxSifremiUnuttumMailAdresi = new System.Windows.Forms.TextBox();
            this.labelFormGirisPanelKullaniciGirisi = new System.Windows.Forms.Label();
            this.ButtoSifremiUnuttumSifirla = new FontAwesome.Sharp.IconButton();
            this.labelSifremiUnuttumEmailBos = new System.Windows.Forms.Label();
            this.panelUstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUstMenu
            // 
            this.panelUstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.panelUstMenu.Controls.Add(this.ButtonSifremiUnuttumGeri);
            this.panelUstMenu.Controls.Add(this.labelFormGirisPanelOturumAc);
            this.panelUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUstMenu.Location = new System.Drawing.Point(0, 0);
            this.panelUstMenu.Name = "panelUstMenu";
            this.panelUstMenu.Size = new System.Drawing.Size(365, 104);
            this.panelUstMenu.TabIndex = 0;
            // 
            // ButtonSifremiUnuttumGeri
            // 
            this.ButtonSifremiUnuttumGeri.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSifremiUnuttumGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonSifremiUnuttumGeri.FlatAppearance.BorderSize = 0;
            this.ButtonSifremiUnuttumGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSifremiUnuttumGeri.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ButtonSifremiUnuttumGeri.IconColor = System.Drawing.Color.White;
            this.ButtonSifremiUnuttumGeri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSifremiUnuttumGeri.IconSize = 40;
            this.ButtonSifremiUnuttumGeri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSifremiUnuttumGeri.Location = new System.Drawing.Point(3, 29);
            this.ButtonSifremiUnuttumGeri.Name = "ButtonSifremiUnuttumGeri";
            this.ButtonSifremiUnuttumGeri.Size = new System.Drawing.Size(45, 41);
            this.ButtonSifremiUnuttumGeri.TabIndex = 3;
            this.ButtonSifremiUnuttumGeri.UseVisualStyleBackColor = false;
            this.ButtonSifremiUnuttumGeri.Click += new System.EventHandler(this.ButtonKullaniciKayitGeri_Click);
            // 
            // labelFormGirisPanelOturumAc
            // 
            this.labelFormGirisPanelOturumAc.AutoSize = true;
            this.labelFormGirisPanelOturumAc.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormGirisPanelOturumAc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormGirisPanelOturumAc.Location = new System.Drawing.Point(62, 32);
            this.labelFormGirisPanelOturumAc.Name = "labelFormGirisPanelOturumAc";
            this.labelFormGirisPanelOturumAc.Size = new System.Drawing.Size(235, 36);
            this.labelFormGirisPanelOturumAc.TabIndex = 2;
            this.labelFormGirisPanelOturumAc.Text = "ŞİFRE SIFIRLAMA";
            // 
            // labelFormGirisPanelCizgi1
            // 
            this.labelFormGirisPanelCizgi1.AutoSize = true;
            this.labelFormGirisPanelCizgi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.labelFormGirisPanelCizgi1.Location = new System.Drawing.Point(36, 208);
            this.labelFormGirisPanelCizgi1.Name = "labelFormGirisPanelCizgi1";
            this.labelFormGirisPanelCizgi1.Size = new System.Drawing.Size(271, 13);
            this.labelFormGirisPanelCizgi1.TabIndex = 18;
            this.labelFormGirisPanelCizgi1.Text = "____________________________________________";
            // 
            // textBoxSifremiUnuttumMailAdresi
            // 
            this.textBoxSifremiUnuttumMailAdresi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSifremiUnuttumMailAdresi.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifremiUnuttumMailAdresi.Location = new System.Drawing.Point(42, 189);
            this.textBoxSifremiUnuttumMailAdresi.Multiline = true;
            this.textBoxSifremiUnuttumMailAdresi.Name = "textBoxSifremiUnuttumMailAdresi";
            this.textBoxSifremiUnuttumMailAdresi.Size = new System.Drawing.Size(265, 32);
            this.textBoxSifremiUnuttumMailAdresi.TabIndex = 1;
            // 
            // labelFormGirisPanelKullaniciGirisi
            // 
            this.labelFormGirisPanelKullaniciGirisi.AutoSize = true;
            this.labelFormGirisPanelKullaniciGirisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormGirisPanelKullaniciGirisi.Location = new System.Drawing.Point(39, 158);
            this.labelFormGirisPanelKullaniciGirisi.Name = "labelFormGirisPanelKullaniciGirisi";
            this.labelFormGirisPanelKullaniciGirisi.Size = new System.Drawing.Size(48, 17);
            this.labelFormGirisPanelKullaniciGirisi.TabIndex = 17;
            this.labelFormGirisPanelKullaniciGirisi.Text = "E-MAİL";
            // 
            // ButtoSifremiUnuttumSifirla
            // 
            this.ButtoSifremiUnuttumSifirla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtoSifremiUnuttumSifirla.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtoSifremiUnuttumSifirla.FlatAppearance.BorderSize = 0;
            this.ButtoSifremiUnuttumSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtoSifremiUnuttumSifirla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtoSifremiUnuttumSifirla.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtoSifremiUnuttumSifirla.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtoSifremiUnuttumSifirla.IconColor = System.Drawing.Color.Black;
            this.ButtoSifremiUnuttumSifirla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtoSifremiUnuttumSifirla.Location = new System.Drawing.Point(39, 300);
            this.ButtoSifremiUnuttumSifirla.Name = "ButtoSifremiUnuttumSifirla";
            this.ButtoSifremiUnuttumSifirla.Size = new System.Drawing.Size(268, 48);
            this.ButtoSifremiUnuttumSifirla.TabIndex = 2;
            this.ButtoSifremiUnuttumSifirla.Text = "ŞİFREYİ MAİL ADRESİNE GÖNDER";
            this.ButtoSifremiUnuttumSifirla.UseVisualStyleBackColor = false;
            this.ButtoSifremiUnuttumSifirla.Click += new System.EventHandler(this.ButtoSifremiUnuttumSifirla_Click);
            // 
            // labelSifremiUnuttumEmailBos
            // 
            this.labelSifremiUnuttumEmailBos.AutoSize = true;
            this.labelSifremiUnuttumEmailBos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifremiUnuttumEmailBos.ForeColor = System.Drawing.Color.Red;
            this.labelSifremiUnuttumEmailBos.Location = new System.Drawing.Point(48, 234);
            this.labelSifremiUnuttumEmailBos.Name = "labelSifremiUnuttumEmailBos";
            this.labelSifremiUnuttumEmailBos.Size = new System.Drawing.Size(0, 16);
            this.labelSifremiUnuttumEmailBos.TabIndex = 34;
            // 
            // SifremiUnuttumPaneli
            // 
            this.AcceptButton = this.ButtoSifremiUnuttumSifirla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 709);
            this.Controls.Add(this.labelSifremiUnuttumEmailBos);
            this.Controls.Add(this.ButtoSifremiUnuttumSifirla);
            this.Controls.Add(this.labelFormGirisPanelCizgi1);
            this.Controls.Add(this.textBoxSifremiUnuttumMailAdresi);
            this.Controls.Add(this.labelFormGirisPanelKullaniciGirisi);
            this.Controls.Add(this.panelUstMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremiUnuttumPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttumPaneli";
            this.panelUstMenu.ResumeLayout(false);
            this.panelUstMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUstMenu;
        private System.Windows.Forms.Label labelFormGirisPanelOturumAc;
        private FontAwesome.Sharp.IconButton ButtonSifremiUnuttumGeri;
        private System.Windows.Forms.Label labelFormGirisPanelCizgi1;
        private System.Windows.Forms.TextBox textBoxSifremiUnuttumMailAdresi;
        private System.Windows.Forms.Label labelFormGirisPanelKullaniciGirisi;
        private FontAwesome.Sharp.IconButton ButtoSifremiUnuttumSifirla;
        private System.Windows.Forms.Label labelSifremiUnuttumEmailBos;
    }
}