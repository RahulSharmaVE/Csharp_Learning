using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class cnst
    {
        private cnst()
        { }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
     class Pvtconstuse
    {
        static void Main(string[] args)
        {
            cnst.getTime();
        }
    }
}
