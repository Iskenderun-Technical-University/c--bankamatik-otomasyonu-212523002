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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
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
                    txtDurum.Text = dr["durum"].ToString();

                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(" update musteriler set adSoyad=@p3 ,adres=@p4 ,telefon=@p5 ,durum = @p6 where ID = @p1 or tcNo = @p2 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            komut.Parameters.AddWithValue("@p2", txtAra.Text);
            komut.Parameters.AddWithValue("@p3", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtAdres.Text);
            komut.Parameters.AddWithValue("@p5", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtDurum.Text);

            con.Open();

            int sonuc= komut.ExecuteNonQuery();

            if (sonuc==1)
            {
                MessageBox.Show("Güncelleme Yapıldı.", "Müşteri Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Güncelleme Yapılamadı !", "Müşteri Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            txtID.Text = "";
            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTelefon.Text = "";
            txtBakiye.Text = "";

            con.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBakiye_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
