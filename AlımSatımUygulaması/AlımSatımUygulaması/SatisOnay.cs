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


namespace AlımSatımUygulaması
{
    public partial class SatisOnay : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection baglanti;
        public SatisOnay()
        {
            InitializeComponent();
        }
        void gridBekleyenSatisDoldur()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Satis Where satisDurumu='" + false + "'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Satis");
            dataGridView1.DataSource = ds.Tables["Satis"];
            baglanti.Close();
        }
        void gerceklesmisSatisDoldur()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Satis Where satisDurumu='" + true + "'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Satis");
            dataGridView2.DataSource = ds.Tables["Satis"];
            baglanti.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            satisID.Text = dataGridView1.Rows[e.RowIndex].Cells["satısId"].FormattedValue.ToString();
            urunId.Text = dataGridView1.Rows[e.RowIndex].Cells["urunId"].FormattedValue.ToString();
            eksilecekMiktarLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["satisMiktari"].FormattedValue.ToString();
            birimFiyatLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["birimFiyati"].FormattedValue.ToString();
            aliciKullaniciLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["aliciKullanici"].FormattedValue.ToString();
            saticiKullaniciAdiLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["saticiKullanici"].FormattedValue.ToString();
        }

        private void SatisOnay_Load(object sender, EventArgs e)
        {
            gridBekleyenSatisDoldur();
            gerceklesmisSatisDoldur();
        }

        private void satisOnaybtn_Click(object sender, EventArgs e)
        {
            User usss = new User();
            usss.satisUcretiAl(aliciKullaniciLabel.Text, Convert.ToInt32(birimFiyatLabel.Text) * Convert.ToInt32(eksilecekMiktarLabel.Text));
            usss.satisUcretiVer(saticiKullaniciAdiLabel.Text, Convert.ToInt32(birimFiyatLabel.Text) * Convert.ToInt32(eksilecekMiktarLabel.Text));
            Product pppp = new Product();
            pppp.urunGuncelle(Convert.ToInt32(urunId.Text), Convert.ToInt32(eksilecekMiktarLabel.Text));
            pppp.urunKontrol(Convert.ToInt32(urunId.Text));
            Satis s = new Satis();
            s.satisOnay(Convert.ToInt32(satisID.Text));
            MessageBox.Show("Satis Islemi Basariyla Gerceklesti");
            gridBekleyenSatisDoldur();
            gerceklesmisSatisDoldur();
        }

        private void satisOnayBackBtn_Click(object sender, EventArgs e)
        {
            BilgiGiris bl = new BilgiGiris();
            bl.Show();
            this.Hide();
        }    
    }
}
