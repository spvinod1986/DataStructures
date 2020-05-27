# DataStructures and Algorithms
This project demonstrates data structure and algorithm concepts with examples.

## Big O
Describes performance of an algorithm.
- Time Complexity:
    - Time algorithm consumes based on length/size of input.
- Space Complexity:
    - (Extra)Space required by algorithm based on length/size of input.
    - Space allocated for input is not counted.

* O(1):
    - Constant.
    - Size of input does not matter.
    - Algorithm always takes constant time to run.
* O(n):
    - Linear.
    - As input grows, cost of algorithm also grows linearly.
    - If input count is n, then the algorithm will do n operations.
    - eg: looping through all input elements and performing an operation.
* O(n^2):
    - Quadratic.
    - If input count is n, then the algorithm will do n*n operations.
    - Worse than linear if size of input is big.
    - eg: multiple loop through all input elements to perform an operation.
* O(log n):
    - Logarithmic.
    - If input count is n, then the algorithm will do log n operations.
    - More efficient and scalable than linear and quadratic.
    - eg: Binary search on sorted array.
* O(2^n):
    - Exponential.
    - Not scalable at all.
    - As input size grows, the number of operations performed grows exponentially.

## Basic Linear Data Structures
* Arrays:
    - Simplest data structure.
    - In C# : Static(Array) - Fixed size vs Dynamic(List<T>) - Grows or Shrinks automatically.
    - LookupByIndex -> O(1).
    - LookupByValue -> O(n).
    - Insert (Beginning/Middle/End) -> O(n). WorstCaseScenario: we need to copy/create new array if the size of existing array is n.
    - Remove (Beginning/Middle/End) -> O(n). WorstCaseScenario: Removing element from beginning of array may require shifting all elements one step to left.
    - Static arrays have fixed size. Dynamic arrays grow by 50% or 100% (Space Complexity).
    - Arrays are recommended if you know the number of items to store.
* LinkedLists(Singly):
    - Fundamental data structure.
    - List of nodes in sequence.
    - Each node has 2 pieces of data. 1) value and 2) address of next node in the list.
    - First node is called Head and Last node is called Tail.
    - Can grow or shrink automatically.
    - LookupByIndex -> O(n). WorstCaseScenario: Elements will not be sequentially stored lik arrays. It can be anywhere in memory. So need to traverse all the nodes and if element is in last node.
    - LookupByValue -> O(n). WorstCaseScenario: Element is in last node.
    - InsertAtEnd -> O(1).
    - InsertAtBeginning -> O(1).
    - InsertAtMiddle -> O(n). Before insert, finding the node itself is O(n).
    - DeleteFromBeginning -> O(1).
    - DeleteFromEnd -> O(n). We need to traverse the list to find the last but previous node to link it to the tail.
    - DeleteFromMiddle -> O(n). We need to traverse the list to find the middle node.
    - LinkedLists is not fixed in size. Hence no waste of memory (Space Complexity).
    - LinkedLists can be circular which means last node can reference first node.
* LinkedLists(Doubly):
    - Each node has 3 pieces of data. 1) address of previous node, 2) value, 3) address of next node.
    - DeleteFromEnd -> O(1). No need to traverse the list to find the last but previous node as each node has reference to previous and next node.
* Stacks:
    - Last In First Out(LIFO).
    - Can be used for reverse order, Undo, forward/backward navigations, evaluating expressions etc.
    - Stacks is just a wrapper around array or linked list.
    - All operations in stack runs in O(1). 
    - Operations: Push, Pop, Peek.
* Queues:
    - First In First Out(FIFO).
    - Can be used in service bus, printers, incoming requests in web servers.
    - All operations in queue runs in O(1). 
    - Operations: Enqueue, Dequeue, Peek.
    - Time complexity of Enqueue operation in Priority Queue implemented using Queue will be O(n).
    - Time complexity of Dequeue operation in Priority Queue implemented using Queue will be O(1).
    - Time complexity of Enqueue/Dequeue operation in Priority Queue implemented using Heap will be O(log n).
