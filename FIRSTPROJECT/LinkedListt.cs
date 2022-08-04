using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class LinkedListt
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "LinkedList implementation");
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("hello");
            list.AddLast("world");
            list.AddLast("whatss");
            list.AddLast("up!!");
            Console.WriteLine("print of the linked list is : ");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
                Console.WriteLine(" now to add elements in between the node");
            LinkedListNode<string> node = list.Find("whatss");
            list.AddBefore(node, "How");
            list.AddBefore(node, "are");
            list.AddBefore(node, "you !!");
            Console.WriteLine("Updated LinkedList is : ");
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
