using DesignPatterns.Csharp.Creational.FactoryMethodPattern.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;
using System;

namespace DesignPatterns.Csharp.Creational.FactoryMethodPattern.Client
{
    public class FactoryMethodPatternClient
    {
        public static void Practice()
        {
            // I want an economical car, coloured blue...
            VehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColour.Blue);
            Console.WriteLine(car);

            // I am a "white van man"...
            VehicleFactory vanFactory = new VanFactory();
            IVehicle van = vanFactory.Build(VehicleFactory.DrivingStyle.Powerful, VehicleColour.White);
            Console.WriteLine(van);
        }
    }
}
