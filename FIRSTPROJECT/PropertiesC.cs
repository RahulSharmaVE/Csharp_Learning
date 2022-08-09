using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class studentprop
    {
        private int _id;
        private string _name;
        private string _description;

        public int id
        {
          
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("please enter valid id......");
                }
                else
                {
                  this._id = value;
                }
            }
            get
            {

                return _id;
            }
        }



            public string name
        {
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter name.......");
                }
                else
                    this._name = value;
            }
            get
            {
                return _name;
            }
        }
        public string description
        {
            
            set
            {
                if(string .IsNullOrEmpty(value))
                {
                    Console.WriteLine("Plese enter the description......");
                }
                else
                    this._description = value;
                    
            }
            get
            {
                return _description;
            }
        }
    }

     class PropertiesC
    {
        static void Main(string[] args)
        {
            studentprop s1 = new studentprop();
            Console.WriteLine("Please Enter Student id");
            s1.id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Student Name");
            s1.name = Console.ReadLine();
            Console.WriteLine("Please Enter Student Description");
            s1.description = Console.ReadLine();
            Console.WriteLine("______________________________________________");
            Console.WriteLine();
            Console.WriteLine("Student Details are...........");
            Console.WriteLine("ID = " +s1.id);
            Console.WriteLine("Name = " + s1.name);
            Console.WriteLine("Description = " + s1.description);
            Console.ReadLine();
            //s1.id = -14;
            //s1.name = null;
            //s1.description = "";
            //Console.WriteLine(s1.id);
            //Console.WriteLine(s1.name);
            //Console.WriteLine(s1.description);
            //studentprop s2 = new studentprop();
            //s2.id = 3;
            //s2.name = "Rahul Sharma";
            //s2.description = "Software Developer Trainee";
            //Console.WriteLine(s2.id);
            //Console.WriteLine(s2.name);
            //Console.WriteLine(s2.description);
        }
    }
}
