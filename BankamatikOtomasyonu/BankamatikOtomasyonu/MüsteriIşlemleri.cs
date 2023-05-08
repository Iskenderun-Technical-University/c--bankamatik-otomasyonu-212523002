using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikOtomasyonu
{
    public partial class MüsteriIşlemleri : Form
    {
        public MüsteriIşlemleri()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 frm= new Form1();
            frm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MüsteriIşlemleri_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = Form1.adSoyad;
            lblHesapNo.Text = Form1.mID.ToString();
        }
    }
}
