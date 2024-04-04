using CS.ProjeDemo2.Abstract;
using CS.ProjeDemo2.Concrete;
using Newtonsoft.Json;
using System;
using System.IO;



namespace CSProje.Demo2.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaasBordro maasBordro = new MaasBordro();

            Memur memur1 = new Memur("Irem", "Kars", 14, 2014);
            memur1.MaasHesapla();
            maasBordro.MemurEkle(memur1);

            maasBordro.MaaslariHesaplaVeRaporuGoster(maasBordro.Personeller());

            foreach (var personel in maasBordro.Personeller())
            {
                Console.WriteLine($"Personel Adı: {personel.Ad}, " +
                                  $"Çalışma Süresi: {personel.CalismaSaati}, " +
                                  $"Ana Ödeme: {personel.AnaOdeme}, " +
                                  $"Mesai: {personel.Mesai}, " +
                                  $"Toplam Ödeme: {personel.ToplamOdeme}");
            }


            string path = @"C:\\Users\\pc\\Desktop\\person";

            //JSON Serileştirme
            //memur1 adlı bir nesne JSON formatına serileştirilir ve elde edilen JSON dizgesi json adlı bir değişkene atanır.memur1 nesnesi JSON formatına dönüştürüldü.
            string json = System.Text.Json.JsonSerializer.Serialize(memur1);
            Console.WriteLine(json);
            //DosyaYaz metodunu çağırarak JSON dizgesini belirtilen yola (path) ve belirtilen dosya adıyla (".json" uzantısı eklenerek) bir dosyaya yazdırır.JSON dizgesini alır ve belirtilen dosya yoluyla birlikte dosyaya yazma işlemini gerçekleştirir.
            DosyaOku.DosyaYaz(json, path + ".json");

            //JSON Serileştirme
            string json1 = System.Text.Json.JsonSerializer.Serialize(memur1);
            Console.WriteLine(json1);
            DosyaOku.DosyaYaz(json1, path + ".json");


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~Yöneticilerim~~~~~~~~~~~~~~~~");
            foreach (var yonetici in maasBordro.YoneticiListele())
            {
                Console.WriteLine(yonetici.Ad + " " + yonetici.Soyad);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~Memurlarım~~~~~~~~~~~~~~~~");
            foreach (var memur in maasBordro.MemurListele())
            {
                Console.WriteLine(memur.Ad + " " + memur.Soyad);
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~Personellerim~~~~~~~~~~~~~~~~~~~~");
            foreach (var personel in maasBordro.Personeller())
            {
                Console.WriteLine(personel.Ad + " " + personel.Soyad);
            }

            maasBordro.MaaslariHesaplaVeRaporuGoster(maasBordro.Personeller());
            foreach (var bordroBilgiler in maasBordro.Personeller())
            {
                Console.WriteLine($"Personel Adı: {bordroBilgiler.Ad}, " +
                                  $"Çalışma Süresi: {bordroBilgiler.CalismaSaati}, " +
                                  $"Ana Ödeme: {bordroBilgiler.AnaOdeme}, " +
                                  $"Mesai: {bordroBilgiler.Mesai}, " +
                                  $"Toplam Ödeme: {bordroBilgiler.ToplamOdeme}");
            }

            // 150 saat veya daha az çalışanları raporla
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~150 saatten Az Çalışan Listesi~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            maasBordro.AzCalisanlariSaatlikRaporla(150);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Az Çalışanların Özeti~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            maasBordro.AzCalisanlariAylikRaporla(maasBordro.Personeller());

            JsonOku();
        }

        public static void JsonOku()
        {
            // Okunacak JSON dosyasının yolu
            string jsonDosyaYolu = @"C:\\Users\\pc\\Desktop\\person.json";
            try
            {
                // DosyaOku sınıfındaki DosyaOkuma metodunu kullanarak JSON dosyasını okur ve jsonVeri değişkenine atar.
                string jsonVeri = DosyaOku.DosyaOkuma(jsonDosyaYolu);

                // Okunan JSON verisini bir dinamik nesneye deserialize eder. Böylece, JSON verisindeki özelliklere dinamik olarak erişilebilir hale gelir.derleme zamanında tür kontrolü yapılma.çalışma zamanında belirlenir.JSON verilerinin yapısı ve içeriği değişken olabileceğinden dynamic kullanılır.
                dynamic dinamikNesne = JsonConvert.DeserializeObject(jsonVeri);

                // Unvan özelliğine bakarak uygun sınıfa dönüştürme işlemini gerçekleştir
                Personel personel;
                string unvan = dinamikNesne.Unvan;
                //Eğer unvan "Yonetici" ise JSON verisi bir Yonetici nesnesine deserialize edilir, eğer unvan "Memur" ise JSON verisi bir Memur nesnesine deserialize edilir.
                if (unvan == "Yonetici")
                {
                    Yonetici yoneticiFromJson=JsonConvert.DeserializeObject<Yonetici>(jsonVeri);
                    personel = yoneticiFromJson;
                }
                else if (unvan == "Memur")
                {
                    // JSON'dan Memur nesnesine dönüşüm yap
                    Memur memurFromJson = JsonConvert.DeserializeObject<Memur>(jsonVeri);
                    // Memur nesnesinin bilgilerini kullan
                    personel = memurFromJson;
                }
                else
                {
                    throw new InvalidOperationException("Geçersiz unvan.");
                }

                // Maaş bilgilerini içeren yeni JSON dosyasını oluştur.JsonConvert.SerializeObject metodu kullanılarak bir nesne serileştirilir ve JSON dizgesine dönüştürülür.
                //Maaş bilgileri farklı tiplerde olabileceği için object türü kullanılarak her türden veri depolanabilir.
                string maasBilgisi = JsonConvert.SerializeObject(new Dictionary<string, object>
                {
                    { "Maas Bordro, " + DateTime.Now.ToString("MMMM yyyy"), new
                       {
                         PersonelIsmi = personel.Ad + " " + personel.Soyad,
                         CalismaSaati = personel.CalismaSaati,
                         AnaOdeme = personel.AnaOdeme,
                         Mesai = personel.Mesai,
                         ToplamOdeme = personel.ToplamOdeme
                       }
                    }
                }, Formatting.Indented); //Formatting.Indented parametresi, oluşturulan JSON dizgesinin okunabilirliğini artırmak için girintili biçimde oluşturulmasını sağlar.

                string maasDosyaAdi = $"{personel.Ad}.json"; // Dosyanın adını oluştururken, personelin adını alarak JSON dosyasının adını belirler. 

                string maasDosyaYolu = Path.Combine(@"C:\Users\pc\Desktop\", maasDosyaAdi); //dizin ve dosya adını birleştirerek, dosyanın tam yolunu sağlar.

                File.WriteAllText(maasDosyaYolu, maasBilgisi); //File.WriteAllText() metodu kullanılarak, belirtilen dosyaya maaş bilgilerini içeren JSON dizgesi yazılır. Bu metot, dosyayı oluşturur veya varsa üzerine yazar.

                Console.WriteLine($"Maaş bilgileri klasöre kaydedildi: {maasDosyaYolu}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }
}