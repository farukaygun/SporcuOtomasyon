using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProjesiKısım2
{  //Template Methodu
    enum OdemeTipi
    {      
        Pesin=1,Taksit=0    
      
    }
   abstract class TransferGorusme
    {
        protected string SporcuAdi;
        protected OdemeTipi odemeTipi;

        //Başlat ve Bitir sabit işlemlerimiz.
        void Baslat()
        {
            Console.WriteLine("Görüşme Başladı.");
        }
        void Bitir()
        {
            Console.WriteLine("Görüşmeler bitti.  {0}, {1} yöntemi ile transfer edilmiştir.",SporcuAdi,odemeTipi);
        }

        //Sporcu ve Ödeme şekli değişkenlik gösterir.O yüzden soyut yaptık
        //Kalıtım alanlara uygulanacak ve içleri dolacaktır.
        abstract public void Sporcu();
        abstract public void OdemeSekli();
        public void TemplateMethodu()
        {
            Baslat();
            Bitir();
            Sporcu();
            OdemeSekli();
        }
    }
    //concrete class Futbolcu

   //Değişken olan methodları burda,özelliklerine göre doldurduk
    class FutbolcuA : TransferGorusme
    {
        public override void OdemeSekli()
        {
            odemeTipi = 0;
        }

        public override void Sporcu()
        {
            SporcuAdi = "Futbolcu A";
        }
    }
    //concrete class Basketbolcu
    class BasketbolcuA : TransferGorusme
    {
        public override void OdemeSekli()
        {
            odemeTipi =0;  
        }

        public override void Sporcu()
        {
            SporcuAdi = "BasketbolcuA";
        }
    }
}
