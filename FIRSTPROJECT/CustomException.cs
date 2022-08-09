using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class InvalidAgeException :Exception
    {
        public InvalidAgeException(string message) :base(message)
            {
        }
    }
     class CustomException
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age......");
            int age =Convert.ToInt32(Console.ReadLine());
            try
            {
                if(age<18)
                {
                    throw new InvalidAgeException("Age is less than 18 years !!");
                }
                else
                    Console.WriteLine("Your Age is perfect to vote !!!");
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
