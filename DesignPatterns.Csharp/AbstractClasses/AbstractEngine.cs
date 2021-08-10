using DesignPatterns.Csharp.Interfaces;

namespace DesignPatterns.Csharp.AbstractClasses
{
    public abstract class AbstractEngine : IEngine
    {
        private int _size;

        private bool _turbo;

        public AbstractEngine(int size, bool turbo)
        {
            this._size = size;
            this._turbo = turbo;
        }

        public virtual int Size { 
            get { return _size; } 
        }

        public virtual bool Turbo { 
            get { return _turbo; } 
        }

        public override string ToString()
        {
            return this.GetType().Name + "(" + _size + ")";
        }
    }
}
