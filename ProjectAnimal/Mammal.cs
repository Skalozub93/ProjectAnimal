using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimal
{
    internal class Mammal : Animal
    {
        public Mammal()
        {

        }

        public Mammal(string name, double age)
        {
            base.Name = name;
            base.Age = age;
        }

        public override void Speak()
        {
            Console.WriteLine("The mammal is speaking");
        }

        public override void Move()
        {
            Console.WriteLine("The mammal is moving");
        }
    }
}
