using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    interface Ianimal
    {
        public void sound();
    }
    class Lion : Ianimal
    {
        public void sound()
        {
            Console.WriteLine("Roar Roar !!");
        }
    }
    class sound
    {
        public static void Main(string[] args)
        {
            Lion l1 = new Lion();
            l1.sound();
        }
    }
}
