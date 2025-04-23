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
using DevExpress.ClipboardSource.SpreadsheetML;

namespace YurtKayitSistemi
{
    public partial class frmOgrKayit: Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void frmOgrKayit_Load(object sender, EventArgs e)
        {
            // Bölümleri listeleme komutları
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler",bgl. Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.Baglanti().Close();

            //Boş odaları listeleme komutları

            
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite !=OdaAktif", bgl.Baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.Baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komutKaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres)Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.Baglanti());
                komutKaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutKaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p3", mskTc.Text);
                komutKaydet.Parameters.AddWithValue("@p4", mskOgrTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p5", mskDogumTarhi.Text);
                komutKaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
                komutKaydet.Parameters.AddWithValue("@p7", txtMail.Text);
                komutKaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutKaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
                komutKaydet.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Girildi");

                //Öğrenci id yi labele Çekme
                SqlCommand komut = new SqlCommand("select OgrID from Ogrenci", bgl.Baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())

                {
                    labelControl2.Text = oku[0].ToString();
                }
                bgl.Baglanti().Close();


                //Öğrenci borç alanı oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar(OgrID,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.Baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", labelControl2.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.Baglanti().Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Hata!! Lütfen yeniden deneyin");
            }

            // Öğrenci oda kontenjanı artırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.Baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }
    }
}

