using System;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.FahrenheitToCelsius(76));
            Console.ReadLine();

            Console.WriteLine(TempConverter.CelsiusToFahrenheit(25));
            Console.ReadLine();
        }
    }
}
