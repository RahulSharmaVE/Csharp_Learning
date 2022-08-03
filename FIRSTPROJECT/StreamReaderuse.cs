using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class StreamReaderuse
    {
        static void Main(string[] args)
        {
            string path = @"E:\file1.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    //int[] arr = new int[5];
                    //Console.WriteLine("enter array elements to write in the file");
                    //for (int i = 0; i < arr.Length; i++)
                    //{
                    //    arr[i] = Convert.ToInt32(Console.ReadLine());
                    //}
                    //foreach (int value in arr)
                    //{
                    //    sw.WriteLine(value);
                    //}
                    Console.WriteLine(sr.ReadToEnd());
                    Console.WriteLine("Readed Successfully..............");
                }
            }
        }
    }
}

