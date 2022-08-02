using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
     class Mldmnarr
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] sum = new int[3, 3];
            Console.WriteLine("Enter The elements in first array ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    arr1[i, j] =Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements in second array ");
            for(int m=0;m < 3; m++)
            {
                for(int n=0;n < 3; n++)
                {
                    arr2[m, n] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Console.WriteLine("The sum of 2D Arrays is :  ");
            for (int s = 0;s<3;s++)
            {
                for(int t=0;t<3;t++)
                {
                    sum[s, t] = arr1[s, t]+ arr2[s, t];
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************");
            Console.WriteLine("The sum of 2D Arrays is :  ");
            for(int a=0;a<3;a++)
            {
                for(int b=0;b<3;b++)
                {
                    Console.WriteLine(sum[a,b]);
                }
            }


        }
    }
}
