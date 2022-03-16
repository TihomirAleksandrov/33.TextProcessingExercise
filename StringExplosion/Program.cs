using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> characters = input.ToList();

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i] == '>')
                {
                    int power = 0;
                    int index = i;
                    
                    while (true)
                    {
                        if (index >= characters.Count)
                        {
                            break;
                        }
                        else
                        {
                            if (characters[index] == '>')
                            {
                                if (index != characters.Count - 1)
                                {
                                    if (char.IsDigit(characters[index + 1]))
                                    {
                                        power += int.Parse(characters[index + 1].ToString());
                                    }
                                    index++;

                                    if (power == 0)
                                    {
                                        break;
                                    }

                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                characters.RemoveAt(index);
                                power -= 1;

                                if (power == 0)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            StringBuilder text = new StringBuilder();

            foreach (char c in characters)
            {
                text.Append(c);
            }

            Console.WriteLine(text);
        }
    }
}
