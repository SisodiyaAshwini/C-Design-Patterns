using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.Creational.FactoryMethodPattern.AbstractClasses
{
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical,
            Midrange,
            Powerful
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(colour);
            return v;
        }

        //This is the factory method
        //The Build() method calls the protected abstract SelectVehicle() method, which is the "factory method" after which the pattern is named.
        //The implementation of SelectVehicle() is therefore delegated to the subclasses such that each subclass determines the specific type of vehicle to instantiate.
        //The method is protected because we only want subclasses to utilise it; it is not intended to be invoked by clients.
        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
    }
}
