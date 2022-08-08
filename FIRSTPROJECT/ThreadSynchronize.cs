using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class ThreadSynchronize
    {
        public static object _locker=new object();
        public static void funcn()
        {
           // lock(_locker)
            Monitor.Enter(_locker);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("thread is sleeping for 5 sec......");
                }
            }
            Monitor.Exit(_locker);

        }
        static void Main(string[] args)
        {
           // ThreadSynchronize thr=new ThreadSynchronize();
            Thread t1=new Thread(funcn);
            Thread t2=new Thread(funcn);
            t1.Start();
            t2.Start();
        }
    }
}
