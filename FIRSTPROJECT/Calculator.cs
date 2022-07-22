using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class Calculator
    { 

        static void Main(string[] args)
        {
            //hello
            double num1,num2;
            int choice;
            Console.WriteLine("Welcome To The Calculator");
            Console.WriteLine("Functions");
            Console.WriteLine("1. Addition" +
                              "2. Subtraction" +
                              "3. Division" +
                              "4.Multiplication");
            Console.WriteLine("Enter your choice");
            choice=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Console.WriteLine("The sum of numbers is :" + (num1 + num2));
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("The subtraction of numbers is :" + (num1 - num2));
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("The Division of numbers is :" + (num1 / num2));
                    }
                    break ;
                    case 4:
                    {
                        Console.WriteLine("The multiplication of numbers is :" + (num1 * num2));
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}
