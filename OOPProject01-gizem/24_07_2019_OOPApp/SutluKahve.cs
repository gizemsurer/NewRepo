using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_07_2019_OOPApp
{
    class SutluKahve:Kahve
    {
      
        public override string Sut()
        {
            return "evet";
        }
        //public override int Adet()
        //{
        //   ClassSutluKahve SutluKahve = new ClassSutluKahve();

        //   return SutluKahve.Adet();
        //}
        public override bool Seker()
        {
            return false;
        }
        public override string KahveTozu()
        {
            return "koyu kahve";
        }
    }
}
