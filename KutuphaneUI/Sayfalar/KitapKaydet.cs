using KutuphaneUI.Forms;
using KutuphaneUI.Sayfalar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneUI.Sayfalar
{
    public partial class KitapKaydet : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        //SqlDataAdapter da;
        

        public KitapKaydet()
        {
            InitializeComponent();
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            if(textBoxKitapAdi.TextLength == 0)
            {
                labelKitapBos.Text = "Kitap ismi boş bırakılamaz";
                labelYazarBos.Text = "";
                labelSayfaBos.Text = "";
                labelYayimeviBos.Text = "";
            }

            else if(textBoxYazarAdi.TextLength == 0)
            {
                labelKitapBos.Text = "";
                labelYazarBos.Text = "Yazar ismi boş bırakılamaz";
                labelSayfaBos.Text = "";
                labelYayimeviBos.Text = "";
            }

            else if (numericUpDownSayfaSayisi.Value == 0)
            {
                labelKitapBos.Text = "";
                labelYazarBos.Text = "";
                labelSayfaBos.Text = "Sayfa sayısını kontrol ediniz";
                labelYayimeviBos.Text = "";
            }

            else if (textBoxYayinevi.TextLength == 0)
            {
                labelKitapBos.Text = "";
                labelYazarBos.Text = "";
                labelSayfaBos.Text = "";
                labelYayimeviBos.Text = "Yayınevi ismi boş bırakılamaz";
            }

            else
            {
                try
                {
                    baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");
                    baglanti.Open();
                    string sorguYazar = "INSERT INTO yazar(YazarAdi) VALUES(@Yazar); SELECT SCOPE_IDENTITY()";
                    komut = new SqlCommand(sorguYazar, baglanti);
                    komut.Parameters.AddWithValue("@Yazar", textBoxYazarAdi.Text);
                    string YazarID = komut.ExecuteScalar().ToString();


                    string sorguYayinevi = "INSERT INTO yayinevi(YayineviAdi) VALUES(@YayineviAdi); SELECT SCOPE_IDENTITY()";
                    komut = new SqlCommand(sorguYayinevi, baglanti);
                    komut.Parameters.AddWithValue("@YayineviAdi", textBoxYayinevi.Text);
                    string YayineviID = komut.ExecuteScalar().ToString();


                    string sorguKitapKayit = "INSERT INTO kitap(YazarID, KullaniciID, YayineviID, KitapAdi, SayfaSayisi, BasimYili, BaslamaTarihi, BitirmeTarihi) VALUES(@YazarID, @KullaniciID, @YayineviID, @KitapAdi, @SayfaSayisi, @BasimYili, @BaslamaTarihi, @BitirmeTarihi)";
                    komut = new SqlCommand(sorguKitapKayit, baglanti);
                    komut.Parameters.AddWithValue("@YazarID", YazarID);
                    komut.Parameters.AddWithValue("@KullaniciID", FormGirisPaneli.kullaniciID);
                    komut.Parameters.AddWithValue("@YayineviID", YayineviID);
                    komut.Parameters.AddWithValue("@KitapAdi", textBoxKitapAdi.Text);
                    komut.Parameters.AddWithValue("@SayfaSayisi", numericUpDownSayfaSayisi.Value);
                    komut.Parameters.AddWithValue("@BasimYili", dateTimePickerBasimYili.Value);
                    komut.Parameters.AddWithValue("@BaslamaTarihi", SqlDbType.Date).Value = dateTimePickerBaslamaTarihi.Value.Date;
                    komut.Parameters.AddWithValue("@BitirmeTarihi", SqlDbType.Date).Value = dateTimePickerBitirmeTarihi.Value.Date;

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kitap başarıyla kayıt edildi.", "Kitap Kayıt");
                    Temizle();
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Kitap Kayıt Hatası");
                    baglanti.Close();
                }
            }
        }

        private void Temizle()
        {
            textBoxKitapAdi.Clear();
            textBoxYazarAdi.Clear();
            numericUpDownSayfaSayisi.Value = 0;
            textBoxYayinevi.Clear();

            dateTimePickerBasimYili.Value = dateTimePickerBasimYili.MaxDate;
            dateTimePickerBaslamaTarihi.Value = dateTimePickerBaslamaTarihi.MaxDate;

            labelKitapBos.Text = "";
            labelYazarBos.Text = "";
            labelYayimeviBos.Text = "";
            labelSayfaBos.Text = "";
        }

        private void ButtonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void KitapKaydet_Load(object sender, EventArgs e)
        {
            dateTimePickerBasimYili.MaxDate = DateTime.Now;
            dateTimePickerBitirmeTarihi.MaxDate = DateTime.Now;
            dateTimePickerBaslamaTarihi.MaxDate = DateTime.Now;
        }

        private void dateTimePickerBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBitirmeTarihi.MinDate = dateTimePickerBaslamaTarihi.Value;
        }

    }
}
