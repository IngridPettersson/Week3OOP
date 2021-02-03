using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Dog : Animal
    {
        // Basklassens constructor körs först, och sedan körs Dog-klassens constructor
        public Dog(double weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woff!");
        }

        public override void Eat(IEdible food)
        {
            Weight += food.Weight * 0.8;
        }

        public override string ToString()
        {
            return $"Dog ({base.ToString()})";
        }
    }
}
