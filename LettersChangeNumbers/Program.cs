using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            double totalSum = 0;

            foreach (string inputItem in input)
            {
                char letter1 = inputItem[0];
                char letter2 = inputItem[inputItem.Length - 1];

                string num = inputItem.Substring(1, inputItem.Length - 2);
                int number = int.Parse(num);
                double sum = 0;
                int letterPosition = 0;

                if (char.IsUpper(letter1))
                {
                    letterPosition = letter1 - 64;

                    sum += (double)number / letterPosition;
                }
                else
                {
                    letterPosition = letter1 - 96;

                    sum += (double)number * letterPosition;
                }

                if (char.IsUpper(letter2))
                {
                    letterPosition = letter2 - 64;

                    sum -= letterPosition;
                }
                else
                {
                    letterPosition = letter2 - 96;

                    sum += letterPosition;
                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
