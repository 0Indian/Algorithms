using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.AdjencyListTraversals
{
    public class BFS
    {
        private readonly int verticesCount;
        private List<int>[] adjencyListArray;

        public BFS(int vertexCount)
        {
            verticesCount = vertexCount;
            adjencyListArray = new List<int>[verticesCount];
            for(int  i = 0; i < verticesCount; i++)
            {
                adjencyListArray[i] = new List<int>();
            }
        }

        /// <summary>
        /// Adding the Edge
        /// </summary>
        /// <param name="v"></param>
        /// <param name="w"></param>
        public void AddEdge(int v, int w)
        {
            adjencyListArray[v].Add(w);
        }
        /// <summary>
        /// Traversal method
        /// </summary>
        /// <param name="vertexToStartWith"></param>
        public void BFSTraversal(int vertexToStartWith)
        {
            bool[] visited = new bool[verticesCount];

            // make the node as visited
            visited[vertexToStartWith] = true;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(vertexToStartWith);

            while(queue.Count!=0)
            {
                int vertex = queue.Dequeue();
                Console.WriteLine(vertex);

                // Retriving the adjacent nodes and adding them to queue if unvisted
                List<int> adjacentList = adjencyListArray[vertex];
                foreach(int ver in adjacentList)
                {
                    if (!visited[ver])
                    {
                        visited[ver] = true;
                        queue.Enqueue(ver);
                    }
                }
            }
        }
    }
}
