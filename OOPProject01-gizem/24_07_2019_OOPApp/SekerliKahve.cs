using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_07_2019_OOPApp
{
    class SekerliKahve:Kahve
    {
        public override bool Seker()
        {
            return true ;
        }
        public override string Sut()
        {
            return "hayır";
        }
        
    }
}
