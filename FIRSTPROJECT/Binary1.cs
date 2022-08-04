using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    internal class Binary1
    {
        static void Main(string[] args)
        {
            string fileName = @"E:\binaryfile.dat";
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    Console.WriteLine("Double Value : " + reader.ReadDouble());
                    Console.WriteLine("String Value : " + reader.ReadString());
                    Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
                }
            }
        }
    }
}
