using DesignPatterns.Csharp.AbstractClasses;
using DesignPatterns.Csharp.ConcreteClasses;
using DesignPatterns.Csharp.Creational.BuilderPattern.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;
using System;

namespace DesignPatterns.Csharp.Creational.BuilderPattern.Client
{
    public class BuilderPatternClient
    {
        public static void Practice()
        {
            AbstractCar car = new Saloon(new StandardEngine(1300)); //This is abstract car, car in progress, i want standard engine

            VehicleBuilder builder = new CarBuilder(car); // this defines the remaianing part to build the car, complex object is what we are creating 

            VehicleDirector director = new CarDirector(); // Calls the method sequence and build the final vehicle

            IVehicle v = director.Build(builder);

            Console.WriteLine(v);
        }
    }

    /*Output
        Building car chassis
        Building car body
        Building car passenger area
        Building car boot
        Building car windows
        Saloon (StandardEngine (1300), Unpainted)
     */
}
