using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Classes
{
    public class VanGlassware : IGlassware 
    {
        public virtual string GlasswareParts => "Window glassware for van";
    }
}