* HashTables:
    - Also called Dictionaries. Provides super fast lookups.
    - Can be used for Spell Checkers, Language Dictionaries, Compilers, Code Editors etc.
    - Used to store Key-Value pairs.
    - HashSet or Set is also form of HashTable. It has only keys and accepts no duplicate elements.
    - Key should be unique which is hashed using hashfunction which returns address in which value is or can be saved.
    - Key can be null. Value can also be null.
    - Hash function should be deterministic. It means it should always return same output for same input.
    - Internally HashTables uses arrays to store objects.
    - Hashfunction maps key to an index for storage.
    - All operations in HashTable runs in O(1). 
    - Operations: Insert, Lookup, Delete.
    - Collision: Possibility of 2 distinct keys generating same hash value. 
    - Chaining and OpenAddressing are 2 solutions for collision problem.
    - Chaining: Using linkedlist to store multiple items at same array index.
    - OpenAddressing: Address of the key value pair is not determined by hash function. Requires search for available empty address using Probing algorithms.
    - 3 Popular Probing Algorithms - Linear, Quadratic, and Double.
    - OpenAddressing-LinearProbing: (hask(key) + i) % tablesize. Start from current slot and move one by one until you find empty slot until you reach boundary of array. If all slots are full then array is full. Probing will take longer as items will eventually form clusters.
    - OpenAddressing-Quadratic: (hash(key) + i^2) % tablesize. Solves clustering problem as empty slots are searched in square of values. Chances of infinite loops are high.
    - OpenAddressing-DoubleHashing: If collision in first hash then find second hash using prime - (key % prime). Then does (hash1 + i*hash2) % tablesize. If this is not unique then used linear probing.

## Non-Linear Data Structures
* Trees:
    - Data structures that stores elements in hierarchy.
    - Elements are referred as nodes and the lines that connect them are called edges.
    - Nodes can be objects or value types.
    - Top Node is called Root. Each node can have 1 or more children.
    - Bottom nodes with no children are called Leaf nodes.
    - Trees are used to represent hierarchial data like folders in disk, indexing in database, compilers.
* Binary Trees:
    - If nodes can have maximum of only 2 children then the tree is called Binary Tree.
    - Binary Search Tree is a special type of binary tree where the left < node < right.
    - Binary Search Tree: Lookup is O(log n), Insert is O(log n) and Delete is O(log n).
    - Linear data structures (like linked list)only have one way for traversal. Start from first node and traverse till we reach the end.
    - Trees can be traversed in 2 ways. 1) Breadth First and 2) Depth First.
    - Breadth First Traversal is also called Level Order Traversal.
    - Breadth First : All nodes in same level is traversed first before visiting the next level.
    - Depth First can be done in 3 ways. 1) Pre-Order 2) In-Order and 3) Post-Order.
    - Pre-Order: Root, Left, Right.
    - In-Order: Left, Root, Right(for ascending order) or Right, Root, Left(for descending order).
    - Post-Order: Left, Right, Root.
    - Depth of Node: Depth of root is 0. The path from root to target node or the number of edges from root to target node.
    - Height of Node: Opposite of Depth. Height of leaf nodes are 0. Longest path from the node to leaf is the height of the node. The height of root node is also called the height of the tree.
    - Formula for calculating height of node is 1 + max(height(L),height(R)).
    - The minimum value in binary search tree is equal to value of left most leaf where as minimum value of binary tree need should be calculated using recursion to find minimum of left and right sub tree and compare it with root value. So the time complexity of this operation in binary tree is O(n) where as that of Binary search tree is O(log n).
* AVL Trees:
    - Most of operations in binary search tree runs in logarithmic time. But this can happen only if the tree is balanced.
    - Balanced Tree: height(left) - height(right) <= 1.
    - Right Skewed Tree: Most of the nodes in the tree only has right child. eg: Inserting values in ascending order in binary search tree results in right skewed tree.
    - Left Skewed Tree: Most of the nodes in the tree only has left child. eg: Inserting values in descending order in binary search tree results in left skewed tree.
    - The skewed trees are worst type of binary tree. They work similar to linear data structure like linked list.
    - Trees can be self balanced by using different algorithms.
    - Self balancing algorithms: AVL Trees, Red-Black Trees, B-Trees, Splay Trees, 2-3Trees, etc.
    - AVL Trees named after inventors Adelson-Vesky and Landis.
    - AVL Trees are special form of binary search trees that rebalance themselves everytime you add or remove nodes. They check if tree is balanced using formula and rebalance themselves after every operation.
    - AVL Trees rebalance themselves using Rotations.
    - Rotations are of 4 types: 1) Left(LL), 2) Right(RR), 3) Left-Right(LR), and 4) Right-Left(RL). Each Rotation is used based on what side of tree is heavy.
    - If heavy on right, then do Left Rotation(LL). If heavy on left, then do Right Rotation(RR). If imbalance is on left child - right subtree, then do Left Rotation followed by Right Rotation(LR). If imbalance is on right child - left subtree, then do Right Rotation followed by Left Rotation(RL).
    - Balance Factor: Height(Left) - Height(Right). 
    - If Balance Factor > 1, then LeftHeavy, hence do Right Rotation.
    - If Balance Factor > 1 and Balance Factor of Left Child < 0, then do Left-Right Rotation.
    - If Balance Factor < -1, then RightHeavy, hence do Left Rotation.
    - If Balance Factor < -1 and Balance Factor of Right Child > 0, then do Right-Left Rotation.
