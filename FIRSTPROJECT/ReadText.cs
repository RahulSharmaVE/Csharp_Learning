using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class ReadText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File  to find ");
            //string path = @"E:\serializable\sample.txt"; //verbatim literal
            string path = Console.ReadLine();
            if (File.Exists(path))
            {
                Console.WriteLine("File Exist !!");
                string data=File.ReadAllText(path);
                Console.WriteLine(data);    
            }
            else
            {
                Console.WriteLine("File does'nt Exist !!");
            }
            Console.ReadLine();
        }
    }
}
