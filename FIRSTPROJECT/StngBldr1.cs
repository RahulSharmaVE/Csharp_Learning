using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class StngBldr1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder Program !!!!");
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter First Name");
            string s1=Console.ReadLine();
            sb.Append(s1);
            Console.WriteLine("Enter last name");
            string s2=Console.ReadLine();
            sb.Append(s2);
            Console.WriteLine("Name is : " +sb);
            Console.WriteLine("Appendformat function : ");
            StringBuilder sb1 = new StringBuilder();
            //Console.WriteLine(sb.ToString());
            sb1.AppendFormat("{0:N}",1323 );
            Console.WriteLine(sb1);
            Console.WriteLine("Insert Function : ");
            StringBuilder sb2 = new StringBuilder("Hello World!!");
            Console.WriteLine("Default input is : " +sb2);
            sb2.Insert(5, " C#");
            Console.WriteLine(sb2);
            Console.WriteLine("Remove  Function : ");///
            StringBuilder sb3 = new StringBuilder("Hello World!!");
            Console.WriteLine("Default input is : " + sb3);
            sb3.Remove(5,2);
            Console.WriteLine(sb3);
            Console.WriteLine("Replace Function : ");
            StringBuilder sb4 = new StringBuilder("Hello World!!");
            Console.WriteLine("Default input is : " + sb4);
            sb4.Replace("World", "C#");
            Console.WriteLine(sb4);
            Console.WriteLine("ToString  Function : ");
            string str = sb.ToString();
            Console.WriteLine(str);


            
        }
    }
}
