using CS.ProjeDemo2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.ProjeDemo2.Abstract
{
    public interface IMaasBordro
    {
        List<Personel> Personeller();
        List<Memur> MemurListele();
        List<Yonetici> YoneticiListele();
        void MemurEkle(Memur memur);
        void YoneticiEkle(Yonetici yonetici);
        public void MaaslariHesaplaVeRaporuGoster(List<Personel> personeller);
        public void AzCalisanlariSaatlikRaporla(int minimumCalismaSaati); //Girilen minimum saate göre o saaaten az çalışan peronelleri listeler.
        public void AzCalisanlariAylikRaporla(List<Personel> personeller);  // Günde 10 saatten az çalışanların özetini oluşturan metot 


    }
}
