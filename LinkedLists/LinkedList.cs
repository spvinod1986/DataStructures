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

        public void Reverse()
        {
            if (first == null)
                return;

            var previous = first;
            var current = first.next;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
        }

        public int GetKthFromTheEnd(int k)
        {
            if (first == null)
                throw new InvalidOperationException("The list is empty");

            var x = first;
            var y = first;

            for (int i = 0; i < k - 1; i++)
            {
                y = y.next;

                if (y == null)
                    throw new InvalidOperationException("k is larger than size of list");
            }

            while (y != last)
            {
                x = x.next;
                y = y.next;
            }

            return x.value;
        }
        private class Node
        {
            public int value { get; set; }
            public Node next { get; set; }
        }
    }
}