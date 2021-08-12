using System;

namespace DesignPatterns.Csharp.Creational.SingletonPattern.Client
{
    public class SingletonPatternClient
    {
        public static void Practice()
        {
            Console.WriteLine("next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " + SerialNumberGenerator.Instance.NextSerial);

        }
    }
}
