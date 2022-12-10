using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "HASİBE";
            musteri1.Soyadi = "AZRA";
            musteri1.Tc = "1203810218";
            musteri1.TelNo = "5077773322";
            MusteriManager musteriManager = new MusteriManager();
            //CONSTRACTER ÇAĞIRILDI
            Console.WriteLine("Müşteri ekleme işlemi sonucu gösterilecek");
            
            musteriManager.MusteriEkleme(musteri1 );
            Console.WriteLine("**************************");
            Console.WriteLine("Müşteri listeleme metoduyla müşterinin özellikleri getirilecek");
          
            musteriManager.MusterileriListele(musteri1);
            Console.WriteLine("**************************");
            Console.WriteLine("Musteri silme metodumuzu çağırıldı");
           
            musteriManager.MusteriSilme(musteri1);
            Console.WriteLine("**************************");
            // Aynı işlemler bir başka müşteri için yapıldı..
            Musteri musteri2 = new Musteri();
            musteri2.Adi = "FURKAN";
            musteri2.Soyadi = "AKCA";
            musteri2.Tc = "213242342";
            musteri2.TelNo = "5077722322";
            MusteriManager _musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusterileriListele(musteri2);
            musteriManager.MusteriSilme(musteri2);


                }
    }
}
