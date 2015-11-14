using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewSample
{
    public class NodeFactory
    {
        public IEnumerable<ANode> GetNodes()
        {
            return Enumerable.Range(0, 10).Select(x => new ANode($"{x}")).ToList();
        }
    }
}
