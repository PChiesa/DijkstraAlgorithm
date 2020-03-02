using System.Collections.Generic;

namespace Dijkstra
{
    public class ShortestPathfinder
    {
        const int infinity = int.MaxValue;
        private List<bool> visited;
        private List<int> distance;

        public int[,] Graph { get; private set; }

        public ShortestPathfinder(int[,] graph)
        {
            Graph = graph;
            visited = new List<bool>();
            distance = new List<int>();

            for (int i = 0; i < Graph.GetLength(0); i++)
            {
                distance.Add(infinity);
                visited.Add(false);
            }

        }

        private int MinimalDistance()
        {
            int minimalDistanceIndex = 0;
            int currentMin = infinity;
            for (int i = 0; i < distance.Count; i++)
            {
                if (!visited[i] && distance[i] < currentMin)
                {
                    currentMin = distance[i];
                    minimalDistanceIndex = i;
                }
            }

            return minimalDistanceIndex;
        }

        public List<int> FindPathBetween(int start, int finish)
        {
            distance[start] = 0;

            for (int i = 0; i < Graph.GetLength(0); i++)
            {
                i = MinimalDistance();
                visited[i] = true;
                if (i == finish)
                    break;

                for (int j = 0; j < Graph.GetLength(1); j++)
                {
                    if (Graph[i, j] == 0 || visited[j])
                        continue;

                    if (Graph[i, j] + distance[i] < distance[j])
                        distance[j] = Graph[i, j] + distance[i];
                }
            }

            return distance;
        }
    }
}