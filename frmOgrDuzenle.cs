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
    public partial class frmOgrDuzenle: Form
    {
        public frmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, TC, Telefon, Dogum, Bolum;

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci Silme

            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where OgrID =@k1", bgl.Baglanti());
            komutsil.Parameters.AddWithValue("@k1", txtOgrID.Text);
            komutsil.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt silindi");

            // odanın aktif öğrenci saayısını azaltma 

            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.Baglanti());
            komutoda.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void btnOgrenciDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@12 where OgrID=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrID.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTc.Text);
                komut.Parameters.AddWithValue("@p5", mskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskDogumTarhi.Text);
                komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchAdres.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Hata ! yeniden deneyin");
            }
        }

        public string mail, odano, veliad, velitel, adres;

        SqlBaglantim bgl = new SqlBaglantim();
        private void frmOgrDuzenle_Load(object sender, EventArgs e)
        {
           txtOgrID.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTc.Text = TC;
            mskOgrTelefon.Text = Telefon;
            mskDogumTarhi.Text = Dogum;
            cmbBolum.Text = Bolum;
            txtMail.Text = mail;
            cmbOdaNo.Text = odano;
            txtVeliAdSoyad.Text = veliad;
            mskVeliTelefon.Text = velitel;
            rchAdres.Text = adres;
        }
    }
}
