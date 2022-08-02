using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class CNSstatic
    {
        public static double pie;
        public static string name;
        
        static CNSstatic()
        {
            pie = 3.14;
            name = "Rahul Sharma";
            Console.WriteLine("Static Constructor Invoked !!");
        }
        public CNSstatic()
        {
            Console.WriteLine("Defaukt Constructor Invoked !!");
        }
        public static void getDetails()
        {
            Console.WriteLine("pie value :" + pie );
            Console.WriteLine("Name : " + name);
        }
    }
     class StaticCNSuse
    {
        static void Main(string[] args)
        {
            CNSstatic ob1=new CNSstatic();
            CNSstatic.getDetails();
            Console.ReadLine();
        }
    }
}
