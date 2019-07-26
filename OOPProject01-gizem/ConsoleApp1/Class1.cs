using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.ClassBase;

namespace OOPProject01
{
    class KalpCerrahi : Doktor
    {
        public override string Hastane()
        {
            return "Okmeydanı Araştırma Hastanesi";
        }
    }
}

