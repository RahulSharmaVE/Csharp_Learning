using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Paramuse
    {
        public static int add(params int[] value)
        {
            int sum = 0;
            foreach(int num in value)
            {
                sum=sum+num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Paramuse.add(14,54,454,2477));
        }
    }
}
