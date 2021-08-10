using DesignPatterns.Csharp.ConcreteClasses;
using DesignPatterns.Csharp.Creational.FactoryMethodPattern.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.Creational.FactoryMethodPattern
{
    public class VanFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if((style == DrivingStyle.Economical) || (style == DrivingStyle.Midrange))
            {
                return new PickUp(new StandardEngine(2200));
            }
            else
            {
                return new BoxVan(new TurboEngine(2500));
            }
        }
    }
}
