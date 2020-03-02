using System;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            var spf = new ShortestPathfinder(
                    new int[,] {
{0, 3, 0, 1, 0, 0, 0, 0 },
{3, 0, 7, 0, 7, 0, 0, 0 },
{0, 7, 0, 11, 3, 0, 0, 0},
{1, 0, 11, 0, 0, 0, 3, 0},
{0, 7, 3, 0, 0, 0, 0, 7 },
{0, 0, 0, 0, 0, 0, 1, 11},
{0, 0, 0, 3, 0, 1, 0, 0 },
{0, 0, 0, 0, 7, 11, 0, 0}
                    }
            );

            var distance = spf.FindPathBetween(0, 7);

            Console.WriteLine($"Shortest distance from start to finish is {distance[7]}");
        }
    }
}
