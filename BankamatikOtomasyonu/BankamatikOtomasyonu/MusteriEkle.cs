using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BankamatikOtomasyonu
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = BankamatikOtomasyonu; integrated security = sspi ");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" insert into musteriler( tcNo , adSoyad , adres ,telefon , sifre, bakiye, durum ) values( @p1,@p2,@p3,@p4,@p5,@p6,@p7 ) ", con);
            komut.Parameters.AddWithValue("@p1", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtAdres.Text);
            komut.Parameters.AddWithValue("@p4", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtTcNo.Text);
            komut.Parameters.AddWithValue("@p6", txtBakiye.Text);
            komut.Parameters.AddWithValue("@p7", 1);

            if(txtTcNo.Text == "" || txtAdSoyad.Text == "" || txtAdres.Text == "" || txtTelefon.Text == "" || txtBakiye.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Giriniz.", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                int sonuc = komut.ExecuteNonQuery();
                con.Close();
                if (sonuc == 1)
                {
                    MessageBox.Show("Müşteri Kaydı Tamamlandı.", "Müşteri kaydı");
                }
                else
                {
                    MessageBox.Show("Müşteri Kaydı Yapılamadı", "Müşteri Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            

            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTelefon.Text = "";
            txtBakiye.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
