using System;

namespace AVLTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new AVLTree();
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(15);
            tree.TraverseInOrder();
        }
    }
}
