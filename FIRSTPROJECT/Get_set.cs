using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Gset1
    {
        private string name;
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
      class Get_set
    {
        static void Main(string[] args)
        {
            Gset1 ob1 = new Gset1();
            Console.WriteLine("Enter name");
            string nme= Console.ReadLine();
            ob1.Name = nme;
            Console.WriteLine("name is :");
            Console.WriteLine(ob1.Name);
        }
    }
}
