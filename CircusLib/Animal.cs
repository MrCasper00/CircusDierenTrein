using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public class Animal
    {
        public string Name;
        public bool IsCarnivore;
        public int Weight;
        public Sizes Size;
        public Animal(string name, bool isCarnivore, Sizes size)
        {
            Name = name;
            IsCarnivore = isCarnivore;
            Size = size;
            Weight = (int)Size;

        }
    }
}
