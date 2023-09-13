using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Dog : Animal
    {
        public string Name { get; }
        public Dog(int age, string name) : base(age)
        {
            this.Name = name;
        }

        public override void animalNoise()
        {
            Console.WriteLine("it sounds like bau bau");
        }

        public override void foodType()
        {
            Console.WriteLine("it eats dog food");
        }
    }
}
