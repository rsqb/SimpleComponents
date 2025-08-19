using Dog;
using Host;

Console.WriteLine("=== .NET Components Demonstration ===");
Console.WriteLine("Host and Dog components");

// Dependency Injection – Host depends on IDog interface, not concrete Dog class
IDog dog = new Dog.Dog();
var owner = new Host.Host(dog);

// Demonstrate IFeeder interface methods
IFeeder feeder = owner;

Console.WriteLine("\n--- Calling the dog ---");
feeder.Call();

Console.WriteLine("\n--- Feeder actions ---");
feeder.GiveFood();
feeder.GiveDrink();

// Demonstrate IDogHost interface methods
IDogHost dogHost = owner;

Console.WriteLine("\n--- Good owner actions ---");
dogHost.CareForAnimalFur();
dogHost.LeadAnimal();

// Direct interaction with the Dog component

IDog directDog = new Dog.Dog();

Console.WriteLine("\n--- Direct dog usage ---");
directDog.Bark();
directDog.Growl();

object attacker = "thief";
int didBite = directDog.Bite(attacker);
Console.WriteLine($"Did the dog bite {attacker}? {(didBite == 1 ? "Yes" : "No")}");

directDog.WagTail();

Console.Write("\nPress any key to exit... ");
Console.ReadKey();
