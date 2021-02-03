using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Cat : Animal
    {
        // Man ärver ansvaret att anropa basklassens constructor.
        public Cat() : base(4.5)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meaooow");
        }

        public override string ToString()
        {
            return $"Cat ({base.ToString()})";
        }
    }
}
