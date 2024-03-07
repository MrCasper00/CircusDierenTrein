using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public class Circus
    {
        public List<Animal> Animals { get; private set; }
        public Train Train { get; private set; }
        public Circus()
        {
            Animals = new List<Animal>();
            Train = new Train();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void FindBest()
        {
            // Save a copy of the original list of animals
            List<Animal> originalAnimals = Animals;

            // Try adding animals in descending order of size
            Animals = Animals.OrderByDescending(a => a.Size).ToList();
            FillWagons();
            int wagonsDescending = Train.Wagons.Count;

            // Reset the train and the list of animals
            Train = new Train();
            Animals = originalAnimals;

            // Try adding animals in ascending order of size
            Animals = Animals.OrderBy(a => a.Size).ToList();
            FillWagons();
            int wagonsAscending = Train.Wagons.Count;

            // Reset the train and the list of animals again
            Train = new Train();
            Animals = originalAnimals;

            // Choose the order that resulted in the least amount wagons
            if (wagonsDescending < wagonsAscending)
            {
                Animals = Animals.OrderByDescending(a => a.Size).ToList();
            }
            else
            {
                Animals = Animals.OrderBy(a => a.Size).ToList();
            }

            // Fill the wagons one last time with the best order
            FillWagons();
        }

        public void FillWagons()
        {
            // First add all the carnivores to their own wagons since they will always need their own wagon
            // And remove them from the list
            foreach (var animal in Animals.ToList())
            {
                if (animal.IsCarnivore)
                {
                    var newWagon = new Wagon();
                    newWagon.AddAnimal(animal);
                    Train.AddWagon(newWagon);
                    Animals.Remove(animal);
                }
            }


            // Then add the remaining animals to wagons
            foreach (var animal in Animals)
            {
                bool addedToWagon = false;

                foreach (var wagon in Train.Wagons)
                {
                    if (wagon.AddAnimal(animal))
                    {
                        addedToWagon = true;
                        break;
                    }
                }

                // If the animal couldn't be added to any wagon create a new wagon and add it there
                if (!addedToWagon)
                {
                    var newWagon = new Wagon();
                    newWagon.AddAnimal(animal);
                    Train.AddWagon(newWagon);
                }
            }
        }
    }
}
