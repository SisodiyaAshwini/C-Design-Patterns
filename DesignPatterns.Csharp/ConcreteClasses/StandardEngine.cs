using DesignPatterns.Csharp.AbstractClasses;

namespace DesignPatterns.Csharp.ConcreteClasses
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) 
            :base(size, false)
        {

        }
    }
}
