using Dog;

Console.WriteLine("=== .NET Components Demonstration ===");
Console.WriteLine("Host and Dog components");

var owner = new Host.Host();

// Demonstrate IFeeder interface methods
Console.WriteLine("\n--- Calling the dog ---");
owner.Call();
Console.WriteLine("\n--- Feeder actions ---");
owner.GiveFood();
owner.GiveDrink();

// Demonstrate IDogHost interface methods
Console.WriteLine("\n--- Good owner actions ---");
owner.CareForAnimalFur();
owner.LeadAnimal();

// Direct interaction with Dog component
Console.WriteLine("\n--- Direct dog usage ---");
IDog directDog = new Dog.Dog();
directDog.Bark();
directDog.Growl();
object attacker = "thief";
var didBite = directDog.Bite(attacker);
Console.WriteLine($"Did the dog bite {attacker}? {(didBite == 1 ? "Yes" : "No")}");
directDog.WagTail();

Console.Write("\nPress any key to exit... ");
Console.ReadKey();