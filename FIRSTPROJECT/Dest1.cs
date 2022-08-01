using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    public class Dest1
    {
        public Dest1()
        {
            Console.WriteLine("This is Constructor Running");
        }
        ~Dest1()
            {
            Console.WriteLine("Destructor is Running");
            }
    }
    class Destuse
    {
        public static void Main(string[] args)
        {
            Dest1 dest1 = new Dest1();
            Dest1 dest2 = new Dest1();
        }
    }
}
