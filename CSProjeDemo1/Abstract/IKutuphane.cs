using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstract
{
    public interface IKutuphane
    {
        List<BaseKitap> KutuphaneKitaplarım();  //Kütüphanedeki Kitaplarımın Listesi
        List<IUye> KutuphaneUyelerim();  //Kütüphanedeki Üyelerimin Listesi
        void KitapEkle(BaseKitap kitap);  //Kütüphaneye Kitap Ekleme Metodu
        void UyeEkle(IUye uye); //Kütüphaneye Üye Ekleme Metodu
      
    }
}
