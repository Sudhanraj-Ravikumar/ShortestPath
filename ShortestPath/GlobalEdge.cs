using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class GlobalEdge
    { 

        int messagelimit = 10;

        //sending the token information to other nodes directly without the local edges. global edseg are used to only send token information
        public List<Tuple<Node, Node, int>> SendGlobalEdge(Node vertex1,IList<Node> vertices, String Message)
        {
            List<Tuple<Node, Node, int>> globalEdges = new List<Tuple<Node, Node, int>>();

            for (int i = 0; i < vertices.Count; i++)
            {
                if (Message.Length <= messagelimit)
                {
                    globalEdges.Add(GetGlobalEdgeiwthDistance(vertex1, vertices[i]));
                }
            }
                return globalEdges;
            
        }

        public List<Tuple<Node, Node, int,List<Token>>> SendThroughGlobalEdge(Node vertex1, IList<Node> vertices, List<Token> Message)
        {
            List<Tuple<Node, Node, int>> globalEdges = new List<Tuple<Node, Node, int>>();
            List<Tuple<Node, Node, int, List<Token>>> TokenwithMessage = new List<Tuple<Node, Node, int, List<Token>>>();
            
            for (int i = 0; i < vertices.Count; i++)
            {
                if (Message.Count <= messagelimit)
                {
                    globalEdges.Add(GetGlobalEdgeiwthDistance(vertex1, vertices[i]));
                    
                }
            }

            foreach (var item in globalEdges)
            {
                TokenwithMessage.Add(Tuple.Create(item.Item1, item.Item2, item.Item3,Message));
            }
            return TokenwithMessage;

        }

        private Tuple<Node, Node, int> GetGlobalEdgeiwthDistance(Node item1, Node item2)
        {
            int dist;
            dist = (int)Math.Sqrt(((item2.X - item1.X) ^ 2) - ((item2.Y - item1.Y) ^ 2));
            return Tuple.Create(item1, item2, dist);
        }

    }
}
