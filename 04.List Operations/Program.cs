using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            while (command[0] != "End")
            {


                switch (command[0])
                {

                    case "Add":
                        number.Insert(number.Count, int.Parse(command[1]));
                        break;

                    case "Insert":
                        if (int.Parse(command[2]) > number.Count - 1 || int.Parse(command[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        number.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) > number.Count - 1 || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        number.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Shift":
                        switch (command[1])
                        {
                            case "left":
                                for (int i = 0; i < int.Parse(command[2]); i++)
                                {
                                    int movedNumber = number[0];
                                    number.Remove(number[0]);
                                    number.Insert(number.Count, movedNumber);


                                }
                                break;
                            case "right":
                                for (int i = 0; i < int.Parse(command[2]); i++)
                                {

                                    int movedNumber = number[number.Count - 1];
                                    number.Remove(number[number.Count - 1]);
                                    number.Insert(0, movedNumber);

                                }
                                break;
                        }
                        break;
                }


                command = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToList();


            }
            Console.WriteLine(string.Join(" ", number));

        }
    }
}
