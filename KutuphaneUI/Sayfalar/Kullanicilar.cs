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
    public partial class Kullanicilar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");
        SqlDataAdapter da;

        public Kullanicilar()
        {
            InitializeComponent();
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=KutuphaneDatabase;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT KullaniciID,YetkiID,KullaniciAdi,Ad,Soyad,Email,SonGorulme,KayitTarihi FROM kullanici", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewKullanicilar.DataSource = tablo;
            baglanti.Close();
        }

        private void Doldur()
        {
            numericUpDownYetki.Value = Convert.ToInt32(dataGridViewKullanicilar.SelectedRows[0].Cells[1].Value);
            textBoxKullaniciAdi.Text = dataGridViewKullanicilar.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridViewKullanicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Doldur();
        }

        private void ButtonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = "";
            numericUpDownYetki.Value = 1;
        }

        private void ButtonKullaniciAdiDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "UPDATE kullanici SET KullaniciAdi=@KullaniciAdi FROM kullanici WHERE KullaniciID=@KullaniciID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", textBoxKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@KullaniciID", dataGridViewKullanicilar.SelectedCells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme Başarılı","Güncelleme İşlemi");
                ButtonTemizle.PerformClick();
                Listele();
            }
            catch (Exception hatamsj)
            {
                baglanti.Close();
                MessageBox.Show(hatamsj.Message, "Güncelleme Hatası");
            }
        }

        private void ButtonYetkiDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "UPDATE kullanici SET YetkiID=@YetkiID FROM kullanici WHERE KullaniciID=@KullaniciID";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@YetkiID", numericUpDownYetki.Value);
                komut.Parameters.AddWithValue("@KullaniciID", dataGridViewKullanicilar.SelectedCells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme Başarılı", "Güncelleme İşlemi");
                ButtonTemizle.PerformClick();
                Listele();
            }
            catch (Exception hatamsj)
            {
                baglanti.Close();
                MessageBox.Show(hatamsj.Message, "Güncelleme Hatası");
            }
        }

        private void ButtonKullaniciSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silenecek, devam etmek istiyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "DELETE FROM kullanici WHERE KullaniciID=@KullaniciID";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@KullaniciID", dataGridViewKullanicilar.SelectedCells[0].Value);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı veri tabanından silindi.", "Silme İşlemi");
                    Listele();
                }
                catch (Exception hataMesaji)
                {
                    MessageBox.Show(hataMesaji.Message, "Silme Hatası");
                    baglanti.Close();
                }
            }
        }
    }
}
