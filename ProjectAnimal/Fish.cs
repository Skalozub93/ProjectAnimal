using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimal
{
     class Fish : Animal
    {
        public override sealed void Speak()
        {
            Console.WriteLine("The fish is speaking");
        }

        public override sealed void Move()
        {
            Console.WriteLine("The fish is moving");
        }
    }
}
