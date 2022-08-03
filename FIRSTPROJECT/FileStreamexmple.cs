using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class FileStreamexmple
    {
        static void Main(string[] args)
        {
            string path = @"E:\file1.txt";
            FileStream fs = new FileStream(path, FileMode.Append,FileAccess.Write);
            Console.WriteLine("Enter what you want to write in the file");
            string s1=Console.ReadLine();
            byte[] writedata=Encoding.UTF8.GetBytes(s1);
            fs.Write(writedata, 0, writedata.Length);
            //fs.WriteByte(66);
            Console.WriteLine("file Written");
            fs.Close();
        }
    }
}
