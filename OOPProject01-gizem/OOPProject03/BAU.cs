using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject03
{//BAU classı veri üretmek için hazırlanmıştır.
   public class BAU
    {
        string[] Adlar = { "Şamil", "Cemal", "Ali", "Murat", "Kemal", "Şahin", "Hüseyin" };
        string[] Soyadlar = { "Yıldız", "Erkmen", "Kahraman", "Erdemir" };
        string[] Sehirler = { "Ankara", "İstanbul", "İzmir", "Eskişehir", "Adana" };
        static Random rnd = new Random();
        public string GetName()
        {
         
            int sayi1 = rnd.Next(0, Adlar.Length);
            return Adlar[sayi1];
        }
        public string GetSurname()
        {
           
            int sayi2 = rnd.Next(0, Soyadlar.Length);
            return Soyadlar[sayi2];
        }
        public string GetCity()
        {
            
            int sayi3 = rnd.Next(0, Sehirler.Length);
            return Sehirler[sayi3];
        }
        public DateTime GetBackDate(int year)
        {
          
            int tarih = rnd.Next(0, year);
            DateTime bugun = DateTime.Now;
            DateTime yenitarih = bugun.AddYears(-year);
            return yenitarih;
        }
        public DateTime GetForwardDate(int year)
        {
           
            int tarih = rnd.Next(0, year);
            DateTime bugun = DateTime.Now;
            DateTime ileritarih = bugun.AddYears(tarih);
            return ileritarih;
        }
        public LifeDurationInfo GetLifeDurations(DateTime birthDate)
        {
          
            LifeDurationInfo lfd = new LifeDurationInfo();
            int ty = DateTime.Now.Year - birthDate.Year;
            lfd.CalculatedAge = ty;
           

            TimeSpan ts =DateTime.Now.Subtract(birthDate);

            double td = ts.TotalDays;
            lfd.CalculatedDays = td;

            double th = ts.TotalHours;
            lfd.CalculatedHours = th;

            double tm = ts.TotalMinutes;
            lfd.CalculatedMinutes = tm;

            double tsc = ts.TotalSeconds;
            lfd.CalculatedSeconds = tsc;

            double tmsc = ts.TotalMilliseconds;
            lfd.CalculatedMiliseconds = tmsc;
            return lfd;
            
            
        }
            
    }
    
}
