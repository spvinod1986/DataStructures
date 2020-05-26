using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);
            System.Console.WriteLine("PreOrder Traversal:");
            tree.TraversePreOrder();
            System.Console.WriteLine("InOrder Traversal:");
            tree.TraverseInOrder();
            System.Console.WriteLine("PostOrder Traversal:");
            tree.TraversePostOrder();
            System.Console.WriteLine($"Height of tree is {tree.Height()}");
            System.Console.WriteLine($"Minimum value of tree is {tree.Min()}"); //O(n)
            System.Console.WriteLine($"Minimum value of binary search tree is {tree.MinOfBinarySearchTree()}");

            var tree2 = new BinaryTree();
            tree2.Insert(7);
            tree2.Insert(4);
            tree2.Insert(9);
            tree2.Insert(1);
            tree2.Insert(6);
            tree2.Insert(8);
            tree2.Insert(10);
            var tree3 = new BinaryTree();
            tree3.Insert(7);
            tree3.Insert(4);
            tree3.Insert(9);
            System.Console.WriteLine($"Whether Tree2 and Tree1 are equal: {tree.Equals(tree2)}");
            System.Console.WriteLine($"Whether Tree3 and Tree1 are equal: {tree.Equals(tree3)}");

            System.Console.WriteLine($"Is Tree1 is binary search tree: {tree.IsBinarySearchTree()}");

            System.Console.WriteLine("Print nodes at distance");
            tree.PrintNodesAtDistance(1);

            System.Console.WriteLine("LevelOrder Traversal");
            tree.TraverseLevelOrder();   
        }
    }
}
