CASE-1- Kütüphane Otomasyon Sistemi
Bir kütüphane programı, kitapların ödünç alınması ve iade edilmesi için bir otomasyon sistemi.Kütüphanemizde birden fazla türde kitaplar bulunmaktadır.(Bilim, Roman, Tarih, v.b.) bu kitap türleri zaman içerisinde genişletilebilir yapıdadır.
Kütüphanemizde tek tip üye bulunmaktadır. 
Kütüphane sistemine dahil olan herkes kütüphane stoğunda bulunan kitaplardan ödünç alabilir. (Ödünç işlemi için şartlar sisteme dahil olması ve kütüphane stoğundan yeterli sayıda kitap olmasıdır.)

Kütüphanenin İşlevleri:

•Bir üye kitap ödünç alabilir.

•Bir üye ödünç aldığı kitabı iade edebilir.

•Bir kitabın mevcut durumu güncellenebilir (ödünç alınabilir, ödünçte, mevcut değil).

•Bir üyenin ödünç aldığı kitapları görüntüleyebilir.

•Kütüphane durumunu (mevcut kitaplar, ödünç alınan kitaplar, üyeler vb.) görüntüleyebilir.

CASE-2- Maaş Bordro Programı
Küçük bir şirketin maaş bordrolarını oluşturan bir uygulamadır.
Şirketimize yazılacak olan maaş bordro program en az iki tipte (Yonetici ve Memur) personeline maaşlarını hesaplar, kayıt altına alır ve raporlama işlemlerine sahiptir.
Ayrıca projemize daha sonradan oluşabilecek yeni personel kadroları dahilinde genişletilebilirdir.
Maaş Bordro Programını İşlevleri:

•Her personelin maaş hesabı saatlik ücret * çalışma saati bilgileri doğrultusunda hesaplanır.

•Yoneticinin saatlik ucreti 500 den kucuk olamaz ve her her yoneticiye maaş dışında bonus adlı ek bir ödeme alır.

•Memurların maaşı maksimum 180 saat den hesaplanır. 180 saati geçen her çalışma süresi normal saatlik ücretin 1.5 katı bedelle belirlenerek ek mesai ücreti olarak ana maaşa eklenir.

•Memurun saatlik ücreti varsayılan olarak 500 TL dir. Fakat memurun derecesine göre değişebilir olmalıdır.

•Memur ve Yonetici listesi bir json dosyası olarak verilecektir. Program maaş hesaplamaya .jsondosyasından okuma yaparak sırasıyla personelin maaş bilgilerinin girişi yapılmasını isteyecektir.

•Hesaplanan maaş bilgileri her personelin adına açılan klasörün içersine maaş tarih bilgisiyle birlikte .jsonformatında kayıt edilecektir.
