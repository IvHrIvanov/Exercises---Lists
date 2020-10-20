using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> passager = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (passager[0] != "end")
            {
                if (passager[0] == "Add")
                {
                    wagons.Add(int.Parse(passager[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(passager[0]) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(passager[0]);
                            break;
                        }
                    }

                }

                passager = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}