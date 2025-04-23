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
    public partial class frmPersonel: Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl=new SqlBaglantim();
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into PersonelAdSoyad,PersonelDepartman)values (@p1,@p2)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p1", txtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt eklendi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelİd.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where PersonelID=@p3", bgl.Baglanti());
            komutgun.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komutgun.Parameters.AddWithValue("@p1", txtPersonelGorev.Text);
            komutgun.Parameters.AddWithValue("@p1", txtPersonelİd.Text);
            komutgun.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet6.Personel);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev= dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtPersonelAd.Text = ad;
            txtPersonelGorev.Text = gorev;
            txtPersonelİd.Text = id;
        }
    }
}
