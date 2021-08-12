using System;

namespace DesignPatterns.Csharp.Creational.SingletonPattern
{
    public class SerialNumberGenerator
    {
        //static members
        private static volatile SerialNumberGenerator instance;
        //volatile : The volatile keyword indicates that a field might be modified by multiple threads that are executing at the same time.
        //The compiler, the runtime system, and even hardware may rearrange reads and writes to memory locations for performance reasons.
        //Fields that are declared volatile are not subject to these optimizations

        public static SerialNumberGenerator Instance 
            //This is a get property which is creating an instance very first time and everytime the same instance is getting used,
            //no at outside is creating the instance
        {
            get { 
                if(instance == null)
                {
                    instance = new SerialNumberGenerator();
                }
                return instance;
            }
        }

        //instance variable
        private int count;

        //private constructor
        private SerialNumberGenerator()
        {

        }

        //instance method
        public virtual int NextSerial
        {
            get
            {
                return ++count;
            }
        }
    }
}

