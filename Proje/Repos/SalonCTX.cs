using Dapper;
using GetConnection;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Repos
{
    public class SalonCTX
    {
        //CRUD Create Read Update Delete       
        public List<Salon_Tablosu> tumSalonlariDondur()
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Salon_Tablosu";
                return x.Query<Salon_Tablosu>(sorgu).ToList();
            }
        }
        internal object tekSalonDondur()
        {
            throw new NotImplementedException();
        }

        public Salon_Tablosu tekSalonDondur(int SalonID)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Salon_Tablosu where SalonID= @id";
                return x.Query<Salon_Tablosu>(sorgu, new { id = SalonID }).FirstOrDefault();
            }
        }

        internal void salonDuzenle()
        {
        }

        internal int salonEkle(Salon_Tablosu sln)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "insert into Salon_Tablosu (SalonAdi, SalonAciklama, SalonKapasite) values (@SalonAdi, @SalonAciklama, @SalonKapasite)";
                //return x.Execute(sorgu, new { SalonAdi = salon.SalonAdi, SalonAciklama = salon.SalonAciklama, SalonKapasite = salon.SalonKapasite });
                return x.Execute(sorgu, sln);
            }
        }

        internal object salonSil(Salon_Tablosu salon)
        {
            return "sil";
        }

        internal object SalonDuzenle(Salon_Tablosu dznl)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "update Salon_Tablosu set SalonAdi = @SalonAdi, SalonAciklama = @SalonAciklama, SalonKapasite =@SalonKapasite";
                return x.Execute(sorgu, dznl);
            }
        }
        public List<Salon_Tablosu> salonEkle()
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Salon_Tablosu";
                return x.Query<Salon_Tablosu>(sorgu).ToList();
            }
        }

        public int salonDuzenle(Salon_Tablosu salon)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "update Salon_Tablosu set SalonAdi = @SalonAdi, SalonAciklama = @SalonAciklama, SalonKapasite =@SalonKapasite where SalonID = @SalonID";
                return x.Execute(sorgu, salon);
            }
        }

        public int salonSil(int id)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "delete from Salon_Tablosu where SalonID = @SalonID";
                return x.Execute(sorgu, new { SalonID = id });
            }
        }
    }
}
