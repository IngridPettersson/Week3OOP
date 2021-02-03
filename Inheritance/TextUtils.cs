using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Zoo
{
    static class TextUtils
    {
        public static void Animate(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}
