using System.Collections.Generic;
using System.Linq;

namespace BucketSort
{
    public class BucketSort
    {
        public void Sort(int[] array, int numberOfBuckets)
        {
            var i = 0;
            foreach (var bucket in CreateBuckets(array, numberOfBuckets))
            {
                bucket.Sort();
                foreach (var item in bucket)
                {
                    array[i] = item;
                    i = i + 1;
                }
            }
        }

        private List<List<int>> CreateBuckets(int[] array, int numberOfBuckets)
        {
            var buckets = new List<List<int>>();

            for (var i = 0; i < numberOfBuckets; i++)
            {
                buckets.Add(new List<int>());
            }
            foreach (var item in array)
            {
                buckets[item / numberOfBuckets].Add(item);
            }
            return buckets;
        }
    }
}