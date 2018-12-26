using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProjesiKısım2
{
    public class Veri
    {
        //public static List<Veri> oyuncuListesi = new List<Veri>();
        //public List<Veri> transferListesi = new List<Veri>();

        string ad;
        string soyad;
        string yas;
        string maas;
        string mevki; 
        string piyasaDegeri;
        string spordali;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        public string Mevki
        {
            get { return mevki; }
            set { mevki = value; }
        }

        public string Maas
        {
            get { return maas; }
            set { maas = value; }
        }

        public string PiyasaDegeri
        {
            get { return piyasaDegeri; }
            set { piyasaDegeri = value; }
        }

        public string SporDali
        {
            get { return spordali; }
            set { spordali = value; }
        }
    }
}
