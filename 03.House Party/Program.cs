using System;
using System.Collections.Generic;

namespace _03.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            List<string> listGuests = new List<string>();

            for (int i = 0; i < row; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string guest = command[0];

                if (command.Length > 3)
                {
                    if (listGuests.Contains(guest))
                    {

                        listGuests.Remove(guest);

                    }

                    else
                    {

                        Console.WriteLine($"{guest} is not in the list!");
                    }
                }
                else if (command.Length <= 3)
                {
                    if (listGuests.Contains(guest))
                    {

                        Console.WriteLine($"{guest} is already in the list!");

                    }

                    else
                    {
                        listGuests.Add(guest);
                        

                    }
                }

            }
        
            Console.WriteLine(string.Join(Environment.NewLine, listGuests));
        }
    }
}