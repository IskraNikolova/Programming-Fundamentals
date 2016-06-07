using System;

namespace ExchangeVariableValues
{
    public class ExchangeVariableValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}\nb = {b}");

            int repository = a;          
            a = b;
            b = repository;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}\nb = {b}");
        }
    }
}
