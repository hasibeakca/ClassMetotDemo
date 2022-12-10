using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
   public class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
          
            Console.WriteLine("MUSTERİ OZELLIKLERI BASARIYLA EKLENDİ:");
        }


        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musterı silindi.");
        }

        public void MusterileriListele(Musteri musteri)
        {
            Console.WriteLine("Musteri adı : " + musteri.Adi);
            Console.WriteLine("Musteri soyadı : " + musteri.Soyadi);
            Console.WriteLine("musteri tc : " + musteri.Tc);
            Console.WriteLine("musteri tel numarası " + musteri.TelNo);
        }
    }
}
