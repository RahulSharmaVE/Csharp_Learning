using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//arraylist code

namespace FIRSTPROJECT
{
     class ArryLst
    {
        static void Main(string[] args)
        {
            ArrayList a1=new ArrayList(10);
            Console.WriteLine("Enter no of Elements of the List");
            int size=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<size;i++)
            {
                a1.Add(Console.ReadLine());
            }
            Console.WriteLine(a1.Count);
            Console.Write("Elements after insertion");
            Console.WriteLine();
            foreach(object obj in a1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

    }
}
