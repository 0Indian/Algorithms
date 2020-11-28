using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraversal
{
    public class GraphAdj
    {
        int VertexCount { get; }
        bool[,] AdjMatrix { get; set; }
        public GraphAdj(int v)
        {
            VertexCount = v;
            AdjMatrix = new bool[VertexCount,VertexCount];
        }
        public void AddEdge(int i , int j)
        {
            if(i>=0 && i < VertexCount  && j >= 0 && j<VertexCount)
            {
                AdjMatrix[i,j] = true;
            }
        }
        public void RemoveEdge(int i, int j)
        {
            if (i >= 0 && i < VertexCount && j >= 0 && j < VertexCount)
            {
                AdjMatrix[i, j] = false;
            }
        }
        public bool IsEdge(int i, int j)
        {
            if (i >= 0 && i < VertexCount && j >= 0 && j < VertexCount)
            {
                return AdjMatrix[i, j];
            }
            else
            {
                return false;
            }
        }

    }
}
