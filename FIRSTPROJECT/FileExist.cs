using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIRSTPROJECT
{
     class FileExist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File  to find ");
            //string path = @"E:\serializable\sample.txt"; //verbatim literal
            string path = Console.ReadLine();
            if(File.Exists(path))
            {
                Console.WriteLine("File Exist !!");
            }
            else
            {
                Console.WriteLine("File does'nt Exist !!");
            }
            Console.ReadLine();

        }
    }
}
