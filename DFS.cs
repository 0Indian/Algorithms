using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.AdjencyListTraversals
{
    /// <summary>
    ///  DFS for connected Graph(All vertices are reachable))
    /// </summary>
    public class DFS
    {
        private readonly int verticesCount;
        private List<int>[] adjencyListArray;

        public DFS(int v)
        {
            verticesCount = v;
            adjencyListArray = new List<int>[verticesCount];
            for(int  i = 0; i< verticesCount; i++)
            {
                adjencyListArray[i] = new List<int>();
            }
        }

        public void AddEdge(int rootVertex, int addedVertex)
        {
            adjencyListArray[rootVertex].Add(addedVertex);
        }

        public void DFSTraversal(int vertexToStartWith)
        {
            bool[] visitedArray = new bool[verticesCount];

            DFSUtil(vertexToStartWith, visitedArray);
        }

        // Recursively visit the adjacent vertex
        private void DFSUtil(int vertex, bool[] visitedArray)
        {
            visitedArray[vertex] = true;
            Console.WriteLine(vertex + " ");

            List<int> adjList = adjencyListArray[vertex];
            foreach(int vertices in adjList)
            {
                if(!visitedArray[vertices])
                {
                    DFSUtil(vertices, visitedArray);
                }             
            }
        }

        /// For disconnected graph we make a few changes.
        /// 1) Iterate over all vertcies in DFSTraversal fuction;
        /// 2) we call DFSTraversal without any parameter
        public void DFSTraversal()
        {
            bool[] visitedArray = new bool[verticesCount];

            for(int i = 0;i< verticesCount; i++)
            {
                if(!visitedArray[i])
                {
                    DFSUtil(i, visitedArray);
                }             
            }            
        }
    }

   
}
