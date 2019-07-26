using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.ClassBase;

namespace ConsoleApp1

{
    class BeyinCerrahi : Doktor
    {
        public override string Hastane()
        {
            return "Acıbadem Araştırma Hastanesi";
        }
        public override string Muayene()
        {
            return "7.Poliklinik";
        }
    }
}
