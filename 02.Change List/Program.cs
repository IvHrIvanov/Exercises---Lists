using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (comand[0] != "end")
            {
                switch (comand[0])
                {
                    case "Delete":
                        number.RemoveAll(n => n == int.Parse(comand[1]));
                        break;
                    case "Insert":
                        number.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                        break;
                }
                comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            }
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
