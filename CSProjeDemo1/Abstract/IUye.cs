using CSProjeDemo1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstract
{
    public interface IUye
    {
        string UyeAd { get; set; }
        string UyeSoyad { get; set; }
        string UyeNumarasi { get; set; }
        int KitapOduncSayisi { get; set; }  //Üyenin Toplam Ödünç Kitap Sayısı
        List<BaseKitap> OduncKitaplarim { get; set; }  //Ödünç Aldığım Kitap Listesi

        List<BaseKitap> OduncAlinanKitapListem();
        public void KitapOduncAl(BaseKitap kitap);
        public void KitapIadeEt(BaseKitap kitap);
    }
}
