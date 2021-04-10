using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KutuphaneUI.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace KutuphaneUI
{
    public partial class SifremiUnuttumPaneli : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");

        public SifremiUnuttumPaneli()
        {
            InitializeComponent();
            //BORDER CORNERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
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

        private void ButtonKullaniciKayitGeri_Click(object sender, EventArgs e)
        {
            FormGirisPaneli GirisPanelNesnesi = new FormGirisPaneli();
            GirisPanelNesnesi.Show();
            this.Hide();
        }

        private void ButtoSifremiUnuttumSifirla_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            labelSifremiUnuttumEmailBos.Text = "";
            if (textBoxSifremiUnuttumMailAdresi.TextLength == 0)
                labelSifremiUnuttumEmailBos.Text = "Lütfen e-mail alanını doldurunuz.";


            else
            {
                baglanti.Open();
                SqlCommand selectSorgu = new SqlCommand("select *from kullanici", baglanti);
                SqlDataReader kayitOkuma = selectSorgu.ExecuteReader();

                while (kayitOkuma.Read())
                {
                    if (kayitOkuma["Email"].ToString() == textBoxSifremiUnuttumMailAdresi.Text)
                    {
                        string sifre =kayitOkuma["Sifre"].ToString();
                        kontrol = true;

                        try
                        {
                            string YeniSatir = System.Environment.NewLine;
                            ButtoSifremiUnuttumSifirla.Text = "LÜTFEN BEKLEYİNİZ...";
                            ButtoSifremiUnuttumSifirla.Enabled = false;

                            MailMessage mesajım = new MailMessage();
                            SmtpClient istemci = new SmtpClient();
                            istemci.Credentials = new System.Net.NetworkCredential("destekkutuphanemuyg@outlook.com", "eyteyt03");
                            //istemci.UseDefaultCredentials = false;
                            istemci.Port = 587;
                            istemci.Host = "smtp.live.com";
                            istemci.EnableSsl = true;
                            mesajım.To.Add(textBoxSifremiUnuttumMailAdresi.Text);
                            mesajım.From = new MailAddress("destekkutuphanemuyg@outlook.com");
                            mesajım.Subject = "Kütüphanem Uygulaması Şifre Sıfırlama";
                            mesajım.Body = "Giriş yapacağınız şifreniz: " + sifre;
                            istemci.Send(mesajım);
                            baglanti.Close();

                            MessageBox.Show("Şifreniz mail adresinize gönderildi.");
                            ButtoSifremiUnuttumSifirla.Enabled = true;
                            ButtoSifremiUnuttumSifirla.Text = "GÖNDER";
                            textBoxSifremiUnuttumMailAdresi.Clear();
                            ButtonSifremiUnuttumGeri.PerformClick();
                            
                            break;
                        }

                        catch (Exception hataMesaji)
                        {
                            baglanti.Close();
                            MessageBox.Show(hataMesaji.Message, "Mail gönderme hatası");
                            ButtoSifremiUnuttumSifirla.Enabled = true;
                            ButtoSifremiUnuttumSifirla.Text = "GÖNDER";
                        }
                    }
                }

                baglanti.Close();
                if(!kontrol)
                {
                    MessageBox.Show("Girdiğiniz e-mail kullanıcılar arasında kayıtlı değiltir.");
                }
            }
        }
    }
}
