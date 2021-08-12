using System;
namespace DesignPatterns.Csharp.Behavioural.ObserverPattern
{
    //This is observer/Subscriber
    public class AutomaticGearBox
    {
        public AutomaticGearBox(Speedometer speedo)
        {
            speedo.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            Speedometer speedometer = (Speedometer)sender;

            if (speedometer.CurrentSpeed <= 10)
            {
                Console.WriteLine("Now in first gear");
            }
            else if (speedometer.CurrentSpeed <= 20)
            {
                Console.WriteLine("Now in second gear");
            }
            else if (speedometer.CurrentSpeed <= 30)
            {
                Console.WriteLine("Now in third gear");
            }
            else
            {
                Console.WriteLine("Now in fourth gear");
            }
        }
    }
}
