using System;

namespace LinkedLists
{
    public class LinkedList
    {
        private Node first;
        private Node last;

        private int size;
        public void AddLast(int item)
        {
            var node = new Node { value = item, next = null };

            // if this is the item in the linkedlist
            if (first == null)
            {
                first = last = node;
                size++;
                return;
            }

            last.next = node;
            last = node;

            size++;
        }

        public void AddFirst(int item)
        {
            var node = new Node { value = item, next = null };

            // if this is the item in the linkedlist
            if (first == null)
            {
                first = last = node;
                size++;
                return;
            }

            node.next = first;
            first = node;
            size++;
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;

            while (current != null)
            {
                if (current.value == item)
                    return index;

                index++;
                current = current.next;
            }

            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public void RemoveFirst()
        {
            if (first == null)
                throw new InvalidOperationException("The list is empty");

            if (first == last)
            {
                first = last = null;
                size--;
                return;
            }

            var second = first.next;
            first.next = null;
            first = second;

            size--;
        }

        public void RemoveLast()
        {
            if (first == null)
                throw new InvalidOperationException("The list is empty");

            if (first == last)
            {
                first = last = null;
                size--;
                return;
            }

            var current = first;

            // Get previous to the last node
            while (current != null)
            {
                if (current.next == last)
                    break;

                current = current.next;
            }

            var previous = current;

            last = previous;
            last.next = null;

            size--;
        }

        public int Size()
        {
            return size;
        }

        public int[] ToArray()
        {
            int[] array = new int[size];
            var current = first;
            var index = 0;

            while (current != null)
            {
                array[index] = current.value;
                index++;
                current = current.next;
            }

            return array;
        }
        private class Node
        {
            public int value { get; set; }
            public Node next { get; set; }
        }
    }
}