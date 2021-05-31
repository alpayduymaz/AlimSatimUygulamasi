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
    public partial class BilgiGiris : Form
    {

        SqlDataAdapter da;
        DataSet ds;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader reader;

        public BilgiGiris()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Uruns Where kullaniciAdi!='" + Singleton.Instance.user.kullaniciAdi + "' AND OnayDurumu='"+true+"'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Uruns");
            dataGridView1.DataSource = ds.Tables["Uruns"];
            baglanti.Close();
        }
        private void BilgiGiris_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand("Select * From Users Where kullaniciAdi='" + Singleton.Instance.user.kullaniciAdi + "'", baglanti);

            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                bakiye_Label.Text = reader["bakiye"].ToString();
            }
            baglanti.Close();
            if (Singleton.Instance.user.adminMi == false)
            {
                Button button, btn, btnn;
                button = paraOnayGorntBtn;
                btn = satisOnayGorntBtn;
                btnn = UrunOnayGrntBtn;
                button.Visible = false;
                btn.Visible = false;
                btnn.Visible = false;
            }

            griddoldur();

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

            Product product = new Product();
            product.urunEkle(Singleton.Instance.user.kullaniciAdi, txtUrunAd.Text, Convert.ToInt32(txtMiktar.Text), Convert.ToDecimal(txtBirimFiyat.Text));
            MessageBox.Show("Ürün satis istegi oluşturuldu");
            griddoldur();
        }

        private void btnParaEkle_Click(object sender, EventArgs e)
        {

            User usrr = new User();
            if (Singleton.Instance.user.adminMi == false)
            {
                usrr.paraEkle(Convert.ToInt32(txtPara.Text));
                MessageBox.Show(txtPara.Text + "tl ekleme isteğiniz gönderilmiştir\nIstek onaylandığında hesabınıza eklenecektir.");
            }
            else
            {
                usrr.adminHesabinaParaEkle(Convert.ToInt32(txtPara.Text));
                MessageBox.Show("Hesabınıza " + txtPara.Text + "tl eklendi.");
                bakiye_Label.Text = (Convert.ToInt32(bakiye_Label.Text) + Convert.ToInt32(txtPara.Text)).ToString();
            }
            // bakiye_Label.Text = para.ToString();
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (Singleton.Instance.user.adminMi == true)
            {
                User u = new User();
                Product p = new Product();
                Satis s = new Satis();
                if (Singleton.Instance.user.bakiye >= Convert.ToInt32(birimFiyatLabel.Text) * Convert.ToInt32(miktarLabel.Text) && Convert.ToInt32(stoktakiMiktar.Text) >= Convert.ToInt32(miktarLabel.Text))
                {

                    p.urunGuncelle(Convert.ToInt32(SatisurunIdLabel.Text), Convert.ToInt32(miktarLabel.Text));
                    p.urunKontrol(Convert.ToInt32(SatisurunIdLabel.Text));
                    u.satisUcretiAl(Singleton.Instance.user.kullaniciAdi, Convert.ToInt32(birimFiyatLabel.Text) * Convert.ToInt32(miktarLabel.Text));
                    u.satisUcretiVer(saticiKullaniciAdi.Text, Convert.ToInt32(birimFiyatLabel.Text) * Convert.ToInt32(miktarLabel.Text));
                    s.satisIstekOlustur(Convert.ToInt32(SatisurunIdLabel.Text), saticiKullaniciAdi.Text, Singleton.Instance.user.kullaniciAdi, urunAdiLabel.Text, Convert.ToInt32(miktarLabel.Text), Convert.ToInt32(birimFiyatLabel.Text), DateTime.Now, true);
                    bakiye_Label.Text = (Convert.ToInt32(bakiye_Label.Text) - (Convert.ToInt32(birimFiyatLabel.Text) * Convert.ToInt32(miktarLabel.Text))).ToString();
                    MessageBox.Show("Satın Alma Isleminiz Basariyla Gerceklesmistir");
                }              
                else MessageBox.Show("Bakiye Yetersiz veya Satistan Cok Alim Yapmaya Calistiniz");
            }
            else
            {
                if (Singleton.Instance.user.bakiye >= Convert.ToInt32(birimFiyatLabel.Text) * Convert.ToInt32(miktarLabel.Text) && Convert.ToInt32(stoktakiMiktar.Text) >= Convert.ToInt32(miktarLabel.Text))
                {

                    Satis st = new Satis();
                    Product pp = new Product();
                    st.satisIstekOlustur(Convert.ToInt32(SatisurunIdLabel.Text), saticiKullaniciAdi.Text, Singleton.Instance.user.kullaniciAdi, urunAdiLabel.Text, Convert.ToInt32(miktarLabel.Text), Convert.ToInt32(birimFiyatLabel.Text), DateTime.Now,false);
                    pp.urunAl(Convert.ToInt32(SatisurunIdLabel.Text), Convert.ToInt32(miktarLabel.Text));
                    MessageBox.Show("Satın Alma Isteginiz Basariyla Iletilmistir\nIleti Onaylandiginda Satis Gerceklesecektir");
                }              
                else MessageBox.Show("Bakiye Yetersiz veya Satistan Cok Alim Yapmaya Calistiniz");
            }
            griddoldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            SatisurunIdLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["urunId"].FormattedValue.ToString();
            saticiKullaniciAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["kullaniciAdi"].FormattedValue.ToString();
            urunAdiLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["urunAdi"].FormattedValue.ToString();
            birimFiyatLabel.Text = dataGridView1.Rows[e.RowIndex].Cells["birimFiyat"].FormattedValue.ToString();
            stoktakiMiktar.Text = dataGridView1.Rows[e.RowIndex].Cells["miktar"].FormattedValue.ToString();
        }

        private void paraOnayGorntBtn_Click(object sender, EventArgs e)
        {
            ParaOnay paraOnay = new ParaOnay();
            paraOnay.Show();
            this.Hide();
        }

        private void satisOnayGorntBtn_Click(object sender, EventArgs e)
        {
            SatisOnay satisOnay = new SatisOnay();
            satisOnay.Show();
            this.Hide();
        }

        private void profilBtn_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void btnMiktarArttir_Click(object sender, EventArgs e)
        {
            int mktr = Convert.ToInt32(miktarLabel.Text);
            mktr++;
            miktarLabel.Text = mktr.ToString();
        }

        private void btnMiktarAzalt_Click(object sender, EventArgs e)
        {
            int mkTr = Convert.ToInt32(miktarLabel.Text);
            if (mkTr > 1)
            {
                mkTr--;
                miktarLabel.Text = mkTr.ToString();
            }
            else MessageBox.Show("En az 1 adet bir şey alabilirsiniz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris blgg = new Giris();
            blgg.Show();
            this.Hide();
        }

        

        private void UrunOnayGrntBtn_Click(object sender, EventArgs e)
        {
            UrunOnay urunOnay = new UrunOnay();
            urunOnay.Show();
            this.Hide();
        }
    }
}

