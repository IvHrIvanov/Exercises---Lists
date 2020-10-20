using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();


            int[] bombPower = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

            int bomb = bombPower[0];
            int power = bombPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    int endIndexToRemo = endIndex-startIndex + 1;

                    numbers.RemoveRange(startIndex, endIndexToRemo);

                    i = startIndex - 1;
                }


            }
            Console.WriteLine(numbers.Sum());
        }
    }
}