using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using KutuphaneUI.Forms;

namespace KutuphaneUI.Sayfalar
{
    public partial class GeriBildirimSayfasi : Form
    {
        public GeriBildirimSayfasi()
        {
            InitializeComponent();
        }

        private void ButtonGeriBildirimSayfasiGonder_Click(object sender, EventArgs e)
        {
            labelGeriBildirimSayfasiKonuBos.Text = "";
            labelGeriBildirimSayfasiAciklamaBos.Text = "";

            if (richTextBoxGeriBildirimSayfasiKonu.TextLength != 0 && richTextBoxGeriBildirimSayfasiAciklama.TextLength != 0)
            {
                try
                {
                    string YeniSatir = System.Environment.NewLine;
                    ButtonGeriBildirimSayfasiGonder.Text = "LÜTFEN BEKLEYİNİZ...";
                    ButtonGeriBildirimSayfasiGonder.Enabled = false;

                    MailMessage mesajım = new MailMessage();
                    SmtpClient istemci = new SmtpClient();
                    istemci.Credentials = new System.Net.NetworkCredential("destekkutuphanemuyg@outlook.com", "eyteyt03");
                    //istemci.UseDefaultCredentials = false;
                    istemci.Port = 587;
                    istemci.Host = "smtp.live.com";
                    istemci.EnableSsl = true;
                    mesajım.To.Add("eness.yasinturan@gmail.com");
                    mesajım.From = new MailAddress("destekkutuphanemuyg@outlook.com");
                    mesajım.Subject = richTextBoxGeriBildirimSayfasiKonu.Text;
                    mesajım.Body = "Gönderenin İsmi " + YeniSatir + FormGirisPaneli.ad + " " + FormGirisPaneli.soyad + YeniSatir+ YeniSatir + "Gönderenin Mail Adresi "+ YeniSatir + FormGirisPaneli.email + YeniSatir+ YeniSatir + "Gönderenin Kullanıcı Adı "+ YeniSatir+ FormGirisPaneli.kullaniciAdi+ YeniSatir+ YeniSatir + YeniSatir+ "Konu" + YeniSatir + "------" + YeniSatir + richTextBoxGeriBildirimSayfasiAciklama.Text;
                    istemci.Send(mesajım);

                    MessageBox.Show("Geri bildiriminiz başarıyla gönderildi.");
                    ButtonGeriBildirimSayfasiGonder.Enabled = true;
                    ButtonGeriBildirimSayfasiGonder.Text = "GÖNDER";
                    richTextBoxGeriBildirimSayfasiKonu.Clear();
                    richTextBoxGeriBildirimSayfasiAciklama.Clear();
                    labelGeriBildirimSayfasiAciklamaBos.Text = "";
                    labelGeriBildirimSayfasiKonuBos.Text = "";

                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Mail gönderme hatası");
                    ButtonGeriBildirimSayfasiGonder.Enabled = true;
                    ButtonGeriBildirimSayfasiGonder.Text = "GÖNDER";
                }
            }

            else if (richTextBoxGeriBildirimSayfasiKonu.TextLength == 0)
                labelGeriBildirimSayfasiKonuBos.Text = "Lütfen konu kısmını doldurulunuz.";
            else if (richTextBoxGeriBildirimSayfasiAciklama.TextLength == 0)
                labelGeriBildirimSayfasiAciklamaBos.Text = "Lütfen açıklama kısmını doldurunuz.";
        }
    }
}
