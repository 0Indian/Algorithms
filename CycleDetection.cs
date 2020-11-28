using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.AdjencyListTraversals
{
    public class CycleDetection
    {
        private readonly int verticesCount;
        private List<int>[] adjencyListArray;

        public CycleDetection(int vertexCount)
        {
            verticesCount = vertexCount;
            adjencyListArray = new List<int>[verticesCount];

            for(int  i =  0; i < verticesCount; i++)
            {
                adjencyListArray[i] = new List<int>();
            }
        }

        public void AddEdge(int source,int destination)
        {
            adjencyListArray[source].Add(destination);
        }

        private bool IsCyclicUtil(bool[] visited,bool[] rectStack,int val)
        {
            if(rectStack[val])
            {
                return true;
            }
            if(visited[val])
            {
                return false;
            }

            rectStack[val] = true;
            visited[val] = true;

            List<int> adjVertices = adjencyListArray[val];

            foreach(int vertex in  adjVertices)
            {
                if (IsCyclicUtil(visited, rectStack, vertex))
                {
                    return true;
                }                   
            }
            rectStack[val] = false;
            return false;
        }
        public bool IsCyclic()
        {

            bool[] visited = new bool[verticesCount];
            bool[] rectStack = new bool[verticesCount];

            for(int  i =  0; i < verticesCount; i++)
            {
                if (IsCyclicUtil(visited,rectStack,i))
                {
                    return true;
                }                    
            }
            return false;
        }
    }
}
