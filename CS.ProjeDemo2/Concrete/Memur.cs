using CS.ProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CS.ProjeDemo2.Concrete
{
    public class Memur : Personel
    {
        public int Derece { get; set; }
        public override string Unvan { get; set; } = "Memur"; 

        public Memur(string ad, string soyad, int calismaSaati,int year) : base(ad, soyad,calismaSaati, 0)  //Memur oluştururken alınan parametreleri temel sınıfa iletir.
        {
            Derece = DereceHesapla(year);
            SaatlikUcret = SaatlikUcretHesapla();
        }

        private int DereceHesapla(int year)
        {
            if (year >= 2022 && year < 2025)
                return 1;
            else if (year >= 2019 && year < 2022)
                return 2;
            else
                return 3;
        }

        private double SaatlikUcretHesapla()
        {
            switch (Derece)
            {
                case 1: return 600;
                case 2: return 700;
                case 3: return 800;
                default: return 500;
            }
        }

        public override double MaasHesapla()
        {
            if ((CalismaSaati*20) > 180)
            {
                AnaOdeme = SaatlikUcret * 180;
                Mesai = ((CalismaSaati*20) - 180) * (SaatlikUcret * 1.5);
                ToplamOdeme = AnaOdeme + Mesai;
                return ToplamOdeme;
            }
            else
            {
                AnaOdeme = SaatlikUcret * (CalismaSaati*20);
                ToplamOdeme = AnaOdeme;
                return ToplamOdeme;
            }
        }


    }
}
