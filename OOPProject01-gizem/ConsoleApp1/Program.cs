using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            KalpCerrahi kc = new KalpCerrahi();
            BeyinCerrahi bc = new BeyinCerrahi();

            kc.Hastane();
            bc.Muayene();
            kc.Sehir();

            Console.WriteLine("Randevu Bilgileriniz Aşağıdaki gibidir.");
            Console.WriteLine("Bölüm: BeyinCerrahi");
            Console.WriteLine("Hastanehane: " + kc.Hastane());
            Console.WriteLine("Poliklinik Bilgisi: " + bc.Muayene());
            Console.WriteLine("Bulunduğu Şehir: " + kc.Sehir());

            Console.ReadLine();

        }
    }
}

