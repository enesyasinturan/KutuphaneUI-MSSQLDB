using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KutuphaneUI.Forms;
using System.Net.Mail;
using System.Data.SqlClient;


namespace KutuphaneUI.Sayfalar
{
    public partial class Profil : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");

        

        public Profil()
        {
            InitializeComponent();
            
        }

        private void ButtonFormGirisPanelGiris_Click(object sender, EventArgs e)
        {
            if(panelProfilSifreDegistir.Visible == true)
                panelProfilSifreDegistir.Visible = false;
            else
                panelProfilSifreDegistir.Visible = true;
        }

        private void Profil_Load_1(object sender, EventArgs e)
        {
            textBoxProfilKullaniciAdi.Text = FormGirisPaneli.kullaniciAdi;
            textBoxProfilSifre.Text = FormGirisPaneli.sifre;
            textBoxProfilAd.Text = FormGirisPaneli.ad;
            textBoxProfilSoyad.Text = FormGirisPaneli.soyad;
            textBoxProfilEmail.Text = FormGirisPaneli.email;
            textBoxProfilSonGorulme.Text = FormGirisPaneli.sonGorulme.ToString();

            int yetkiNo = FormGirisPaneli.yetki;
            if (yetkiNo == 1)
                textBoxProfilYetki.Text = "Yönetici";
            else if (yetkiNo == 2)
                textBoxProfilYetki.Text = "Süper Kullanıcı";
            else if (yetkiNo == 3)
                textBoxProfilYetki.Text = "Kullanıcı";
            else if (yetkiNo == 4)
                textBoxProfilYetki.Text = "Misafir";

            textBoxProfilKayitTarihi.Text = FormGirisPaneli.kayitTarihi.ToString();

            labelProfilKullaniciAdi.Enabled = false;
            textBoxProfilEmail.Enabled = false;
            textBoxProfilSonGorulme.Enabled = false;
            textBoxProfilYetki.Enabled = false;
            textBoxProfilSifre.Enabled = false;
            textBoxProfilKayitTarihi.Enabled = false;
            textBoxProfilKullaniciAdi.Enabled = false;

            panelProfilSifreDegistir.Visible = false;
            panelProfilEmailDegistir.Visible = false;

            if(FormAnaSayfa.adDegistirildiMi == true)
            {
                ButtonProfilAdKaydet.Text = "DEĞİŞTİRİLDİ";
                ButtonProfilAdKaydet.Enabled = false;
                textBoxProfilAd.Enabled = false;
            }

            if (FormAnaSayfa.adDegistirildiMi == false)
            {
                ButtonProfilAdKaydet.Text = "KAYDET";
                ButtonProfilAdKaydet.Enabled = true;
                textBoxProfilAd.Enabled = true;
            }



            if (FormAnaSayfa.soyadDegistirildiMi == true)
            {
                ButtonProfilSoyadKaydet.Text = "DEĞİŞTİRİLDİ";
                ButtonProfilSoyadKaydet.Enabled = false;
                textBoxProfilSoyad.Enabled = false;
            }

            if (FormAnaSayfa.soyadDegistirildiMi == false)
            {
                ButtonProfilSoyadKaydet.Text = "KAYDET";
                ButtonProfilSoyadKaydet.Enabled = true;
                textBoxProfilSoyad.Enabled = true;
            }



            if (FormAnaSayfa.sifreDegistirildiMi == true)
            {
                ButtonProfilSifreDegistir.Text = "DEĞİŞTİRİLDİ";
                ButtonProfilSifreDegistir.Enabled = false;
            }

            if (FormAnaSayfa.sifreDegistirildiMi == false)
            {
                ButtonProfilSifreDegistir.Text = "ŞİFRE DEĞİŞTİR";
                ButtonProfilSifreDegistir.Enabled = true;

            }


            if (FormAnaSayfa.emailDegistirildiMi == false)
            {
                ButtonProfilEmailDegistir.Text = "E-MAİL DEĞİŞTİR";
                ButtonProfilEmailDegistir.Enabled = true;
            }

            if (FormAnaSayfa.emailDegistirildiMi == true)
            {
                ButtonProfilEmailDegistir.Text = "DEĞİŞTİRİLDİ";
                ButtonProfilEmailDegistir.Enabled = false;
            }

        }

