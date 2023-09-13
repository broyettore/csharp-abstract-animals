using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_abstract_animals.Classes.Abstracts;
using csharp_abstract_animals.Classes.Interfaces;

namespace csharp_abstract_animals.Classes
{
    public class Eagle : Animal,IFly
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

        public void Flies()
        {
            Console.WriteLine("I can fly");
        }

        public void CanFly()
        {
            Console.WriteLine("It can fly");
        }
    }
}
