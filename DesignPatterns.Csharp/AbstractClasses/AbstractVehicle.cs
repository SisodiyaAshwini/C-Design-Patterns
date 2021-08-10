using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.AbstractClasses
{
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine _engine;

        private VehicleColour _colour;

        public AbstractVehicle(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {

        }

        public AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            this._engine = engine;
            this._colour = colour;
        }

        public virtual IEngine Engine => _engine;
        public virtual VehicleColour Colour => _colour;
        
        public virtual void Paint(VehicleColour colour)
        {
            this._colour = colour;
        }

        public override string ToString()
        {
            return this.GetType().Name + "(" + _engine + "," + _colour + ")";
        }
    }
}
