using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class Animal_Details
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inheritance  implementation : ");
            Tiger_Animal tgr = new Tiger_Animal();
            tgr.sleep();
            tgr.walk();
            tgr.carnivore();
            tgr.eat();

        }
    }
}
