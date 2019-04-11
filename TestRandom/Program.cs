using System;

namespace TestRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare random object
            Random rnd = new Random();

            // Ask for user input
            int userInp;
            Console.WriteLine("Type a number of your choice:");
            userInp = Convert.ToInt32(Console.ReadLine());

            // Generate random number between 1-6 (Next is a Method)
            int dado = rnd.Next(1, 6);

            // Addition of user input with random dice number
            int sum = userInp + dado;

            // Print out results
            Console.WriteLine($"User number was: {userInp}");
            Console.WriteLine($"Random number was: {dado}");
            Console.WriteLine($"The sum of both is: {sum}");

            Console.ReadKey();
        }
    }
}
