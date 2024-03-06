// See https://aka.ms/new-console-template for more information
using System.CodeDom.Compiler;
using System.Globalization;
using System.Runtime.InteropServices;
using CircusLib;
End:
Circus Circus   = new Circus();

Console.WriteLine("Welcome to the circus! We are going to fill the train with animals.");
Console.WriteLine("How many big carnivores?");
int bigCarnivores = int.Parse(Console.ReadLine());
Console.WriteLine("How many medium carnivores?");
int mediumCarnivores = int.Parse(Console.ReadLine());
Console.WriteLine("How many small carnivores?");
int smallCarnivores = int.Parse(Console.ReadLine());
Console.WriteLine("How many big herbivores?");
int bigHerbivores = int.Parse(Console.ReadLine());
Console.WriteLine("How many medium herbivores?");
int mediumHerbivores = int.Parse(Console.ReadLine());
Console.WriteLine("How many small herbivores?");
int smallHerbivores = int.Parse(Console.ReadLine());



AddAnimalsToTrain("Carnivore large", true, Sizes.B, bigCarnivores);
AddAnimalsToTrain("Carnivore medium", true, Sizes.M, mediumCarnivores);
AddAnimalsToTrain("Carnivore small", true, Sizes.S, smallCarnivores);

AddAnimalsToTrain("Herbivore large", false, Sizes.B, bigHerbivores);
AddAnimalsToTrain("Herbivore medium", false, Sizes.M, mediumHerbivores);
AddAnimalsToTrain("Herbivore small", false, Sizes.S, smallHerbivores);



void AddAnimalsToTrain(string animalType, bool isCarnivore, Sizes size, int count)
{
    if (isCarnivore)
    {
        for (int i = 0; i < count; i++)
        {
            Circus.AddAnimal(new Carnivore(animalType, size));
        }
    }
    else
    {
        for (int i = 0; i < count; i++)
        {
            Circus.AddAnimal(new Herbivore(animalType, size));
        }
    }
}


Circus.FindBest();
Console.WriteLine("The train has " + Circus.Train.Wagons.Count + " wagons.");
foreach (Wagon a in Circus.Train.Wagons)
{
    Console.WriteLine("---------");
    Console.WriteLine($"Wagon");
    Console.WriteLine(a.Weight.ToString());
    a.Animals.ForEach(animal => Console.WriteLine(animal.Name));
}

Console.WriteLine("Do you want to continue? (yes/no)");
string answer = Console.ReadLine();
if (answer == "yes")
{
    goto End;
}
else
{
    Console.WriteLine("Goodbye!");
}


















