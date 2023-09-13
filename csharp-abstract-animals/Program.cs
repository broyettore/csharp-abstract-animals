namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog scooby = new Dog(3, "scooby doo");
            Sparrow jack = new Sparrow(4);
            Dolphin liu = new Dolphin(5);
            Eagle dex = new Eagle(6);

            List<Animal> animals = new List<Animal>();
            animals.Add(scooby);
            animals.Add(liu);
            animals.Add(jack);
            animals.Add(dex);

            int tracker = 1;
            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal - {tracker} is {animal.Age} years old: ");
                animal.animalNoise();
                animal.foodType();
                animal.Sleep();
                Console.WriteLine();
                tracker++;
            }

        }
    }
}