using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Cpycnstrt1
    {
        public string name;
        public int age;
        public Cpycnstrt1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //public void getdata()
        //{
        //    Console.WriteLine(name +" "+age);
        //}
        public Cpycnstrt1(Cpycnstrt1 e)
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getdata11()
        {
            Console.WriteLine(name +"  "+ age);
        }
    }
    class Constrtuse
    {
        static void Main(string[] args)
        {
            Cpycnstrt1 ob1 = new Cpycnstrt1("Rahul Sharma",22);
            //ob1.name = ;
            //ob1.age = 22;
            Console.WriteLine("constructor output");
            //+ob1.getdata();
            Cpycnstrt1 ob2 = new Cpycnstrt1(ob1);
            Console.WriteLine("Copy constructor output");
            ob2.getdata11();
        }
    }
}
