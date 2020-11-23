using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animal
{
    class Chicken : IAnimal
    {
        public string GetName()
        {
            return "I am Chicken";
        }
    }
}
