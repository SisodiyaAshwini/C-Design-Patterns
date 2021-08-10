using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.Csharp.Creational.AbstractFactoryPattern.FactoryClasses
{
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();

    }
}
