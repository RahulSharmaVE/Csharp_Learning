// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //float a=0.0f;
            //Console.WriteLine("enter number");
            //a=Single.Parse(Console.ReadLine());
            //Console.WriteLine("float no " + a);
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = $"My full name is: {firstName} {lastName}";
            //Console.WriteLine(name);
            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName); 
        }
    }
}