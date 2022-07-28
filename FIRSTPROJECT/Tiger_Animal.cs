using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    //Tiger_Animal is the child class
     class Tiger_Animal : Animal1 //inherit properties from class Animal1
    {
        public void carnivore()

        {
            Console.WriteLine("I am Carnivore");
        }
    }
}
