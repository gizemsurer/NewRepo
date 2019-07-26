using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_07_2019_OOPApp
{ class Program
    {
        static void Main(string[] args)
        {
            SutluKahve sutluKahve = new SutluKahve();
            int sonuc =sutluKahve.Adet();
            string sut = sutluKahve.Sut();
            string kahve = sutluKahve.KahveTozu();
            Console.WriteLine(sonuc + " bardak sütlü kahve içilmiş ");
            Console.WriteLine("süt ister misiniz?  "  + sut);
            Console.WriteLine("kahvem "  + kahve +  " olsun ");
            Console.ReadLine();

            SekerliKahve sekerliKahve=new SekerliKahve();
            bool seker = sekerliKahve.Seker();
            string Sut = sekerliKahve.Sut();
            Console.WriteLine("şekerli mi ? " + seker);
            Console.WriteLine("süt ister misiniz? " + Sut);
            Console.ReadLine();
            
            //Console.WriteLine("açık kahve");
            //Console.WriteLine("krema aromalı");
            //Console.ReadLine();
        }
    }
   abstract class  Kahve
    {
        
        public virtual string KahveTozu()
        {
            return "açık kahve";
           
        }
       
        public abstract string Sut();
        public abstract bool Seker();
        private  string Aroma()
        {
            return "krema aromalı";
        }
        
        public virtual int Adet()
        {
            return 100;
        }
        
    }
    
}
