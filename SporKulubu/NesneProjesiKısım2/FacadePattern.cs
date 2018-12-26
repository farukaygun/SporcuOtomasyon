using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProjesiKısım2
{
    class FacadePattern
    {
        
        public class Defans
        {
            public void Yukle(String mevki)
            {
                Console.WriteLine("Oyuncuya" + mevki + "özelliği eklendi.");
            }
        }
        public class OrtaSaha
        {
            public void AntremanYap()
            {
                Console.WriteLine("Antreman Yapıldı.");
            }

            public void MevkiEkle(string mevki)
            {
                Console.WriteLine(mevki + "Eklendi");
            }
        }
        public class Bilgi
        {
            public string Bilgilendir(string mevki)
            {
                return "Defans oyuncusuna ve OrtaSahaya"+mevki+"Özelliği eklendi." ;
            }
        }

        //Facade Pattern
        public class Takım
        {
            public void Baslat()
            {
                OrtaSaha ortaSaha = new OrtaSaha();
                Defans defans = new Defans();
                Bilgi bilgi = new Bilgi();

                ortaSaha.MevkiEkle("defans");
                string a = bilgi.Bilgilendir("ortasaha");
                Console.WriteLine(a);
                defans.Yukle("ortasaha");

                ortaSaha.AntremanYap();
            }
        }




    }
}
