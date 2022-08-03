using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIRSTPROJECT
{
    class CopyFile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File  to find ");
            //string path = @"E:\serializable\sampletext1.txt"; //verbatim literal
            string path1 = Console.ReadLine();
            if (File.Exists(path1))
            {
                Console.WriteLine("File Exist !!");
                //string data = File.ReadAllText(path);
                //Console.WriteLine(data);
                Console.WriteLine("Enter second path you want to copy");
                string path2=Console.ReadLine();
                File.Copy(path1, path2); //1st overloaded method takes 2 arguments
                File.Copy(path2 , path1,true); //2nd overloaded method takes 3 arguments
                Console.WriteLine("File Copied Successfully.....");
            }
            else
            {
                Console.WriteLine("File does'nt Exist !!");
            }
            Console.ReadLine();
        }
    }
}
