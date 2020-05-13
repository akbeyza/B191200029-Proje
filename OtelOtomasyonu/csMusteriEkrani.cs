using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OtelOtomasyonu
{
    class csMusteriEkrani
    {
        DataBase db = new DataBase();
        public string guncelleDurum { get; set; }
        public string silDurum { get; set; }

        public DataTable tablola()
            
        {
            if(db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand veriAl = new SqlCommand("select * from musteriler", db.baglanti);   //müsteriler tablosundaki bütün veriler alınıyor.
                SqlDataAdapter adapter = new SqlDataAdapter(veriAl);              //verileri adaptör içerisinde sakladık
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);              //adaptörü tablo içerisine doldur
                return tablo;                     //geriye tabloyu döndür
                
            }
            catch { return null; }    //geriye boş veri döndürüyoruz
            finally
            {
                db.baglanti.Close();
            }
        }
        public void musteriGuncelle(int id, string adi, string soyadi, string cinsiyet, string telefonNo, string mail, string tcNo, string odaAdi, string ucret, DateTime giris, DateTime cikis)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update musteriler set adi=@adi, soyadi=@soyadi, cinsiyet=@cinsiyet, telefon=@telefon, mail=@mail, tcNo=@tc, odaNo=@oda, ucret=@ucret, girisTarihi=@tarih1, cikisTarihi=@tarih2 where id=@id", db.baglanti);
                guncelle.Parameters.AddWithValue("adi", adi);
                guncelle.Parameters.AddWithValue("soyadi", soyadi);
                guncelle.Parameters.AddWithValue("cinsiyet", cinsiyet);
                guncelle.Parameters.AddWithValue("telefon", telefonNo);
                guncelle.Parameters.AddWithValue("mail", mail);
                guncelle.Parameters.AddWithValue("tc", tcNo);
                guncelle.Parameters.AddWithValue("oda", odaAdi);
                guncelle.Parameters.AddWithValue("ucret", ucret);
                guncelle.Parameters.AddWithValue("tarih1", giris);
                guncelle.Parameters.AddWithValue("tarih2", cikis);
                guncelle.Parameters.AddWithValue("id", id);
                guncelle.ExecuteNonQuery();     //nesnenin içerisindeki sql cümlesini sqlserver da işle
                guncelleDurum = adi + "" + soyadi + "isimli kişinin bilgileri güncellenmiştir.";
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void musteriSil(int id)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand sil = new SqlCommand("delete musteriler where id=@id", db.baglanti);    //id'si, @id parametresinden gelen kişiyi yok et.
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();
                silDurum = "Silme işlemi başarılı!";
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable musteriAra(string adi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand arama = new SqlCommand("select * from musteriler where adi LIKE '%' + @adi + '%' ", db.baglanti);    //like=içerisinde
                arama.Parameters.AddWithValue("@adi", adi);
                SqlDataAdapter adaptor = new SqlDataAdapter(arama);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);           //adaptörün içerisini tabloya doldur.
                return tablo;

                
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
