using System;

namespace FirstProject
{
    class Program
    {
        // klassvariabel = fält = field/public field
        // instans = object
        // referenstyp = reference type ( och i kontexten av C# även = pekare = pointer)

        const string name = "Strumpan";
        static void Main(string[] args)
        {
            const string lillansName = "Madame";
            Console.WriteLine(name);
            Console.WriteLine(lillansName);
            
        }
    }
}
