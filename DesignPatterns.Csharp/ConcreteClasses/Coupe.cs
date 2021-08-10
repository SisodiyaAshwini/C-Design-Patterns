using DesignPatterns.Csharp.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.ConcreteClasses
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine)
            :this(engine, VehicleColour.Unpainted)
        {

        }

        public Coupe(IEngine engine, VehicleColour colour)
            :base(engine, colour)
        {

        }
    }
}
