using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Red", "Green", "Yellow" };
            string randomcolor = PickRandomColor(colors);
            Console.WriteLine($"Arvuti valis {randomcolor}.");
            DisplayRandomColor(colors);
        }
        private static int GenerateRandomNumberForArrays(string[] somearrays)
        {
            Random rnd = new Random();
            return rnd.Next(0, somearrays.Length);
        }
        private static string PickRandomColor(string[] someArrays)
        {
            return someArrays[GenerateRandomNumberForArrays(someArrays)];
        }


        private static void DisplayRandomColor(string[] someArrays)
        {
            Console.WriteLine(someArrays[GenerateRandomNumberForArrays(someArrays)]); 

        }

    }
}
