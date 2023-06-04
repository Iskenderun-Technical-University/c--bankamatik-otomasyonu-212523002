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
    public partial class HesapHaraketleri : Form
    {
        public HesapHaraketleri()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = BankamatikOtomasyonu; integrated security = sspi ");

        private void HesapHaraketleri_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from hareketler where musteriID = @p1",con);
            komut.Parameters.AddWithValue("@p1",Form1.mID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource= tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
