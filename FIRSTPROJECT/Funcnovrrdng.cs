using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Funcnovrrdng
    {
        public virtual void flower()
        {
            Console.WriteLine("Flower is White in Colour");
        }
    }
    class Funcnovrrdnguse1 : Funcnovrrdng
    {
        public override void flower()
        {
            Console.WriteLine("Flower is Yellow in Colour");
        }
    }
    class floweroverride
    {
        public static void Main(string[] args)
        {
            
            Funcnovrrdng fn1 = new Funcnovrrdng();
            Console.WriteLine("Function without Overriding : ");
            Console.WriteLine();
            fn1.flower();
            Console.WriteLine();
            Funcnovrrdnguse1 fn = new Funcnovrrdnguse1();
            Console.WriteLine("Function After Overriding : ");
            Console.WriteLine();
            fn.flower();
            Console.ReadLine();
        }
    }
}
