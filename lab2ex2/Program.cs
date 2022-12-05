using System;

namespace lab2ex2
{
    /*  Scrieti un program care va afisa factorialul unui numar n,
        n fiind citit de la tastatura.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Introduceti numarul: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            while (n >= 1)
            {
                fact = fact * n;
                n = n - 1;
            }
            Console.WriteLine($"Factorialul numarului ales este: {fact} ");
        }
    }
}
