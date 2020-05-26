using System.Collections.Generic;
using System;
using System.Linq;

namespace Graphs
{
    public class WeightedGraph
    {
        private Dictionary<string, Node> nodes = new Dictionary<string, Node>();

        public void AddNode(string label)
        {
            nodes.TryAdd(label, new Node(label));
        }

        public void AddEdge(string from, string to, int weight)
        {
            var fromNode = nodes.GetValueOrDefault(from);
            if (fromNode == null)
            {
                throw new InvalidOperationException("From does not exist");
            }

            var toNode = nodes.GetValueOrDefault(to);
            if (toNode == null)
            {
                throw new InvalidOperationException("To does not exist");
            }

            fromNode.AddEdge(toNode, weight);
            toNode.AddEdge(fromNode, weight);
        }

        public void Print()
        {
            foreach (var source in nodes.Values)
            {
                System.Console.WriteLine($"Node {source.Label} is connected to following nodes:");
                foreach (var edge in source.GetEdges())
                {
                    System.Console.WriteLine(edge.To.Label);
                }
            }
        }

        public Path GetShortestPath(string from, string to)
        {
            var fromNode = nodes.GetValueOrDefault(from);
            if (fromNode == null)
            {
                throw new ArgumentException("From is not valid");
            }
            var toNode = nodes.GetValueOrDefault(to);
            if (toNode == null)
            {
                throw new ArgumentException("To is not valid");
            }

            var distances = new Dictionary<Node, int>();
            var previousNodes = new Dictionary<Node, Node>();
            var visited = new HashSet<Node>();
            var sorted = new SortedList<int, Node>();

            foreach (var node in nodes.Values)
            {
                distances.Add(node, int.MaxValue);
            }
            distances[fromNode] = 0;
            sorted.Add(0, fromNode);

            while (sorted.Any())
            {
                var minKey = sorted.Keys.Min();
                var current = sorted[minKey];
                sorted.Remove(minKey);
                visited.Add(current);

                foreach (var edge in current.GetEdges())
                {
                    if (visited.Contains(edge.To))
                    {
                        continue;
                    }
                    var newDistance = distances.GetValueOrDefault(current) + edge.Weight;
                    if (newDistance < distances.GetValueOrDefault(edge.To))
                    {
                        distances[edge.To] = newDistance;
                        previousNodes[edge.To] = current;
                        sorted.Add(newDistance, edge.To);
                    }
                }
            }

            var stack = new Stack<Node>();
            stack.Push(toNode);
            var previous = previousNodes.GetValueOrDefault(toNode);

            while (previous != null)
            {
                stack.Push(previous);
                previous = previousNodes.GetValueOrDefault(previous);
            }

            var path = new Path();
            while (stack.Any())
            {
                path.Add(stack.Pop().Label);
            }
            return path;
        }

        public bool HasCycle()
        {
            var visited = new HashSet<Node>();
            foreach (var node in nodes.Values)
            {
                if (!visited.Contains(node))
                {
                    if (HasCycle(node, null, visited))
                        return true;
                }
            }
            return false;
        }

        private bool HasCycle(Node node, Node parent, HashSet<Node> visited)
        {
            visited.Add(node);

            foreach (var edge in node.GetEdges())
            {
                if (edge.To == parent)
                {
                    continue;
                }

                if (visited.Contains(edge.To))
                {
                    return true;
                }

                if (HasCycle(edge.To, node, visited))
                    return true;
            }
            return false;
        }

        public WeightedGraph GetMinimumSpanningTree()
        {
            var tree = new WeightedGraph();
            if (nodes == null)
            {
                return tree;
            }
            var startNode = nodes.Values.First();
            var edges = startNode.GetEdges();

            if (edges == null)
            {
                return tree;
            }
            tree.AddNode(startNode.Label);

            while (tree.nodes.Count() < nodes.Count())
            {
                var minEdge = edges.OrderBy(e => e.Weight).First();
                var nextNode = minEdge.To;
                edges.Remove(minEdge);

                if (tree.ContainsNode(nextNode.Label))
                {
                    continue;
                }

                tree.AddNode(nextNode.Label);
                tree.AddEdge(minEdge.From.Label, nextNode.Label, minEdge.Weight);

                foreach (var edge in nextNode.GetEdges())
                {
                    if (!tree.ContainsNode(edge.To.Label))
                        edges.Add(edge);
                }
            }

            return tree;
        }

        public bool ContainsNode(string label)
        {
            return nodes.ContainsKey(label);
        }
        private class Node
        {
            public string Label { get; private set; }
            private List<Edge> edges = new List<Edge>();
            public Node(string label)
            {
                Label = label;
            }

            public void AddEdge(Node targetNode, int weight)
            {
                edges.Add(new Edge(this, targetNode, weight));
            }

            public List<Edge> GetEdges()
            {
                return edges;
            }
        }

        private class Edge
        {
            public Node From { get; private set; }
            public Node To { get; private set; }
            public int Weight { get; private set; }

            public Edge(Node from, Node to, int weight)
            {
                From = from;
                To = to;
                Weight = weight;
            }
        }
    }
}