* Heaps:
    - Heap is a special type of tree with 2 properties: 1) Complete Tree and 2) Heap Property.
    - Complete Tree: Every level except potentially last level is completely filled and levels are filled from Left to Right.
    - Heap Property: 1) Max Heap - Value of every node should be greater than or equal to children. 2) Min Heap - Value of every node should be lesser than or equal to children.
    - Heap is a "Complete Tree" which satisfies "Heap Property".
    - Heaps of Binary Tree can be more accurately called as Binary Heap.
    - Heaps are used in Shortest Path/Graph alogirthms(GPS), Priority Queues, sorting, finding nth smallest or largest values.
    - Bubble Up: Swapping a node with parent in order to satisfy Heap Property.
    - Bubble Down: Opposite of Bubble up. Swapping a parent with node in order to satisfy Heap property. This usually happens during Delete.
    - In Heaps, we can only delete root node and not inner node.
    - Time Complexity: Insert/Remove : O(log n).The longest a value can travel in heap = height of tree. This is equal to finding a value in binary search tree.
    - Finding maximum value in Max Heap is O(1). Similarly finding minimum value in Min Heap is O(1).
    - Heaps can be implemented using arrays even though they are conceptually Binary Tree. As Heaps are "Complete Binary Trees" and they donot have any holes (missing nodes) in them, it is more efficient to implement them using array. Small memory foot print because of that.
    - Formula to calculate array index of Left and Right children from Parent Index: Left = ParentIndex * 2 + 1. Right = ParentIndex * 2 + 2.
    - Formula to calculate array index of Parent from Children: Parent = (Child index - 1)/2.
    - Heap Sort: Removing elements from Max Heap will return elements in descending order. Removing elements from Min Heap will return elements in ascending order.
    - Priority Queues: Time complexity of Enqueue/Dequeue operation in Priority Queue implemented using Heap will be O(log n).
    - Heapify Algorithm: Algorithm used to convert regular arrays to Heap arrays. Iterate through all array elements and move it to satisfy heap property. More optimised option is to iterate through all array elements eliminating leaf nodes (start from last parent). Formula to find last parent: (n/2)-1.
* Tries:
    - Tries are another kind of trees but they are not binary trees. Each child can have several nodes.
    - Other names for Tries are Retrieval, Digital, Radix and Prefix.
    - Used to implement auto completion.
    - Insert/Delete/Lookup runs in O(L), where L is equal to number of characters in the word we are trying to insert, delete or lookup.
    - Tries can be traversed in 2 ways: 1) Pre-Order and 2) Post-Order.
    - Pre-Order: Root will be visited first before children.
    - Post-Order: Leaf nodes to root.
