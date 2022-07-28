using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    internal class Funcn1use 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Function overloading !!!!");
            Funcn1 fcn = new Funcn1();
            Console.WriteLine("Enter total no of numbers you want to add");
                int ttl=Convert.ToInt32(Console.ReadLine());

            switch(ttl)
            { 
                case 0:
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter 2 numbers");
                        double no1=Double.Parse(Console.ReadLine());
                        double no2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Addition of 2 numbers is : ");
                        Console.WriteLine(fcn.add(no1,no2));
                    }
                    break;
                    case 3:
                    { 
                        Console.WriteLine("Enter 3 numbers");
                        double no1 = Double.Parse(Console.ReadLine());
                        double no2 = Double.Parse(Console.ReadLine());
                        double no3 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Addition of 3 numbers is : ");
                        Console.WriteLine(fcn.add(no1, no2,no3));

                    }
                    break ;
                    case 4:
                    {
                        Console.WriteLine("Enter 4 numbers");
                        double no1 = Double.Parse(Console.ReadLine());
                        double no2 = Double.Parse(Console.ReadLine());
                        double no3 = Double.Parse(Console.ReadLine());
                        double no4 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Addition of 4 numbers is : ");
                        Console.WriteLine(fcn.add(no1, no2, no3, no4));

                    }
                    break;
                    default:
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                    break;


            }

        }
    }
}
