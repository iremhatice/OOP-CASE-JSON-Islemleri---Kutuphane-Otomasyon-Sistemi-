using CSProjeDemo1.Enum_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstract
{
    public abstract class BaseKitap //Farklı türdeki kitapların temel özelliklerini içerir.
    {
        public string ISBN { get; set; } = Guid.NewGuid().ToString().Substring(0, 4); //Guid=>Eşsiz bir numara
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int? YayinYili { get; set; } //değer vermeden üretim yapılsın,boş geçilebilir.
        public KitapDurumu KitapDurumu { get; set; }  //Enum tipinde KitapDurumları var.

        private int _toplamKitapSayisi;

        public int ToplamKitapSayisi
        {
            get { return _toplamKitapSayisi; }
            set
            {
                if (value >= 0)
                {
                    _toplamKitapSayisi = value;
                    KitapDurumu = _toplamKitapSayisi > 0 ? KitapDurumu.OduncAlabilir : KitapDurumu.MevcutDegil;
                }
                else
                {
                    throw new Exception("Kitap Sayısı negatif olamaz");
                }
            }
        }

        public abstract void KutuphaneKitapOduncVerir(); //Her sınıfta ezilecek
        public abstract void KutuphaneKitapGeriAlir();


    }
}
