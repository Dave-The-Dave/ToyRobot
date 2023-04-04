using System;
using ToyRobot.Models;

namespace ToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {

            Table table = new Table(5);
            iRobot robot = new Robot(table);

            Console.WriteLine($"A table of size {table.X} * {table.Y} has been created and a Toy Robot is avaialable to place. \r\n");

            while (true)
            {
                string input = Console.ReadLine();

                string[] command = input.Split(' ',',','\r');

                switch (command[0].ToUpper())
                {
                    case "PLACE":
                        int x, y;
                        Enum.TryParse(command[3], out Direction direction);
                        if (int.TryParse(command[1], out x) && int.TryParse(command[2], out y))
                            robot.Place(x, y, direction);
                        break;

                    case "MOVE":
                        robot.Move();
                        break;

                    case "LEFT":
                        robot.Left();
                        break;

                    case "RIGHT":
                        robot.Right();
                        break;

                    case "REPORT":
                        Console.WriteLine(robot.Report() + "\r\n");
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}