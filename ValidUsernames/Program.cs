using System;
using System.Linq;
using System.Collections.Generic;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> validUsernames = new List<string>();

            foreach (string username in usernames)
            {
                if (CheckUsername(username))
                {
                    validUsernames.Add(username);
                }
            }

            foreach (string validUsername in validUsernames)
            {
                Console.WriteLine(validUsername);
            }
        }

        static bool CheckUsername(string username)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                bool flag = true;

                foreach (char letter in username)
                {
                    if (char.IsLetterOrDigit(letter) || letter == '_' || letter == '-')
                    {
                        flag = true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return flag;
            }
            else
            {
                return false;
            }
        }
    }
}
