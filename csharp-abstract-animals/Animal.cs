using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        public int Age {  get; }

        public Animal(int age)
        {
            this.Age = age;
        }
       
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }

        public abstract void animalNoise();

        public abstract void foodType();
    }
}
