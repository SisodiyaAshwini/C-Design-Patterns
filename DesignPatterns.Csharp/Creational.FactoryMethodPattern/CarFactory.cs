using DesignPatterns.Csharp.ConcreteClasses;
using DesignPatterns.Csharp.Creational.FactoryMethodPattern.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.Creational.FactoryMethodPattern
{
    public class CarFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if(style == DrivingStyle.Economical)
            {
                return new Saloon(new StandardEngine(1300));
            }

            else if(style == DrivingStyle.Midrange)
            {
                return new Coupe(new StandardEngine(1600));
            }

            else
            {
                return new Sport(new TurboEngine(2000));
            }
        }
    }
}
