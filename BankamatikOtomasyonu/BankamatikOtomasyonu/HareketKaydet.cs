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
    internal class HareketKaydet
    {
        public static void kaydet(int mID,string msj)
        {
            SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = BankamatikOtomasyonu; integrated security = sspi ");
            SqlCommand komut = new SqlCommand("insert into hareketler (musteriID,islem,tarih) values (@p1,@p2,@p3) ",con);
            komut.Parameters.AddWithValue("@p1",mID);
            komut.Parameters.AddWithValue("@p2", msj);
            komut.Parameters.AddWithValue("@p3", DateTime.Now);

            con.Open();
            komut.ExecuteNonQuery();
            con.Close();    


        }
    }
}
