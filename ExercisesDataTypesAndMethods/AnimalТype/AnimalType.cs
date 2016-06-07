using System;

namespace AnimalТype
{
    public class AnimalType
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            string animalType = TakeAnimalType(input);
            Console.WriteLine(animalType);
        }

        private static string TakeAnimalType(string input)
        {
            string animalType = string.Empty;
            switch (input)
            {
                case "dog":
                    animalType = "mammal";
                    break;
                case "snake":
                case "crocodile":
                case "tortoise":
                    animalType = "reptile";
                    break;
                default:
                    animalType= "unknown";
                    break;
            }

            return animalType;
        }
    }
}
