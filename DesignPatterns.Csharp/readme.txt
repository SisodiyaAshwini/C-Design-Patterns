Creational patterns provide approaches to object instantiation. Where you place the new keyword affects how tightly or loosely coupled your classes are.
1. Abstract Factory Pattern
2. Builder Pattern
3. Factory Method Pattern

Structural patterns provide approaches for combining classes and objects to form larger structures. 
Deciding whether to use inheritance or composition affects how flexible and adaptable your software is;

Behavioural patterns provide approaches for handling communication between objects.

Prefer object composition over inheritance. Where a class is related to another in some way, you should distinguish between "is a" (or "is a type of") and "has a" relationships. 
In the IVehicle and IEngine hierarchies described earlier, it is true to say that AbstractCar "is a" IVehicle, and that Saloon "is a" AbstractCar. 
But it would not be true to say that IVehicle "is a" IEngine, but rather that an IVehicle "has a" IEngine. 
Therefore, inheritance is legitimately used for AbstractCar and Saloon, but object composition is used between IVehicle and IEngine.
