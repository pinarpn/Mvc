using Dapper;
using GetConnection;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Repos
{
    public class YetkiliCTX
    {
        public object KayitYapanID { get; private set; }

        //CRUD Create Read Update Delete

        //Read (Select)
        public List<Yetkili_Tablosu> tumYetkilileriDondur()
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Yetkili_Tablosu";
                return x.Query<Yetkili_Tablosu> (sorgu).ToList();
            }
        }

        internal object tekYetkiliDondur()
        {
            throw new NotImplementedException();
        }

        internal object YetkiliEkle()
        {
            throw new NotImplementedException();
        }

        public Yetkili_Tablosu tekYetkiliDondur(int KayitYapanID)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Yetkili_Tablosu where id = @id";
                return x.Query<Yetkili_Tablosu>(sorgu, new { id = KayitYapanID }).FirstOrDefault();
            }
        }

        internal object YetkiliSil()
        {
            throw new NotImplementedException();
        }

        internal object YetkiliDuzenle()
        {
            throw new NotImplementedException();
        }

        public int YetkiliEkle(Yetkili_Tablosu yetkili)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "insert into Yetkili_Tablosu (TC, Aktif, Tarih) values (@TC, @Aktif, @Tarih)";
                //return x.Execute(sorgu, new { SalonAdi = salon.SalonAdi, SalonAciklama = salon.SalonAciklama, SalonKapasite = salon.SalonKapasite });
                return x.Execute(sorgu, yetkili);

            }
        }

        public int YetkiliDuzenle(Yetkili_Tablosu yetkili)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "update Yetkili_Tablosu set TC = @TC, Aktif = @Aktif, Tarih =@Tarih where KayitYapanID = @KayitYapanID";
                return x.Execute(sorgu, yetkili);
            }
        }

        public int YetkiliSil(int id)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "delete from Yetkili_Tablosu where KayitYapanID = @KayitYapanID";
                return x.Execute(sorgu, new { KayitYapanID = id });
            }
        }
    }
}
