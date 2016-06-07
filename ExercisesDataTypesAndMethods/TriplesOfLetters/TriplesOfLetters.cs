namespace TriplesOfLetters
{
    using System;

    public class TriplesOfLetters
    {
        private static int k;
        private static int n = 3;
        private static int[] taken;
        public static void Main()
        {
            k = int.Parse(Console.ReadLine().Trim());

            taken = new int[n];
            Variate(0);
        }

        private static void Print(int l)
        {
            for (int i = 0; i <= l - 1; i++)
            {
                char printResult = (char)(taken[i]);
                Console.Write(printResult);
            }

            Console.WriteLine();
        }

        private static void Variate(int l)
        {
            if (l >= n)
            {
                Print(l);
                return;
            }

            for (int i = 97; i < 97 + k; i++)
            {
                taken[l] = i;
                Variate(l + 1);
            }
        }
    }
}
