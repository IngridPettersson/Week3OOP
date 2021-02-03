using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Strumpan");
            // p.Name = "Bo"; // set is private
            Console.WriteLine(p.Name); // get is public
        }

        public static void Print(Person personToPrint)
        {
            Console.WriteLine(personToPrint.Name);
        }
    }

    class Person
    {
        public string Name { get; private set; }
        public Person(string name)
        {
            Name = name;
            // using this keyword like this. You refer to the 
            Program.Print(this);
        }

        //public string name;
        // Extern kod gör inte skillnad på automatic properties eller full properties så inget behöver kompilera om.
        // Använd INTE publika klassvariabler, men privata klassvariabler är JÄTTEBRA!
    }

    class Life
    {
        string boost;
        string _boost;

        public string Boost { get; set; }

        public Life(string boost)
        {
            this.boost = boost;
            Console.WriteLine(boost);

            _boost = boost;
            Console.WriteLine(boost);
        }
    }
}
