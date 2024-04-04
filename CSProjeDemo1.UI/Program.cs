using CSProjeDemo1.Concrete;

namespace CSProjeDemo1.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kutuphane Oluşturuldu.
            Kutuphane kutuphane = new Kutuphane();

            //Kitaplar Oluşturulu.
            KitapBilim kitap1 = new KitapBilim() { Baslik = "Büyük Tasarım", Yazar = "Stephen Hawkıng", YayinYili = 2010, ToplamKitapSayisi = 12 };

            KitapBilim kitap2 = new KitapBilim() { Baslik = "Kara Delikler", Yazar = "Stephen Hawkıng", YayinYili = 2017, ToplamKitapSayisi = 10 };

            KitapBilim kitap3 = new KitapBilim() { Baslik = "Hiç Yoktan Bir Evren", Yazar = "Lawrance Krauss", YayinYili = 2012, ToplamKitapSayisi = 20 };

            KitapBilim kitap4 = new KitapBilim() { Baslik = "İnsanın Türeyişi", Yazar = "Charles Darwin", YayinYili = 1859, ToplamKitapSayisi = 8 };

            KitapCocuk kitap5 = new KitapCocuk()
            {
                Baslik = "Çantamdan Fil Çıktı",
                Yazar = "Mert Arık",
                YayinYili = 2023,
                ToplamKitapSayisi = 15
            };

            KitapCocuk kitap6 = new KitapCocuk()
            {
                Baslik = "Alice Harikalar Diyarında",
                Yazar = "Lewıs Carroll",
                YayinYili = 1865,
                ToplamKitapSayisi = 17
            };

            KitapRoman kitap7 = new KitapRoman() { Baslik = "Uğultulu Tepeler", Yazar = "Emily Bronte", YayinYili = 1847, ToplamKitapSayisi = 35 };

            KitapRoman kitap8 = new KitapRoman() { Baslik = "Milena'ya Mektuplar", Yazar = "Franz Kafka", YayinYili = 1952, ToplamKitapSayisi = 22 };

            KitapRoman kitap9 = new KitapRoman() { Baslik = "İstanbul Hatırası", Yazar = "Ahmet Ümit", YayinYili = 2010, ToplamKitapSayisi = 9 };

            KitapTarih kitap10 = new KitapTarih() { Baslik = "Şu Çılgın Türkler", Yazar = "Turgut Özakman", YayinYili = 2005, ToplamKitapSayisi = 7 };

            KitapTarih kitap11 = new KitapTarih()
            {
                Baslik = "Osmanlı'yı Yeniden Keşfetmek",
                Yazar = "İlber Ortaylı",
                YayinYili = 2006,
                ToplamKitapSayisi = 14
            };

            //Kütüphaneye Kitap Ekle
            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);
            kutuphane.KitapEkle(kitap3);
            kutuphane.KitapEkle(kitap4);
            kutuphane.KitapEkle(kitap5);
            kutuphane.KitapEkle(kitap6);
            kutuphane.KitapEkle(kitap7);
            kutuphane.KitapEkle(kitap8);
            kutuphane.KitapEkle(kitap9);
            kutuphane.KitapEkle(kitap10);
            kutuphane.KitapEkle(kitap11);

            //Kütüphanede ki Kitaplarım
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~Kütüphane Kitap Listesi~~~~~~~~~~~~~~~~~~");
            //foreach (var kitap in kutuphane.KutuphaneKitaplarım())
            //{
            //    Console.WriteLine(kitap.Baslik + " Adet: " + kitap.ToplamKitapSayisi);
            //}

            //Üye Oluştur
            Uye uye1 = new Uye() { UyeAd = "Irem", UyeSoyad = "Kars", UyeNumarasi = "1" };
            Uye uye2 = new Uye() { UyeAd = "Eren", UyeSoyad = "Kars", UyeNumarasi = "2" };
            Uye uye3 = new Uye() { UyeAd = "Yaren", UyeSoyad = "Sevim", UyeNumarasi = "3" };
            Uye uye4 = new Uye() { UyeAd = "Milena", UyeSoyad = "Kara", UyeNumarasi = "4" };
            Uye uye5 = new Uye() { UyeAd = "Şevval", UyeSoyad = "Güvercin", UyeNumarasi = "5" };


            //Üyeleri Kütüphaneye Kayıt Et
            kutuphane.UyeEkle(uye1);
            kutuphane.UyeEkle(uye2);
            kutuphane.UyeEkle(uye3);
            kutuphane.UyeEkle(uye4);
            kutuphane.UyeEkle(uye5);

            //Kütüphanede ki Üyelerim
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~Kütüphane Üye Listesi~~~~~~~~~~~~~~~~~~~~~~");
            //foreach (var uye in kutuphane.KutuphaneUyelerim())
            //{
            //    Console.WriteLine(uye.UyeNumarasi + "- " + uye.UyeAd + " " + uye.UyeSoyad);
            //}


            //Üyelerim Kitapları Ödünç Aldı
            uye1.KitapOduncAl(kitap1);
            uye2.KitapOduncAl(kitap1);
            uye3.KitapOduncAl(kitap3);
            uye4.KitapOduncAl(kitap5);
            uye5.KitapOduncAl(kitap3);
            uye1.KitapOduncAl(kitap4);
            uye2.KitapOduncAl(kitap7);
            uye3.KitapOduncAl(kitap8);
            uye4.KitapOduncAl(kitap9);
            uye5.KitapOduncAl(kitap6);
            uye1.KitapOduncAl(kitap5);
            uye2.KitapOduncAl(kitap10);


            ////Kütüphanede ki Kitaplarım
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~Kütüphane Kitap Listesi~~~~~~~~~~~~~~~~~~");
            //foreach (var kitap in kutuphane.KutuphaneKitaplarım())
            //{
            //    Console.WriteLine(kitap.Baslik + " Adet: " + kitap.ToplamKitapSayisi);
            //}

            ////Üyemde ki Kitaplar
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~Üyelerimde ki Kitaplar~~~~~~~~~~~~~~~~~~~~~~");
            //foreach (var uye in kutuphane.KutuphaneUyelerim())
            //{
            //    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~" + uye.UyeAd + "'in Kitapları~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //    Console.WriteLine("Ödünç Kitap Sayısı: " + uye.KitapOduncSayisi);
            //    foreach (var odunc in uye.OduncAlinanKitapListem())
            //    {                   
            //        Console.WriteLine(odunc.Baslik);
            //    }
            //}

            //Üyelerim Kitapları İade Ediyor
            uye1.KitapIadeEt(kitap1);
            uye2.KitapIadeEt(kitap10);
            uye4.KitapIadeEt(kitap9);
            uye5.KitapIadeEt(kitap3);

            //Kütüphanede ki Kitaplarım
            Console.WriteLine("~~~~~~~~~~~~~~~~~~Kütüphane Kitap Listesi~~~~~~~~~~~~~~~~~~");
            foreach (var kitap in kutuphane.KutuphaneKitaplarım())
            {
                Console.WriteLine(kitap.Baslik + " Adet: " + kitap.ToplamKitapSayisi);
            }

            //Üyemde ki Kitaplar
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Üyelerimde ki Kitaplar~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var uye in kutuphane.KutuphaneUyelerim())
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~" + uye.UyeAd + "'in Kitapları~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Ödünç Kitap Sayısı: " + uye.KitapOduncSayisi);
                foreach (var odunc in uye.OduncAlinanKitapListem())
                {
                    Console.WriteLine(odunc.Baslik);
                }
            }
        }
    }
}