namespace CircusLib
{
    public class Wagon
    {
        public List<Animal> Animals;
        public int Weight;
        public Wagon()
        {
            Animals = new List<Animal>();
        }
        public bool AddAnimal(Animal animal)
        {
            if (Animals.Count == 0)
            {
                Animals.Add(animal);
                Weight += animal.Weight;
                return true;
            }

            //Never have more than 1 carnivore in a wagon
            foreach (Animal a in Animals)
            {
                if (a.IsCarnivore == true)
                {
                    if (animal.IsCarnivore == true)
                    {
                        return false;
                    }
                }
            }
            //Never have a carnivore in a wagon with a herbivore that weighs less
            if (Animals[0].IsCarnivore == true)
            {
                if (Animals[0].Weight < animal.Weight)
                {
                    if (Weight + animal.Weight <= 10)
                    {
                        Animals.Add(animal);
                        Weight += animal.Weight;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            //If the wagon only contains herbivores, check if the weight total weight is less than 10
            {
                if (Weight + animal.Weight <= 10)
                {
                    Animals.Add(animal);
                    Weight += animal.Weight;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
