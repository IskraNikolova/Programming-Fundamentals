using System;

namespace CensorYourEmailAddress
{
    public class CensorYourEmailAddress
    {
        public static void Main()
        {
            string email = Console.ReadLine();
            string[] text = Console.ReadLine().Split();

            string username = email.Split('@')[0];
            string domain = email.Split('@')[1];
            string replacement = new string('*', username.Length) + '@' + domain;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == email)
                {
                    text[i] = replacement;
                }
            }

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
