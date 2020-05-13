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

## Basic Data Structures
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
    
    
