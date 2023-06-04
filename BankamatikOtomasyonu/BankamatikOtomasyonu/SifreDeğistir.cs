using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankamatikOtomasyonu
{
    public partial class SifreDeğistir : Form
    {
        public SifreDeğistir()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = BankamatikOtomasyonu; integrated security = sspi ");

        private void SifreDeğistir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtEski.Text=="" || txtYeni.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Giriniz !", "Şifre Değiştirme İşlemi");
            }
            else if (txtYeni.Text.Length<5)
            {
                MessageBox.Show("Lütfen en az 5 karakter uzunluğunda şifre giriniz.", "Şifre Değiştirme İşlemi");

            }
            else
            {
                SqlCommand komut = new SqlCommand(" update musteriler set sifre = @p1 where sifre = @p2 ", con);
                komut.Parameters.AddWithValue("@p1", txtYeni.Text);
                komut.Parameters.AddWithValue("@p2", txtEski.Text);


                con.Open();

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    MessageBox.Show("Şifre Değiştirme İşlemi Yapıldı.", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Şifre Değiştirme İşlemi Başarısız!", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                con.Close();
                txtEski.Text = "";
                txtYeni.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
