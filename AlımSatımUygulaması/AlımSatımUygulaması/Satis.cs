using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AlımSatımUygulaması
{
    public class Satis
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader reader;

        public int satisId { get; set; }
        public int urunId { get; set; }
        public string saticiKullanici { get; set; }
        public string aliciKullanici { get; set; }
        public string urunAdi { get; set; }
        public int satisMiktari { get; set; }
        public int birimFiyati { get; set; }
        public DateTime satisTarihi { get; set; }
        public bool satisDurumu { get; set; }
        public void satisIstekOlustur(int urunıd,string saticikullanici, string alicikullanici,string urunadi, int satismiktari, int birimfiyati, DateTime satistarihi,bool satisdurumu)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");

            string sorgu = "INSERT INTO Satis(urunId,saticiKullanici,aliciKullanici,urunAdi,satisMiktari,birimFiyati,satisTarihi,satisDurumu) VALUES (@urunId,@saticiKullanici,@aliciKullanici,@urunAdi,@satisMiktari,@birimFiyati,@satisTarihi,@satisDurumu)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@urunId", urunıd);
            komut.Parameters.AddWithValue("@saticiKullanici", saticikullanici);
            komut.Parameters.AddWithValue("@aliciKullanici", alicikullanici);
            komut.Parameters.AddWithValue("@urunAdi", urunadi);
            komut.Parameters.AddWithValue("@satisMiktari", satismiktari);
            komut.Parameters.AddWithValue("@birimFiyati", birimfiyati);
            komut.Parameters.AddWithValue("@satisTarihi", satistarihi);
            komut.Parameters.AddWithValue("@satisDurumu", satisdurumu);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void satisOnay(int satisıd)
        {

            baglanti = new SqlConnection("Data Source=DESKTOP-H0M8STK\\MSSQL;Initial Catalog=YazilimYapimiDatabase;Integrated Security=True");
            komut = new SqlCommand("Select *From Satis Where satısId='" + satisıd + "'", baglanti);
            baglanti.Open();
            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                komut.Dispose();
                komut = new SqlCommand("Update Satis set satisDurumu='" + true + "' where satısId='" + satisıd + "'", baglanti);
                reader.Close();
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
        }
    }
}
