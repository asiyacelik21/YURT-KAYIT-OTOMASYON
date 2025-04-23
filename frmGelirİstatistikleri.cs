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
using DevExpress.XtraBars;


namespace YurtKayitSistemi
{
    public partial class frmGelirİstatistikleri: Form
    {
        public frmGelirİstatistikleri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void frmGelirİstatistikleri_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar

            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar)from Kasa ", bgl.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                lblPara.Text = oku[0].ToString() + "TL";
            }
            bgl.Baglanti().Close();

            // Tekrarsız olarak ayları listeleme
            SqlCommand komut2 = new SqlCommand("select distinct(OdemeAy) from Kasa ", bgl.Baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0].ToString());
            }
            bgl.Baglanti().Close();


            // grafikere veri tabanından veri çekme 
            SqlCommand komut3 = new SqlCommand("select OdemeAy,sum(odememiktar) from Kasa group by OdemeAy", bgl.Baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read()) ;
            {
                this .chart1.Series["Aylık"].Points.AddXY(oku3[0],oku3[1]);
            }
            bgl.Baglanti().Close();
        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar)from Kasa where OdemeAy=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblSecilenAy.Text = oku[0].ToString();
            }
            bgl.Baglanti().Close();
        }
    }
}
