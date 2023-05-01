using System;
using System.Collections.Generic;

// This is my solution to the Fibonacci Sequence program challenge by Ka

namespace FibonacciSequence
{
    class FindNthFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            // Prompts the user to enter a number.
            int number = int.Parse(Console.ReadLine());

            List<int> fibonacciSequence = GenerateFibonacci(number);


            // fibonacci sequence is displayed in the console.
            Console.WriteLine("Fibonacci Sequence:");
            foreach (int num in fibonacciSequence)
            {
                Console.WriteLine(num + " ");
            }

        }

        public static List<int> GenerateFibonacci(int number)
        {
            List<int> fibonacci = new List<int> { 0, 1 };
            
            // Generates a fibonacci sequence using a for list.
            for (int i = 2; ; i++)
            {
                int nextNumber = fibonacci[i - 1] + fibonacci[i - 2];
                if (nextNumber > number)
                    break;
                fibonacci.Add(nextNumber);
            }
            return fibonacci;
        }
    }
}
