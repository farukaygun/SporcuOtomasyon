using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NesneProjesiKısım2.FacadePattern;

namespace NesneProjesiKısım2
{
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());


            //Template Pattern

            TransferGorusme t1 = new FutbolcuA();
            t1.TemplateMethodu();
            Console.WriteLine("******************");
            TransferGorusme t2 = new BasketbolcuA();
            t2.TemplateMethodu();


            //Composite
            //ilk olarak Root Composite yi oluşturuyoruz.
            CompositeGorevli Yonetici = new CompositeGorevli("Furkan Baltacı", Gorevi.Yonetici);
            //Genel müdürün altında çalışan diğer çalışanları hiyerarşik olarak ekliyoruz
            //Futbolcu en alt seviye görevli ve Leafden alıyoruz onları.
            CompositeGorevli Antrenor = new CompositeGorevli("Ahmet ", Gorevi.Antrenor);
            Antrenor.GorevliEkle(new LeafSporcu("kadir ", Gorevi.Futbolcu));
            Antrenor.GorevliEkle(new LeafSporcu("ahmet ", Gorevi.Futbolcu));
            //Root komposite altındaki Composite yi ekliyoruz.
            Yonetici.GorevliEkle(Antrenor);
            //Composite için döngü ile altındaki Calisan sınıfları, Leaf için sadece kendisi
            Yonetici.Goster();

            /********************************************************/
            //Adapter Pattern

            //Futbolcu satma sistemine basketbolcu satma özelliği adapte ettik.
            AdapterTarget target = new Adapter();
            target.SatılıkFutbolcu();


            /*********************************************/
            //Command Pattern
            //Duduk nesnesi oluşturduk
            Duduk duduk = new Duduk();
            //Duduk komutları oluşturuyoruz.
            DudukCalKomutu dudukCal = new DudukCalKomutu(duduk);
            DudukSusKomutu dudukSus = new DudukSusKomutu(duduk);
            //Duduk Ufleme nesnesi oluşturuyoruz.
            DudukUfle ufle = new DudukUfle(dudukCal ,dudukSus);
            ufle.Ufle();
            ufle.Bırak();


            //Facade Tasarım Deseni
            //Önyüz sınıfından nesne oluşturduk
            Takım takım = new Takım();
            //Takıma iş yaptırdık.
            takım.Baslat();

            Console.Read();
        }
    }
}
