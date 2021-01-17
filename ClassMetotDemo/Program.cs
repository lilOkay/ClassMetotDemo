using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Okay";
            musteri1.Soyadi = "Genc";
            musteri1.Yasi = 16;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "lionel";
            musteri2.Soyadi = "messi";
            musteri2.Yasi = 35;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach(var musteri in musteriler)
            {
                Console.WriteLine("---Müşteri-- -");
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
            }
            MusteriManager musterimanager = new MusteriManager();
            {
                musterimanager.Ekle(musteri1);
                Console.WriteLine("---------------------------------");
                musterimanager.Sil(musteri2);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
