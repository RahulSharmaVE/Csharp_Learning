using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class TextReaderExample
    {
        static void Main(string[] args)
        {
            string path = @"E:\Text.txt";
            using (TextReader tr = File.OpenText(path))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.WriteLine("Text Readed Successfully...............");
        }
    }
}
