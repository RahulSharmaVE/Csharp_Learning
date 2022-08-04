using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    [Serializable]
    class Student
    {
        public int age;
        public string name;
        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

    }
     class Serializableuse
    {
        static void Main(string[] args)
        {
            string locn = @"E:\Rahul_name.txt";
            Student s1 = new Student(22, "Rahul Sharma");
            FileStream fs = new FileStream(locn,FileMode.OpenOrCreate);
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(fs, s1);
            fs.Close();
            Console.WriteLine("File Created Successfully !!");
            Console.ReadLine();

        }
    }
}
