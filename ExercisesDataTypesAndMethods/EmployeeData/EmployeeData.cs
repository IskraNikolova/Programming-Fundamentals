namespace EmployeeData
{
    using System;

    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = Console.ReadLine().Trim();
            string lastName = Console.ReadLine().Trim();
            int age = int.Parse(Console.ReadLine().Trim());
            string gender = Console.ReadLine().Trim();
            string id = Console.ReadLine().Trim();
            string uniqueEmployeeNumber = Console.ReadLine().Trim();

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");
        }
    }
}
