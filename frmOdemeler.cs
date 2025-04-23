using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class frmOdemeler: Form
    {
        public frmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        int Secilen;
        private void frmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet2.Borclar' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Secilen;
            string id, ad, soyad, kalan;
            Secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
            ad= dataGridView1.Rows[Secilen].Cells[1].Value.ToString();
            soyad= dataGridView1.Rows[Secilen].Cells[2].Value.ToString();
            kalan= dataGridView1.Rows[Secilen].Cells[3].Value.ToString();

            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalanBorc.Text = kalan;
            txtOgrID.Text = id;
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //Ödenen Tutarı Kalan Borçtan Düşme 

            int Odenen, kalan, yeniborc;
            Odenen = Convert.ToInt16(txtOdenen.Text);
            kalan = Convert.ToInt16(txtKalanBorc.Text);
            yeniborc = kalan-Odenen;
            txtKalanBorc.Text = yeniborc.ToString();

            //Yeni Tutarı Veri Tabanına Kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrID=@p2", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrID.Text);
            komut.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

            // Kasa tablosuna ekleme yapma 

            SqlCommand komut2 = new SqlCommand("insert into Kasa(OdemeAy,OdemeMiktar)values (@k1,@k2)", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.Baglanti().Close();

        }
    }
}
