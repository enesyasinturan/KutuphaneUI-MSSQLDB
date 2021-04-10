
namespace KutuphaneUI
{
    partial class FormAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.ButtonAnaSayfaCikis = new FontAwesome.Sharp.IconButton();
            this.ButtonAnaSayfaMinimize = new FontAwesome.Sharp.IconButton();
            this.panelAnaSayfaUstMenu = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelSaat = new System.Windows.Forms.Label();
            this.panelAnaSayfaAltMenu = new System.Windows.Forms.Panel();
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit = new FontAwesome.Sharp.IconButton();
            this.panelAnaSayfaAnaMenu = new System.Windows.Forms.Panel();
            this.panelAnaSayfaSolMenu = new System.Windows.Forms.Panel();
            this.ButtonAnaSayfaSolMenuGeriBildirim = new FontAwesome.Sharp.IconButton();
            this.ButtonAnaSayfaSolMenuKullanicilar = new FontAwesome.Sharp.IconButton();
            this.ButtonProfil = new FontAwesome.Sharp.IconButton();
            this.ButtonAnaSayfaSolMenuKitapListele = new FontAwesome.Sharp.IconButton();
            this.ButtonAnaSayfaSolMenuKitapKaydet = new FontAwesome.Sharp.IconButton();
            this.ButtonAnaSayfaSolMenuAnaSayfa = new FontAwesome.Sharp.IconButton();
            this.panelAnaSayfaSolMenuUst = new System.Windows.Forms.Panel();
            this.labelFormAnaSayfaEmail = new System.Windows.Forms.Label();
            this.labelFormAnaSayfaEmailYazisi = new System.Windows.Forms.Label();
            this.labelFormAnaSayfaKullaniciAdi = new System.Windows.Forms.Label();
            this.labelFormAnaSayfaKullaniciAdiYazisi = new System.Windows.Forms.Label();
            this.labelFormAnaSayfaYetki = new System.Windows.Forms.Label();
            this.labelFormAnaSayfaYetkiYazisi = new System.Windows.Forms.Label();
            this.labelFormAnaSayfaHosGeldin = new System.Windows.Forms.Label();
            this.labelFormAnaSayfaHosGeldinYazisi = new System.Windows.Forms.Label();
            this.timerAnaSayfa = new System.Windows.Forms.Timer(this.components);
            this.panelAnaSayfaUstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelAnaSayfaAltMenu.SuspendLayout();
            this.panelAnaSayfaSolMenu.SuspendLayout();
            this.panelAnaSayfaSolMenuUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAnaSayfaCikis
            // 
            this.ButtonAnaSayfaCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAnaSayfaCikis.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaCikis.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ButtonAnaSayfaCikis.IconColor = System.Drawing.Color.Black;
            this.ButtonAnaSayfaCikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaCikis.IconSize = 25;
            this.ButtonAnaSayfaCikis.Location = new System.Drawing.Point(1156, 12);
            this.ButtonAnaSayfaCikis.Name = "ButtonAnaSayfaCikis";
            this.ButtonAnaSayfaCikis.Size = new System.Drawing.Size(32, 30);
            this.ButtonAnaSayfaCikis.TabIndex = 0;
            this.ButtonAnaSayfaCikis.UseVisualStyleBackColor = true;
            this.ButtonAnaSayfaCikis.Click += new System.EventHandler(this.ButtonAnaSayfaCikis_Click);
            // 
            // ButtonAnaSayfaMinimize
            // 
            this.ButtonAnaSayfaMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAnaSayfaMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ButtonAnaSayfaMinimize.IconColor = System.Drawing.Color.Black;
            this.ButtonAnaSayfaMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaMinimize.IconSize = 25;
            this.ButtonAnaSayfaMinimize.Location = new System.Drawing.Point(1110, 12);
            this.ButtonAnaSayfaMinimize.Name = "ButtonAnaSayfaMinimize";
            this.ButtonAnaSayfaMinimize.Size = new System.Drawing.Size(32, 30);
            this.ButtonAnaSayfaMinimize.TabIndex = 1;
            this.ButtonAnaSayfaMinimize.UseVisualStyleBackColor = true;
            this.ButtonAnaSayfaMinimize.Click += new System.EventHandler(this.ButtonAnaSayfaMinimize_Click);
            // 
            // panelAnaSayfaUstMenu
            // 
            this.panelAnaSayfaUstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.panelAnaSayfaUstMenu.Controls.Add(this.labelTitle);
            this.panelAnaSayfaUstMenu.Controls.Add(this.labelLogo);
            this.panelAnaSayfaUstMenu.Controls.Add(this.pictureBoxIcon);
            this.panelAnaSayfaUstMenu.Controls.Add(this.ButtonAnaSayfaCikis);
            this.panelAnaSayfaUstMenu.Controls.Add(this.ButtonAnaSayfaMinimize);
            this.panelAnaSayfaUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnaSayfaUstMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAnaSayfaUstMenu.Name = "panelAnaSayfaUstMenu";
            this.panelAnaSayfaUstMenu.Size = new System.Drawing.Size(1200, 50);
            this.panelAnaSayfaUstMenu.TabIndex = 3;
            this.panelAnaSayfaUstMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAnaSayfa_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(625, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(89, 28);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "BAŞLIK";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLogo.Location = new System.Drawing.Point(60, 12);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(143, 24);
            this.labelLogo.TabIndex = 4;
            this.labelLogo.Text = "KÜTÜPHANEM";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::KutuphaneUI.Properties.Resources.book;
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(44, 38);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSaat.Location = new System.Drawing.Point(1106, 15);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(55, 24);
            this.labelSaat.TabIndex = 3;
            this.labelSaat.Text = "Saat";
            // 
            // panelAnaSayfaAltMenu
            // 
            this.panelAnaSayfaAltMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.panelAnaSayfaAltMenu.Controls.Add(this.ButtonAnaSayfaSolMenuGirisSayfasinaGit);
            this.panelAnaSayfaAltMenu.Controls.Add(this.labelSaat);
            this.panelAnaSayfaAltMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAnaSayfaAltMenu.Location = new System.Drawing.Point(0, 650);
            this.panelAnaSayfaAltMenu.Name = "panelAnaSayfaAltMenu";
            this.panelAnaSayfaAltMenu.Size = new System.Drawing.Size(1200, 50);
            this.panelAnaSayfaAltMenu.TabIndex = 4;
            this.panelAnaSayfaAltMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAnaSayfa_MouseDown);
            // 
            // ButtonAnaSayfaSolMenuGirisSayfasinaGit
            // 
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.Location = new System.Drawing.Point(0, 0);
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.Name = "ButtonAnaSayfaSolMenuGirisSayfasinaGit";
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.Size = new System.Drawing.Size(250, 60);
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.TabIndex = 11;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.Text = "Oturumu Kapat";
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.UseVisualStyleBackColor = false;
            this.ButtonAnaSayfaSolMenuGirisSayfasinaGit.Click += new System.EventHandler(this.ButtonAnaSayfaSolMenuGirisSayfasinaGit_Click);
            // 
            // panelAnaSayfaAnaMenu
            // 
            this.panelAnaSayfaAnaMenu.BackColor = System.Drawing.Color.White;
            this.panelAnaSayfaAnaMenu.Location = new System.Drawing.Point(250, 50);
            this.panelAnaSayfaAnaMenu.Name = "panelAnaSayfaAnaMenu";
            this.panelAnaSayfaAnaMenu.Size = new System.Drawing.Size(950, 600);
            this.panelAnaSayfaAnaMenu.TabIndex = 5;
            this.panelAnaSayfaAnaMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAnaSayfa_MouseDown);
            // 
            // panelAnaSayfaSolMenu
            // 
            this.panelAnaSayfaSolMenu.Controls.Add(this.ButtonAnaSayfaSolMenuGeriBildirim);
            this.panelAnaSayfaSolMenu.Controls.Add(this.ButtonAnaSayfaSolMenuKullanicilar);
            this.panelAnaSayfaSolMenu.Controls.Add(this.ButtonProfil);
            this.panelAnaSayfaSolMenu.Controls.Add(this.ButtonAnaSayfaSolMenuKitapListele);
            this.panelAnaSayfaSolMenu.Controls.Add(this.ButtonAnaSayfaSolMenuKitapKaydet);
            this.panelAnaSayfaSolMenu.Controls.Add(this.ButtonAnaSayfaSolMenuAnaSayfa);
            this.panelAnaSayfaSolMenu.Controls.Add(this.panelAnaSayfaSolMenuUst);
            this.panelAnaSayfaSolMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAnaSayfaSolMenu.Location = new System.Drawing.Point(0, 50);
            this.panelAnaSayfaSolMenu.Name = "panelAnaSayfaSolMenu";
            this.panelAnaSayfaSolMenu.Size = new System.Drawing.Size(250, 600);
            this.panelAnaSayfaSolMenu.TabIndex = 6;
            // 
            // ButtonAnaSayfaSolMenuGeriBildirim
            // 
            this.ButtonAnaSayfaSolMenuGeriBildirim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonAnaSayfaSolMenuGeriBildirim.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAnaSayfaSolMenuGeriBildirim.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaSolMenuGeriBildirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaSolMenuGeriBildirim.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAnaSayfaSolMenuGeriBildirim.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuGeriBildirim.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.ButtonAnaSayfaSolMenuGeriBildirim.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuGeriBildirim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaSolMenuGeriBildirim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAnaSayfaSolMenuGeriBildirim.Location = new System.Drawing.Point(0, 540);
            this.ButtonAnaSayfaSolMenuGeriBildirim.Name = "ButtonAnaSayfaSolMenuGeriBildirim";
            this.ButtonAnaSayfaSolMenuGeriBildirim.Size = new System.Drawing.Size(250, 60);
            this.ButtonAnaSayfaSolMenuGeriBildirim.TabIndex = 10;
            this.ButtonAnaSayfaSolMenuGeriBildirim.Text = "Geri Bildirim";
            this.ButtonAnaSayfaSolMenuGeriBildirim.UseVisualStyleBackColor = false;
            this.ButtonAnaSayfaSolMenuGeriBildirim.Click += new System.EventHandler(this.ButtonAnaSayfaSolMenuGeriBildirim_Click);
            // 
            // ButtonAnaSayfaSolMenuKullanicilar
            // 
            this.ButtonAnaSayfaSolMenuKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonAnaSayfaSolMenuKullanicilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAnaSayfaSolMenuKullanicilar.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaSolMenuKullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaSolMenuKullanicilar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAnaSayfaSolMenuKullanicilar.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuKullanicilar.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ButtonAnaSayfaSolMenuKullanicilar.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuKullanicilar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaSolMenuKullanicilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAnaSayfaSolMenuKullanicilar.Location = new System.Drawing.Point(0, 480);
            this.ButtonAnaSayfaSolMenuKullanicilar.Name = "ButtonAnaSayfaSolMenuKullanicilar";
            this.ButtonAnaSayfaSolMenuKullanicilar.Size = new System.Drawing.Size(250, 60);
            this.ButtonAnaSayfaSolMenuKullanicilar.TabIndex = 9;
            this.ButtonAnaSayfaSolMenuKullanicilar.Text = "Kullanıcılar";
            this.ButtonAnaSayfaSolMenuKullanicilar.UseVisualStyleBackColor = false;
            this.ButtonAnaSayfaSolMenuKullanicilar.Click += new System.EventHandler(this.ButtonAnaSayfaSolMenuKullanicilar_Click);
            // 
            // ButtonProfil
            // 
            this.ButtonProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonProfil.FlatAppearance.BorderSize = 0;
            this.ButtonProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProfil.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonProfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonProfil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ButtonProfil.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonProfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProfil.Location = new System.Drawing.Point(0, 420);
            this.ButtonProfil.Name = "ButtonProfil";
            this.ButtonProfil.Size = new System.Drawing.Size(250, 60);
            this.ButtonProfil.TabIndex = 11;
            this.ButtonProfil.Text = "Profil";
            this.ButtonProfil.UseVisualStyleBackColor = false;
            this.ButtonProfil.Click += new System.EventHandler(this.ButtonProfil_Click);
            // 
            // ButtonAnaSayfaSolMenuKitapListele
            // 
            this.ButtonAnaSayfaSolMenuKitapListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonAnaSayfaSolMenuKitapListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAnaSayfaSolMenuKitapListele.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaSolMenuKitapListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaSolMenuKitapListele.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAnaSayfaSolMenuKitapListele.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuKitapListele.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.ButtonAnaSayfaSolMenuKitapListele.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuKitapListele.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaSolMenuKitapListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAnaSayfaSolMenuKitapListele.Location = new System.Drawing.Point(0, 360);
            this.ButtonAnaSayfaSolMenuKitapListele.Name = "ButtonAnaSayfaSolMenuKitapListele";
            this.ButtonAnaSayfaSolMenuKitapListele.Size = new System.Drawing.Size(250, 60);
            this.ButtonAnaSayfaSolMenuKitapListele.TabIndex = 8;
            this.ButtonAnaSayfaSolMenuKitapListele.Text = "Kayıtlı Kitaplar";
            this.ButtonAnaSayfaSolMenuKitapListele.UseVisualStyleBackColor = false;
            this.ButtonAnaSayfaSolMenuKitapListele.Click += new System.EventHandler(this.ButtonAnaSayfaSolMenuKitapListele_Click);
            // 
            // ButtonAnaSayfaSolMenuKitapKaydet
            // 
            this.ButtonAnaSayfaSolMenuKitapKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonAnaSayfaSolMenuKitapKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAnaSayfaSolMenuKitapKaydet.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaSolMenuKitapKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaSolMenuKitapKaydet.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAnaSayfaSolMenuKitapKaydet.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuKitapKaydet.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ButtonAnaSayfaSolMenuKitapKaydet.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuKitapKaydet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaSolMenuKitapKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAnaSayfaSolMenuKitapKaydet.Location = new System.Drawing.Point(0, 300);
            this.ButtonAnaSayfaSolMenuKitapKaydet.Name = "ButtonAnaSayfaSolMenuKitapKaydet";
            this.ButtonAnaSayfaSolMenuKitapKaydet.Size = new System.Drawing.Size(250, 60);
            this.ButtonAnaSayfaSolMenuKitapKaydet.TabIndex = 7;
            this.ButtonAnaSayfaSolMenuKitapKaydet.Text = "Kitap Kaydet";
            this.ButtonAnaSayfaSolMenuKitapKaydet.UseVisualStyleBackColor = false;
            this.ButtonAnaSayfaSolMenuKitapKaydet.Click += new System.EventHandler(this.ButtonAnaSayfaSolMenuKitapKaydet_Click);
            // 
            // ButtonAnaSayfaSolMenuAnaSayfa
            // 
            this.ButtonAnaSayfaSolMenuAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.ButtonAnaSayfaSolMenuAnaSayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonAnaSayfaSolMenuAnaSayfa.FlatAppearance.BorderSize = 0;
            this.ButtonAnaSayfaSolMenuAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnaSayfaSolMenuAnaSayfa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonAnaSayfaSolMenuAnaSayfa.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuAnaSayfa.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ButtonAnaSayfaSolMenuAnaSayfa.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonAnaSayfaSolMenuAnaSayfa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAnaSayfaSolMenuAnaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAnaSayfaSolMenuAnaSayfa.Location = new System.Drawing.Point(0, 240);
            this.ButtonAnaSayfaSolMenuAnaSayfa.Name = "ButtonAnaSayfaSolMenuAnaSayfa";
            this.ButtonAnaSayfaSolMenuAnaSayfa.Size = new System.Drawing.Size(250, 60);
            this.ButtonAnaSayfaSolMenuAnaSayfa.TabIndex = 6;
            this.ButtonAnaSayfaSolMenuAnaSayfa.Text = "Ana Sayfa";
            this.ButtonAnaSayfaSolMenuAnaSayfa.UseVisualStyleBackColor = false;
            this.ButtonAnaSayfaSolMenuAnaSayfa.Click += new System.EventHandler(this.ButtonAnaSayfaSolMenuAnaSayfa_Click_1);
            // 
            // panelAnaSayfaSolMenuUst
            // 
            this.panelAnaSayfaSolMenuUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaEmail);
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaEmailYazisi);
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaKullaniciAdi);
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaKullaniciAdiYazisi);
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaYetki);
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaYetkiYazisi);
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaHosGeldin);
            this.panelAnaSayfaSolMenuUst.Controls.Add(this.labelFormAnaSayfaHosGeldinYazisi);
            this.panelAnaSayfaSolMenuUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnaSayfaSolMenuUst.Location = new System.Drawing.Point(0, 0);
            this.panelAnaSayfaSolMenuUst.Name = "panelAnaSayfaSolMenuUst";
            this.panelAnaSayfaSolMenuUst.Size = new System.Drawing.Size(250, 240);
            this.panelAnaSayfaSolMenuUst.TabIndex = 0;
            // 
            // labelFormAnaSayfaEmail
            // 
            this.labelFormAnaSayfaEmail.AutoSize = true;
            this.labelFormAnaSayfaEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaEmail.Location = new System.Drawing.Point(9, 212);
            this.labelFormAnaSayfaEmail.Name = "labelFormAnaSayfaEmail";
            this.labelFormAnaSayfaEmail.Size = new System.Drawing.Size(37, 16);
            this.labelFormAnaSayfaEmail.TabIndex = 11;
            this.labelFormAnaSayfaEmail.Text = "email";
            // 
            // labelFormAnaSayfaEmailYazisi
            // 
            this.labelFormAnaSayfaEmailYazisi.AutoSize = true;
            this.labelFormAnaSayfaEmailYazisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaEmailYazisi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaEmailYazisi.Location = new System.Drawing.Point(9, 190);
            this.labelFormAnaSayfaEmailYazisi.Name = "labelFormAnaSayfaEmailYazisi";
            this.labelFormAnaSayfaEmailYazisi.Size = new System.Drawing.Size(52, 16);
            this.labelFormAnaSayfaEmailYazisi.TabIndex = 10;
            this.labelFormAnaSayfaEmailYazisi.Text = "E-MAİL";
            // 
            // labelFormAnaSayfaKullaniciAdi
            // 
            this.labelFormAnaSayfaKullaniciAdi.AutoSize = true;
            this.labelFormAnaSayfaKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaKullaniciAdi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaKullaniciAdi.Location = new System.Drawing.Point(9, 158);
            this.labelFormAnaSayfaKullaniciAdi.Name = "labelFormAnaSayfaKullaniciAdi";
            this.labelFormAnaSayfaKullaniciAdi.Size = new System.Drawing.Size(71, 16);
            this.labelFormAnaSayfaKullaniciAdi.TabIndex = 5;
            this.labelFormAnaSayfaKullaniciAdi.Text = "kullanıcı adı";
            // 
            // labelFormAnaSayfaKullaniciAdiYazisi
            // 
            this.labelFormAnaSayfaKullaniciAdiYazisi.AutoSize = true;
            this.labelFormAnaSayfaKullaniciAdiYazisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaKullaniciAdiYazisi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaKullaniciAdiYazisi.Location = new System.Drawing.Point(9, 136);
            this.labelFormAnaSayfaKullaniciAdiYazisi.Name = "labelFormAnaSayfaKullaniciAdiYazisi";
            this.labelFormAnaSayfaKullaniciAdiYazisi.Size = new System.Drawing.Size(105, 16);
            this.labelFormAnaSayfaKullaniciAdiYazisi.TabIndex = 4;
            this.labelFormAnaSayfaKullaniciAdiYazisi.Text = "KULLANICI ADI ";
            // 
            // labelFormAnaSayfaYetki
            // 
            this.labelFormAnaSayfaYetki.AutoSize = true;
            this.labelFormAnaSayfaYetki.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaYetki.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaYetki.Location = new System.Drawing.Point(9, 108);
            this.labelFormAnaSayfaYetki.Name = "labelFormAnaSayfaYetki";
            this.labelFormAnaSayfaYetki.Size = new System.Drawing.Size(32, 16);
            this.labelFormAnaSayfaYetki.TabIndex = 3;
            this.labelFormAnaSayfaYetki.Text = "yetki";
            // 
            // labelFormAnaSayfaYetkiYazisi
            // 
            this.labelFormAnaSayfaYetkiYazisi.AutoSize = true;
            this.labelFormAnaSayfaYetkiYazisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaYetkiYazisi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaYetkiYazisi.Location = new System.Drawing.Point(9, 90);
            this.labelFormAnaSayfaYetkiYazisi.Name = "labelFormAnaSayfaYetkiYazisi";
            this.labelFormAnaSayfaYetkiYazisi.Size = new System.Drawing.Size(41, 16);
            this.labelFormAnaSayfaYetkiYazisi.TabIndex = 2;
            this.labelFormAnaSayfaYetkiYazisi.Text = "YETKİ";
            // 
            // labelFormAnaSayfaHosGeldin
            // 
            this.labelFormAnaSayfaHosGeldin.AutoSize = true;
            this.labelFormAnaSayfaHosGeldin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaHosGeldin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaHosGeldin.Location = new System.Drawing.Point(8, 45);
            this.labelFormAnaSayfaHosGeldin.Name = "labelFormAnaSayfaHosGeldin";
            this.labelFormAnaSayfaHosGeldin.Size = new System.Drawing.Size(46, 22);
            this.labelFormAnaSayfaHosGeldin.TabIndex = 1;
            this.labelFormAnaSayfaHosGeldin.Text = "İSİM";
            // 
            // labelFormAnaSayfaHosGeldinYazisi
            // 
            this.labelFormAnaSayfaHosGeldinYazisi.AutoSize = true;
            this.labelFormAnaSayfaHosGeldinYazisi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormAnaSayfaHosGeldinYazisi.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFormAnaSayfaHosGeldinYazisi.Location = new System.Drawing.Point(8, 5);
            this.labelFormAnaSayfaHosGeldinYazisi.Name = "labelFormAnaSayfaHosGeldinYazisi";
            this.labelFormAnaSayfaHosGeldinYazisi.Size = new System.Drawing.Size(120, 23);
            this.labelFormAnaSayfaHosGeldinYazisi.TabIndex = 0;
            this.labelFormAnaSayfaHosGeldinYazisi.Text = "HOŞ GELDİN";
            // 
            // timerAnaSayfa
            // 
            this.timerAnaSayfa.Tick += new System.EventHandler(this.timerAnaSayfa_Tick);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelAnaSayfaSolMenu);
            this.Controls.Add(this.panelAnaSayfaAnaMenu);
            this.Controls.Add(this.panelAnaSayfaAltMenu);
            this.Controls.Add(this.panelAnaSayfaUstMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.FormAnaSayfa_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAnaSayfa_MouseDown);
            this.panelAnaSayfaUstMenu.ResumeLayout(false);
            this.panelAnaSayfaUstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelAnaSayfaAltMenu.ResumeLayout(false);
            this.panelAnaSayfaAltMenu.PerformLayout();
            this.panelAnaSayfaSolMenu.ResumeLayout(false);
            this.panelAnaSayfaSolMenuUst.ResumeLayout(false);
            this.panelAnaSayfaSolMenuUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ButtonAnaSayfaCikis;
        private FontAwesome.Sharp.IconButton ButtonAnaSayfaMinimize;
        private System.Windows.Forms.Panel panelAnaSayfaUstMenu;
        private System.Windows.Forms.Panel panelAnaSayfaAltMenu;
        private System.Windows.Forms.Panel panelAnaSayfaAnaMenu;
        private System.Windows.Forms.Panel panelAnaSayfaSolMenu;
        private System.Windows.Forms.Panel panelAnaSayfaSolMenuUst;
        private System.Windows.Forms.Label labelFormAnaSayfaHosGeldinYazisi;
        private FontAwesome.Sharp.IconButton ButtonAnaSayfaSolMenuKitapListele;
        private FontAwesome.Sharp.IconButton ButtonAnaSayfaSolMenuKitapKaydet;
        private FontAwesome.Sharp.IconButton ButtonAnaSayfaSolMenuAnaSayfa;
        private System.Windows.Forms.Label labelFormAnaSayfaHosGeldin;
        private System.Windows.Forms.Label labelFormAnaSayfaEmail;
        private System.Windows.Forms.Label labelFormAnaSayfaEmailYazisi;
        private System.Windows.Forms.Label labelFormAnaSayfaKullaniciAdi;
        private System.Windows.Forms.Label labelFormAnaSayfaKullaniciAdiYazisi;
        private System.Windows.Forms.Label labelFormAnaSayfaYetki;
        private System.Windows.Forms.Label labelFormAnaSayfaYetkiYazisi;
        private FontAwesome.Sharp.IconButton ButtonAnaSayfaSolMenuKullanicilar;
        private FontAwesome.Sharp.IconButton ButtonAnaSayfaSolMenuGirisSayfasinaGit;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Timer timerAnaSayfa;
        private System.Windows.Forms.Label labelLogo;
        private FontAwesome.Sharp.IconButton ButtonAnaSayfaSolMenuGeriBildirim;
        private FontAwesome.Sharp.IconButton ButtonProfil;
        private System.Windows.Forms.Label labelTitle;
    }
}