namespace Dog;

public interface IDog
{
    #region Interface methods
    
    // Core behaviors we want:
    void Bark();            // Loti
    void Growl();           // Urgzti
    int Bite(Object whom);  // Kasti(Kam) - returns 0 if didn't bite, 1 if did bitet
    void Run();             // Begti
    void WagTail();         // VizgintiUodega
    
    // Additional behaviors that dogs have:
    void DemandFood();
    void LiftLeg();

    #endregion
}