        private void ButtonProfilEmailDegistir_Click(object sender, EventArgs e)
        {
            if (panelProfilEmailDegistir.Visible == true)
                panelProfilEmailDegistir.Visible = false;
            else
                panelProfilEmailDegistir.Visible = true;
        }

        private void ButtonProfilAdKaydet_Click(object sender, EventArgs e)
        {
            if(textBoxProfilAd.Text == FormGirisPaneli.ad)
            {
                labelProfilAdHata.Text = "Aynı adı kaydetmeye çalışıyorsunuz.";
            }

            else if(textBoxProfilAd.TextLength == 0)
            {
                labelProfilAdHata.Text = "Ad alanı boş bırakılamaz.";
            }

            else if(textBoxProfilAd.Text != FormGirisPaneli.ad && textBoxProfilAd.TextLength != 0)
            {
                baglanti.Open();
                string sorgu = "UPDATE kullanici SET Ad=@Ad FROM kullanici WHERE KullaniciAdi=@KullaniciAdi";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Ad", textBoxProfilAd.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", textBoxProfilKullaniciAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                ButtonProfilAdKaydet.Text = "DEĞİŞTİRİLDİ";
                ButtonProfilAdKaydet.Enabled = false;
                textBoxProfilAd.Enabled = false;

                labelProfilAdHata.Text = "";

                FormAnaSayfa.adDegistirildiMi = true;
            }
        }

