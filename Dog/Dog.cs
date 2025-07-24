namespace Dog;

public class Dog : IDog
{
    private static readonly Random RandomGenerator = new();
    
    public void Bark() => Console.WriteLine("Woof woof!");
    public void Growl() => Console.WriteLine("Rrrrrrrrr...");
    public int Bite(Object whom) => RandomGenerator.Next(0,2); // 0 - didn't bite, 1 - did bite.
    public void Run() => Console.WriteLine("The dog is running");
    public void WagTail() => Console.WriteLine("The dog wags its tail");
    
    public void DemandFood()
    {
        Console.WriteLine("The dog demands food!");
        Bark();
    }
    
    public void LiftLeg() => Console.WriteLine("Dog lifts its leg...");
}
