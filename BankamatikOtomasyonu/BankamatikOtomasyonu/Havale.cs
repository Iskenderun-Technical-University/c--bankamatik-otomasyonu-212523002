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
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = BankamatikOtomasyonu; integrated security = sspi ");

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi = float.Parse(TxtMiktar.Text);

            if (sayi > Form1.mBakiye)
            {
                MessageBox.Show("Yetersiz Bakiye !", "Havale İşlemi");
            }
            else
            {
                SqlCommand komut = new SqlCommand("update musteriler set bakiye= bakiye  -  @p1 where ID= @p2 ", con);
                komut.Parameters.AddWithValue("@p1", sayi);
                komut.Parameters.AddWithValue("@p2", Form1.mID);

                SqlCommand komut2 = new SqlCommand("update musteriler set bakiye= bakiye  +  @p3 where ID= @p4 ", con);
                komut2.Parameters.AddWithValue("@p3", TxtMiktar.Text);
                komut2.Parameters.AddWithValue("@p4", TxtNo.Text);

                if (sayi < 0)
                {
                    MessageBox.Show("Lütfen geçerli miktar giriniz !", "Eksik Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    con.Open();

                    int sonuc1 = komut2.ExecuteNonQuery();
                    con.Close();
                    if (sonuc1 == 1)
                    {
                        con.Open();

                        komut.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Havale/EFT İşlemi Gerçekleştirildi", "Havale/EFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1.mBakiye -= sayi;
                        HareketKaydet.kaydet(Form1.mID, (sayi + "TL Havale/EFT Gönderildi "));
                        HareketKaydet.kaydet(int.Parse(TxtNo.Text), (sayi + "TL Havale/EFT Alındı "));


                    }
                    else
                    {
                        MessageBox.Show("Alıcı Hesap No Yanlış !", "Havale/EFT Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
                TxtMiktar.Text = "";
                TxtNo.Text= "";

      
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Havale_Load(object sender, EventArgs e)
        {

        }
    }
}
