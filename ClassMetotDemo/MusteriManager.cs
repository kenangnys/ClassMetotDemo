using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklendi"+" "+musteri.Ad+" "+musteri.Soyad);

        }
        public void listele()
        {
            Console.WriteLine("Listelendi");
        }
        public void musterisil(Musteri musteri)
        {
            Console.WriteLine("silindi"+" "+musteri.Ad+" "+musteri.Soyad);
        }
    }
}
