using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class GUIDuse
    {
        static void Main(string[] args)
        {
            Guid g = Guid.NewGuid();
            Console.WriteLine(g.ToString()); //gives  36 characters including hypens
            Console.WriteLine(g.ToString("N"));//to remove Hypens from the O/P
        }
    }
}
