using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    // Abstract classes can not be instantiated, they are only to be inherited from
    abstract class Animal
    {
        public double Weight { get; set; }
        public Animal(double weight)
        {
            Weight = weight;
            MakeSound();
        }

        public virtual void Eat(Animal food)
        {
            this.Weight += food.Weight;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}";
        }

        public abstract void MakeSound(); // en abstrakt metodsignatur

    }
}
