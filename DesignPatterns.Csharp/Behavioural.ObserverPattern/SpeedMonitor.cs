using System;

namespace DesignPatterns.Csharp.Behavioural.ObserverPattern
{
    //This is observer/Subscriber
    public class SpeedMonitor
    {
        public const int SpeedToAlert = 70;

        public SpeedMonitor(Speedometer speedometer)
        {
            speedometer.ValueChanged += ValueHasChanged; // SpeedMonitor has subscribed the Speedometer, anytime the speedometer would change the Speedmonitor will be notified.
        }

        private void ValueHasChanged(object sender, EventArgs e)
        {
            Speedometer speedometer = (Speedometer)sender;

            if(speedometer.CurrentSpeed > SpeedToAlert)
            {
                Console.WriteLine("Alert! Driving too fast " + speedometer.CurrentSpeed);
            }
            else
            {
                Console.WriteLine("Nice and steady " + speedometer.CurrentSpeed);
            }
        }
    }
}
