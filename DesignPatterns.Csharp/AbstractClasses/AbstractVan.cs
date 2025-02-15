﻿using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.AbstractClasses
{
    public abstract class AbstractVan : AbstractVehicle
    {
        public AbstractVan(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {

        }

        public AbstractVan(IEngine engine, VehicleColour colour)
            :base(engine, colour)
        {

        }
    }
}
