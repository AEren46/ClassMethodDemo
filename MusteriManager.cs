using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri mx) 
        {
            Console.WriteLine("Yeni üyemiz hayırlı olsun:");
            Console.WriteLine("Ad:     "+ mx.Ad);
            Console.WriteLine("Soyad:  "+ mx.Soyad);
        }

        public void Cikar(Musteri my) 
        {
            Console.WriteLine("Güle güle! Bizi kaybeden kişi:    ");
            Console.WriteLine("Ad:     " + my.Ad);
            Console.WriteLine("Soyad:  " + my.Soyad);
        }

        public void Listele(Musteri[] liste) 
        {
            foreach (Musteri mus in liste)
            {
                Console.WriteLine("Müşteri Id     :    " + mus.Id);
                Console.WriteLine("Müşteri Adı    :    " + mus.Ad);
                Console.WriteLine("Müşteri Soyadı :    " + mus.Soyad);
                Console.WriteLine("Müşteri Yaşı   :    " + mus.Yas);
                Console.WriteLine("Müşteri Parası :    " + mus.Para);
                Console.WriteLine("----------------------------");
            }
        }

    }
}
