
namespace KutuphaneUI.Forms
{
    partial class FormGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisPaneli));
            this.labelFormGirisPanelKullaniciGirisi = new System.Windows.Forms.Label();
            this.textBoxFormGirisPanelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.panelFormGirisPanelGorunum = new System.Windows.Forms.Panel();
            this.labelFormGirisPanelOturumAc = new System.Windows.Forms.Label();
            this.pictureBoxFormGirisPanelLogo = new System.Windows.Forms.PictureBox();
            this.labelFormGirisPanelCizgi1 = new System.Windows.Forms.Label();
            this.labelFormGirisPanelCizgi2 = new System.Windows.Forms.Label();
            this.textBoxFormGirisPanelSifre = new System.Windows.Forms.TextBox();
            this.labelFormGirisPanelSifre = new System.Windows.Forms.Label();
            this.errorProviderKullaniciGirisi = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelGirisDurumu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFormGirisPanelGiris = new FontAwesome.Sharp.IconButton();
            this.ButtonFormGirisPanelCikis = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSifremiUnuttum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFormGirisPanelGorunum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormGirisPanelLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKullaniciGirisi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFormGirisPanelKullaniciGirisi
            // 
            this.labelFormGirisPanelKullaniciGirisi.AutoSize = true;
            this.labelFormGirisPanelKullaniciGirisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormGirisPanelKullaniciGirisi.Location = new System.Drawing.Point(86, 343);
            this.labelFormGirisPanelKullaniciGirisi.Name = "labelFormGirisPanelKullaniciGirisi";
            this.labelFormGirisPanelKullaniciGirisi.Size = new System.Drawing.Size(178, 17);
            this.labelFormGirisPanelKullaniciGirisi.TabIndex = 0;
            this.labelFormGirisPanelKullaniciGirisi.Text = "KULLANICI ADI VEYA E-MAİL";
            // 
            // textBoxFormGirisPanelKullaniciAdi
            // 
            this.textBoxFormGirisPanelKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFormGirisPanelKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFormGirisPanelKullaniciAdi.Location = new System.Drawing.Point(43, 376);
            this.textBoxFormGirisPanelKullaniciAdi.Multiline = true;
            this.textBoxFormGirisPanelKullaniciAdi.Name = "textBoxFormGirisPanelKullaniciAdi";
            this.textBoxFormGirisPanelKullaniciAdi.Size = new System.Drawing.Size(265, 32);
            this.textBoxFormGirisPanelKullaniciAdi.TabIndex = 1;
            // 
            // panelFormGirisPanelGorunum
            // 
            this.panelFormGirisPanelGorunum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.panelFormGirisPanelGorunum.Controls.Add(this.labelFormGirisPanelOturumAc);
            this.panelFormGirisPanelGorunum.Controls.Add(this.pictureBoxFormGirisPanelLogo);
            this.panelFormGirisPanelGorunum.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormGirisPanelGorunum.Location = new System.Drawing.Point(0, 0);
            this.panelFormGirisPanelGorunum.Name = "panelFormGirisPanelGorunum";
            this.panelFormGirisPanelGorunum.Size = new System.Drawing.Size(365, 300);
            this.panelFormGirisPanelGorunum.TabIndex = 9;
            this.panelFormGirisPanelGorunum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelFormGirisPanelOturumAc
            // 
            this.labelFormGirisPanelOturumAc.AutoSize = true;
            this.labelFormGirisPanelOturumAc.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormGirisPanelOturumAc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormGirisPanelOturumAc.Location = new System.Drawing.Point(61, 232);
            this.labelFormGirisPanelOturumAc.Name = "labelFormGirisPanelOturumAc";
            this.labelFormGirisPanelOturumAc.Size = new System.Drawing.Size(247, 36);
            this.labelFormGirisPanelOturumAc.TabIndex = 1;
            this.labelFormGirisPanelOturumAc.Text = "KULLANICI GİRİŞİ";
            this.labelFormGirisPanelOturumAc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxFormGirisPanelLogo
            // 
            this.pictureBoxFormGirisPanelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFormGirisPanelLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormGirisPanelLogo.Image")));
            this.pictureBoxFormGirisPanelLogo.Location = new System.Drawing.Point(89, 46);
            this.pictureBoxFormGirisPanelLogo.Name = "pictureBoxFormGirisPanelLogo";
            this.pictureBoxFormGirisPanelLogo.Size = new System.Drawing.Size(183, 150);
            this.pictureBoxFormGirisPanelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormGirisPanelLogo.TabIndex = 0;
            this.pictureBoxFormGirisPanelLogo.TabStop = false;
            this.pictureBoxFormGirisPanelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelFormGirisPanelCizgi1
            // 
            this.labelFormGirisPanelCizgi1.AutoSize = true;
            this.labelFormGirisPanelCizgi1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.labelFormGirisPanelCizgi1.Location = new System.Drawing.Point(40, 395);
            this.labelFormGirisPanelCizgi1.Name = "labelFormGirisPanelCizgi1";
            this.labelFormGirisPanelCizgi1.Size = new System.Drawing.Size(271, 13);
            this.labelFormGirisPanelCizgi1.TabIndex = 12;
            this.labelFormGirisPanelCizgi1.Text = "____________________________________________";
            // 
            // labelFormGirisPanelCizgi2
            // 
            this.labelFormGirisPanelCizgi2.AutoSize = true;
            this.labelFormGirisPanelCizgi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.labelFormGirisPanelCizgi2.Location = new System.Drawing.Point(40, 483);
            this.labelFormGirisPanelCizgi2.Name = "labelFormGirisPanelCizgi2";
            this.labelFormGirisPanelCizgi2.Size = new System.Drawing.Size(271, 13);
            this.labelFormGirisPanelCizgi2.TabIndex = 15;
            this.labelFormGirisPanelCizgi2.Text = "____________________________________________";
            // 
            // textBoxFormGirisPanelSifre
            // 
            this.textBoxFormGirisPanelSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFormGirisPanelSifre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFormGirisPanelSifre.Location = new System.Drawing.Point(43, 464);
            this.textBoxFormGirisPanelSifre.Multiline = true;
            this.textBoxFormGirisPanelSifre.Name = "textBoxFormGirisPanelSifre";
            this.textBoxFormGirisPanelSifre.PasswordChar = '*';
            this.textBoxFormGirisPanelSifre.Size = new System.Drawing.Size(265, 32);
            this.textBoxFormGirisPanelSifre.TabIndex = 2;
            // 
            // labelFormGirisPanelSifre
            // 
            this.labelFormGirisPanelSifre.AutoSize = true;
            this.labelFormGirisPanelSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormGirisPanelSifre.Location = new System.Drawing.Point(153, 434);
            this.labelFormGirisPanelSifre.Name = "labelFormGirisPanelSifre";
            this.labelFormGirisPanelSifre.Size = new System.Drawing.Size(38, 17);
            this.labelFormGirisPanelSifre.TabIndex = 13;
            this.labelFormGirisPanelSifre.Text = "ŞİFRE";
            // 
            // errorProviderKullaniciGirisi
            // 
            this.errorProviderKullaniciGirisi.ContainerControl = this;
            // 
            // labelGirisDurumu
            // 
            this.labelGirisDurumu.AutoSize = true;
            this.labelGirisDurumu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGirisDurumu.ForeColor = System.Drawing.Color.Red;
            this.labelGirisDurumu.Location = new System.Drawing.Point(43, 512);
            this.labelGirisDurumu.Name = "labelGirisDurumu";
            this.labelGirisDurumu.Size = new System.Drawing.Size(0, 16);
            this.labelGirisDurumu.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı hesabı";
            // 
            // ButtonFormGirisPanelGiris
            // 
            this.ButtonFormGirisPanelGiris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFormGirisPanelGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonFormGirisPanelGiris.FlatAppearance.BorderSize = 0;
            this.ButtonFormGirisPanelGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormGirisPanelGiris.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonFormGirisPanelGiris.ForeColor = System.Drawing.Color.GhostWhite;
            this.ButtonFormGirisPanelGiris.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonFormGirisPanelGiris.IconColor = System.Drawing.Color.Black;
            this.ButtonFormGirisPanelGiris.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonFormGirisPanelGiris.Location = new System.Drawing.Point(43, 552);
            this.ButtonFormGirisPanelGiris.Name = "ButtonFormGirisPanelGiris";
            this.ButtonFormGirisPanelGiris.Size = new System.Drawing.Size(266, 48);
            this.ButtonFormGirisPanelGiris.TabIndex = 3;
            this.ButtonFormGirisPanelGiris.Text = "GİRİŞ";
            this.ButtonFormGirisPanelGiris.UseVisualStyleBackColor = false;
            this.ButtonFormGirisPanelGiris.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // ButtonFormGirisPanelCikis
            // 
            this.ButtonFormGirisPanelCikis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFormGirisPanelCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonFormGirisPanelCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonFormGirisPanelCikis.FlatAppearance.BorderSize = 0;
            this.ButtonFormGirisPanelCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFormGirisPanelCikis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonFormGirisPanelCikis.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonFormGirisPanelCikis.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonFormGirisPanelCikis.IconColor = System.Drawing.Color.Black;
            this.ButtonFormGirisPanelCikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonFormGirisPanelCikis.Location = new System.Drawing.Point(43, 606);
            this.ButtonFormGirisPanelCikis.Name = "ButtonFormGirisPanelCikis";
            this.ButtonFormGirisPanelCikis.Size = new System.Drawing.Size(266, 48);
            this.ButtonFormGirisPanelCikis.TabIndex = 4;
            this.ButtonFormGirisPanelCikis.Text = "ÇIKIŞ";
            this.ButtonFormGirisPanelCikis.UseVisualStyleBackColor = false;
            this.ButtonFormGirisPanelCikis.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(166, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "oluştur";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSifremiUnuttum
            // 
            this.labelSifremiUnuttum.AutoSize = true;
            this.labelSifremiUnuttum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifremiUnuttum.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelSifremiUnuttum.Location = new System.Drawing.Point(99, 684);
            this.labelSifremiUnuttum.Name = "labelSifremiUnuttum";
            this.labelSifremiUnuttum.Size = new System.Drawing.Size(79, 21);
            this.labelSifremiUnuttum.TabIndex = 18;
            this.labelSifremiUnuttum.Text = "unuttum";
            this.labelSifremiUnuttum.Click += new System.EventHandler(this.labelSifremiUnuttum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(42, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Şifremi";
            // 
            // FormGirisPaneli
            // 
            this.AcceptButton = this.ButtonFormGirisPanelGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ButtonFormGirisPanelCikis;
            this.ClientSize = new System.Drawing.Size(365, 709);
            this.ControlBox = false;
            this.Controls.Add(this.labelSifremiUnuttum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGirisDurumu);
            this.Controls.Add(this.labelFormGirisPanelCizgi2);
            this.Controls.Add(this.textBoxFormGirisPanelSifre);
            this.Controls.Add(this.labelFormGirisPanelSifre);
            this.Controls.Add(this.labelFormGirisPanelCizgi1);
            this.Controls.Add(this.ButtonFormGirisPanelCikis);
            this.Controls.Add(this.panelFormGirisPanelGorunum);
            this.Controls.Add(this.ButtonFormGirisPanelGiris);
            this.Controls.Add(this.textBoxFormGirisPanelKullaniciAdi);
            this.Controls.Add(this.labelFormGirisPanelKullaniciGirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Giriş Paneli";
            this.Load += new System.EventHandler(this.FormGirisPaneli_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelFormGirisPanelGorunum.ResumeLayout(false);
            this.panelFormGirisPanelGorunum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormGirisPanelLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKullaniciGirisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormGirisPanelKullaniciGirisi;
        private System.Windows.Forms.TextBox textBoxFormGirisPanelKullaniciAdi;
        private FontAwesome.Sharp.IconButton ButtonFormGirisPanelGiris;
        private System.Windows.Forms.Panel panelFormGirisPanelGorunum;
        private System.Windows.Forms.PictureBox pictureBoxFormGirisPanelLogo;
        private FontAwesome.Sharp.IconButton ButtonFormGirisPanelCikis;
        private System.Windows.Forms.Label labelFormGirisPanelCizgi1;
        private System.Windows.Forms.Label labelFormGirisPanelCizgi2;
        private System.Windows.Forms.TextBox textBoxFormGirisPanelSifre;
        private System.Windows.Forms.Label labelFormGirisPanelSifre;
        private System.Windows.Forms.ErrorProvider errorProviderKullaniciGirisi;
        private System.Windows.Forms.Label labelGirisDurumu;
        private System.Windows.Forms.Label labelFormGirisPanelOturumAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSifremiUnuttum;
        private System.Windows.Forms.Label label4;
    }
}