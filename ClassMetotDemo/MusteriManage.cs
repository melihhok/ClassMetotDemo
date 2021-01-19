using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManage
    {

        public void Ekleme(Musteri musteriekle) {

            Console.WriteLine( "ID : " + musteriekle.MusteriID+ "  " + musteriekle.MusteriAd + "  " + musteriekle.MusteriSoyad + "  " + musteriekle.Bakiye + " TL"  + "  " + "Kayıt Başarıyla Alınmıştır."  );


        }


     
        public void Guncelleme(Musteri musterigüncelle) {

            string Cnsiyet = "" ;
            

            if (musterigüncelle.Cinsiyet == "erkek")
            {
                Cnsiyet = " Bey'in ";
            }
            else
            {
                Cnsiyet = " Hanım'ın ";
            }

            Console.WriteLine(musterigüncelle.MusteriAd + " {0}  Yeni Bakiyesi " + musterigüncelle.Bakiye  + " TL"      , Cnsiyet);


        
        }


        public void silme(Musteri musterisilme) {


            
            Console.WriteLine(musterisilme.MusteriAd.Remove(0) + musterisilme.MusteriSoyad.Remove(0) + musterisilme.MusteriID + " ID'li Kullanıcı Silinmiştir." );

        
        }

    }
}
