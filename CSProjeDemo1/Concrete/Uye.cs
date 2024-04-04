using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class Uye : IUye
    {
        public Uye()
        {
            OduncKitaplarim = new List<BaseKitap>();
        }

        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeNumarasi { get; set; }

        private int _kitapOduncSayisi = 0;
        public int KitapOduncSayisi
        {
            get { return _kitapOduncSayisi; }
            set { _kitapOduncSayisi = value; }
        }
        public List<BaseKitap> OduncKitaplarim { get; set; }   

        public List<BaseKitap> OduncAlinanKitapListem()
        {
            return OduncKitaplarim;
        }

        public void KitapIadeEt(BaseKitap kitap) //Kütüphaneye Kitabı Teslim Etme Metodu
        {
            if (KitapOduncSayisi > 0 && OduncKitaplarim.Contains(kitap))
            {
                OduncKitaplarim.Remove(kitap);
                KitapOduncSayisi--;
                kitap.KutuphaneKitapGeriAlir();
                kitap.KitapDurumu = KitapDurumu.OduncAlabilir;
            }
            else
            {
                throw new Exception("Ödünç verilebilecek kitabınız bulunmamaktadır veya daha önce böyle bir kitap almadınız.");
            }
        }

        public void KitapOduncAl(BaseKitap kitap)  //Kütüphaneden Kitap Ödünç Alma Metodu
        {

            if (kitap.KitapDurumu == KitapDurumu.OduncAlabilir || kitap.KitapDurumu == KitapDurumu.OduncVerildi)
            {
                OduncKitaplarim.Add(kitap);
                KitapOduncSayisi++;
                kitap.KutuphaneKitapOduncVerir();
                kitap.KitapDurumu = KitapDurumu.OduncVerildi;
            }
            else
            {
                kitap.KitapDurumu = KitapDurumu.MevcutDegil;
                throw new Exception("Kitap Stok u Yoktur Ödünç Verilemedi.");
            }
        }
    }
}
