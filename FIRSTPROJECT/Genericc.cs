using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FIRSTPROJECT
{
    class Gen1
    {
        //public Gen1(T msg)
        //{
        //    Console.WriteLine(msg);
        //}
        public void message<T>(T msg)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Generic Class Created Sucessfully");
        }
    }



        class Genericc
        {
            static void Main(string[] args)
            {
                Gen1 gen = new Gen1();
                //Gen1<int> genI = new Gen1<int>(101);
                //Gen1<char> getCh = new Gen1<char>('I');
                gen.message("Hello world");
            gen.message('a');
            gen.message(54541554);
            Console.ReadLine();
            }
        }
    }
