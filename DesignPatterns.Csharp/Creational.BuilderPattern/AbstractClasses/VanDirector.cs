using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.Creational.BuilderPattern.AbstractClasses
{
    public class VanDirector: VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();

            return builder.Vehicle;
        }
    }
}
