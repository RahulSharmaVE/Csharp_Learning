using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    internal class Goto1
    {
        static void Main(string[] args)
        {
        inelegible:
            Console.WriteLine("You are not eligible for this Placement");

            Console.WriteLine("Enter your percentage : ");
            double per=Convert.ToDouble(Console.ReadLine());
            if(per<60)
            {
                goto inelegible;
            }
            else
            {
                Console.WriteLine("We Welcome you Onboard !!!!");
            }
        }
    }
}
