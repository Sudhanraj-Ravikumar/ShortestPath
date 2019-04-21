using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public interface IEdge
    {
        List<Tuple<Node,Node>> AddEdges(Node vertex1, Node vertex2);
    }
}
