using System;

namespace AVLTrees
{
    public class AVLTree
    {
        private AVLNode root;
        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private AVLNode Insert(AVLNode node, int value)
        {
            if (node == null)
                return new AVLNode(value);

            if (value < node.Value)
                node.Left = Insert(node.Left, value);
            else
                node.Right = Insert(node.Right, value);

            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;

            return Balance(node);
        }
        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }
        private void TraverseInOrder(AVLNode root)
        {
            if (root == null)
                return;

            TraverseInOrder(root.Left);
            System.Console.WriteLine($"Node Value is: {root.Value} and Node Height is: {root.Height}");
            TraverseInOrder(root.Right);
        }
        private int Height(AVLNode node)
        {
            if (node == null)
                return -1;
            return node.Height;
        }
        private int BalanceFactor(AVLNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Height(node.Left) - Height(node.Right);
        }
        private AVLNode Balance(AVLNode node)
        {
            if (IsLeftHeavy(node))
            {
                if (BalanceFactor(node.Left) < 0)
                {
                    node.Left = RotateLeft(node.Left);
                }
                return RotateRight(node);
            }
            else if (IsRightHeavy(node))
            {
                if (BalanceFactor(node.Right) > 0)
                {
                    node.Right = RotateRight(node.Right);
                }
                return RotateLeft(node);
            }
            return node;
        }

        private bool IsLeftHeavy(AVLNode node)
        {
            return BalanceFactor(node) > 1;
        }
        private bool IsRightHeavy(AVLNode node)
        {
            return BalanceFactor(node) < -1;
        }

        private AVLNode RotateLeft(AVLNode node)
        {
            var newNode = node.Right;
            node.Right = newNode.Left;
            newNode.Left = node;

            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
            newNode.Height = Math.Max(Height(newNode.Left), Height(newNode.Right)) + 1;

            return newNode;
        }

        private AVLNode RotateRight(AVLNode node)
        {
            var newNode = node.Left;
            node.Left = newNode.Right;
            newNode.Right = node;

            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
            newNode.Height = Math.Max(Height(newNode.Left), Height(newNode.Right)) + 1;

            return newNode;
        }
        private class AVLNode
        {
            public int Value { get; private set; }
            public int Height { get; set; }
            public AVLNode Left { get; set; }
            public AVLNode Right { get; set; }

            public AVLNode(int value)
            {
                Value = value;
            }
        }
    }
}