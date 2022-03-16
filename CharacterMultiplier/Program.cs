using System;
using System.Linq;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string input1 = input[0];
            string input2 = input[1];

            int sum = SumCharacterCodes(input1, input2);

            Console.WriteLine(sum);
        }

        static int SumCharacterCodes(string input1, string input2)
        {
            string shorterWord = (input1.Length < input2.Length) ? input1 : input2;
            string longerWord = (input1.Length >= input2.Length) ? input1 : input2;
            int sum = 0;

            for (int i = 0; i < shorterWord.Length; i++)
            {
                sum += (shorterWord[i] * longerWord[i]);
            }

            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }

            return sum;
        }
    }
}
