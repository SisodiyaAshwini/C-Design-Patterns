﻿using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.AbstractClasses
{
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {

        }

        public AbstractCar(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {

        }
    }
}
