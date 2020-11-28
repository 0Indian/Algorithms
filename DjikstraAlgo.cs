using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    // Adjency Matrix Implementation
    public class DjikstraAlgo
    {
        int verticesCount;
        
        public void AlgoImplementation(int[,] graphAsAdjencyMatrix,int sourceVertex)
        {
            verticesCount = graphAsAdjencyMatrix.GetLength(0);
            Console.WriteLine(verticesCount);

            int[] distArray = new int[verticesCount];

            bool[] sptSet = new bool[verticesCount];

            // setting all distances to infinity and sptSet to false as no node is included
            for(int  i =  0; i < verticesCount; i++)
            {
                distArray[i] = int.MaxValue;
                sptSet[i] = false;
            }

            // distance of source node from iteself is always 0.
            distArray[sourceVertex] = 0;

            for(int i = 0; i < verticesCount; i++)
            {

                int indexOfMin = minDistanceVertex(distArray, sptSet);

                sptSet[indexOfMin] = true;


                // Update the dist values of the adjecent vertices of the indexOfMin Vertex

                for(int j = 0; j  < verticesCount; j++)
                {
                    if(sptSet[j] == false && graphAsAdjencyMatrix[indexOfMin, j] !=0
                        && distArray[indexOfMin] !=int.MaxValue && distArray[indexOfMin] + graphAsAdjencyMatrix[indexOfMin, j] < distArray[j])
                    {
                        distArray[j] = distArray[indexOfMin] + graphAsAdjencyMatrix[indexOfMin, j];
                    }
                }              
            }

            printSolution(distArray);
        }
        // finding the index of the vertex with min distance
        private int minDistanceVertex(int[] distArray, bool[] sptSet)
        {
            int minDist = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < verticesCount; i++)
            {
                if(sptSet[i]==false && minDist > distArray[i])
                {
                    minDist = distArray[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        void printSolution(int[] dist)
        {
            Console.Write("Vertex \t\t Distance "
                          + "from Source\n");
            for (int i = 0; i < verticesCount; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }
    }
}
