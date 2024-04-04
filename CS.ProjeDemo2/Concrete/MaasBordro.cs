using CS.ProjeDemo2.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.ProjeDemo2.Concrete
{
    public class MaasBordro : IMaasBordro
    {
        static List<Personel> personeller = new List<Personel>(); //Orneği oluşturulmadan erişilsin.
        static List<Memur> memurlar = new List<Memur>();
        static List<Yonetici> yoneticiler = new List<Yonetici>();


        public void MemurEkle(Memur memur)
        {
            memurlar.Add(memur);
            personeller.Add(memur);
        }

        public void YoneticiEkle(Yonetici yonetici)
        {
            yoneticiler.Add(yonetici);
            personeller.Add(yonetici);
        }

        public List<Memur> MemurListele()
        {
            return memurlar;
        }

        public List<Yonetici> YoneticiListele()
        {
            return yoneticiler;
        }

        public List<Personel> Personeller()
        {
            return personeller;
        }

        public void MaaslariHesaplaVeRaporuGoster(List<Personel> personeller)
        {
            foreach (var personel in personeller)
            {
                // Unvana göre maaş hesapla
                if (personel is Yonetici) //Personel yonetici ise
                {
                    Yonetici yonetici = (Yonetici)personel; //personel nesnesini yonetici nesnesine dönüştür
                    yonetici.MaasHesapla();

                }
                else if (personel is Memur)
                {
                    Memur memur = (Memur)personel;
                    memur.MaasHesapla();
                }
                else
                {
                    Console.WriteLine($"Geçersiz unvan: {personel.Unvan}");
                }
            }
        }

        public void AzCalisanlariSaatlikRaporla(int minimumCalismaSaati)
        {
            Console.WriteLine($"Az çalışan personeller ({minimumCalismaSaati} saat veya daha az çalışanlar):");
            foreach (var personel in personeller)
            {
                if (personel.CalismaSaati < minimumCalismaSaati)
                {
                    Console.WriteLine($"- {personel.Ad}: {personel.CalismaSaati} saat");
                }
            }
        }

        // Günde 10 saatten az çalışanların özetini oluşturan metot 
        public void AzCalisanlariAylikRaporla(List<Personel> personeller)
        {
            foreach (var calisan in personeller)
            {
                if (calisan.CalismaSaati < 10)
                {
                    Console.WriteLine($"{calisan.Ad} - Günlük: {calisan.CalismaSaati} saat, Aylık: {(calisan.CalismaSaati * 20)} saat");
                }
            }
        }

    }
}
