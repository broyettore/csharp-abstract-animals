using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_abstract_animals.Classes.Abstracts;
using csharp_abstract_animals.Classes.Interfaces;

namespace csharp_abstract_animals.Classes
{
    public class Dog : Animal,ISwim
    {
        public string Name { get; }
        public Dog(int age, string name) : base(age)
        {
            Name = name;
        }

        public override void animalNoise()
        {
            Console.WriteLine("it sounds like bau bau");
        }

        public override void foodType()
        {
            Console.WriteLine("it eats dog food");
        }

        public void CanSwim()
        {
            Console.WriteLine("It can swim");
        }

    }
}
