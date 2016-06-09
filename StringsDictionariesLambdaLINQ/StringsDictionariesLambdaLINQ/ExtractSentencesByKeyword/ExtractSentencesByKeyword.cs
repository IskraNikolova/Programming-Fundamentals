using System;

namespace ExtractSentencesByKeyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine()
                .Split(new char[] {'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split();
                bool isForPrint = false;
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == word)
                    {
                        isForPrint = true;
                    }
                }

                if (isForPrint)
                {
                    Console.WriteLine(sentences[i]);
                }
            }
        }
    }
}
