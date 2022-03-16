using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            List<int> digits = new List<int>();

            foreach (char num in num1.Reverse())
            {
                
                digits.Add((int)char.GetNumericValue(num));
            }

            StringBuilder finalNum = new StringBuilder();

            if (num1 == "0" || num2 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int currNum = 0;
                int excessNum = 0;

                for (int i = 0; i < digits.Count; i++)
                {
                    int sum = (num2 * digits[i]) + excessNum;

                    currNum = sum % 10;
                    excessNum = sum / 10;

                    finalNum.Append(currNum);
                }

                if (excessNum != 0)
                {
                    finalNum.Append(excessNum);
                }

                string number = finalNum.ToString();
                char[] reversedDigits = number.ToCharArray();
                Array.Reverse(reversedDigits);
                string finalNumber = new string(reversedDigits);

                Console.WriteLine(finalNumber);
            }
        }
    }
}
