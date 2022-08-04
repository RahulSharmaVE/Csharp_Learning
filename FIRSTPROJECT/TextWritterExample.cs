using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIRSTPROJECT
{
     class TextWritterExample
    {
        static void Main(string[] args)
        {
            string path = @"E:\Text.txt";
            using(TextWriter tw=File.CreateText(path))
            {
                tw.WriteLine("hello world");
                tw.WriteLine("how are you");
            }
            Console.WriteLine("Text Created Sucessfully");
        }
    }
}
