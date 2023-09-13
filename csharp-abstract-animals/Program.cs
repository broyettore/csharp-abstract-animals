using csharp_abstract_animals.Classes;
using csharp_abstract_animals.Classes.Abstracts;
using csharp_abstract_animals.Classes.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // takes an arg that implements the IFly interface and then print a method
            static void CanItFly(IFly animal)
            {
                animal.CanFly();
            }

            // takes an arg that implements the ISwim interface and then print a method
            static void CanItSwim(ISwim animal)
            {
                animal.CanSwim();
            }

            Dog scooby = new Dog(3, "scooby doo");
            Sparrow jack = new Sparrow(4);
            Dolphin liu = new Dolphin(5);
            Eagle dex = new Eagle(6);


            // animals list
            List<Animal> animals = new List<Animal>();
            animals.Add(scooby);
            animals.Add(jack);
            animals.Add(liu);
            animals.Add(dex);

            Console.WriteLine("Guess the animal ? \n");

            int tracker = 1;
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal-{tracker} is {animal.Age} years old: ");
                animal.animalNoise();
                animal.foodType();
                animal.Sleep();

                if (animal is IFly flyable)
                {
                    CanItFly(flyable);
                }

                if (animal is ISwim swimmer)
                {
                    CanItSwim(swimmer);
                }

                Console.WriteLine();
                tracker++;
            }


        }
    }
}