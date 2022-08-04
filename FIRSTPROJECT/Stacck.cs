using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class Stacck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Implementation.........");
            Stack<string> st = new Stack<string>();
            Console.WriteLine("Enter no of names which want to enter : ");
            int no=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter names......");
            for(int i=0;i<no;i++)
            {
                st.Push(Console.ReadLine());
            }
            Console.WriteLine("No of elements in stack are : ");
            foreach(string s in st)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Topmost element in the Stack is : ");
            Console.WriteLine(st.Peek());
            Console.WriteLine("Pop Function implementation : ");
            while(st.Count > 0)
            {
                Console.WriteLine(st.Pop());
            }
            Console.WriteLine("Peek Now..........");
            Console.WriteLine(st.Peek);
        }
    }
}
