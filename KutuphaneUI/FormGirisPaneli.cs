using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace KutuphaneUI.Forms
{
    public partial class FormGirisPaneli : Form
    {
        public static string kullaniciAdi, ad, soyad, email, sifre;
        public static int yetki, kullaniciID;
        public static DateTime sonGorulme, kayitTarihi;

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");

        public FormGirisPaneli()
        {
            InitializeComponent();
            //BORDER CORNERS
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void FormGirisPaneli_Load(object sender, EventArgs e)
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

        private void labelSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumPaneli SifremiUnuttumNesnesi = new SifremiUnuttumPaneli();
            SifremiUnuttumNesnesi.Show();
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //DRAG FORM
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormKullaniciKayit KullaniciKayitNesnesi = new FormKullaniciKayit();
            KullaniciKayitNesnesi.Show();
            this.Hide();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            labelGirisDurumu.Text = "";
            errorProviderKullaniciGirisi.Clear();
            baglanti.Open();
            SqlCommand selectSorgu = new SqlCommand("select *from kullanici", baglanti);
            SqlDataReader kayitOkuma = selectSorgu.ExecuteReader();
            while (kayitOkuma.Read())
            {
                if (kayitOkuma["KullaniciAdi"].ToString() == textBoxFormGirisPanelKullaniciAdi.Text && kayitOkuma["Sifre"].ToString() == textBoxFormGirisPanelSifre.Text || kayitOkuma["Email"].ToString() == textBoxFormGirisPanelKullaniciAdi.Text && kayitOkuma["Sifre"].ToString() == textBoxFormGirisPanelSifre.Text)
                {
                    kullaniciID = kayitOkuma.GetInt32(0);
                    yetki = kayitOkuma.GetInt32(1);
                    kullaniciAdi = kayitOkuma.GetValue(2).ToString();
                    sifre = kayitOkuma.GetValue(3).ToString();
                    ad = kayitOkuma.GetValue(4).ToString();
                    soyad = kayitOkuma.GetValue(5).ToString();
                    email = kayitOkuma.GetValue(6).ToString();
                    kayitTarihi = kayitOkuma.GetDateTime(8);
                    sonGorulme = DateTime.Now;
                    baglanti.Close();

                    baglanti.Open();
                    string sorgu = "UPDATE kullanici SET sonGorulme=@sonGorulme WHERE KullaniciID=@KullaniciID";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("KullaniciID", kullaniciID);
                    komut.Parameters.AddWithValue("sonGorulme", sonGorulme);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    FormAnaSayfa kutuphaneAnasayfaNesnesi = new FormAnaSayfa();
                    kutuphaneAnasayfaNesnesi.Show();
                    this.Hide();
                    
                    break;
                }
            }

            if (textBoxFormGirisPanelKullaniciAdi.TextLength == 0 || textBoxFormGirisPanelSifre.TextLength == 0)
            {
                labelGirisDurumu.Text = "Kullanıcı adı veya parola boş bırakılamaz";
                errorProviderKullaniciGirisi.SetError(labelGirisDurumu, "Kullanıcı adı veya parola boş bırakılamaz");
                baglanti.Close();
            }

            else
            {
                labelGirisDurumu.Text = "Kullanıcı adı veya parola yanlış";
                errorProviderKullaniciGirisi.SetError(labelGirisDurumu, "Kullanıcı adı veya parola yanlış");
                baglanti.Close();
            }
        }


        private void ıconButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }
    }
}
