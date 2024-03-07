namespace CircusLib
{
    public class Wagon
    {
        public List<Animal> Animals { get; private set; }
        public int Weight { get; private set;}
        public Wagon()
        {
            Animals = new List<Animal>();
        }
        public bool AddAnimal(Animal animal)
        {
            // If the wagon is empty always add the animal
            if (Animals.Count == 0)
            {
                Animals.Add(animal);
                Weight += animal.Weight;
                return true;
            }

            // Check if the new animal can share a wagon with all the existing animals
            foreach (Animal existingAnimal in Animals)
            {
                if (!existingAnimal.CanShareWagonWith(animal))
                {
                    return false;
                }
            }

            // Check if adding the new animal would exceed the weight limit
            if (Weight + animal.Weight > 10)
            {
                return false;
            }

            // If all checks pass, add the animal to the wagon
            Animals.Add(animal);
            Weight += animal.Weight;
            return true;
        }
    }
}
