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

    public partial class Giris : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader reader;
        
        public Giris()
        {
            InitializeComponent();
        }
        
        private void kayit_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand("Select * From Users Where kullaniciAdi='"+ txtKulAdi.Text + "'", baglanti);
            
            reader = komut.ExecuteReader();
            if(reader.Read())
            {
                MessageBox.Show("Kullanici Adi daha önceden alınmış");
            }
            else
            {
                User userr = new User();
                userr.kayıtOl(txtKulAdi.Text, txtSifre.Text, txtAd.Text, txtSoyad.Text, Convert.ToInt64(txtTel.Text), Convert.ToInt64(txtTc.Text), txtMail.Text, txtAdres.Text);
                MessageBox.Show("Kayıt başarıyla oluşturuldu");
            }
            baglanti.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM Users WHERE kullaniciAdi='" + txtGirisKul.Text + "'AND sifre='"+txtSifrekul.Text+"'", baglanti);

            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                Singleton.Instance.user.kullaniciAdi = reader["kullaniciAdi"].ToString();
                Singleton.Instance.user.sifre = reader["sifre"].ToString();
                Singleton.Instance.user.ad = reader["ad"].ToString();
                Singleton.Instance.user.soyad = reader["soyad"].ToString();
                Singleton.Instance.user.tcKimlikNo = Convert.ToInt64(reader["tcKimlikNo"].ToString());
                Singleton.Instance.user.telefon = Convert.ToInt64(reader["telefon"].ToString());
                Singleton.Instance.user.email = reader["email"].ToString();
                Singleton.Instance.user.adres = reader["adres"].ToString();
                Singleton.Instance.user.bakiye = Convert.ToInt32(reader["bakiye"].ToString());
                Singleton.Instance.user.adminMi = Convert.ToBoolean(reader["adminMi"].ToString());
                BilgiGiris blgGrs = new BilgiGiris();
                blgGrs.Show();
                this.Hide();
            }
            else MessageBox.Show("Hatalı Giris Lutfen Kullanıcı Adı ve Sifrenizi Kontrol Ediniz");
        }

        private void txtGirisKul_Click(object sender, EventArgs e)
        {
            txtGirisKul.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtSifrekul_Click(object sender, EventArgs e)
        {
            txtSifrekul.Clear();
        }

        private void txtKulAdi_Click(object sender, EventArgs e)
        {
            txtKulAdi.Clear();
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Clear(); 
        }

        private void txtAd_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
        }

        private void txtSoyad_Click(object sender, EventArgs e)
        {
            txtSoyad.Clear();
        }

        private void txtTc_Click(object sender, EventArgs e)
        {
            txtTc.Clear();
        }

        private void txtTel_Click(object sender, EventArgs e)
        {
            txtTel.Clear();
        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            txtMail.Clear();
        }

        private void txtAdres_Click(object sender, EventArgs e)
        {
            txtAdres.Clear();
        }
    }
}