* Graphs:
    - Graphs are one of the most versatile data structures because they allow us to solve interesting problems.
    - They are used in GPS, to connect routers in network, people in Social networks, anywhere we want to model relationships between bunch of objects.
    - Like Trees, Graphs consist of Nodes and Edges. Mathematically, a tree is a kind of Graph without any cycles. Also Graph do not have root. 
    - In Graph, Nodes are called Vertices.
    - If two Vertices are directly connected, then they are called Adjacent or Neighbours.
    - Directed Graph: If the edges have direction. Twitter is an example of directed graph. If you follow some one then the connection will be from your account to their account and not other way around.
    - UnDirectedGraph: If the edges have no direction. Facebook/LinkedIn are examples of undirected graph. If you connect with someone then there will be connection between two of you.
    - Weight: Edges of connection can hold weight which determines how strong a connection is. For example, in social network, 2 people who interact a lot will have higher weight than their other adjacents and used to recommend friends. In GPS, weights are used to show best route for a destination.
    - In Graphs, we use V for "Vertices" and E for "Edges" to define Space time complexity.
    - Two ways to implement Graph in code. 1) Adjacency Matrix and 2) Adjacency List.
    - Adjacency Matrix: Using Matrix or two dimensional array. Every node/vertex in the graph will have a row and column. If 2 nodes are connected then their intersection is marked as 1.
    - One disadvantage of Adjacency Matrix is the amount of space to be allocated. The space complexity is: O(n^2) or O(V^2). If you have n nodes, you will need n rows and n columns.
    - Adding a new node will require, creating a new matrix with one additional row and column and copy all values from existing matrix. Time complexity for adding a node is O(n^2) or O(V^2). If we want to avoid copying, then we can preallocate a larger matrix which will waste memory as well.
    - Removing a node will also require creating a smaller matrix, hence O(V^2).
    - Adding/Removing/Finding(Querying) a edge or connection will be O(1). We can have indexes of nodes in hastable and hence adding connection is constant time.
    - Finding adjacent or neighbouring nodes to a node is O(V).
    - Adjacency List: Using Array of Linked Lists. Every array will have linkedlist which contains all neighbours or adjacent nodes of a given node. The index of a node in array is found using hashtables similar to Adjacency Matrix.
    - We are just storing the edges or connection that exist, hence no waste of memory. So the space complexity is O(V + E).
    - Dense Graph : It is a kind of graph where every node will be connected to every other node except itself. Total number of Edges in dense graph will be V * (V - 1) or V^2 - V. Hence for Dense Graph the space complexity will be O(V + E) = O(V^2).
    - Multi Graph: It is a kind of graph where two nodes can have multiple connections.
    - Adding a node will require just adding one more linked list at the end of array. Hence it is O(1).
    - Removing a node will require removing the node fro adjacency list and also iterate and remove the target node from every linked list. Hence it is O(V + E). In dense graph it is O(V^2).
    - Adding a edge requires to iterate through all the edges of a node to confirm the connection does not exist and then adding the edge. So if K is the number of edges a given node has, then adding a edge is O(K). In dense graph it is O(V). In multi graph, no need to check for existence of a edge and hence it will be O(1).
    - Removing or Finding(Querying) a edge is also O(K) or in dense graph it is O(V). This requires iterating through all edges of a node.
    - Finding adjacent or neighbouring nodes to a node is O(K) or for dense graph it is O(V).
    - If dealing with dense graph, it is better to implement your graph using Adjacency Matrix otherwise use list.
    - Traversal Algorithms: Similar to trees, graphs also have 1) Depth First and 2) Breadth First traversals. But the difference is Graphs does not have root node. So in graphs we can start traversing from any node but we can traverse nodes only those which are reachable from that node.
    - Depth First: Start from node and recursively visit all of its neighbours to deep level.
    - Breadth First: Instead of going deep in a graph, we visit a node and all its neighbours before going farther from that node. Implemented using Queue.
    - Topological Sorting Algorithm: Used to figure out right order we need to process the nodes in a graph. For example in an application A which depends on library B and C which depends on library D. We need to find and build the projects in right order for application A to build.
    - Topological Sorting algorithm only works on graph without a cycle. Such graphs are called Directed Acyclic Graph.
    - Pick a node and do depth first traversal to go deep and find the node with no child or connections. Add that node to Stack and then follow back and add nodes whose neighbours are already visited. Now when we pop the stack, nodes will come out in right order.
    - Weighted Graphs: If the edges of graph have weight then it is called wighted graph. The weights can represent cost, distance, or anything. Common use of weighted graph is to find shortest path between 2 nodes or close friends between 2 people.
    - Dijkstra's Algorithm: Classic alogirthm for finding shortest path between 2 nodes of a graph. This is an example for Greedy Algorithm. A Greedy algorithm tries to find the optimal solution to a problem by making optimal choices in each step. In Dijkstra's algorithm we try to find shortest path between current nodes and all it neighbours.
    - Spanning Tree: A graph can be converted to a tree. A tree is a graph without a cycle. Removing edges from a graph but still keeping all nodes in a graph directly or indirectly connected results in spanning tree. There is many ways to create spanning tree for a given graph. If there are n nodes in a graph then a spanning tree should have n-1 edges. If there are more than n-1 edges then we will have a cycle and it is no longer a tree. If it has lass than n-1 edges then not all of the nodes are connected. Each spanning tree will have cost which is equal to sum of weight of the edges.
    - Prim's Alogirthm - Popular Algorithm to find minimum spanning tree of a graph or tree with minimum cost. Idea of algorithn is to extend the tree by adding the smallest connected edge. This is another example of Greedy Algorithm.

