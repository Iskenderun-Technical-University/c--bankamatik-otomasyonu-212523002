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
    public partial class SifreUret : Form
    {
        public SifreUret()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = BankamatikOtomasyonu; integrated security = sspi ");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTel.Text == "" || txtTC.Text=="" || txtYeni.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Giriniz !", "Şifre Üretme İşlemi");
            }
            else if (txtYeni.Text.Length < 5)
            {
                MessageBox.Show("Lütfen en az 5 karakter uzunluğunda şifre giriniz.", "Şifre Üretme İşlemi");

            }
            else
            {
                SqlCommand komut = new SqlCommand(" update musteriler set sifre = @p1 where tcNo = @p2 and telefon = @p3", con);
                komut.Parameters.AddWithValue("@p1", txtYeni.Text);
                komut.Parameters.AddWithValue("@p2", txtTC.Text);
                komut.Parameters.AddWithValue("@p3", txtTel.Text);


                con.Open();

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    MessageBox.Show("Şifre Üretme İşlemi Yapıldı.", "Şifre Üretme İşlemi", MessageBoxButtons.OK);
                    //HareketKaydet.kaydet(Form1.mID, "Şifre Üretildi ");

                }
                else
                {
                    MessageBox.Show("Şifre Üretme İşlemi Başarısız!", "Şifre Üretme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                con.Close();
                txtTC.Text = "";
                txtTel.Text = "";
                txtYeni.Text = "";
            }
        }

        private void SifreUret_Load(object sender, EventArgs e)
        {

        }
    }
}
