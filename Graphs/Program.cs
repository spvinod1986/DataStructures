using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            graph.AddNode("David");
            graph.AddNode("John");
            graph.AddNode("Peter");
            graph.AddEdge("David", "John");
            graph.AddEdge("David", "Peter");
            graph.AddEdge("John", "Peter");
            graph.RemoveEdge("David", "Peter");
            graph.RemoveEdge("A", "B");
            graph.RemoveNode("John");
            graph.Print();

            var graph1 = new Graph();
            graph1.AddNode("A");
            graph1.AddNode("B");
            graph1.AddNode("C");
            graph1.AddNode("D");
            graph1.AddEdge("A", "B");
            graph1.AddEdge("B", "D");
            graph1.AddEdge("D", "C");
            graph1.AddEdge("A", "C");
            graph1.TraverseDepthFirstRecursive("A");
            graph1.TraverseDepthFirstIterative("A");
            graph1.TraverseBreadthFirstIterative("A");

            var graph2 = new Graph();
            graph2.AddNode("X");
            graph2.AddNode("A");
            graph2.AddNode("B");
            graph2.AddNode("P");
            graph2.AddEdge("X", "A");
            graph2.AddEdge("X", "B");
            graph2.AddEdge("A", "P");
            graph2.AddEdge("B", "P");
            var nodes = graph2.TopologicalSort();
            foreach (var node in nodes)
            {
                System.Console.WriteLine(node);
            }

            var graph3 = new Graph();
            graph3.AddNode("A");
            graph3.AddNode("B");
            graph3.AddNode("C");
            graph3.AddEdge("A", "B");
            graph3.AddEdge("B", "C");
            graph3.AddEdge("C", "A");
            System.Console.WriteLine(graph3.HasCycle());

            var weightedGraph = new WeightedGraph();
            weightedGraph.AddNode("A");
            weightedGraph.AddNode("B");
            weightedGraph.AddNode("C");
            weightedGraph.AddEdge("A", "B", 3);
            weightedGraph.AddEdge("A", "C", 2);
            weightedGraph.Print();

            var weightedGraph1 = new WeightedGraph();
            weightedGraph1.AddNode("A");
            weightedGraph1.AddNode("B");
            weightedGraph1.AddNode("C");
            weightedGraph1.AddEdge("A", "B", 1);
            weightedGraph1.AddEdge("B", "C", 2);
            weightedGraph1.AddEdge("A", "C", 10);
            var path = weightedGraph1.GetShortestPath("A", "C");
            System.Console.WriteLine(path);

            var weightedGraph2 = new WeightedGraph();
            weightedGraph2.AddNode("A");
            weightedGraph2.AddNode("B");
            weightedGraph2.AddNode("C");
            weightedGraph2.AddEdge("A", "B", 0);
            weightedGraph2.AddEdge("B", "C", 0);
            weightedGraph2.AddEdge("C", "A", 0);
            System.Console.WriteLine(weightedGraph2.HasCycle());

            var weightedGraph3 = new WeightedGraph();
            weightedGraph3.AddNode("A");
            weightedGraph3.AddNode("B");
            weightedGraph3.AddNode("C");
            weightedGraph3.AddNode("D");
            weightedGraph3.AddEdge("A", "B", 3);
            weightedGraph3.AddEdge("B", "D", 4);
            weightedGraph3.AddEdge("C", "D", 5);
            weightedGraph3.AddEdge("A", "C", 1);
            weightedGraph3.AddEdge("B", "C", 2);
            var tree = weightedGraph3.GetMinimumSpanningTree();
            tree.Print();
        }
    }
}
