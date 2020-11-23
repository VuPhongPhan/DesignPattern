using FactoryMethod.Animal;
using FactoryMethod.Factory;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if(type == 0)
            {
                factory = new BasicAnimalFactory();
            }
            else
            {
                factory = new RandomAnimalFactory();
            }

            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
            Console.WriteLine(factory.createAnimal().GetName());
        }
    }
}
