using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimal
{
    internal class Bird : Animal 
    {       

        public override void Speak()
        {
            Console.WriteLine($"The bird is speaking");
        }

        public override void Move()
        {
            Console.WriteLine("The bird is moving");
        }
    }
}
