using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CS.ProjeDemo2.Abstract
{
    public abstract class Personel
    {
        private int _id;
        [JsonIgnore] //Json işleminde dikkate alınmaz.
        public int ID 
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _ad;

        public string Ad
        {
            get { return _ad.ToUpper(); }
            set { _ad = value; }
        }

        private string _soyad;

        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set { _soyad = value; }
        }
         
        private int _calismaSaati;
       
        public int CalismaSaati
        {
            get {return _calismaSaati;}
            set
            {
                if (value >= 0)
                    _calismaSaati = value;
                else
                    throw new Exception("Çalışma Saati 0 veya 0 dan büyük olmalıdır.");
            }
        }

        private double _saatlikUcret;
   
        public double SaatlikUcret
        {
            get {return _saatlikUcret;}
            set
            {
                if (value >= 0)
                    _saatlikUcret = value;
                else
                    throw new Exception("Saatlik Ücret 0 veya 0 dan büyük olmalıdır.");
            }
        }
       
        public double ToplamOdeme { get; set; }
       
        public double AnaOdeme { get; set; }
       
        public double Mesai { get; set; }
        public abstract string Unvan { get; set; }
        [JsonIgnore]
        public int Year { get; set; }

        public abstract double MaasHesapla(); //Ezilmek zorunda olduğundan abstract tanımlandı.Farklı hesaplamalar yapılacak.

        public Personel(string ad,string soyad,int calismaSaati,double saatlikucret) //Personel nesnesi oluştururken parametreye girilen değerler Propertyde ki değerlere atanır.
        {
            Ad = ad;
            Soyad=soyad;
            CalismaSaati=calismaSaati;
            SaatlikUcret=saatlikucret;
        }
    }
}
