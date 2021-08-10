using DesignPatterns.Csharp.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.ConcreteClasses
{
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {

        }

        public Sport(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {

        }
    }
}
