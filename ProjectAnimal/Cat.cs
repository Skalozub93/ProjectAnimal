using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimal
{
    internal class Cat : Mammal
    {
        public Cat()
        {

        }

        public Cat(string name, double age)
        {
            base.Name = name;
            base.Age = age;
        }

        public override void Speak()
        {
            Console.WriteLine($"The cas is meow");
        }

        public override void Move()
        {
            Console.WriteLine("The cat is moving");
        }
    }
}
