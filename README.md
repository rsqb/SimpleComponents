# .NET Components Example
![.NET](https://img.shields.io/badge/.NET-9.0-512BD4)
![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

Two components demonstrating .NET component interaction:
- **Dog.dll** – Class library implementing IDog interface
- **Host.exe** – Console app using Dog component

## Architecture
```mermaid
graph TB

    subgraph "Host.exe"
        Host
        IFeeder[<i>IFeeder</i>]
        IDogHost[<i>IDogHost</i>]
        Host -.-> IFeeder
        Host -.-> IDogHost
    end

    subgraph "Dog.dll"
        Dog
        IDog[<i>IDog</i>]
        Dog -.-> IDog
    end

    Host --> IDog

    style IFeeder fill:#ffffcc,color:#333,stroke:#333,stroke-dasharray: 5 5
    style IDogHost fill:#ffffcc,color:#333,stroke:#333,stroke-dasharray: 5 5
    style IDog fill:#ffffcc,color:#333,stroke:#333,stroke-dasharray: 5 5
    style Host fill:#5C2D91,color:#fff,stroke:#333,stroke-width:2px
    style Dog fill:#512BD4,color:#fff,stroke:#333,stroke-width:2px
```

- Dependency Inversion Principle
- **IDog interface** – Defines dog behaviors:
    - *Core:* Bark, Growl, Bite, Run, WagTail
    - *Others:* DemandFood, LiftLeg
- **Dog class** – Implements dog behaviors
- **IFeeder** – *Feeding responsibilities:* GiveFood, GiveDrink, Call
- **IDogHost** – *Care responsibilities:* LeadAnimal, CareForAnimalFur
- **Host** class implements both interfaces
- **Program** – Main entry point with demonstration

## Build & Run
```bash
# Build the solution
dotnet build

# Run the host application
dotnet run --project Host
```
## Attribution
Based on tutorial by Professor V. Giedrimas, Vilnius University *(Šiauliai Academy)*. Extended by:
- Slightly enhanced interface design
- Modern C# language features
