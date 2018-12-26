using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NesneProjesiKısım2
{
    public interface IKomut
    {
        //Düdüğü çalıştırma ve kapatmak için Komut interfacesi.
        void calistir();

    }

    public class DudukCalKomutu : IKomut
    {
        public  Duduk duduk;

        public DudukCalKomutu(Duduk duduk)
        {
            this.duduk = duduk;
        }

        public void calistir()
        {
            duduk.Cal();
        }
    }
        public class Duduk
        {
            public void Cal()
            {
                Console.WriteLine("Düdük Çalındı.");
            }
            public void Sus()
            {
                Console.WriteLine("Düdük susturuldu.");
            }
        }
    

    public class DudukSusKomutu : IKomut
    {
        public  Duduk duduk;
        public DudukSusKomutu (Duduk duduk)
        {
            this.duduk = duduk;
        }

        public void calistir()
        {
            duduk.Sus();
        }
    }

    public class DudukUfle
    {
        public  IKomut ufleKomutu;
        public IKomut susKomutu;
        public DudukUfle (IKomut ufleKomutu,IKomut susKomutu)
        {
            this.ufleKomutu = ufleKomutu;
            this.susKomutu = susKomutu;
        }
        public void Ufle()
        {
            ufleKomutu.calistir();
        }
        public void Bırak()
        {
            susKomutu.calistir();
        }
    }
}






