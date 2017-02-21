using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class MazeSolving : IProgram
    {
        public void Run()
        {
            Console.Write("Enter the width of the maze: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of the maze: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Do you want to fill the maze automatically (Y/N): ");
            bool autoFill = Console.ReadLine().ToUpper().Equals("Y");

            int[,] maze = new int[width, length];
            if (autoFill)
            {
                maze = FillMaze(width, length);

                for (int w = 0; w < length; w++)
                {
                    for (int l = 0; l < width; l++)
                        Console.Write("{0} ", maze[w, l]);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Enter exit location");
            Console.Write("X: ");
            int exitX = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int exitY = int.Parse(Console.ReadLine());

            FindTheExit(maze, width, length, exitX, exitY);
                
        }

        private void FindTheExit(int[,] maze, int width, int length, int exitX, int exitY)
        {
            int movements = 0;
            bool[,] nodesVisited = new bool[width, length];
            

        }

        private int[,] FillMaze(int width, int length)
        {
            var maze = new int[width, length];

            for (int w = 0; w < length; w++)
                for (int l = 0; l < width; l++)
                    maze[w, l] = (int)new Random(2).Next(0, 1);

            return maze;
        }
    }
}
