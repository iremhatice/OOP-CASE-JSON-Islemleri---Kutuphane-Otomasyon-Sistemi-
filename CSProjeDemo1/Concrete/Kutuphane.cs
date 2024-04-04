using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum_s;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class Kutuphane : IKutuphane
    {
        private static List<BaseKitap> _kitaplar; //sınıf örneği oluşturulmadan da erişilebilir
        private static List<IUye> _uyeler;
        public Kutuphane()
        {
            _kitaplar = new List<BaseKitap>();
            _uyeler = new List<IUye>();
        }

        public void KitapEkle(BaseKitap kitap)  //Kütüphaneye Kitap Ekleme Metodu
        {
            _kitaplar.Add(kitap);
        }                      

        public List<BaseKitap> KutuphaneKitaplarım()  //Kütüphanedeki Kitaplarımın Listesi
        {
            return _kitaplar;
        }

        public List<IUye> KutuphaneUyelerim()  //Kütüphanedeki Üyelerimin Listesi
        {
            return _uyeler;
        }

        public void UyeEkle(IUye uye) //Kütüphaneye Üye Ekleme Metodu
        {
            _uyeler.Add(uye);
        }
    }
}
