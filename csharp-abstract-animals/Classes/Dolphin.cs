using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_abstract_animals.Classes.Abstracts;
using csharp_abstract_animals.Classes.Interfaces;

namespace csharp_abstract_animals.Classes
{
    public class Dolphin : Animal, ISwim
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

        public void CanSwim()
        {
             Console.WriteLine("It can swim");
        }
    }
}
