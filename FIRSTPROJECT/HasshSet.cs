﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    
    class HasshSet
    {
        static void Main(string[] args)
        {
            // HashSet<string> hs1 = new HashSet<string>();
            //   Console.WriteLine("Hashset Example : ");
            SortedSet<string> set = new SortedSet<string>();
            Console.WriteLine("Sortedset Example : ");
            Console.WriteLine("Enter no of names you want to enter.....");
            int no=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names below : ");
            for(int i = 0; i < no; i++)
            {
                set.Add(Console.ReadLine());
            }
            Console.WriteLine(  "names after enter is : ");
            foreach(string s1 in set)
            {
                Console.WriteLine(s1);
            }
            Console.WriteLine("Enter name which you want to delete :");
            set.Remove(Console.ReadLine());
            //Console.WriteLine("Updated Hashset is..............");
            Console.WriteLine("Updated Sortedset is..............");
            foreach (string s in set) 
            {
                Console.WriteLine(s);
            }
            }
        }
    }

