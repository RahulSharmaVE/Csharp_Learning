using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Hshtble
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            //ht.Add("name", "Rahul");
            //ht.Add("course", "Btech");
            //ht.Add("Branch", "CSE");
            //ht.Add("Desigination", "Software Developer");
            //ht.Add("Hobbies", "Travelling");
            //ht.Add("age",19);
            //ht.Remove("Hobbies");
            ////Console.WriteLine(ht["name"]);
            ////Console.WriteLine(ht["course"]);
            ////Console.WriteLine(ht["Branch"]);
            ////Console.WriteLine(ht["Desigination"]);
            ////Console.WriteLine(ht["Hobbies"]);
            //foreach(object key in ht.Values)
            //{
            //    Console.WriteLine(key);
            //}
            //Console.ReadLine();
            Console.WriteLine("Enter no of Elements you want to enter in key-value pair");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the keys and values");
            for (int i = 0; i < size; i++)
            {

                ht.Add(Console.ReadLine(), Console.ReadLine());
            }
            Console.WriteLine("The Enteries You Have Entered Are : ");
            Console.WriteLine("keys are : ");
            foreach(object ob in ht.Keys)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("Values are : ");
            foreach(object ob1 in ht.Values)
            {
                Console.WriteLine(ob1);
            }
            Console.WriteLine("Enter key which you want to remove : ");
            ht.Remove(Console.ReadLine());
            Console.WriteLine("Check the specific key present in the HashTable");
            {
                Console.WriteLine(ht.ContainsKey(Console.ReadLine())); 
            }
            Console.WriteLine(" Check the specific value Present in the HashTable");
            {
                Console.WriteLine(ht.ContainsValue(Console.ReadLine())); 

            }
            //Console.WriteLine("Enter the Key/value for which you want to get the Hashcode");

            // int hcde= ht.GetHashCode(Console.ReadLine());
            //Console.WriteLine(hcde);



        }
    }
}
