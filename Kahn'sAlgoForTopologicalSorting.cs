using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.AdjencyListTraversals
{
    // Time Complexity O(V+E) Space Complexity O(V)
    public class Kahn_sAlgoForTopologicalSorting
    {
        private int verticesCount;
        private List<int>[] adjencyListArray;

        public Kahn_sAlgoForTopologicalSorting(int vertexCount)
        {
            verticesCount = vertexCount;
            adjencyListArray = new List<int>[verticesCount];
        }
        public void AddEdge(int v, int w)
        {
            adjencyListArray[v].Add(w);
        }

        public void TopoLogicalSort()
        {
            // Array creation to store the indegree
            int[] indegreeArray = new int[verticesCount];

            // Traversing the adjency list to fill the indegrees
            for(int i = 0; i < verticesCount; i++)
            {
                List<int> adjList = adjencyListArray[i];
                foreach(int item in adjList)
                {
                    indegreeArray[item]++;
                }
            }

            Queue<int> queue = new Queue<int>();
            for(int i =  0; i < verticesCount; i++)
            {
                if(indegreeArray[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            // Initialize count of visited node
            int count = 0; 

            List<int> topologicallySortedList = new List<int>();

            while(queue.Count!=0)
            {
                int vertex = queue.Dequeue();
                topologicallySortedList.Add(vertex);

                foreach(int val in adjencyListArray[vertex])
                {
                    if(--indegreeArray[val] == 0)
                    {
                        queue.Enqueue(val);
                    }                       
                }
                count++;
            }

            // Check if there is a cycle
            if(count != verticesCount)
            {
                Console.WriteLine("Cycle exists");
                return;
            }

            // Print Topological sorted list
            foreach(int val in topologicallySortedList)
            {
                Console.WriteLine(val + " ");
            }
        }
    }
}
