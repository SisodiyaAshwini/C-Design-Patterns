using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.Creational.BuilderPattern.AbstractClasses
{
    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            builder.BuildBoot();
            builder.BuildWindows();

            return builder.Vehicle;
        }
    }
}
