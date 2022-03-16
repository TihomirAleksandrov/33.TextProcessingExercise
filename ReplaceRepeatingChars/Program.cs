using System;
using System.Linq;
using System.Text;

namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder finalText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1)
                {
                    if (input[i] != input[i + 1])
                    {
                        finalText.Append(input[i]);
                    }
                }
                else
                {
                    finalText.Append(input[i]);
                }
            }

            Console.WriteLine(finalText);
        }
    }
}
