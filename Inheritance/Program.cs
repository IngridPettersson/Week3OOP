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
            Console.WriteLine();
            animals.Add(new Cat());
            animals.Add(new Dog(10));
            Console.WriteLine($"\nSeems like our animals are hungry... let's give them something to eat!\n");

            foreach (var animal in animals)
            {
                
                Console.WriteLine(animal);
                animal.Eat(new Grass(2));
                animal.Eat(new Dog(1));
                Console.WriteLine("------LUNCH------");
                Console.WriteLine(animal);

                Console.WriteLine();
            }


        }


    }

    
}
