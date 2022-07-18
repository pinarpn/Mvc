using Dapper;
using GetConnection;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Repos
{
    public class Etkinlik_TablosuCTX
    {
        //CRUD Create Read Update Delete

        //Read(Select)
        public List<Etkinlik> tumEtkinlikleriDondur()
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Etkinlik_Tablosu";
                return x.Query<Etkinlik>(sorgu).ToList(); //model adı yazılacak query den sonra
            }
        }

        public Etkinlik tekEtkinlikDondur(int EtkinlikID)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                string sorgu = "select * from Etkinlik_Tablosu where id = @id";
                return x.Query<Etkinlik>(sorgu, new { id = EtkinlikID }).FirstOrDefault();
            }
        }

        //internal object EtkinlikDuzenle()
        //{
        //    throw new NotImplementedException();
        //}

        internal object tekEtkinlikDondur()
        {
            throw new NotImplementedException();
        }

        //internal object EtkinlikSil()
        //{
        //    throw new NotImplementedException();
        //}

        public int EtkinlikEkle(Etkinlik etkinlik)
        {
            baglanti bag = new baglanti();
            using (var x = bag.GetConnection())
            {
                //KONTROL ET
                string sorgu = "insert into Etkinlik_Tablosu (EtkinlikAdi, TalepBirim, TalepKisiTC, BaslangicTarih, BitisTarih, BaslangicSaat, BitisSaat, Aciklama, EvrakNo, EtkinlikNo) values (@EtkinlikAdi, @TalepBirim, @TalepKisiTC, @BaslangicTarih, @BitisTarih, @BaslangicSaat, @BitisSaat, @Aciklama, @EvrakNo, @EtkinlikNo)";
                //return x.Execute(sorgu, new { SalonAdi = salon.SalonAdi, SalonAciklama = salon.SalonAciklama, SalonKapasite = salon.SalonKapasite });
                return x.Execute(sorgu, etkinlik);
            }
        }

        //public int EtkinlikDuzenle(Etkinlik_Tablosu etkinlik)
        //{
        //    baglanti bag = new baglanti();
        //    using (var x = bag.GetConnection())
        //    {       //KONTROL ET
        //        string sorgu = "update Etkinlik_Tablosu set EtkinlikAdi = @EtkinlikAdi, TalepBirim = @TalepBirim, TalepKisiTC =@TalepKisiTC, BaslangicTarih = @BaslangicTarih, BitisTarih = @BitisTarih, BaslangicSaat = @BaslangicSaat, BitisSaat = @BitisSaat, Aciklama = @Aciklama, EvrakNo = @EvrakNo, EtkinlikNo = @EtkinlikNo where EtkinlikID = @EtkinlikID";
        //        return x.Execute(sorgu, etkinlik);
        //    }
        //}

        //public int EtkinlikSil(int id)
        //{
        //    baglanti bag = new baglanti();
        //    using (var x = bag.GetConnection())
        //    {
        //        string sorgu = "delete from Etkinlik_Tablosu where EtkinlikID = @EtkinlikID";
        //        return x.Execute(sorgu, new { EtkinlikID = id });
        //    }
        //}
    }
}