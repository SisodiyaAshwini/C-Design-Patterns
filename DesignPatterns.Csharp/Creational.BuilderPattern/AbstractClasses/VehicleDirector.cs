using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.Creational.BuilderPattern.AbstractClasses
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder); //Check car director from car sequence to build car and VanDirector for van.
    }
}
