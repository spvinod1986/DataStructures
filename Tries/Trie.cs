using System;
using System.Collections.Generic;
using System.Linq;

namespace Tries
{
    public class Trie
    {
        private Node root = new Node(' ');

        public void Insert(string input)
        {
            var current = root;

            foreach (var ch in input)
            {
                if (!current.HasChild(ch))
                    current.AddChild(ch);

                current = current.GetChild(ch);
            }
            current.IsEndofWord = true;
        }

        public bool Contains(string input)
        {
            if (input == null)
                return false;

            var current = root;
            foreach (var ch in input)
            {
                if (!current.HasChild(ch))
                    return false;

                current = current.GetChild(ch);
            }
            return current.IsEndofWord;
        }

        public void PreOrderTraverse()
        {
            PreOrderTraverse(root);
        }

        private void PreOrderTraverse(Node node)
        {
            System.Console.WriteLine(node.Value);
            foreach (var child in node.GetChildren())
            {
                PreOrderTraverse(child);
            }
        }

        public void PostOrderTraverse()
        {
            PostOrderTraverse(root);
        }

        private void PostOrderTraverse(Node node)
        {
            foreach (var child in node.GetChildren())
            {
                PostOrderTraverse(child);
            }
            System.Console.WriteLine(node.Value);
        }

        public void Remove(string input)
        {
            if (input == null)
                return;
            Remove(root, input, 0);
        }

        private void Remove(Node node, string input, int index)
        {
            if (index == input.Length)
            {
                node.IsEndofWord = false;
                return;
            }
            var ch = input[index];
            var child = node.GetChild(ch);

            if (child == null)
            {
                return;
            }

            Remove(child, input, index + 1);

            if (!child.HasChildren() && child.IsEndofWord == false)
            {
                node.RemoveChild(ch);
            }
        }

        public List<string> AutoComplete(string prefix)
        {
            if (prefix == null)
            {
                return null;
            }
            var words = new List<string>();
            var lastNode = FindLastNodeOf(prefix);
            FindWords(lastNode, prefix, words);
            return words;
        }

        private Node FindLastNodeOf(string prefix)
        {
            var current = root;
            foreach (var ch in prefix)
            {
                if (!current.HasChild(ch))
                    return null;

                current = current.GetChild(ch);
            }
            return current;
        }

        private void FindWords(Node node, string prefix, List<string> words)
        {
            if (node == null)
            {
                return;
            }

            if (node.IsEndofWord)
                words.Add(prefix);

            foreach (var child in node.GetChildren())
            {
                FindWords(child, prefix + child.Value, words);
            }
        }
        private class Node
        {
            public Node(char value)
            {
                Value = value;
            }
            public char Value { get; private set; }
            public Dictionary<char, Node> Children { get; set; } = new Dictionary<char, Node>();
            public bool IsEndofWord { get; set; }

            public bool HasChild(char ch)
            {
                return Children.ContainsKey(ch);
            }

            public void AddChild(char ch)
            {
                Children.Add(ch, new Node(ch));
            }

            public Node GetChild(char ch)
            {
                return Children.GetValueOrDefault(ch);
            }

            public Node[] GetChildren()
            {
                return Children.Select(c => c.Value).ToArray();
            }

            public bool HasChildren()
            {
                return Children.Any();
            }

            public void RemoveChild(char ch)
            {
                Children.Remove(ch);
            }
        }
    }
}