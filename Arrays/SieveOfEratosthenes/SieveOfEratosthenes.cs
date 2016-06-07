using System;
using System.Collections.Generic;

namespace SieveOfEratosthenes
{
    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine().Trim());        
            bool[] isPrime = new bool[n]; 
            for (long i = 2; i < n; i++)
            {
                isPrime[i] = true; 
            }
  
            List<long> primeNumbers = new List<long>();
            for (long j = 2; j < n; j++)
            {
                if (isPrime[j]) 
                {
                    primeNumbers.Add(j);
                    for (long p = 2; (p*j) < n; p++)
                    {
                        isPrime[p*j] = false;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", primeNumbers));
        }
    }
}
