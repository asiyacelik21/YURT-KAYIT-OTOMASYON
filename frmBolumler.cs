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
    public partial class frmBolumler: Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void frmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
             
                SqlCommand komut1 = new SqlCommand("insert into Bolumler(BolumAd) values (@p1)", bgl.Baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.Baglanti(). Close();
                MessageBox.Show("Bölüm eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("hata oluştu yeniden deneyin");
            }
        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@p1",bgl. Baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumId.Text);
                komut2.ExecuteNonQuery();
               bgl. Baglanti().Close();
                MessageBox.Show("Silme işlemi gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("hata,işlem gerçekleşmedi");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumId.Text = id;
            txtBolumAd.Text = bolumad;
        }

        private void pcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut2 = new SqlCommand("update Bolumler set BolumAd=@p1 where Bolumid=@p2",bgl. Baglanti());
                komut2.Parameters.AddWithValue("@p2", txtBolumId.Text);
                komut2.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Güncelleme gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
