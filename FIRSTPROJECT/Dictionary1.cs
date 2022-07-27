using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    class Dictionary1
    {
        public static void Main(string[] args)//
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            Console.WriteLine("Enter number of elements in Dictionary");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SNO AND NAME");
            for (int i = 0; i < size; i++)
            {
                int sno = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                dict1.Add(sno, name);
            }
            Console.WriteLine("Elements entered are:");
            foreach (KeyValuePair<int, string> kvp in dict1)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }


        }
    }


