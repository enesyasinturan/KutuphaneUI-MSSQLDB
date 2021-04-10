using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using KutuphaneUI.Forms;

namespace KutuphaneUI
{
    public partial class FormKullaniciKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");


        public FormKullaniciKayit()
        {
            InitializeComponent();
            //BORDER CORNERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void FormKullaniciKayit_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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

        private void ButtonKullaniciKayitGeri_Click(object sender, EventArgs e)
        {
            FormGirisPaneli GirisPanelNesnesi = new FormGirisPaneli();
            GirisPanelNesnesi.Show();
            this.Hide();
        }

        private void FormKullaniciKayit_MouseDown(object sender, MouseEventArgs e)
        {
            //DRAG FORM
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonFormKullaniciKayitKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxFormKullaniciKayitKullaniciAdi.TextLength == 0)
            {
                labelKullaniciKayitKullaniciAdiBos.Text = "Kullanıcı adı boş bırakılamaz.";
                labelKullaniciKayitSifreBos.Text = "";
                labelKullaniciKayitSifreTekrarBos.Text = "";
                labelKullaniciKayitAdBos.Text = "";
            }
                
            else if (textBoxFormKullaniciKayitSifre.TextLength == 0)
            {
                labelKullaniciKayitKullaniciAdiBos.Text = "";
                labelKullaniciKayitSifreBos.Text = "Şifre alanı boş bırakılamaz.";
                labelKullaniciKayitSifreTekrarBos.Text = "";
                labelKullaniciKayitAdBos.Text = "";
            }
                
            else if (textBoxFormKullaniciKayitSifreTekrar.TextLength == 0)
            {
                labelKullaniciKayitKullaniciAdiBos.Text = "";
                labelKullaniciKayitSifreBos.Text = "";
                labelKullaniciKayitSifreTekrarBos.Text = "Şifre tekrar alanı boş bırakılamaz.";
                labelKullaniciKayitAdBos.Text = "";
            }
                
            else if (textBoxFormKullaniciKayitAd.TextLength == 0)
            {
                labelKullaniciKayitKullaniciAdiBos.Text = "";
                labelKullaniciKayitSifreBos.Text = "";
                labelKullaniciKayitSifreTekrarBos.Text = "";
                labelKullaniciKayitAdBos.Text = "Ad alanı boş bırakılamaz.";
            }

            else if(textBoxFormKullaniciKayitSifre.Text != textBoxFormKullaniciKayitSifreTekrar.Text)
            {
                labelKullaniciKayitKullaniciAdiBos.Text = "";
                labelKullaniciKayitSifreBos.Text = "";
                labelKullaniciKayitSifreTekrarBos.Text = "";
                labelKullaniciKayitAdBos.Text = "";
                labelKullaniciKayitSifreTekrarBos.Text = "Girilen şifreler aynı değil.";
            }

            

            else if(textBoxFormKullaniciKayitSifre.Text == textBoxFormKullaniciKayitSifreTekrar.Text)
            {
                bool kontrol = true;

                labelKullaniciKayitKullaniciAdiBos.Text = "";
                labelKullaniciKayitSifreBos.Text = "";
                labelKullaniciKayitSifreTekrarBos.Text = "";
                labelKullaniciKayitAdBos.Text = "";

                baglanti.Open();
                SqlCommand selectSorgu = new SqlCommand("select *from kullanici", baglanti);
                SqlDataReader kayitOkuma = selectSorgu.ExecuteReader();
                while (kayitOkuma.Read())
                {
                    if(kayitOkuma["KullaniciAdi"].ToString() == textBoxFormKullaniciKayitKullaniciAdi.Text)
                    {
                        baglanti.Close();
                        MessageBox.Show("Bu kullanıcı adını kullanan bir kayıt mevcuttur.","Kayıt Uyarısı");
                        kontrol = false;
                        break;
                    }

                    else if(kayitOkuma["Email"].ToString() == textBoxFormKullaniciKayitEmail.Text)
                    {
                        baglanti.Close();
                        MessageBox.Show("Bu e-mail adresini kullanan bir kayıt mevcuttur.", "Kayıt Uyarısı");
                        kontrol = false;
                        break;
                    }
                }

                baglanti.Close();

                if(kontrol)
                {
                    try
                    {
                        baglanti.Open();
                        string sorgu = "INSERT INTO kullanici(YetkiID,KullaniciAdi,Sifre,Ad,Soyad,Email,KayitTarihi) VALUES(@Yetki, @KullaniciAdi, @Sifre, @Ad, @Soyad, @Email, @KayitTarihi)";
                        //string sorgu = "INSERT INTO kullanici(YetkiID,KullaniciAdi,Sifre,Ad,Soyad,Email) VALUES(@Yetki, @KullaniciAdi, @Sifre, @Ad, @Soyad, @Email)";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);

                        komut.Parameters.AddWithValue("@Yetki", "3");
                        komut.Parameters.AddWithValue("@KullaniciAdi", textBoxFormKullaniciKayitKullaniciAdi.Text);
                        komut.Parameters.AddWithValue("@Sifre", textBoxFormKullaniciKayitSifre.Text);
                        komut.Parameters.AddWithValue("@Ad", textBoxFormKullaniciKayitAd.Text);
                        komut.Parameters.AddWithValue("@Soyad", textBoxFormKullaniciKayitSoyad.Text);
                        komut.Parameters.AddWithValue("@Email", textBoxFormKullaniciKayitEmail.Text);
                        komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);


                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Kullanıcı başarıyla kayıt edilmiştir.", "Kullanıcı Kayıt");
                        textBoxFormKullaniciKayitKullaniciAdi.Clear();
                        textBoxFormKullaniciKayitSifre.Clear();
                        textBoxFormKullaniciKayitSifreTekrar.Clear();
                        textBoxFormKullaniciKayitAd.Clear();
                        textBoxFormKullaniciKayitSoyad.Clear();
                        textBoxFormKullaniciKayitEmail.Clear();

                        FormGirisPaneli GirisPanelNesnesi = new FormGirisPaneli();
                        GirisPanelNesnesi.Show();
                        this.Hide();
                    }
                    catch (Exception hataMesaji)
                    {
                        baglanti.Close();
                        MessageBox.Show(hataMesaji.Message, "Kullanıcı Kayıt Hatası");
                    }
                }
            }
        }
    }
}
