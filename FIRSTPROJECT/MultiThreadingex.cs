using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FIRSTPROJECT
{
     class MultiThreadingex
    {
        public static void fun1()
        {
            for(int i = 0; i <=50; i++)
            {
                Console.WriteLine("Fun1 = "+ i);
            }
        }
        public static void fun2()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Fun2 = " + i);
                if(i==35)
                {
                    Console.WriteLine("thread is sleeping for 10 sec.........");
                    Thread.Sleep(10000);

                }
            }
        }
        public static void fun3()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Fun3 = " + i);
                if (i == 35)
                {
                    Console.WriteLine("thread is sleeping for 9 sec.........");
                    Thread.Sleep(9000);

                }
            }
        }
        static void Main(string[] args)
        {
            //MultiThreadingex.fun1();
            //MultiThreadingex.fun2();
            //MultiThreadingex.fun3();
           
            Thread t1=new Thread(fun1);
            Thread t2=new Thread(fun2);
            Thread t3=new Thread(fun3);
           
            t2.Start();
            t1.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
