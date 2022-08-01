using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Mdfiers
    {
        protected string first_name;
        private string middle_name;
        public string last_name;

        public string Middle_name
        {
            get { return middle_name; }
            set { middle_name = value; }
        }
    }
     class Acssmdfrs : Mdfiers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first name");
            string firstnme= Console.ReadLine();
            Console.WriteLine("middle name");
            string middlenme= Console.ReadLine();
            Console.WriteLine("last name");
            string lastnme= Console.ReadLine();
            Acssmdfrs ob1=new Acssmdfrs();
            ob1.first_name = firstnme;
            ob1.Middle_name = middlenme;
            ob1.last_name = lastnme;
            Console.WriteLine("Full name is : ");
            Console.WriteLine(ob1.first_name +" "+ob1.Middle_name+" "+ob1.last_name);
            Console.ReadLine();
        }
    }
}
