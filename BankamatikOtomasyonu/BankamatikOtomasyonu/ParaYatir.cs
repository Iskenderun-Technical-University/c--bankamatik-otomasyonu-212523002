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
    public partial class ParaYatir : Form
    {
        public ParaYatir()
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
            float sayi = float.Parse(maskedTextBox1.Text);

            if (int.Parse( maskedTextBox1.Text) <= 0)
            {
                MessageBox.Show("Lütfen geçerli miktar giriniz !", "Para Yatırma İşlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand(" update musteriler set bakiye += @p1 where ID = @p2 ", con);
                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.mID);


                con.Open();

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc == 1)
                {
                    MessageBox.Show("Para Yatırma İşlemi Yapıldı.", "Para Yatırma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form1.mBakiye += sayi;
                    HareketKaydet.kaydet(Form1.mID, (sayi + "TL Para Yatırıldı "));

                }
                else
                {
                    MessageBox.Show("Para Yatırma İşlemi Başarısız!", "Para Yatırma İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                maskedTextBox1.Text = "";

                con.Close();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
