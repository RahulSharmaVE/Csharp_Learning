using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class animal
    {
        public virtual void sound()
        {
            Console.WriteLine("the animal makes the sound");
        }
    }
    class Lion1 : animal
    {
        public override void sound()
        {
            Console.WriteLine("Roar Roar !!");
        }
    }
    class Cheetah : animal
    {
        public override void sound()
        {
            Console.WriteLine("churtlings !!");
        }
    }
    class Plymrphsm
    {
        public static void Main(string[] args)
        {
            animal myanml1 = new animal();
            animal myanml2 = new Lion1();
            animal myanml3 = new Cheetah();
            myanml1.sound();
            myanml2.sound();
            myanml3.sound();
        }
    }
}
