using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIRSTPROJECT
{ class DirectoryExample
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is Directory Example -- ");
            //Console.WriteLine("Enter the location in which you want to create the Directory ");
            //string path = Console.ReadLine();
            
            //dir.Create();
            //Console.WriteLine("Enter the sub directory name ");
            //string subdir=Console.ReadLine();
            //dir.CreateSubdirectory(subdir);
            string path = @"E:\My Directory";
            string path2 = @"E:\My Directory2";
            string path3 = @"E:\My Directory2\name";
            DirectoryInfo dir = new DirectoryInfo(path3);
            //DirectoryInfo[] dir2 = dir.GetDirectories();
            //foreach (var value in dir2)
            //{
            //    Console.WriteLine(value);
            //}
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Root);
            Console.WriteLine(dir.LastWriteTime);
            //dir.Create();
            //dir.MoveTo(path2);
            //dir.Delete(true);
            // Console.WriteLine("Directory Moved Successfully............");
            Console.ReadLine();
        }
    }
}
