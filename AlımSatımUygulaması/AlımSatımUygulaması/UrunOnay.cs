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
    public partial class UrunOnay : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection baglanti;
        public UrunOnay()
        {
            InitializeComponent();
        }
        void urunGridDoldur()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Uruns Where OnayDurumu='" + false + "'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Uruns");
            dataGridView1.DataSource = ds.Tables["Uruns"];
            baglanti.Close();
        }
        private void urunOnaybtn_Click(object sender, EventArgs e)
        {
            Product prdcttt = new Product();
            prdcttt.urunOnay(Convert.ToInt32(urunID.Text));
            MessageBox.Show("Urun basariyla onaylandı");
            urunGridDoldur();
        }

        private void UrunOnay_Load(object sender, EventArgs e)
        {
            urunGridDoldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            urunID.Text = dataGridView1.Rows[e.RowIndex].Cells["urunId"].FormattedValue.ToString();

        }

        private void urunOnayBackBtn_Click(object sender, EventArgs e)
        {
            BilgiGiris bilgiGiris = new BilgiGiris();
            bilgiGiris.Show();
            this.Hide();
        }
    }
}
