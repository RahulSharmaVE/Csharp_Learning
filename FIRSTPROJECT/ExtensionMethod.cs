using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class ExtensionMethod
    {
        public void funcn1()
        {
            Console.WriteLine("This is 1st function........");
        }
       public void funcn2()
        {
            Console.WriteLine("This is 2nd function........");
        }

        static void Main(string[] args)
        {
            ExtensionMethod method = new ExtensionMethod();
            method.funcn1();
            method.funcn2();
        }
    }
    static class MethodBind //static class for binding extension class
    {
       public static void funcn3(this ExtensionMethod e,int num) //Binding Parameter
        {
            Console.WriteLine("This is 3rd function.......");
            Console.WriteLine("The number is : "+num);
        }
    }

    class TestExtensionMethod
    {
        static void Main(string[] args)
        {
          ExtensionMethod obj = new ExtensionMethod();
            obj.funcn1();
            obj.funcn2();   
            obj.funcn3(45);

        }
    }
}
