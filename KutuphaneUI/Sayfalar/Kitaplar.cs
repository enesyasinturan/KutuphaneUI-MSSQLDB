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
    public partial class Kitaplar : Form
    {
        SqlConnection baglanti;
        //SqlCommand komut;
        SqlDataAdapter da;

        public Kitaplar()
        {
            InitializeComponent();
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            Listele();

            dateTimePickerKitaplarBasimYili.MaxDate = DateTime.Now;
            dateTimePickerKitaplarBitirmeTarihi.MaxDate = DateTime.Now;
            dateTimePickerKitaplarBaslamaTarihi.MaxDate = DateTime.Now;
        }

        private void Doldur()
        {
            textBoxKitaplarKitapAdi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[2].Value.ToString();
            textBoxKitaplarYazarAdi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[3].Value.ToString();
            numericUpDownKitaplarSayfaSayisi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[4].Value.ToString();
            textBoxKitaplarYayineviAdi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePickerKitaplarBasimYili.Text = dataGridViewKitaplar.SelectedRows[0].Cells[6].Value.ToString();
            dateTimePickerKitaplarBaslamaTarihi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[7].Value.ToString();
            dateTimePickerKitaplarBitirmeTarihi.Text = dataGridViewKitaplar.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void Listele()
        {
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT k.KitapID AS[ID], kk.KullaniciAdi AS[Kaydeden Kullanıcı],k.KitapAdi AS[Kitap Adı], y.YazarAdi AS[Yazar Adı], k.SayfaSayisi AS[Sayfa Sayısı] ,yy.YayineviAdi AS[Yayınevi Adı], k.BasimYili AS[Basım Yılı], k.BaslamaTarihi AS[Başlama Tarihi], k.BitirmeTarihi AS[Bitirme Tarihi] FROM kitap k, yazar y, yayinevi yy, kullanici kk WHERE k.KullaniciID='" + FormGirisPaneli.kullaniciID + "' AND k.YazarID = y.YazarID AND k.YayineviID = yy.YayineviID AND k.KullaniciID = kk.KullaniciID ", baglanti) ;
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewKitaplar.DataSource = tablo;
            baglanti.Close();
        }

        private void Temizle()
        {
            textBoxKitaplarKitapAdi.Clear();
            textBoxKitaplarYazarAdi.Clear();
            numericUpDownKitaplarSayfaSayisi.Value = 0;
            textBoxKitaplarYayineviAdi.Clear();
            dateTimePickerKitaplarBasimYili.Value = dateTimePickerKitaplarBasimYili.MaxDate;
            dateTimePickerKitaplarBaslamaTarihi.Value = dateTimePickerKitaplarBaslamaTarihi.MaxDate;
        }

        private void dataGridViewKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Doldur();
        }

        private void ButtonKitaplarSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silenecek, devam etmek istiyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "delete from kitap where KitapID=@KitapID";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@KitapID", dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap veri tabanından silindi.", "Silme İşlemi");
                    Listele();
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Silme Hatası");
                    baglanti.Close();
                }
            }
        }

        private void ButtonKitaplarGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxKitaplarKitapAdi.TextLength == 0 || textBoxKitaplarYazarAdi.TextLength == 0)
                MessageBox.Show("Lütfen güncellemek istediğiniz kayıt üzerine çift tıklayınız.", "Güncelleme Hatası");

            else
            {
                try
                {
                    baglanti.Open();

                    string updateYazar = "UPDATE yazar SET YazarAdi=@YazarAdi FROM yazar y INNER JOIN kitap k ON k.YazarID = y.YazarID WHERE k.KitapID = @KitapID ";

                    string updateYayinevi = "UPDATE yayinevi SET YayineviAdi=@YayineviAdi FROM yayinevi yy INNER JOIN kitap k ON k.YayineviID = yy.YayineviID WHERE k.KitapID = @KitapID ";

                    string updateKitap = "UPDATE kitap SET KitapAdi=@KitapAdi, SayfaSayisi=@SayfaSayisi, BasimYili=@BasimYili, BaslamaTarihi=@BaslamaTarihi, BitirmeTarihi=@BitirmeTarihi WHERE KitapID = @KitapID ";

                    SqlCommand komutYazar = new SqlCommand(updateYazar, baglanti);
                    SqlCommand komutYayinevi = new SqlCommand(updateYayinevi, baglanti);
                    SqlCommand komutKitap = new SqlCommand(updateKitap, baglanti);

                    komutYazar.Parameters.AddWithValue("@KitapID", dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString());
                    komutYayinevi.Parameters.AddWithValue("@KitapID", dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString());
                    komutKitap.Parameters.AddWithValue("@KitapID", dataGridViewKitaplar.SelectedRows[0].Cells[0].Value.ToString());

                    komutKitap.Parameters.AddWithValue("@KitapAdi", textBoxKitaplarKitapAdi.Text);
                    komutYazar.Parameters.AddWithValue("@YazarAdi", textBoxKitaplarYazarAdi.Text);
                    komutKitap.Parameters.AddWithValue("@SayfaSayisi", numericUpDownKitaplarSayfaSayisi.Value.ToString());
                    komutYayinevi.Parameters.AddWithValue("@YayineviAdi", textBoxKitaplarYayineviAdi.Text);
                    komutKitap.Parameters.AddWithValue("@BasimYili", dateTimePickerKitaplarBasimYili.Value);
                    komutKitap.Parameters.AddWithValue("@BaslamaTarihi", dateTimePickerKitaplarBaslamaTarihi.Value);
                    komutKitap.Parameters.AddWithValue("@BitirmeTarihi", dateTimePickerKitaplarBitirmeTarihi.Value);
                    komutYayinevi.ExecuteNonQuery();
                    komutYazar.ExecuteNonQuery();
                    komutKitap.ExecuteNonQuery();
                    baglanti.Close();
                    Listele();
                    Temizle();
                    
                    MessageBox.Show("Kitap bilgileri güncellendi.", "Güncelleme İşlemi");
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Güncelleme Hatası");
                    baglanti.Close();
                }
            }
        }

        private void ButtonKitaplarTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dateTimePickerKitaplarBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerKitaplarBitirmeTarihi.MinDate = dateTimePickerKitaplarBaslamaTarihi.Value;
        }
    }
}
