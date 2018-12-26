using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProjesiKısım2
{
    
    //Composite Teseni

    enum Gorevi
    {
        Yonetici = 1,
        Antrenor = 2,
        AntrenorYrd = 3,
        Futbolcu = 4
    }

    //component yapısı
    abstract class Gorevli
    {
        protected string Ad;
        protected string Soyad;
        protected string Yas;
        protected string Mevki;
        protected string Maas;
        protected string PiyasaDegeri;
        protected Gorevi gorev;
        public Gorevli(string Ad, Gorevi gorevi)
        {
            this.Ad = Ad;
        }
        public abstract void Goster(); //leaf ve composite uygulanacak
    }

    //Leaf yapısı
    class LeafSporcu : Gorevli
    {
        public LeafSporcu(string Ad,Gorevi gorevi) 
            :base(Ad,gorevi)
        {

        }
        public override void Goster()
        {
            Console.WriteLine("{0} {1}",base.gorev.ToString(),base.Ad);
        }
    }

    //Composite Yapısı

    class CompositeGorevli : Gorevli
    {
        List<Gorevli> Sporcular;
        public CompositeGorevli(string Ad,Gorevi gorevi)
            : base(Ad, gorevi)
        {
            Sporcular = new List<Gorevli>();
        }

        public void GorevliEkle(Gorevli s)
        {
            Sporcular.Add(s);
        }
        public override void Goster()
        {
            Console.WriteLine("{0} {1}",base.gorev.ToString(),base.Ad);
            foreach (Gorevli item in Sporcular)
            {
                item.Goster();
            }
        }
    }
}
