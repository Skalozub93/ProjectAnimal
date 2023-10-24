using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimal
{
    internal class Dog : Mammal
    {
        public Dog()
        {

        }

        public Dog(string name, double age)
        {
            base.Name = name;
            base.Age = age;
        }

        public override void Speak()
        {
            Console.WriteLine($"The dog is barking");
        }

        public override void Move()
        {
            Console.WriteLine("The bird is moving");
        }
    }
}
