using Dog;

namespace Host;

public class Host : IFeeder, IDogHost
{
    private readonly IDog _pet = new Dog.Dog();

    public int GiveFood()
    {
        Console.WriteLine("Host is giving food to the dog");
        return 1;
    }

    public int GiveDrink()
    {
        Console.WriteLine("Host is giving water to the dog");
        return 1;
    }

    public int Call()
    {
        Console.WriteLine("Host is calling the dog");
        for (var i = 0; i < 3; i++)
        {
            _pet.Run();
            _pet.WagTail();
        }
        return 1;
    }

    public int LeadAnimal()
    {
        Console.WriteLine("Host takes the dog for a walk");
        _pet.Run();
        _pet.Run();
        _pet.WagTail();
        return 1;
    }

    public int CareForAnimalFur()
    {
        Console.WriteLine("Host cares for the dog's fur (combing, washing)");
        return 1;
    }
}
