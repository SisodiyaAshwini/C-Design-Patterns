using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Classes
{
    public class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts => "Window glassware for car";
    }
}
