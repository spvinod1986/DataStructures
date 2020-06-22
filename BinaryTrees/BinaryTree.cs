using System;

namespace BinaryTrees
{
    public class BinaryTree
    {
        private Node root;

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }

            var current = root;
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(value);
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(value);
                        break;
                    }
                    current = current.Right;
                }
            }
        }
        public bool Find(int value)
        {
            var current = root;

            while (current != null)
            {
                if (value < current.Value)
                {
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    current = current.Right;
                }
                else
                {
                    return true;
                }

            }
            return false;
        }
        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }
        private void TraversePreOrder(Node root)
        {
            if (root == null)
                return;

            System.Console.WriteLine(root.Value);
            TraversePreOrder(root.Left);
            TraversePreOrder(root.Right);
        }
        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }
        private void TraverseInOrder(Node root)
        {
            if (root == null)
                return;

            TraverseInOrder(root.Left);
            System.Console.WriteLine(root.Value);
            TraverseInOrder(root.Right);
        }
        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }
        private void TraversePostOrder(Node root)
        {
            if (root == null)
                return;

            TraversePostOrder(root.Left);
            TraversePostOrder(root.Right);
            System.Console.WriteLine(root.Value);
        }
        public int Height()
        {
            return Height(root);
        }
        private int Height(Node root)
        {
            if (root == null)
                return -1;
            if (root.Left == null && root.Right == null)
                return 0;
            return 1 + Math.Max(Height(root.Left), Height(root.Right));
        }
        public int Min()
        {
            return Min(root);
        }
        private int Min(Node root)
        {
            if (root.Left == null && root.Right == null)
                return root.Value;

            return Math.Min(Math.Min(Min(root.Left), Min(root.Right)), root.Value);

        }
        public int MinOfBinarySearchTree()
        {
            if (root == null)
                throw new InvalidOperationException("The tree is empty");

            var current = root;
            var last = current;
            while (current != null)
            {
                last = current;
                current = current.Left;
            }

            return last.Value;
        }

        public bool Equals(BinaryTree other)
        {
            if (other == null)
                return false;
            return Equals(root, other.root);
        }
        private bool Equals(Node node1, Node node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1 != null && node2 != null)
            {
                return node1.Value == node2.Value
                        && Equals(node1.Left, node2.Left)
                        && Equals(node1.Right, node2.Right);
            }

            return false;
        }
        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
        }
        private bool IsBinarySearchTree(Node node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.Value < min || node.Value > max)
                return false;

            if (IsBinarySearchTree(node.Left, min, node.Value - 1)
                && IsBinarySearchTree(node.Right, node.Value + 1, max))
                return true;

            return false;
        }
        public void PrintNodesAtDistance(int distance)
        {
            PrintNodesAtDistance(root, distance);
        }
        public void TraverseLevelOrder()
        {
            for (int i = 0; i <= Height(); i++)
            {
                PrintNodesAtDistance(i);
            }
        }
        private void PrintNodesAtDistance(Node node, int distance)
        {
            if (node == null)
                return;
            if (distance == 0)
            {
                System.Console.WriteLine(node.Value);
                return;
            }

            PrintNodesAtDistance(node.Left, distance - 1);
            PrintNodesAtDistance(node.Right, distance - 1);
        }
        private class Node
        {
            public int Value { get; private set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }
    }
}