using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListele();
        }
        public static bool OgrenciSilbll(EntityOgrenci p)
        {
            if (p != null)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> Ogrencidetay(int p)
        {
            return DALOgrenci.Ogrencidetay(p);
        }
       
        public static List<EntityOgrenci> OgrenciBul(int id)
        {
            return DALOgrenci.OgrenciGuncelle(id);
        }
    }
}
