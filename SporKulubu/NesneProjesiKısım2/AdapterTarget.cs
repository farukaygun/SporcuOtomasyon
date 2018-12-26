using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProjesiKısım2
{
    class AdapterTarget
    {
        //Sadece Futbolcular satılık.
        public virtual void SatılıkFutbolcu()
        {
            Console.WriteLine("Futbolcu satılık listesine eklendi.");
        }
    }
    class Adaptee
    {
        //Spor kulübü basketbolcuda satmaya karar verdi. Sisteme Adapte olacak.
        public void SatılıkBasketbolcu()
        {
            Console.WriteLine("Basketbolcu satılık listesine eklendi.");
        }
    }

    class Adapter:AdapterTarget
    {
        private Adaptee _adaptee = new Adaptee();
        public override void SatılıkFutbolcu()
        {
            _adaptee.SatılıkBasketbolcu();
        }

    }
}
