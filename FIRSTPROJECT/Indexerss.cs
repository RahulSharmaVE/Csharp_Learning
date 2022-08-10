using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class IndexersUse
    {
        private int[]Age=new int[4];

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {

                    if (value < 0)
                    {
                        Console.WriteLine("Age must be greater than 0....");
                    }
                    else
                    {
                        Age[index] = value;
                    }
                }
                else
                {
                    Console.WriteLine("Out of range...");
                }
            }
            get {
                return Age[index];
            }
           
        }

    }
     class Indexerss
    {
        static void Main(string[] args)
        {
            IndexersUse ob=new IndexersUse();
            ob[0] = 12;
            ob[1] = 11;
            ob[2] = -45;
            ob[3] = 15;
            //ob[4] = 12;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ob[i]);
            }

        }
    }
}
