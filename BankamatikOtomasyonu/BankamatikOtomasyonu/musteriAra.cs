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
    public partial class musteriAra : Form
    {
        public musteriAra()
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
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void musteriAra_Load(object sender, EventArgs e)
        {

        }
    }
}
  
