using System.Collections.Generic;
using System;

namespace HashTables
{
    public class HashTable
    {
        private LinkedList<KeyValue>[] keyValues;

        public HashTable(int capacity)
        {
            keyValues = new LinkedList<KeyValue>[capacity];
        }

        public void Put(int key, string value)
        {
            var index = Hash(key);

            if (keyValues[index] == null)
                keyValues[index] = new LinkedList<KeyValue>();

            foreach (var keyValue in keyValues[index])
            {
                if (keyValue.Key == key)
                {
                    keyValue.Value = value;
                    return;
                }
            }

            keyValues[index].AddLast(new KeyValue { Key = key, Value = value });
        }

        public string Get(int key)
        {
            var index = Hash(key);

            if (keyValues[index] == null)
                return null;

            foreach (var keyValue in keyValues[index])
            {
                if (keyValue.Key == key)
                    return keyValue.Value;
            }

            return null;
        }

        public void Remove(int key)
        {
            var index = Hash(key);

            if (keyValues[index] == null)
                throw new InvalidOperationException("Key not found");

            foreach (var keyValue in keyValues[index])
            {
                if (keyValue.Key == key)
                {
                    keyValues[index].Remove(keyValue);
                    return;
                }
            }
            throw new InvalidOperationException("Key not found");
        }
        private int Hash(int key)
        {
            return key % keyValues.Length;
        }
        private class KeyValue
        {
            public int Key { get; set; }
            public string Value { get; set; }
        }
    }
}