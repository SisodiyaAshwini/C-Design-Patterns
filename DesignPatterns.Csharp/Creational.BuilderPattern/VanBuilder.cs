using DesignPatterns.Csharp.AbstractClasses;
using DesignPatterns.Csharp.Creational.BuilderPattern.AbstractClasses;
using DesignPatterns.Csharp.Interfaces;
using System;

namespace DesignPatterns.Csharp.Creational.BuilderPattern
{
    public class VanBuilder : VehicleBuilder
    {
        private AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            vanInProgress = van;
        }

        public override void BuildBody() => Console.WriteLine("building van body");
        public override void BuildChassis() => Console.WriteLine("building van chassis");
        public override void BuildReinforcedStorageArea() => Console.WriteLine("building van storage area");
        public override void BuildWindows() => Console.WriteLine("building van windows");        
        public override IVehicle Vehicle => vanInProgress;

        //BuildBoot() and BuildPassengerArea() methods were not overridden since they are not applicable to vans.
    }
}
