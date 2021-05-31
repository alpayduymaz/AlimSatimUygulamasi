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
    public partial class ParaOnay : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection baglanti;
        public ParaOnay()
        {
            InitializeComponent();
        }
        void gridBekleyenParaDoldur()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Users Where eklenecekMiktar>0", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Users");
            dataGridView1.DataSource = ds.Tables["Users"];
            baglanti.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            kullaniciLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["kullaniciAdi"].FormattedValue.ToString();
            eklenecekBakiye_label.Text = dataGridView1.Rows[e.RowIndex].Cells["eklenecekMiktar"].FormattedValue.ToString();

        }

        private void ParaOnay_Load(object sender, EventArgs e)
        {
            gridBekleyenParaDoldur();
        }

        private void paraonayBtn_Click(object sender, EventArgs e)
        {
            User ussr = new User();
            ussr.paraOnay(kullaniciLabel.Text, Convert.ToInt32(eklenecekBakiye_label.Text));
            gridBekleyenParaDoldur();
        }

        private void paraOnayBackBtn_Click(object sender, EventArgs e)
        {
            BilgiGiris blgg = new BilgiGiris();
            blgg.Show();
            this.Hide();
        }
    }
}
