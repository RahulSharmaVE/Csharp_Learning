using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    [Serializable]
    class Serial
    {
        public int age;
        public string name;
        public Serial(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

    }
     class Serializableuse
    {
        static void Main(string[] args)
        {
            string locn = @"E:\serializable\sample.pdf";
            Serial s1 = new Serial(19, "Rahul Sharma");
            FileStream fs = new FileStream(locn,FileMode.OpenOrCreate);
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(fs, s1);
            fs.Close();
            Console.WriteLine("File Created Successfully !!");
            Console.ReadLine();

        }
    }
}
