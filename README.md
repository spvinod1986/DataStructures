# DataStructures and Algorithm
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
    - Insert (Beginning/Middle/End) -> O(n).
    - Remove (Beginning/Middle/End) -> O(n).
    - Static arrays have fixed size. Dynamic arrays grow by 50% or 100% (Space Complexity).
    - Arrays are recommended if you know the number of items to store.
* LinkedLists(Singly):
    - Fundamental data structure.
    - List of nodes in sequence.
    - Each node has 2 pieces of data. 1) value and 2) address of next node in the list.
    - First node is called Head and Last node is called Tail.
    - Can grow or shrink automatically.
    - LookupByIndex -> O(n).
    - LookupByValue -> O(n).
    - InsertAtEnd -> O(1).
    - InsertAtBeginning -> O(1).
    - InsertAtMiddle -> O(n).
    - DeleteFromBeginning -> O(1).
    - DeleteFromEnd -> O(n).
    - DeleteFromMiddle -> O(n).
    - LinkedLists is not fixed in size. Don't waste memory (Space Complexity).
    - LinkedLists can be circular which means last node can reference first node.
* LinkedLists(Doubly):
    - Each node has 3 pieces of data. 1) address of previous node, 2) value, 3) address of next node.
    - DeleteFromEnd -> O(1).
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
    - Left Skewed Tree: Most of the nodes in the tree inly has left child. eg: Inserting values in descending order in binary search tree results in left skewed tree.
    - The skewed trees are worst type of binary tree. They work similar to linear data structur like linked list.
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
    
    
