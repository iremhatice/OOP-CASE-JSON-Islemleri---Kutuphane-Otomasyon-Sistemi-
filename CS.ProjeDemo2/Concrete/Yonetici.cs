using CS.ProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.ProjeDemo2.Concrete
{
    public class Yonetici : Personel
    {
        private readonly double _bonus = 30000;

        public Yonetici(string ad, string soyad,int calismaSaati, double saatlikUcret) : base(ad, soyad,calismaSaati,saatlikUcret) //Yçnetici oluştururken alınan parametreleri temel sınıfa iletir.
        {
          
        }

        public override string Unvan { get; set; } = "Yonetici";

        public override double MaasHesapla()
        {
            AnaOdeme = SaatlikUcret * (CalismaSaati * 20);
            if (SaatlikUcret > 500)
            {
                ToplamOdeme = AnaOdeme + _bonus;
                return ToplamOdeme;
            }
            ToplamOdeme = AnaOdeme;
            return ToplamOdeme;
        }

    }
}
