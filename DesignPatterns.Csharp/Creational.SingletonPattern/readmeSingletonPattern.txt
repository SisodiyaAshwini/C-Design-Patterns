Purpose: Ensure a class allows only one object to be created, providing a single point of access to it.

The Singleton pattern provides a way of ensuring that only one instance of a particular class can ever be created. So how can we stop other objects from just invoking new multiple times? 
There are several ways of accomplishing this, and the "traditional" approach that you may often encounter is to make your constructor private but provide a public static getter method that returns a static instance of the Singleton class.

Note that the Instance getter will only instantiate the object once and so the same instance will always be returned. 
The constructor is private to prevent client programs from calling new, thus enforcing the fact that only one object can ever be created,
