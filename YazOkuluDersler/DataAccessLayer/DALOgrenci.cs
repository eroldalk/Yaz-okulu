using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;


namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut = new SqlCommand("insert into Tblogrenci (OgrNumara,OgrAd,OgrSoyad,OgrMail,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", parametre.NUMARA);
            komut.Parameters.AddWithValue("@p2", parametre.AD);
            komut.Parameters.AddWithValue("@p3", parametre.SOYAD);
            komut.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut.Parameters.AddWithValue("@p5", parametre.SIFRE);
          
            return komut.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListele()
        {

            List<EntityOgrenci> deger = new List<EntityOgrenci>();
            SqlCommand komut1 = new SqlCommand("select * from TBLOGRENCİ", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader oku = komut1.ExecuteReader();
            while (oku.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(oku["OGRID"]);
                ent.AD = oku["OGRAD"].ToString();
                ent.SOYAD = oku["OGRSOYAD"].ToString();
                ent.NUMARA = oku["OGRNUMARA"].ToString();
                ent.FOTOGRAF = oku["OGRFOTO"].ToString();
                ent.SIFRE = oku["OGRSİFRE"].ToString();
                ent.BAKİYE = Convert.ToDouble(oku["OGRBAKİYE"].ToString());
                deger.Add(ent);
            }
            oku.Close();
            return deger;
        }
        public static bool OgrenciSil(EntityOgrenci parametre)
        {
            SqlCommand komut2 = new SqlCommand("Delete from TBLOGRENCİ Where OGRID=@P1", Baglanti.bgl);
            
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", parametre);
            return komut2.ExecuteNonQuery() > 0;

        }
        public static List<EntityOgrenci> Ogrencidetay(int id)  
        {

            List<EntityOgrenci> degerler = new List<EntityOgrenci>();

            SqlCommand komut3 = new SqlCommand("Select * From TBLOGRENCİ Where OGRID=@P1", Baglanti.bgl);
            komut3.Parameters.AddWithValue("@p1",id);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.AD = dr["OGRAD"].ToString();
                ent.SOYAD = dr["OGRSOYAD"].ToString();
                ent.NUMARA = dr["OGRNUMARA"].ToString();
                ent.FOTOGRAF  = dr["OGRFOTO"].ToString();
                ent.SIFRE  = dr["OGRSIFRE"].ToString();
                ent.BAKİYE = Convert.ToDouble(dr["OGRBAKİYE"].ToString());
                degerler.Add(ent);
              

            }
            dr.Close();
            return degerler;
        }
        public static List<EntityOgrenci> OgrenciGuncelle(int deger)
        {
            SqlCommand komut4 = new SqlCommand("Update TBLOGRENCİLER set OGRAD=@P1,OGRSOYAD=@P2,OGRNUMARA=@P3,OGRFOTO=@P4,OGRSIFRE=@P5 Where OGRID=@P6", Baglanti.bgl);
            
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }

            komut4.Parameters.AddWithValue("@P1", deger.AD);
            komut4.Parameters.AddWithValue("@P2", deger.SOYAD);
            komut4.Parameters.AddWithValue("@P3", deger.NUMARA);
            komut4.Parameters.AddWithValue("@P4", deger.FOTOGRAF);
            komut4.Parameters.AddWithValue("@P5", deger.SIFRE);
            komut4.Parameters.AddWithValue("@P6", deger.ID);

            return komut4.ExecuteNonQuery() > 0;

            
            
        }
    }
}
