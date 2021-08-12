using System;

namespace DesignPatterns.Csharp.Behavioural.ObserverPattern
{
    //This is observable/Subject
    public class Speedometer
    {
        public event EventHandler ValueChanged; // EventHandler is a delegate. The valueChnaged is a delegate, the method it will call is onValueChanged.
        private int currentSpeed;

        public Speedometer()
        {
            currentSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                currentSpeed = value;

                // Tell all observers so they know value has changed...
                OnValueChanged();
            }

            get
            {
                return currentSpeed;
            }
        }

        protected void OnValueChanged()
        {
            if(ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }
    }
}
