using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dolphin : Animal
    {
        public Dolphin(int age) : base(age)
        {
        }
        public override void animalNoise()
        {
            Console.WriteLine("it sounds like hiu hiu");
        }

        public override void foodType()
        {
            Console.WriteLine("it eats fishes and seafood");
        }
    }
}
