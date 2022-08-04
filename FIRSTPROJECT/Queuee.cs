using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
   class Queuee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Implementation.......");
            Queue<string> name = new Queue<string>();
            Console.WriteLine("Enter no of names you want to enter in the Queue........");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enqueue Function");
            Console.WriteLine("Enter Names...");
            for (int i = 0; i < no; i++)
            {
                name.Enqueue(Console.ReadLine());
            }
            Console.WriteLine("Peek Function");
            Console.WriteLine("Names are :");
            foreach(string s in name)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Dequeue Function Implementation");
            while(name.Count > 0)
            {
                Console.WriteLine(name.Dequeue());
            }
        }
    }
}
