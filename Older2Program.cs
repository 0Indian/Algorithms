using Graph;
using Graph.AdjencyListTraversals;
using GraphTraversal.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //DFS graph = new DFS(4);

            //    //graph.AddEdge(0, 1);
            //    //graph.AddEdge(0, 2);
            //    //graph.AddEdge(1, 2);
            //    //graph.AddEdge(2, 0);
            //    //graph.AddEdge(2, 3);
            //    //graph.AddEdge(3, 3);

            //   // graph.DFSTraversal(2);

            //    BFS graphBFS = new BFS(4);

            //    graphBFS.AddEdge(0, 1);
            //    graphBFS.AddEdge(0, 2);
            //    graphBFS.AddEdge(1, 2);
            //    graphBFS.AddEdge(2, 0);
            //    graphBFS.AddEdge(2, 3);
            //    graphBFS.AddEdge(3, 3);

            //    //graphBFS.BFSTraversal(2);

            //    TopologicalSorting topologicalSorting = new TopologicalSorting(6);

            //    topologicalSorting.AddEdge(5, 2);
            //    topologicalSorting.AddEdge(5, 0);
            //    topologicalSorting.AddEdge(4, 0);
            //    topologicalSorting.AddEdge(4, 1);
            //    topologicalSorting.AddEdge(2, 3);
            //    topologicalSorting.AddEdge(3, 1);

            //    // topologicalSorting.TopoSort();
            //    //graph.AddVertex('A');
            //    //graph.AddVertex('B');
            //    //graph.AddVertex('C');
            //    //graph.AddVertex('D');
            //    //graph.AddEdge(0, 2);
            //    //graph.AddEdge(0, 1);
            //    //graph.AddEdge(0, 3);
            //    //graph.AddEdge(1, 3);
            //    //graph.AddEdge(2, 3);
            //    //graph.BFS();

            //    CycleDetection graph = new CycleDetection(4);
            //    graph.AddEdge(0, 1);
            //    graph.AddEdge(0, 2);
            //    graph.AddEdge(1, 2);
            //    graph.AddEdge(2, 0);
            //    graph.AddEdge(2, 3);
            //    graph.AddEdge(3, 3);

            //    if (graph.IsCyclic())
            //        Console.WriteLine("Graph contains cycle"); 
            //else
            //        Console.WriteLine("Graph doesn't "
            //                            + "contain cycle");


            DjikstraAlgo djikstraAlgo = new DjikstraAlgo();
            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            djikstraAlgo.AlgoImplementation(graph,0);
        }
    }
}
