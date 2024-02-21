// See https://aka.ms/new-console-template for more information
using System.CodeDom.Compiler;
using System.Globalization;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
Train train = new Train();

void SampleCaseSelector(int Case)
{
    switch (Case)
    {
        case 1:
            SampleCase(1, 0, 0, 0, 3, 2);
            break;
        case 2:
            SampleCase(1, 0, 0, 5, 2, 1);
            break;
        case 3:
            SampleCase(1, 1, 1, 1, 1, 1);
            break;
        case 4:
            SampleCase(2, 1, 1, 1, 5, 1);
            break;
        case 5:
            SampleCase(1, 0, 0, 1, 1, 2);
            break;
        case 6:
            SampleCase(3, 0, 0, 0, 2, 3);
            break;
        case 7:
            SampleCase(7, 3, 3, 0, 5, 6);
            break;
        default:
            Console.WriteLine("Invalid case.");
            break;
    }
}


void SampleCase(int s, int m, int b, int S, int M, int B)
{
    int CarnivoreSmall = s;
    int CarnivoreMedium = m;
    int CarnivoreBig = b;
    int HerbivoreSmall = S; 
    int HerbivoreMedium = M;
    int HerbivoreBig = B;

    for (int i = 0; i < CarnivoreSmall; i++)
    {
        train.addAnimal(new Animal("CarnivoreSmall", true, Sizes.S));
    }
    for (int i = 0; i < CarnivoreMedium; i++)
    {
        train.addAnimal(new Animal("CarnivoreMedium", true, Sizes.M));
    }
    for (int i = 0; i < CarnivoreBig; i++)
    {
        train.addAnimal(new Animal("CarnivoreBig", true, Sizes.B));
    }
    for (int i = 0; i < HerbivoreSmall; i++)
    {
        train.addAnimal(new Animal("HerbivoreSmall", false, Sizes.S));
    }
    for (int i = 0; i < HerbivoreMedium; i++)
    {
        train.addAnimal(new Animal("HerbivoreMedium", false, Sizes.M));
    }
    for (int i = 0; i < HerbivoreBig; i++)
    {
        train.addAnimal(new Animal("HerbivoreBig", false, Sizes.B));
    }
}

for (int i = 1; i < 8; i++)
{
    SampleCaseSelector(i);


    train.FindBest();

    Console.WriteLine("The train has " + train.Wagons.Count + " wagons.");

    //foreach (Wagon a in train.Wagons)
    //{
    //    Console.WriteLine("---------");
    //    Console.WriteLine($"Wagon");
    //    Console.WriteLine(a.Weight.ToString());
    //    a.Animals.ForEach(animal => Console.WriteLine(animal.Name));
    //}

    if (i == 1)
    {
        if (train.Wagons.Count == 2)
        {
            Console.WriteLine("Test Passed");
        }
    }
    if (i == 2)
    {
        if (train.Wagons.Count == 2)
        {
            Console.WriteLine("Test Passed");
        }
    }
    if (i == 3)
    {
        if (train.Wagons.Count == 4)
        {
            Console.WriteLine("Test Passed");
        }
    }
    if (i == 4)
    {
        if (train.Wagons.Count == 5)
        {
            Console.WriteLine("Test Passed");
        }
    }
    if (i == 5)
    {
        if (train.Wagons.Count == 2)
        {
            Console.WriteLine("Test Passed");
        }
    }
    if (i == 6)
    {
        if (train.Wagons.Count == 3)
        {
            Console.WriteLine("Test Passed");
        } else 
        {
            Console.WriteLine("Test Failed");
        }
    }
    if (i == 7)
    {
        if (train.Wagons.Count == 13)
        {
            Console.WriteLine("Test Passed");
        }
    }
    train.Wagons.Clear();
    train.Animals.Clear();

}




public enum Sizes
{
    S = 1,
    M = 3,
    B = 5
}



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



        //Try Ass And Desc



        //foreach (Animal animal in Animals)
        //{
        //    Console.WriteLine(animal.Name);
        //}


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
        } else
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








