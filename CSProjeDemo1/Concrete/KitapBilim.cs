using CSProjeDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class KitapBilim : BaseKitap
    {
        public override void KutuphaneKitapGeriAlir() //Kütüphane kitabı geri aldığında toplam kitap sayım artar.
        {
            ToplamKitapSayisi += 1;
        }

        public override void KutuphaneKitapOduncVerir()
        {
           ToplamKitapSayisi -= 1;
        }
    }
}
