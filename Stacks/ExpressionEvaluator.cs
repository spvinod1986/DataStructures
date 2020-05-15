using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class ExpressionEvaluator
    {
        private List<char> openBrackets = new List<char> { '[', '{', '(', '<' };
        private List<char> closeBrackets = new List<char> { ']', '}', ')', '>' };
        public bool IsBalanced(string input)
        {
            var stackInput = new Stack<char>();

            foreach (var c in input)
            {
                if (openBrackets.Contains(c))
                    stackInput.Push(c);

                if (closeBrackets.Contains(c))
                {
                    if (stackInput.Count == 0)
                        return false;

                    if (openBrackets.IndexOf(stackInput.Pop()) != closeBrackets.IndexOf(c))
                        return false;
                }

            }

            return stackInput.Count == 0;
        }
    }
}