using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int i = 0;
            while (firstDeck.Count != 0 && secondDeck.Count != 0)
            {
                if (firstDeck[0] == secondDeck[0])
                {
                    firstDeck.RemoveAt(i);
                    secondDeck.RemoveAt(i);
                }
                else if (firstDeck[i] > secondDeck[i])
                {
                    firstDeck.Insert(firstDeck.Count, firstDeck[0]);
                    firstDeck.Insert(firstDeck.Count, secondDeck[0]);
                    secondDeck.RemoveAt(i);
                    firstDeck.RemoveAt(i);
                }
                else if (secondDeck[i]>firstDeck[i])
                {
                    secondDeck.Insert(secondDeck.Count, secondDeck[0]);
                    secondDeck.Insert(secondDeck.Count, firstDeck[0]);
                    firstDeck.RemoveAt(i);
                    secondDeck.RemoveAt(i);
                }
                
            }
            if(firstDeck.Count-1>secondDeck.Count-1)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
