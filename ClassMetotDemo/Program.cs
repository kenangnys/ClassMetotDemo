using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Ad = "Murat";
            m1.Soyad = "Büyük";
            m1.Numara = 10;

            

            Musteri m2 = new Musteri();
            m2.Ad = "Oğuz";
            m2.Soyad = "Keskiner";
            m2.Numara = 11;

            Musteri m3 = new Musteri();
            m3.Ad = "Yunus Bedri";
            m3.Soyad = "Örnek";
            m3.Numara = 12;

            Console.WriteLine("----------EKLE----------");
            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(m1);
            musteri.Ekle(m2);
            musteri.Ekle(m3);


            Console.WriteLine("---------LİSTE----------");
            Musteri[] musteriler = new Musteri[] { m1, m2, m3 };
            foreach (var musteris in musteriler)
            {
                Console.WriteLine(musteris.Ad+" "+musteris.Soyad+" "+musteris.Numara);
            }
            Console.WriteLine("---------SİLİNENLER---------");
            MusteriManager smusteri = new MusteriManager();
            smusteri.musterisil(m1);

            

            
            
        }
        
    }
}
