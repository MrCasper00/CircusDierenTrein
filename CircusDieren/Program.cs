// See https://aka.ms/new-console-template for more information
using System.CodeDom.Compiler;
using System.Globalization;
using System.Runtime.InteropServices;
using CircusLib;
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













