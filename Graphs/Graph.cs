using System.Collections.Generic;
using System;
using System.Linq;

namespace Graphs
{
    public class Graph
    {
        private Dictionary<string, Node> nodes = new Dictionary<string, Node>();
        private Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();
        public void AddNode(string label)
        {
            var node = new Node(label);
            nodes.TryAdd(label, node);
            adjacencyList.TryAdd(node, new List<Node>());
        }

        public void AddEdge(string from, string to)
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

            adjacencyList.GetValueOrDefault(fromNode).Add(toNode);
            // For undirected graphs
            // adjacencyList.GetValueOrDefault(toNode).Add(fromNode);
        }

        public void RemoveNode(string label)
        {
            var node = nodes.GetValueOrDefault(label);

            if (node == null)
            {
                return;
            }

            foreach (var n in adjacencyList.Select(c => c.Key))
            {
                adjacencyList.GetValueOrDefault(n).Remove(node);
            }
            adjacencyList.Remove(node);
            nodes.Remove(label);
        }

        public void RemoveEdge(string from, string to)
        {
            var fromNode = nodes.GetValueOrDefault(from);
            var toNode = nodes.GetValueOrDefault(to);

            if (fromNode == null || toNode == null)
            {
                return;
            }
            adjacencyList.GetValueOrDefault(fromNode).Remove(toNode);
        }
        public void TraverseDepthFirstRecursive(string label)
        {
            var node = nodes.GetValueOrDefault(label);
            if (node == null)
            {
                return;
            }

            TraverseDepthFirstRecursive(node, new HashSet<Node>());
        }

        private void TraverseDepthFirstRecursive(Node node, HashSet<Node> visitedNodes)
        {
            System.Console.WriteLine(node.Label);
            visitedNodes.Add(node);

            foreach (var neighbour in adjacencyList.GetValueOrDefault(node))
            {
                if (!visitedNodes.Contains(neighbour))
                {
                    TraverseDepthFirstRecursive(neighbour, visitedNodes);
                }
            }
        }

        public void TraverseDepthFirstIterative(string label)
        {
            var node = nodes.GetValueOrDefault(label);
            if (node == null)
            {
                return;
            }
            var visitedNodes = new HashSet<Node>();
            var stack = new Stack<Node>();
            stack.Push(node);

            while (stack.Any())
            {
                var current = stack.Pop();

                if (visitedNodes.Contains(current))
                {
                    continue;
                }

                System.Console.WriteLine(current.Label);
                visitedNodes.Add(current);

                foreach (var neighbour in adjacencyList.GetValueOrDefault(current))
                {
                    if (!visitedNodes.Contains(neighbour))
                    {
                        stack.Push(neighbour);
                    }
                }
            }
        }

        public void TraverseBreadthFirstIterative(string label)
        {
            var node = nodes.GetValueOrDefault(label);
            if (node == null)
            {
                return;
            }
            var visitedNodes = new HashSet<Node>();
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (visitedNodes.Contains(current))
                {
                    continue;
                }

                System.Console.WriteLine(current.Label);
                visitedNodes.Add(current);

                foreach (var neighbour in adjacencyList.GetValueOrDefault(current))
                {
                    if (!visitedNodes.Contains(neighbour))
                    {
                        queue.Enqueue(neighbour);
                    }
                }
            }
        }
        public List<string> TopologicalSort()
        {
            var stack = new Stack<Node>();
            var visitedNodes = new HashSet<Node>();
            foreach (var node in nodes.Values)
            {
                TopologicalSort(node, visitedNodes, stack);
            }

            var sorted = new List<string>();
            while (stack.Any())
            {
                sorted.Add(stack.Pop().Label);
            }
            return sorted;
        }

        private void TopologicalSort(Node node, HashSet<Node> visitedNodes, Stack<Node> stack)
        {
            if (visitedNodes.Contains(node))
            {
                return;
            }

            visitedNodes.Add(node);

            foreach (var neighbour in adjacencyList.GetValueOrDefault(node))
            {
                TopologicalSort(neighbour, visitedNodes, stack);
            }
            stack.Push(node);
        }

        public bool HasCycle()
        {
            var all = new HashSet<Node>();
            all.UnionWith(nodes.Values);

            var visiting = new HashSet<Node>();
            var visited = new HashSet<Node>();

            foreach (var current in all.ToArray())
            {
                if (HasCycle(current, all, visiting, visited))
                    return true;
            }

            return false;
        }

        private bool HasCycle(Node node, HashSet<Node> all, HashSet<Node> visiting, HashSet<Node> visited)
        {
            all.Remove(node);
            visiting.Add(node);

            foreach (var neighbour in adjacencyList.GetValueOrDefault(node))
            {
                if (visited.Contains(neighbour))
                {
                    continue;
                }

                if (visiting.Contains(neighbour))
                {
                    return true;
                }

                if (HasCycle(neighbour, all, visiting, visited))
                    return true;
            }

            visiting.Remove(node);
            visited.Add(node);

            return false;
        }
        public void Print()
        {
            foreach (var source in adjacencyList)
            {
                System.Console.WriteLine($"Node {source.Key.Label} is connected to following nodes:");
                foreach (var node in source.Value)
                {
                    System.Console.WriteLine(node.Label);
                }
            }
        }
        private class Node
        {
            public string Label { get; private set; }

            public Node(string label)
            {
                Label = label;
            }
        }
    }
}