using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class List1
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            Console.WriteLine("Enter the no of numbers you want to enter");
            int size=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter numbers");
            for (int i=0; i<size; i++)
            {
                int no1 = Convert.ToInt32(Console.ReadLine());
                number.Add(no1);
            }
            Console.WriteLine("Numbers you have entered");
            foreach(int s in number)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();



        }
    }

