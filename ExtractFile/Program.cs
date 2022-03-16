using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] splitters = { '\\', '.' };

            List<string> path = Console.ReadLine()
                .Split(splitters, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string fileName = path[path.Count - 2];
            string fileExtension = path[path.Count - 1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
