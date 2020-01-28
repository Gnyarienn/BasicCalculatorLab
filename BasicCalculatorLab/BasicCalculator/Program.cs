using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*** WHEATHER CALCULATOR ***");

            //declare variables
            string input;
            int temp;
            int relhumidity;
            int dewpoint;



            //ask user for temp
            Console.WriteLine("Enter the temperature");
            input = Console.ReadLine();
            temp = int.Parse(input);

            //ask user for rel humidity 
            Console.WriteLine("enter RH");
            input = Console.ReadLine();
            relhumidity = int.Parse(input);

            //ask user for dew point 
            dewpoint= temp - (9 * (100 - relhumidity) / 25);

            //print the dewpoint
            Console.WriteLine("Dew point =" + dewpoint);

            Console.WriteLine("Enter windspeed");
            int windspeed = int.Parse(Console.ReadLine());

            double windchill = 35.74 + (0.6215 * temp) - 37.5 * Math.Pow(windspeed, 0.16)
               + 0.4275 * temp * Math.Pow(windspeed, 0.16);
            Console.WriteLine("Wind Chill is" + windchill);


            

        }
    }
}