        private void ButtonProfilSoyadKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxProfilSoyad.Text == FormGirisPaneli.soyad)
            {
                labelProfilSoyadHata.Text = "Aynı soyadı kaydetmeye çalışıyorsunuz.";
            }

            else if (textBoxProfilSoyad.TextLength == 0)
            {
                labelProfilSoyadHata.Text = "Soyad alanı boş bırakılamaz.";
            }

            else if(textBoxProfilSoyad.Text != FormGirisPaneli.soyad && textBoxProfilSoyad.TextLength != 0)
            {
                baglanti.Open();
                string sorgu = "UPDATE kullanici SET Soyad=@Soyad FROM kullanici WHERE KullaniciID=@KullaniciID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Soyad", textBoxProfilSoyad.Text);
                komut.Parameters.AddWithValue("@KullaniciID", FormGirisPaneli.kullaniciID);
                komut.ExecuteNonQuery();
                baglanti.Close();

                ButtonProfilSoyadKaydet.Text = "DEĞİŞTİRİLDİ";
                ButtonProfilSoyadKaydet.Enabled = false;
                textBoxProfilSoyad.Enabled = false;

                labelProfilSoyadHata.Text = "";

                FormAnaSayfa.soyadDegistirildiMi = true;
            }
        }

        //ŞİFRE
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if(tbPanelSifreSifre.Text != FormGirisPaneli.sifre)
            {
                labelPanelSifreHata1.Text = "Mevcut şifrenizi yanlış girdiniz.";
                labelPanelSifreHata3.Text = "";
                labelPanelSifreHata2.Text = "";
            }

            else if (tbPanelSifreYeniSifre.TextLength == 0)
            {
                labelPanelSifreHata2.Text = "Şifre alanı boş bırakılamaz.";
                labelPanelSifreHata1.Text = "";
                labelPanelSifreHata3.Text = "";
            }

            else if(tbPanelSifreYeniSifre.Text != tbPanelSifreYeniSifreTekrar.Text)
            {
                labelPanelSifreHata3.Text = "Yeni şifreler birbiriyle aynı değil.";
                labelPanelSifreHata1.Text = "";
                labelPanelSifreHata2.Text = "";
            }

            else if (tbPanelSifreSifre.Text == tbPanelSifreYeniSifre.Text)
            {
                labelPanelSifreHata2.Text = "Girdiğiniz şifre mevcut şifrenizle aynıdır.";
                labelPanelSifreHata1.Text = "";
                labelPanelSifreHata3.Text = "";
            }

            else if(tbPanelSifreSifre.Text == FormGirisPaneli.sifre && tbPanelSifreYeniSifre.Text == tbPanelSifreYeniSifreTekrar.Text && tbPanelSifreSifre.Text != tbPanelSifreYeniSifre.Text)
            {
                baglanti.Open();
                string sorgu = "UPDATE kullanici SET Sifre=@Sifre FROM kullanici WHERE KullaniciID=@KullaniciID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Sifre", tbPanelSifreYeniSifre.Text);
                komut.Parameters.AddWithValue("@KullaniciID",FormGirisPaneli.kullaniciID);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Şifreniz başarıyla değiştirildi.");

                labelPanelEmailHata3.Text = "";
                labelPanelEmailHata1.Text = "";

                tbPanelSifreSifre.Clear();
                tbPanelSifreYeniSifre.Clear();
                tbPanelSifreYeniSifreTekrar.Clear();
                panelProfilSifreDegistir.Visible = false;

                FormAnaSayfa.sifreDegistirildiMi = true;

                textBoxProfilSifre.Enabled = false;
                ButtonProfilSifreDegistir.Enabled = false;
                ButtonProfilSifreDegistir.Text = "DEĞİŞTİRİLDİ";
            }
        }

        //Email
        private void ıconButton2_Click(object sender, EventArgs e)
        {
            if (tbEmailSifre.Text != FormGirisPaneli.sifre)
            {
                labelPanelEmailHata1.Text = "Mevcut şifrenizi yanlış girdiniz.";
                labelPanelEmailHata3.Text = "";
                labelPanelEmailHata2.Text = "";
            }

            else if (tbEmailYeniEmail.TextLength == 0)
            {
                labelPanelEmailHata2.Text = "E-mail alanı boş bırakılamaz.";
                labelPanelEmailHata1.Text = "";
                labelPanelEmailHata3.Text = "";
            }

            else if (tbEmailYeniEmail.Text != tbEmailYeniEmailTekrar.Text)
            {
                labelPanelEmailHata3.Text = "Yeni e-mail adresleri birbiriyle aynı değil.";
                labelPanelEmailHata1.Text = "";
                labelPanelEmailHata2.Text = "";
            }

            else if(tbEmailYeniEmail.Text == FormGirisPaneli.email)
            {
                labelPanelEmailHata2.Text = "Girdiğiniz e-mail mevcut şifrenizle aynıdır.";
                labelPanelEmailHata1.Text = "";
                labelPanelEmailHata3.Text = "";
            }
            

            else if (tbEmailSifre.Text == FormGirisPaneli.sifre && tbEmailYeniEmail.Text == tbEmailYeniEmailTekrar.Text && tbEmailYeniEmail.Text != FormGirisPaneli.email)
            {
                baglanti.Open();
                string sorgu = "UPDATE kullanici SET Email=@Email FROM kullanici WHERE KullaniciID=@KullaniciID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Email", tbEmailYeniEmail.Text);
                komut.Parameters.AddWithValue("@KullaniciID", FormGirisPaneli.kullaniciID);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("E-Mail adresiniz başarıyla değiştirildi.");

                labelPanelEmailHata1.Text = "";
                labelPanelEmailHata3.Text = "";

                tbEmailSifre.Clear();
                tbEmailYeniEmail.Clear();
                tbEmailYeniEmailTekrar.Clear();
                panelProfilEmailDegistir.Visible = false;

                FormAnaSayfa.emailDegistirildiMi = true;

                textBoxProfilEmail.Enabled = false;
                ButtonProfilEmailDegistir.Enabled = false;
                ButtonProfilEmailDegistir.Text = "DEĞİŞTİRİLDİ";
            }
        }
    }
}
