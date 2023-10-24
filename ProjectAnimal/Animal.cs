using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnimal
{
    internal class Animal
    {
        private string _name;
        private double _age;

        public Animal()
        {
            
        }
        
        public Animal(string name, double age)
        {
            _name = name;
            _age = age;
        }

        public string Name
        {
            get { return _name; }
            set { value = _name; }
        }

        public double Age
        {
            get { return _age; }
            set { value = _age; }
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{_name} is speaking");
        }

        public virtual void Move()
        {
            Console.WriteLine($"The animal's age is - {_age} ");
        }
    }
}
