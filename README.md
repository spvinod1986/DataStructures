# DataStructures and Algorithm
This project demonstrates data structure and algorithm concepts with examples.

## Big O
Describes performance of an alogorithm.
Time Complexity:
    - Time algorithm consumes based on length/size of input.
Space Complexity:
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

## Arrays
