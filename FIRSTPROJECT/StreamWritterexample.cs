using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class StreamWritterexample
    {
        static void Main(string[] args)
        {
            string path = @"E:\file1.txt";
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    int[] arr = new int[5];
                    Console.WriteLine("enter array elements to write in the file");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                        foreach(int value in arr)
                    {
                        sw.WriteLine(value);
                    }
                    Console.WriteLine("written Successfully..............");
                }
            }
            
            //Console.WriteLine("Enter what you want to write in the file");
            //string s1 = Console.ReadLine();
            //byte[] writedata = Encoding.UTF8.GetBytes(s1);
            //fs.Write(writedata, 0, writedata.Length);
            ////fs.WriteByte(66);
            //Console.WriteLine("file Written");
            //fs.Close();

        }
    }
}
