﻿using DesignPatterns.Csharp.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.ConcreteClasses
{
    public class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {

        }

        public BoxVan(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {

        }
    }
}
