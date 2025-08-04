namespace Dog;

public interface IDog
{
    // Core behaviors we want
    void Bark();
    void Growl();
    int Bite(object whom);  // returns 0 if didn't bite, 1 if did bite
    void Run();
    void WagTail();

    // Additional behaviors that dogs have
    void DemandFood();
    void LiftLeg();
}
