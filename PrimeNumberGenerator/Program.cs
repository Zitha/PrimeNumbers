using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 50;
            foreach (int prime in GetPrimeNumbers(maxValue))
            {
                Console.WriteLine($"{prime}");
            }
            Console.ReadLine();
        }
         
        private static IEnumerable<int> GetPrimeNumbers(int maxValue)
        {
            List<int> primeNumbers = new List<int>();

            bool[] prime = new bool[maxValue];
            for (int i = 0; i < maxValue; i++)
                prime[i] = true; // Mark all numbers as prime number 

            for (int p = 2; p * p < maxValue; p++)  //loop through all the numbers in the list where power 2 is less that the max value
            {
                if (prime[p] == true) //Check if the number a prime number
                {
                    for (int i = p * p; i < maxValue; i += p)
                        prime[i] = false; // set all the multiple of prime number to false on the list 
                }
            }
            
            for (int i = 2; i < maxValue; i++)
            {
                if (prime[i] == true)
                    primeNumbers.Add(i); // Add all the prime numbers to the list
            }
            return primeNumbers;
        } 
    }
}
