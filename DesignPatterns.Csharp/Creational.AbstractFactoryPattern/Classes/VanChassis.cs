using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Classes
{
    public class VanChassis : IChassis
    {
        public virtual string ChassisParts => "Chassis parts for van";
    }
}
