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

namespace YurtKayitSistemi
{
    public partial class frmAdminGiris: Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *fromwhere YoneticiAd=@p1 and YoneticiSifre=@p2", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) 
            {
                frmAnaForm fr = new frmAnaForm();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı yada şifre");
                txtKullaniciAd.Clear();
                txtSifre.Clear();
                txtKullaniciAd.Focus();
            }
            bgl.Baglanti().Close();
        }
    }
}
