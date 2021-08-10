using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Classes;
using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.Csharp.Creational.AbstractFactoryPattern.FactoryClasses
{
    // This will return the care related objects
    public class CarFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}
