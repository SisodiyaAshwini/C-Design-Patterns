using DesignPatterns.Csharp.AbstractClasses;

namespace DesignPatterns.Csharp.ConcreteClasses
{
    public class TurboEngine : AbstractEngine
    {
        public TurboEngine(int size)
            : base(size, true)
        {

        }
    }
}
