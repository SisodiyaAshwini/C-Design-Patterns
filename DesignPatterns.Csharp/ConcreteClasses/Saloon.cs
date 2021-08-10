using DesignPatterns.Csharp.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.ConcreteClasses
{
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine)
            :this(engine, VehicleColour.Unpainted)
        {

        }

        public Saloon(IEngine engine, VehicleColour colour)
            :base(engine, colour)
        {

        }
    }
}
