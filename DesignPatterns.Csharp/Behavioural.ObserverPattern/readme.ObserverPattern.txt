Purpose: Define a one-to-many dependency between objects so that when one object changes its state, all its dependants are notified and updated automatically.

a 'subject'/observable (the object that is of interest;
'observers' (any other class that needs to be kept informed when interesting stuff happens).

observers observe the observable for updates

Because this is a very common need in object-oriented systems, the C# libraries already contains mechanisms that enable the pattern to be implemented. 
One of these is by utilising the EventHandler event class:


The 'subject' (Speedometer) can have multiple observers, each of which will be notified whenever. an event occurs on the Speedometer object. 
The Speedometer class looks like this:
