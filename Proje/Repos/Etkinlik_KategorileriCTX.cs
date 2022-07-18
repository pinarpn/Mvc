using Dapper;
using GetConnection;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Repos
{
    public class Etkinlik_KategorileriCTX
    {
        public List<Etkinlik_Kategorileri> tumKategorileriDondur()
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Etkinlik_Kategorileri";
                return x.Query<Etkinlik_Kategorileri>(sorgu).ToList();
            }
        }

        public Etkinlik_Kategorileri tekKategoriDondur(int KategoriID)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Etkinlik_Kategorileri where id = @id";
                return x.Query<Etkinlik_Kategorileri>(sorgu, new { id = KategoriID }).FirstOrDefault();
            }
        }

        internal object tekKategoriDondur()
        {
            throw new NotImplementedException();
        }

        public int KategoriEkle(Etkinlik_Kategorileri kategori)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "insert into Etkinlik_Kategorileri (KategoriAdi, KategoriAciklama) values (@KategoriAdi, @KategoriAciklama)";
                //return x.Execute(sorgu, new { SalonAdi = salon.SalonAdi, SalonAciklama = salon.SalonAciklama, SalonKapasite = salon.SalonKapasite });
                return x.Execute(sorgu, kategori);

            }
        }

        internal object KategoriDuzenle()
        {
            throw new NotImplementedException();
        }

        public int KategoriDuzenle(Etkinlik_Kategorileri kategori)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "update Etkinlik_Kategorileri set KategoriAdi = @KategoriAdi, KategoriAciklama = @KategoriAciklama where KategoriID = @KategoriID";
                return x.Execute(sorgu, kategori);
            }
        }

        public int KategoriSil(int id)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "delete from Etkinlik_Kategorileri where KategoriID = @KategoriID";
                return x.Execute(sorgu, new { KategoriID = id });
            }
        }
    }
}