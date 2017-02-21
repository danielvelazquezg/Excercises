using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class SnakesAndLadders : IProgram
    {
        public void Run()
        {
            //int t = Convert.ToInt32(Console.ReadLine());
            //List<TestCase> cases = new List<TestCase>();
            //for (int i = 0; i < t; i++)
            //{
            //    var testCase = new TestCase();
            //    var test = new Graph();
            //    testCase.Ladders = Convert.ToInt32(Console.ReadLine());
            //    for (int j = 0; j < testCase.Ladders; j++)
            //    {
            //        var points = Console.ReadLine().Split(' ');
            //        ((LinkedListNode<int>)test.Vertices.(Convert.ToInt32(points[0]))).Next = 
            //    }
            //    //testCase.LaddersCoords = 
            //    //testCase.Snakes = Convert.ToInt32(Console.ReadLine());
            //    //cases.Add(testCase);
            //}
            //Console.ReadKey();
        }

        public class TestCase
        {
            public int Ladders;
            public int Snakes;
            public int[,] LaddersCoords;
            public int[,] SnakesCoords;
        }

        public class Graph
        {
            public Graph()
            {
                int vertices, edges, i, j, v1, v2;
                vertices = 100;
                edges = 0;

                Node[] adjList = new Node[vertices + 1];

                int[] parent = new int[vertices + 1];
                int[] level = new int[vertices + 1];

                for (i = 0; i <= vertices; ++i) {
                    // Initialising our arrays
                    adjList[i] = null;
                    parent[i] = 0;
                    level[i] = -1;
                }

                for (i = 1; i <= vertices; ++i)
                {

                    // From vertex 'i', add a path to
                    // the next 6 locations possible
                    for (j = 1; j <= 6 && j + i <= vertices; ++j)
                    {
                        adjList[i].Next = new Node { Value = j, };
                        ++edges;
                    }
                }
            }
        }

        public class Node {
            public int Value;
            public Node Next;
        }
    }
}
