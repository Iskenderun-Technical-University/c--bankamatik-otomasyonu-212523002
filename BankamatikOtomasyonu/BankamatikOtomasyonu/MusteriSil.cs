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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = BankamatikOtomasyonu; integrated security = sspi ");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" select * from musteriler where ID = @p1 or tcNo = @p2 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);
            con.Open();



            if (txtAra.Text == "")
            {
                MessageBox.Show("Lütfen TcNo/ID Giriniz.", "Müşteri Arama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTelefon.Text = "";
                txtBakiye.Text = "";
            }
            else
            {
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtTcNo.Text = dr["tcNo"].ToString();
                    txtAdSoyad.Text = dr["adSoyad"].ToString();
                    txtAdres.Text = dr["adres"].ToString();
                    txtTelefon.Text = dr["telefon"].ToString();
                    txtBakiye.Text = dr["bakiye"].ToString();
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete musteriler where ID = @p1 or tcNo = @p2 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);

            
            DialogResult dr = MessageBox.Show("Müşteri Kaydını Silmek İstediğinize Emin Misiniz?", "Müşteri Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr== DialogResult.No)
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Müşteri Silme İptali", MessageBoxButtons.OK);

            }
            else
            {
                con.Open();
                int sonuc = komut.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    MessageBox.Show("Silme İşlemi Yapıldı.", "Müşteri Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Silme İşlemi Yapılamadı !", "Müşteri Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                con.Close();

                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTelefon.Text = "";
                txtBakiye.Text = "";
            }

           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
