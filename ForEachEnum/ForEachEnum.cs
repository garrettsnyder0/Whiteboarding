using System;

namespace ForEachEnum
{
    class ForEachEnum
    {

        //enum cannot be inside a method as it is a static class
        //always implicitly public static final
        enum Cars
        {
            toyota,
            honda,
            ford,
            chevy,
            austinHealey,
            jaguar,
            mg,
            lamborghini,
            mitsubishi
        }

        static public void doStuff()
        {
            //This does not work
            //foreach (var vehicle in cars)
            // {
            //     Console.WriteLine(vehicle);
            // }

            //The loop must be written like this to work
            //this will give you a string
            foreach (var vehicle in Enum.GetNames(typeof(Cars)))
            {
                Console.WriteLine(vehicle);
            }

            //or 
            //This will give you the literal value not a string
            //ex. toyota vs. "toyota"
            foreach (var vehicle in Enum.GetValues(typeof(Cars)))
            {
                Console.WriteLine(vehicle);
            }
        }


        static void Main(string[] args)
        {
            doStuff();
            Console.ReadKey();
        }
    }
}
