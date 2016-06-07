using System;

namespace Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            string firstName = Console.ReadLine().Trim();
            string lastName = Console.ReadLine().Trim();
            int age = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
