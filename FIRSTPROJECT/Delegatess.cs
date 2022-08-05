using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    public delegate void Calculation(int a, int b);
     class Delegatess
    {
        public static void addition(int a,int b)
            {
            int sum=a+b;
            Console.WriteLine("addition is: "+sum);
        }
        public static void subtraction(int a, int b)
        {
            int sum = a - b;
            Console.WriteLine("subtraction is:  " + sum);
        }
        public static void multiplication(int a, int b)
        {
            int sum = a * b;
            Console.WriteLine("Multiplication is:  " + sum);
        }
        public static void division(int a, int b)
            {
                int sum = (a / b);
            Console.WriteLine("division is:  " + sum);
        }
       

        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Delegatess.addition);
            obj.Invoke(40, 56);
            obj=new Calculation(Delegatess.subtraction);
            obj.Invoke(10, 5);
            obj = new Calculation(Delegatess.division);
            obj.Invoke(4, 2);
            obj = new Calculation(Delegatess.multiplication);
            obj.Invoke(2, 3);
            Console.WriteLine("Delegates Completed.......");
        }
    }
}
