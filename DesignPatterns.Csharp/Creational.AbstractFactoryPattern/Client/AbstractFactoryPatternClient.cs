using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.FactoryClasses;
using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Interfaces;
using System;

namespace DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Client
{
    public class AbstractFactoryPatternClient
    {        
        public static void Practice()
        {
            string whatToMake = "car"; // or van

            AbstractVehicleFactory factory = null;

            //Create the correct factory
            if (whatToMake.Equals("car"))
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            // Create the vehicle's component parts...
            // These will either be all car parts or all van parts

            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            //The objects we have created

            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts);
        }        
    }
}
