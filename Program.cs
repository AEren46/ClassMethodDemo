using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri(), m2 = new Musteri(), m3 = new Musteri();
            Musteri[] musteriler = new Musteri[] { m1, m2, m3 };
            m1.Id = "123qwe";
            m1.Ad = "Ahmet";
            m1.Soyad = "Toprak";
            m1.Yas = 23;
            m1.Para = 12000;
            m2.Id = "456asd";
            m2.Ad = "Mehmet";
            m2.Soyad = "Elmas";
            m2.Yas = 46;
            m2.Para = 29600;
            m3.Id = "789zxc";
            m3.Ad = "Sakıp";
            m3.Soyad = "Tarlacı";
            m3.Yas = 37;
            m3.Para = 357000;
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(m1);
            musterimanager.Ekle(m2);
            musterimanager.Ekle(m3);
            Console.WriteLine("==============");
            musterimanager.Listele(musteriler);
            musterimanager.Cikar(m2);
            musterimanager.Cikar(m3);


        }
    }
}
