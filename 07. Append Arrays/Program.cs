using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|")
                .ToList();

            input.Reverse();

            List<string> result = new List<string>();
            foreach (string currentNumber in input)
            {
                string[] numbers = currentNumber
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
