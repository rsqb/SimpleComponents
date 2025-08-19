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

## Verifying Releases

All releases are signed with GPG (GNU Privacy Guard) key:
- Fingerprint: `B1FD 20DB 15EE D25F D6DE 7C93 C7CE 19DC DFD0 11BD`
- Public key: [PUBLIC_KEY.asc](PUBLIC_KEY.asc) or [Gist](https://gist.github.com/rsqb/1bd8693e60027034031efade3c6ac95d)

### To verify:
```bash
# Import key
curl -L https://gist.github.com/rsqb/1bd8693e60027034031efade3c6ac95d/raw | gpg --import

# Verify signature
gpg --verify <release>.asc <release>
```
