using System;
using System.Collections.Generic;

namespace DifferentIntegersSize
{
    public class DifferentIntegerSize
    {
        public static void Main()
        {
            string number = Console.ReadLine().Trim();

            long tryParseLong = 0;
            bool parseLong = long.TryParse(number, out tryParseLong);
            if (!parseLong)
            {
                Console.WriteLine($"{number} can't fit in any type");
                return;
            }

            Console.WriteLine($"{number} can fit in:");
            sbyte tryParseSbyte = 0;
            bool parseSbyte = sbyte.TryParse(number, out tryParseSbyte);
            if (parseSbyte)
            {
                Console.WriteLine("* sbyte");
            }

            byte tryParseByte = 0;
            bool parseByte = byte.TryParse(number, out tryParseByte);
            if (parseByte)
            {
                Console.WriteLine("* byte");
            }

            short tryParseShort = 0;
            bool parseShort = short.TryParse(number, out tryParseShort);
            if (parseShort)
            {
                Console.WriteLine("* short");
            }

            ushort tryParseUshort = 0;
            bool parseUshort = ushort.TryParse(number, out tryParseUshort);
            if (parseUshort)
            {
                Console.WriteLine("* ushort");
            }

            int tryParseInt = 0;
            bool parseInt = int.TryParse(number, out tryParseInt);
            if (parseInt)
            {
                Console.WriteLine("* int");
            }

            uint tryParseUint = 0;
            bool parseUint = uint.TryParse(number, out tryParseUint);
            if (parseUint)
            {
                Console.WriteLine("* uint");
            }

            if (parseLong)
            {
                Console.WriteLine("* long");
            }
        }
    }
}

