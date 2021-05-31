using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AlımSatımUygulaması
{
    public class Product
    {
        SqlConnection baglanti;
        SqlCommand komut;
        public Product() { }
        public int urunId { get; set; }
        public string kullaniciAdi { get; set; }
        public string urunAdi { get; set; }
        public int miktar { get; set; }
        public decimal birimFiyat { get; set; }
        public void urunEkle(string KullaniciAdi, string  UrunAdi, int miktar, decimal birimFiyat)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            string sorgu = "INSERT INTO Uruns(kullaniciAdi,urunAdi,miktar,birimFiyat,satisbeklemeDurumu,eksilecekMiktar,OnayDurumu) VALUES (@kullaniciAdi,@urunAdi,@miktar,@birimFiyat,@satisbeklemeDurumu,@eksilecekMiktar,@OnayDurumu)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullaniciAdi", KullaniciAdi);
            komut.Parameters.AddWithValue("@urunAdi", UrunAdi);
            komut.Parameters.AddWithValue("@miktar", miktar);
            komut.Parameters.AddWithValue("@birimFiyat", birimFiyat);
            komut.Parameters.AddWithValue("@satisbeklemeDurumu", false);
            komut.Parameters.AddWithValue("@eksilecekMiktar", 0);
            komut.Parameters.AddWithValue("@OnayDurumu", false);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void urunOnay(int urunıd)
        {
            SqlDataReader reader;
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            komut = new SqlCommand("Select * From Uruns Where urunId='" + urunıd + "'", baglanti);
            baglanti.Open();
            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                komut.Dispose();
                komut = new SqlCommand("Update Uruns set OnayDurumu='" + true + "' where urunId='" + urunıd + "'", baglanti);
                reader.Close();
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }
       
        public void urunAl(int urunid, int miktar)
        {
            SqlDataReader reader;
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            komut = new SqlCommand("Select *From Uruns Where urunId='" + urunid + "'", baglanti);
            baglanti.Open();
            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                komut.Dispose();
                komut = new SqlCommand("Update Uruns set satisbeklemeDurumu='" + true + "', eksilecekMiktar='"+miktar+"' where urunId='" + urunid + "'", baglanti);
                reader.Close();
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }
        public void urunKontrol(int urunid)
        {
            SqlDataReader reader;

            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            komut = new SqlCommand("Select *From Uruns Where urunId='" + urunid + "'", baglanti);
            baglanti.Open();
            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                komut.Dispose();
                komut = new SqlCommand("DELETE FROM Uruns WHERE miktar='"+ 0 + "';", baglanti);
                reader.Close();
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }
        public void urunGuncelle(int urunid,int alinanAdet)
        {
            SqlDataReader reader;

            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            komut = new SqlCommand("Select *From Uruns Where urunId='" + urunid + "'", baglanti);
            baglanti.Open();
            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                komut.Dispose();
                komut = new SqlCommand("Update Uruns set miktar=miktar-'" + alinanAdet + "', eksilecekMiktar='"+0+"', satisbeklemeDurumu='"+false+"' where urunId='" + urunid + "'", baglanti);
                reader.Close();
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }
        public void satistanKaldır(int urunid)
        {
            SqlDataReader reader;

            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            komut = new SqlCommand("Select *From Uruns Where urunId='" + urunid + "'", baglanti);
            baglanti.Open();
            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                komut.Dispose();
                komut = new SqlCommand("DELETE FROM Uruns Where urunId='" + urunid + "'", baglanti);
                reader.Close();
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }

    }
}
