using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Path
    {
        private List<string> nodes = new List<string>();

        public void Add(string node)
        {
            nodes.Add(node);
        }

        public override string ToString()
        {
            var path = new StringBuilder();
            foreach (var item in nodes)
            {
                path = path.Append(" -> " + item);
            }
            return path.ToString();
        }
    }
}