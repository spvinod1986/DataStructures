using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverser = new StringReverser();
            System.Console.WriteLine($"Reverse the string Vinod: {reverser.Reverse("Vinod")}");
            System.Console.WriteLine($"Reverse the string : {reverser.Reverse("")}");

            var evaluator = new ExpressionEvaluator();
            System.Console.WriteLine($"Check the string [Vinod]: {evaluator.IsBalanced("[Vinod]")}");
            System.Console.WriteLine($"Check the string [[Vinod]: {evaluator.IsBalanced("[[Vinod]")}");
            System.Console.WriteLine($"Check the string [Vinod)]: {evaluator.IsBalanced("[Vinod)]")}");
            System.Console.WriteLine($"Check the string [(Vinod)]: {evaluator.IsBalanced("[(Vinod)]")}");
            System.Console.WriteLine($"Check the string [)Vinod(]: {evaluator.IsBalanced("[)Vinod(]")}");

            var stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            stack.Print();
        }
    }
}
