using System;
using System.Linq;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // number of columns.
        int H = int.Parse(inputs[1]); // number of rows.
        List<List<string>> lines = new(); // for saving the rows representing the maze
        for (int i = 0; i < H; i++)
        {
            string LINE = Console.ReadLine(); // represents a line in the grid and contains W integers. Each integer represents one room of a given type.
            List<string> strRow = LINE.Split(' ').ToList();
            lines.Add(strRow); // saving all rows
        }
        int EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int XI = int.Parse(inputs[0]);
            int YI = int.Parse(inputs[1]);
            string POS = inputs[2];

            switch (lines[YI][XI])
            {
                case "1":
                case "3":
                case "7":
                case "8":
                case "9":
                case "12":
                case "13":
                    YI++;
                    break;
                case "2":
                case "6":
                    XI += POS == "LEFT" ? 1 : -1;
                    break;
                case "4":
                    if (POS == "TOP")
                    {
                        XI--;
                    }
                    else
                    {
                        YI++;
                    }
                    break;
                case "5":
                    if (POS == "TOP")
                    {
                        XI++;
                    }
                    else
                    {
                        YI++;
                    }
                    break;
                case "10":
                    XI--;
                    break;
                case "11":
                    XI++;
                    break;
            }

            // One line containing the X Y coordinates of the room in which you believe Indy will be on the next turn.
            Console.WriteLine($"{XI} {YI}");
        }
    }
}