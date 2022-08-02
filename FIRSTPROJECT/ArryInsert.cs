using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
   class ArryInsert
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            Console.WriteLine("Enter names :");
            for(int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("____________________________");
            Console.WriteLine("Names are : ");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
    //sum of array elements
     class Sum
    {
        static void Main(string[] args)
        {
            double[] sum = new double[10];
            double sum2 = 0;
            Console.WriteLine("Enter numbers for addition : ");
            for(int j=0;j<sum.Length;j++)
            {
                sum[j]=Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < sum.Length; i++)
            {
                sum2=sum2+ sum[i];
            }
            Console.WriteLine("Sum is : "+sum2);
        }
        
        
      }


}
