using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public bool IsCarnivore { get; set; }
        public int Weight { get; set; }
        public Sizes Size { get; set; }
        public Animal(string name, bool isCarnivore, Sizes size)
        {
            Name = name;
            IsCarnivore = isCarnivore;
            Size = size;
            Weight = (int)Size;

        }

        public abstract bool CanShareWagonWith(Animal otherAnimal);
        

    }

    public class Carnivore : Animal 
    {
        public Carnivore(string name, Sizes size) : base(name, true, size)
        {
            Name=name;
            Size=size;
            Weight = (int)size;
        }
        
        public override bool CanShareWagonWith(Animal otherAnimal)
        {
            if (otherAnimal.IsCarnivore)
            {
                return false;
            }
            if (otherAnimal.Size <= Size)
            {
                return false;
            }
            return true;
        }

    }

    public class Herbivore : Animal
    {
        public Herbivore(string name, Sizes size) : base(name, false, size)
        {
            Name = name;
            Size = size;
            Weight = (int)size;
        }

        public override bool CanShareWagonWith(Animal otherAnimal)
        {

            if (otherAnimal.IsCarnivore)
            {
                if (otherAnimal.Weight > Weight)
                {
                    return false;
                }
            }
            return true;
        }

    }

}
