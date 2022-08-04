using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace FIRSTPROJECT
{
    //[Serializable]
    //class Student
    //{
    //    public int age;
    //    public string name;
    //    public Student(int age, string name)
    //    {
    //        this.age = age;
    //        this.name = name;
    //    }
    //}

    class Deserializationuse
    {
        static void Main(string[] args)
        {

            string locn = @"E:\Rahul_name.txt";
            using (FileStream fs1 = new FileStream(locn, FileMode.OpenOrCreate))
            {
                BinaryFormatter bnrfmtr = new BinaryFormatter();
                Student s1=(Student)bnrfmtr.Deserialize(fs1);

                Console.WriteLine("student age :" + s1.age);
                Console.WriteLine("student name : " + s1.name);
            }
            Console.WriteLine("Deserialization Successful................");

        }
    }
}