## Sorting Algorithms
* Bubble Sort:
    - Simplest of all sorting algorithms.
    - Scan the array from left to right one by one and and if it is out of order then swap them one at a time. Requires multiple passes to swap all items in the array.
    - Time Complexity: Best case scenario where array is already sorted then bubble sort requires O(1) pass. In worst cases scenario where it is not sorted then it requires O(n) passes. Irespective of passes, bubble sort requires O(n) comparisons. So Bubble Sort runs in O(n) or linear time in best case scenario and O(n^2) or quadratic time in worst case scenario.
* Selection Sort:
    - In selection sort, in each pass, you will find or select the next minimum value and move it in to correct position. 
    - We need multiple passes to sort the array. In first pass, we should find the next smallest item in the array and move it in to correct position. This divides the array in to 2 parts. Sorted part and Unsorted part. In the next pass, we should find the next minimum item in the unsorted part and move it as next item in sorted part.
    - Time Complexity: We need n passes for both best and worst case scenario hence O(n) pass required. In each pass we need to find minimum value in unsorted part of the array. Though technically, the unsorted part of array shrinks in size after each pass, it is still seen as O(n) operation. So Selection Sort runs in O(n^2) or quadratic time in best or worst cases scenario and hence it is seen as fairly slow algorithm.
    - Why we need n pass if the array is already sorted or in best case scenario: If an array is already sorted, In bubble sort, you can find it after first pass because each item is compared with the following one where as in selection sort we are not comparing each item with following one, instead we are finding the next minimum value.
* Insertion Sort:
    - During each pass, take one item and insert it at the right position. Take the first item and it is the only item we have now, so assume it is in correct position. Then move to next item, if the next item is smaller than any previous element we have seen so far, then move the elements in sorted part to right to make space to insert the smaller item.
    - Time Complexity: We need to pass through all items atleast one in best or worst case scenario. Hence O(n) pass required. If the array is already sorted, then we may not need to shift any items, so shifting is O(1) in best case scenario but in worst case scenario we need to shift n items and hence it is O(n). So Insertion Sort runs in O(n) or linear time in best case scenario and O(n^2) or quadratic time in worst case scenario.
* Merge Sort:
    - The top 3 algorithms (Bubble, Selection, Insertion) are inefficient and runs in quadratic time.
    - Merge Sort and other algorithms are efficient and runs in O(n log n).
    - The idea of merge sort is to break down a list in to smaller and smaller sublist, then sort those and merge them back to build a completed sorted list. Merge Sort is also called as Divide and Conquer algorithm. It works by dividing a problem in to smaller sub problems until it becomes esy enough to solve. And then it combines the solution to build solution for the original problem.
    - Time Complexity: Dividing runs in O(log n) in best and worst case scenario. Merging is O(n) operation for best and worst case as you need to read all elements from sub array to merge. Hence Merge Sort runs in O(n log n) in best and worst case scenario.
    - Merge Sort or algorithm that runs in O(n log n) complexity is way more better than the algorithm that runs in linear or quadratic time. But Merge Sort comes with a cost, the cost of allocation additional space. Every time we split an array, we need to allocate space for 2 new subarrays, whose sum will be equivalent to the space of original array. So the space complexity of Merge Sort is O(n).
    - There are some variations of this algorithm (called in-place merge sort) where you can sort the elements without allocation of additional space.
