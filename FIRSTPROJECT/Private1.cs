using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program100
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }

}
