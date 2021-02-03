using System;

namespace ArraysIndexing
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[] { "Håkan", "Pontus", "Anja", "Bo" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[names.Length - 1]);

            // Byt plats på första och sista värdet
            var firstPos = 0;
            var lastPos = names.Length - 1;
            var firstValue = names[firstPos]; // Håkan
            var lastValue = names[lastPos]; // Bo
            names[firstPos] = lastValue; // Bo
            names[lastPos] = firstValue; // Håkan
        }
    }
}
