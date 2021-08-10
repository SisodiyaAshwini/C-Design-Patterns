Purpose: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

Requirement that can be achieved from this pattern? 
We will create a way of getting the correct family of parts (either for a car or for a van) but without having to explicitly instantiate the specific type in client programs.
To accomplish this, we shall define "factory" classes that will do this for us

our client want body, chassis and glassware to build either car or van. okay!

We need some factory which will createBody createCassis and createGlassware

parent abstract fatory class and then child carfactoy and van factory

Now it just remains for client programs to instantiate the appropriate 'factory' after which it can obtain the correct parts without having to specify whether they are for a car or a van.

The main disadvantage of the Abstract Factory pattern arises if you need to add additional 'products'. 
For example, if we now need to include lights in the family of components, we would need to amend AbstractVehicleFactory, CarFactory and VanFactory, in addition to creating a new ILights hierarchy (CarLights and VanLights).