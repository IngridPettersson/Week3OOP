using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            TextUtils.Animate("Welcome to the Zoo!".ToUpper());

            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog(10));

            foreach (var animal in animals)
            {
                
                Console.WriteLine(animal);
                Dog lunch = new Dog(1);
                animal.Eat(lunch);
                Console.WriteLine("------LUNCH------");
                Console.WriteLine(animal);

                Console.WriteLine();
            }


        }


    }

    
}
