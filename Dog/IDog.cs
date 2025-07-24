namespace Dog;

public interface IDog
{
    // Core behaviours we want:
    void Bark();            // Loti
    void Growl();           // Urgzti
    int Bite(Object whom);  // Kasti(Kam) - returns 0 if didn't bite, 1 if did bite
    void Run();             // Begti
    void WagTail();         // VizgintiUodega
    
    // Additional behaviours that dogs have:
    void DemandFood();
    void LiftLeg();
}