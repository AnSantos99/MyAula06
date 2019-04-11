using System;

namespace TestRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare random object
            Random rnd = new Random();

            // Generate random number between 1-6 (Next is a Method)
            int dado = rnd.Next(1, 6);

            // Print out random number
            Console.WriteLine(dado);
        }
    }
}
