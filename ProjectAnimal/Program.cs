using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();

            bird.Name = "Sova";
            bird.Age = 2.5;

            bird.Speak();

            Fish fish = new Fish();
            fish.Move();
             
            Shark shark = new Shark();
            shark.Move();
            
        }
    }
}
