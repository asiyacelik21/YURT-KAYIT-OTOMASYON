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
    public partial class frmGiderGuncelle: Form
    {
        public frmGiderGuncelle()
        {
            InitializeComponent();
        }

        public string elektrik, su, dogalgaz, gida, diger, internet, personel, id;

        SqlBaglantim bgl = new SqlBaglantim();

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,İnternet=@p4,Gida=@p5,Personel=@p6,Diger=@p7 where Giderİd=@p8", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p8", txtGiderİd.Text);
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", txtInternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGida.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Güncelleme yapıldı");

            }
            catch(Exception)
            {
                MessageBox.Show("hata oluştu yeniden deneyin");
            }
        }

        private void frmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtGiderİd.Text = id;
            txtElektrik.Text = elektrik;
            txtGida.Text = gida;
            txtSu.Text = su;
            txtPersonel.Text = personel;
            txtInternet.Text = internet;
            txtDogalGaz.Text = dogalgaz;
            txtDiger.Text = diger;
        }
    }
}
