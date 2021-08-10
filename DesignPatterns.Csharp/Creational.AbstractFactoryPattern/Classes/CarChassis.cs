using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Classes
{
    public class CarChassis : IChassis
    {
        public virtual string ChassisParts => "Chassis parts for car";
    }
}
