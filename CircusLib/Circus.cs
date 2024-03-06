using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public class Circus
    {
        public List<Animal> Animals;
        public Train Train;
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
            List<Animal> originalAnimals = new List<Animal>(Animals);

            // Try adding animals in descending order of size
            Animals = Animals.OrderByDescending(a => a.Size).ToList();
            FillWagons();
            int wagonsDescending = Train.Wagons.Count;

            // Reset the train and the list of animals
            Train = new Train();
            Animals = new List<Animal>(originalAnimals);

            // Try adding animals in ascending order of size
            Animals = Animals.OrderBy(a => a.Size).ToList();
            FillWagons();
            int wagonsAscending = Train.Wagons.Count;

            // Reset the train and the list of animals one more time
            Train = new Train();
            Animals = new List<Animal>(originalAnimals);

            // Choose the order that resulted in the fewest wagons
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
