using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            var stackInput = new Stack<char>();

            foreach (var c in input)
            {
                stackInput.Push(c);
            }

            var output = new StringBuilder();
            while (stackInput.Count != 0)
            {
                output.Append(stackInput.Pop());
            }

            return output.ToString();
        }
    }
}