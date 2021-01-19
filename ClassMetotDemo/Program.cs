using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri2 = new Musteri();

            musteri2.MusteriID = 2;
            musteri2.MusteriAd = "Semih ";
            musteri2.MusteriSoyad = "Koca";
            musteri2.Bakiye = 999999;


            Musteri musteri1 = new Musteri();

            musteri1.MusteriID = 1;
            musteri1.MusteriAd = "Melih Ömer";
            musteri1.MusteriSoyad = "Kamar";
            musteri1.Bakiye = 9999;
            musteri1.Cinsiyet = "erkek";

            MusteriManage musteriManage = new MusteriManage();

            musteriManage.Ekleme(musteri1);

            musteriManage.Ekleme(musteri2);



            musteri1.Bakiye = 999999999;

            musteriManage.Guncelleme(musteri1);

            musteriManage.silme(musteri2);





            Console.ReadLine();
        }
    }



    



}
