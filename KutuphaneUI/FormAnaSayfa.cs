using KutuphaneUI.Forms;
using KutuphaneUI.Sayfalar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneUI
{
    public partial class FormAnaSayfa : Form
    {
        public static bool adDegistirildiMi;
        public static bool soyadDegistirildiMi;
        public static bool sifreDegistirildiMi;
        public static bool emailDegistirildiMi;

        public FormAnaSayfa()
        {
            InitializeComponent();
            //BORDER CORNERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

           
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            labelFormAnaSayfaHosGeldin.Text = FormGirisPaneli.ad;
            labelFormAnaSayfaKullaniciAdi.Text = FormGirisPaneli.kullaniciAdi;
            labelFormAnaSayfaEmail.Text = FormGirisPaneli.email;

            adDegistirildiMi = false;
            soyadDegistirildiMi = false;
            sifreDegistirildiMi = false;
            emailDegistirildiMi = false;


            ButtonAnaSayfaSolMenuAnaSayfa.PerformClick();

            timerAnaSayfa.Start();

            if (FormGirisPaneli.yetki == 1)
                labelFormAnaSayfaYetki.Text = "Yönetici";

            else if (FormGirisPaneli.yetki == 2)
                labelFormAnaSayfaYetki.Text = "Süper Kullanıcı";

            else if (FormGirisPaneli.yetki == 3)
                labelFormAnaSayfaYetki.Text = "Kullanıcı";

            else if (FormGirisPaneli.yetki == 4)
                labelFormAnaSayfaYetki.Text = "Misafir";
        }

        //BORDER CORNERS
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        //DRAG FORM
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormAnaSayfa_MouseDown(object sender, MouseEventArgs e)
        {
            //DRAG FORM
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonAnaSayfaCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void ButtonAnaSayfaMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void ButtonAnaSayfaSolMenuGirisSayfasinaGit_Click(object sender, EventArgs e)
        {
            ButtonSelectedColor(ButtonAnaSayfaSolMenuGirisSayfasinaGit);
            FormGirisPaneli GirisPanelNesnesi = new FormGirisPaneli();
            GirisPanelNesnesi.Show();
            this.Hide();
        }

        private void ButtonAnaSayfaSolMenuAnaSayfa_Click_1(object sender, EventArgs e)
        {
            panelAnaSayfaAnaMenu.Controls.Clear();
            labelTitle.Text = "ANA SAYFA";

            GirisSayfasi GirisSayfaNesnesi = new GirisSayfasi();
            GirisSayfaNesnesi.TopLevel = false;
            GirisSayfaNesnesi.AutoScroll = true;
            panelAnaSayfaAnaMenu.Controls.Add(GirisSayfaNesnesi);
            GirisSayfaNesnesi.Show();

            ButtonSelectedColor(ButtonAnaSayfaSolMenuAnaSayfa);
        }

        private void ButtonSelectedColor(FontAwesome.Sharp.IconButton button)
        {
            ButtonAnaSayfaSolMenuAnaSayfa.BackColor = Color.FromArgb(225, 91, 0);
            ButtonAnaSayfaSolMenuAnaSayfa.IconColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuAnaSayfa.ForeColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuAnaSayfa.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonAnaSayfaSolMenuKitapKaydet.BackColor = Color.FromArgb(225, 91, 0);
            ButtonAnaSayfaSolMenuKitapKaydet.IconColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuKitapKaydet.ForeColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuKitapKaydet.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonAnaSayfaSolMenuKitapListele.BackColor = Color.FromArgb(225, 91, 0);
            ButtonAnaSayfaSolMenuKitapListele.IconColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuKitapListele.ForeColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuKitapListele.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonAnaSayfaSolMenuKullanicilar.BackColor = Color.FromArgb(225, 91, 0);
            ButtonAnaSayfaSolMenuKullanicilar.IconColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuKullanicilar.ForeColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuKullanicilar.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonAnaSayfaSolMenuGeriBildirim.BackColor = Color.FromArgb(225, 91, 0);
            ButtonAnaSayfaSolMenuGeriBildirim.IconColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuGeriBildirim.ForeColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuGeriBildirim.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonAnaSayfaSolMenuGirisSayfasinaGit.BackColor = Color.FromArgb(225, 91, 0);
            ButtonAnaSayfaSolMenuGirisSayfasinaGit.IconColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuGirisSayfasinaGit.ForeColor = Color.Gainsboro;
            ButtonAnaSayfaSolMenuGirisSayfasinaGit.ImageAlign = ContentAlignment.MiddleLeft;

            ButtonProfil.BackColor = Color.FromArgb(225, 91, 0);
            ButtonProfil.IconColor = Color.Gainsboro;
            ButtonProfil.ForeColor = Color.Gainsboro;
            ButtonProfil.ImageAlign = ContentAlignment.MiddleLeft;

            button.BackColor = Color.Gainsboro;
            button.ForeColor = Color.Black;
            button.IconColor = Color.Black;
            //button.ImageAlign = ContentAlignment.MiddleRight;
            
            
                  
        }

        private void ButtonAnaSayfaSolMenuKitapKaydet_Click(object sender, EventArgs e)
        {
            panelAnaSayfaAnaMenu.Controls.Clear();
            labelTitle.Text = "KİTAP KAYDET";

            KitapKaydet KitapKaydetNesnesi = new KitapKaydet();
            KitapKaydetNesnesi.TopLevel = false;
            KitapKaydetNesnesi.AutoScroll = true;
            panelAnaSayfaAnaMenu.Controls.Add(KitapKaydetNesnesi);
            KitapKaydetNesnesi.Show();

            ButtonSelectedColor(ButtonAnaSayfaSolMenuKitapKaydet);
        }

        private void ButtonAnaSayfaSolMenuKitapListele_Click(object sender, EventArgs e)
        {
            panelAnaSayfaAnaMenu.Controls.Clear();
            labelTitle.Text = "KİTAPLAR";

            Kitaplar KitaplarNesnesi = new Kitaplar();
            KitaplarNesnesi.TopLevel = false;
            KitaplarNesnesi.AutoScroll = true;
            panelAnaSayfaAnaMenu.Controls.Add(KitaplarNesnesi);
            KitaplarNesnesi.Show();

            ButtonSelectedColor(ButtonAnaSayfaSolMenuKitapListele);
        }

        private void ButtonAnaSayfaSolMenuKullanicilar_Click(object sender, EventArgs e)
        {
            panelAnaSayfaAnaMenu.Controls.Clear();
            labelTitle.Text = "KULLANICILAR";


            Kullanicilar KullanicilarNesnesi = new Kullanicilar();
            KullanicilarNesnesi.TopLevel = false;
            KullanicilarNesnesi.AutoScroll = true;
            panelAnaSayfaAnaMenu.Controls.Add(KullanicilarNesnesi);
            KullanicilarNesnesi.Show();

            ButtonSelectedColor(ButtonAnaSayfaSolMenuKullanicilar);
        }

        private void ButtonAnaSayfaSolMenuGeriBildirim_Click(object sender, EventArgs e)
        {
            panelAnaSayfaAnaMenu.Controls.Clear();
            labelTitle.Text = "GERİ BİLDİRİM";


            GeriBildirimSayfasi GeriBildirimSayfaNesnesi = new GeriBildirimSayfasi();
            GeriBildirimSayfaNesnesi.TopLevel = false;
            GeriBildirimSayfaNesnesi.AutoScroll = true;
            panelAnaSayfaAnaMenu.Controls.Add(GeriBildirimSayfaNesnesi);
            GeriBildirimSayfaNesnesi.Show();

            ButtonSelectedColor(ButtonAnaSayfaSolMenuGeriBildirim);
        }

        private void timerAnaSayfa_Tick(object sender, EventArgs e)
        {
            
            labelSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ButtonProfil_Click(object sender, EventArgs e)
        {
            panelAnaSayfaAnaMenu.Controls.Clear();
            labelTitle.Text = "PROFİL";


            Profil ProfilNesnesi = new Profil();
            ProfilNesnesi.TopLevel = false;
            ProfilNesnesi.AutoScroll = true;
            panelAnaSayfaAnaMenu.Controls.Add(ProfilNesnesi);
            ProfilNesnesi.Show();

            ButtonSelectedColor(ButtonProfil);
        }
    }                                             


}
