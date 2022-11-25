using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public static class DersDal
    {

            //public static List<EntityDers> DersListele()
            //{
            //    List<EntityDers> dersler = new List<EntityDers>();

            //    SqlCommand komut = new SqlCommand("Select * from Dersler", Baglanti.bgl);
            //    if (komut.Connection.State != ConnectionState.Open)
            //    {
            //        komut.Connection.Open();
            //    }
            //    SqlDataReader oku = komut.ExecuteReader();

            //    while (oku.Read())
            //    {
            //        EntityDers ders = new EntityDers();
            //        ders.Id = int.Parse(oku["Id"].ToString());
            //        ders.Ad = oku["Ad"].ToString();
            //        ders.MinKontenjan = Convert.ToInt16(oku["MinKontenjan"].ToString());
            //        ders.MaxKontenjan = Convert.ToInt16(oku["MaxKontenjan"].ToString());
            //        dersler.Add(ders);
            //    }
            //    oku.Close();
            //    return dersler;
            //}
            //public static int TalepEkle(EntityBasvuruForm basvuru)
            //{
            //    SqlCommand komut = new SqlCommand("insert into Basvurular values(@ogrId,@dersId)", Baglanti.bgl);
            //    komut.Parameters.AddWithValue("@ogrId", basvuru.OgrenciId);
            //    komut.Parameters.AddWithValue("@derId", basvuru.DersId);
            //    if (komut.Connection.State != ConnectionState.Open)
            //    {
            //        komut.Connection.Open();
            //    }
            //    return komut.ExecuteNonQuery();
            //}
    }

}
