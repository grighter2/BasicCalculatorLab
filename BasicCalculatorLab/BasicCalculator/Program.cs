using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WEATHER CALCULATOR ***");

            Console.WriteLine("Enter the temperature in Farenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int tempFarenheit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Relative Humidity");
            int RelHumid = int.Parse(Console.ReadLine());

            int AlmostEnd = (9 * (100 - RelHumid)) / 25;

            double DewPoint = tempFarenheit - AlmostEnd;

            Console.WriteLine("The Dew Point is " + DewPoint);

            Console.WriteLine("Enter the Wind Speed");
            int WindSpeed = int.Parse(Console.ReadLine());

            double Base = WindSpeed;
            double exponent = 0.16;
            double Result = Math.Pow(Base, exponent);

            double WindChill = 35.74 + (.6215 * tempFarenheit) - (35.75 * Result) + (.4275 * tempFarenheit * Result);

            Console.WriteLine("The Wind Chill is " + WindChill);

        }
    }
        
}
