using DesignPatterns.Csharp.Behavioural.ObserverPattern.Client;
using DesignPatterns.Csharp.Creational.AbstractFactoryPattern.Client;
using DesignPatterns.Csharp.Creational.BuilderPattern.Client;
using DesignPatterns.Csharp.Creational.FactoryMethodPattern.Client;
using DesignPatterns.Csharp.Creational.SingletonPattern.Client;
using System;

namespace DesignPatterns.Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creational Patterns
            AbstractFactoryPatternClient.Practice();
            BuilderPatternClient.Practice();
            FactoryMethodPatternClient.Practice();
            SingletonPatternClient.Practice();

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Behavioural Patterns");
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Behavioural Patterns
            ObserverPatternClient.Practice();
        }
    }
}
