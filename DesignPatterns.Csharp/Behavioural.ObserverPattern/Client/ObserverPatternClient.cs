namespace DesignPatterns.Csharp.Behavioural.ObserverPattern.Client
{
    public class ObserverPatternClient
    {
        public static void Practice()
        {
            // Create a speedometer...
            Speedometer speedo = new Speedometer();
            // Create a monitor...
            SpeedMonitor monitor = new SpeedMonitor(speedo);
            AutomaticGearBox auto = new AutomaticGearBox(speedo);
            // Drive at different speeds...
            speedo.CurrentSpeed = 50; //Whenever speed is changing SpeedMonitor and AutomaticGearBox are getting notified.
            speedo.CurrentSpeed = 70;
            speedo.CurrentSpeed = 40;
            speedo.CurrentSpeed = 100;
            speedo.CurrentSpeed = 69;            
        }
    }

    /*
     * Nice and steady 50
Now in fourth gear
Nice and steady 70
Now in fourth gear
Nice and steady 40
Now in fourth gear
Alert! Driving too fast 100
Now in fourth gear
Nice and steady 69
Now in fourth gear
     */
}
