using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Eagle : Animal
    {
        public Eagle(int age) : base(age)
        {
        }
        public override void animalNoise()
        {
            Console.WriteLine("it sounds like chiu chiu");
        }

        public override void foodType()
        {
            Console.WriteLine("it eats the prey it catches");
        }
    }
}
