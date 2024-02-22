using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public class Train
    {
        public List<Wagon> Wagons;
        public List<Animal> Animals;

        public Train()
        {
            Wagons = new List<Wagon>();
            Animals = new List<Animal>();
        }

        public void addAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void AddWagon(Wagon wagon)
        {
            Wagons.Add(wagon);
        }

        public void FindBest()
        {
            List<Animal> AnimalsCopy = Animals;
            Animals = Animals.OrderByDescending(x => x.Size).ToList();
            int sorteddesc = FillWagons(0);
            Animals = AnimalsCopy;

            Animals = Animals.OrderBy(x => x.Size).ToList();
            int sortedasc = FillWagons(0);
            Animals = AnimalsCopy;

            //Console.WriteLine($"{sortedasc} + {sorteddesc}");

            if (sorteddesc < sortedasc)
            {

                Animals = Animals.OrderByDescending(x => x.Size).ToList();
            }
            else
            {
                Animals = Animals.OrderBy(x => x.Size).ToList();
            }
            FillWagons(1);
        }

        public int FillWagons(int skip)
        {

            // Carnivores always get their own wagon
            foreach (Animal animal in Animals)
            {
                if (animal.IsCarnivore == true)
                {
                    Wagon wagon = new Wagon();
                    AddWagon(wagon);
                }
            }

            // Add all carnivores to wagons
            foreach (Animal animal in Animals.ToList())
            {
                foreach (Wagon wagon in Wagons)
                {
                    if (animal.IsCarnivore == true)
                    {
                        if (wagon.AddAnimal(animal))
                        {
                            Animals.Remove(animal);
                            break;
                        }
                    }
                }
            }

            // Add all herbivores to wagons
            while (Animals.Count > 0)
            {
                foreach (Animal animal in Animals.ToList())
                {
                    foreach (Wagon wagon in Wagons)
                    {
                        if (wagon.AddAnimal(animal))
                        {
                            Animals.Remove(animal);
                            break;
                        }
                    }
                }

                if (Animals.Count > 0)
                {
                    Wagon wagon = new Wagon();
                    AddWagon(wagon);
                }
            }


            if (skip == 0)
            {
                int wagonscoutn = Wagons.Count;
                Wagons.Clear();
                return wagonscoutn;
            }
            return 0;


        }
    }
}
