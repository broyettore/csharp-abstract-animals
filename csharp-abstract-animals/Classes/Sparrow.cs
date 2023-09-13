using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_abstract_animals.Classes.Abstracts;
using csharp_abstract_animals.Classes.Interfaces;

namespace csharp_abstract_animals.Classes
{
    public class Sparrow : Animal,IFly
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

        public void CanFly()
        {
            Console.WriteLine("It can fly");
        }
    }
}