* Quick Sort:
    - Most used Sorting algorithm and is the one built in to most languages and frameworks.
    - It is fairly efficient algorithm and unlike merge sort it does not require any extra space.
    - It starts off by selecting an item called Pivot. Then rearrange the items such that all the items smaller than Pivot on the left and all the items greater than pivot are on the right side of the pivot. This is called partitioning. Typically last item is selected as Pivot. The order of items in left and right partition does not matter as long as they are smaller than Pivot in left and greater than pivot in right. When you pick a pivot and partition an array, the pivot will move to the correct position and position of pivot will never change after that. Then the same steps are repeated for the left and right partition.
    - Time Complexity: Partitioning takes O(n) operation for best and worst scenarios as we have to iterate through all the items and swap them as necessary. The number of times to partition an array varies based on the selection of partition. In the best case scenario, if after the first partition, the pivot ends up in the middle then the complexity is O(log n). In the worst case scenario, if the pivot ends in extreme left or right, then the number of partitions required will be equal to O(n).
    - There are few pivot selection strategies used to work around identifying pivot issues. 1) Pick Pivot randomly 2) Use the middle index as Pivot 3) Average of first, middle and last item. These strategies will not prevent the worst case scenarios but it will help decrease the livelihood.
    - The time complexity of Quick Sort can be O(n log n) for best case scenario and O(n^2) for worst case scenario.
    - Space Complexity: Unlike merge sort, we are not allocating extra space for quick sort. We may need to consider space required for recursive call because the runtime uses stack to keep track of these recursive calls. The number of times of recursive call is equal to how many times we need to partition the array. The space complexity of Quick Sort is O(log n) for best case scenario and O(n) for worst case scenario.
* Counting Sort:
    - All sorting algorithms above are comparsion bast sorting algorithms. There are bunch of sorting algorithms that don't use comparisons (like Counting Sort, Bucket Sort and Radix Sort).
    - If you have list of integers in range of 0 to k. To sort this array, we find the number of times the integers appear or the frequency of the integers in the array. These frequencies are represented using another array called counts array with index equal to the range of integers in original array. We iterate through the original array and find the frequency of integer and increment the frequency of the integer in the counts array where index is equal to the integer. Once the counts array is ready, we can now use the counts array to sort the data and refill the input array.
    - Space Complexity: Extra space is required for counts array. If k is maximum of the elements in input array then the space complexity is O(k).
    - Time Complexity: Populating counys array, requires iterating over input array which is O(n) complexity. Then we need to iterate through counts array and refill input array which is O(k) operation. So the time complexity is O(n + k) which is equal to O(n). 
    - Linear complexity is better than O(n log n) or quadratic complexity. So Counting Sort is better than the above sort based on scenario. Because Counting Sort comes with a cost , the cost of allocating extra space. This is called as Time-memory trade off in computer science.
    - When to use Counting Sort: 1) Allocating extra space is not an issue, 2) Values should be postivie integers otherwise we cannot use them as index in counts array, 3) Most the of the values in the range are present other wise we will end up with lot of empty or 0 in counts array.
* Bucket Sort:
    - Another sorting algorithm which does not use comparisons.
    - The idea of bucket sort is to distribute items in to number of buckets. And then sort the buckets using another sorting algorithm and then finally we can iterate through the buckets array and put the elements in input array.
    - Instead of sorting large arrays, here you can sort in buckets or smaller array and also you can run the bucket sorts in parallel.
    - Simple formula for finding a bucket for an item: bucket = item/ number of buckets.
    - How many buckets do we need: The more buckets we have, the more memory is required to store the buckets but we can sort each bucket in less time because of fewer items in each bucket.
    - Space Complexity: if we have k buckets then we have to allocate array of k items and each item in this array will be linked list. Total number of items around all this linked list will be equal to the total number of items in input array. So the space complexity is O(n + k).
    - Time Complexity: Distributing items from input array to buckets array is O(n) operation in best and worst scenario. Then we will need to iterate through buckets array and put the elements back in input array which is O(k) operation in best and worst scenario. Sorting depends on the underlying algorithm used to sort. In best case scenario, we can have single element in each bucket in which case sorting can be O(1) operation. In worst case scenario, all the elements are in single bucket in which case sorting can be O(n^2) operation (considering insertion sort). So the time complexity of bucket sort in best case scenario is O(n + k) or O(n) which is linear and for worst case scenario is O(n^2). So the time complexity depends on the number of buckets. The more buckets will save time but cost space.

## Searching Algorithms
* Linear Search:
    - This is the simplest search algorithm.
    - Iterate over a list and find the item, once you find the item return index of that item otherwise return -1.
    - Time Complexity: In best case scenario, the target item is the first element in the list and we can find it in O(1) operation. In worst case scenario, the target item can be the last element or not present in the list and it takes O(n) operation.
* Binary Search:
    - 

    
    
