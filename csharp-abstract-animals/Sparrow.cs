using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Sparrow : Animal
    {
        public Sparrow(int age) : base(age)
        {
        }

        public override void animalNoise()
        {
            Console.WriteLine("it sounds like piu piu");
        }

        public override void foodType()
        {
            Console.WriteLine("it eats worms");
        }
    }
}
