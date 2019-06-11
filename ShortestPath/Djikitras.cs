using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class Djikitras
    {
        List<Tuple<Node>> DijikitrasAlgorithm(Node SourceNode, Node DestinationNode)
        {
            List<Tuple<Node>> DijikitrasShotestNodes = new List<Tuple<Node>>();
            DijikitrasShotestNodes = GetDijikitras(SourceNode, DestinationNode);

            return DijikitrasShotestNodes;
        }

        private List<Tuple<Node>> GetDijikitras(Node sourceNode, Node destinationNode)
        {
            GraphLayout graphLayout = new GraphLayout();
            LocalEdge LocalEdge = new LocalEdge();
            IList<Node> Vertices = new List<Node>();
            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();
            List<Tuple<Node, Node,int>> EdgeswithDistance = new List<Tuple<Node, Node,int>>();
            List<Tuple<Node>> shortestpath = new List<Tuple<Node>>();

            Vertices = graphLayout.GetGraphLayout();
            Edges = LocalEdge.GetGrapgEdges(Vertices);
            EdgeswithDistance = GetEdgesWithDistance(Edges);

            shortestpath = GetShortestPath(sourceNode, destinationNode, EdgeswithDistance);
            return shortestpath;

        }

        private List<Tuple<Node>> GetShortestPath(Node sourceNode, Node destinationNode, List<Tuple<Node, Node, int>> edgeswithDistance)
        {
            List<Tuple<Node>> shortestroute = new List<Tuple<Node>>();

            for (int i = 0; i < edgeswithDistance.Count; i++)
            {

            }

            throw new NotImplementedException();
        }

        private List<Tuple<Node, Node, int>> GetEdgesWithDistance(List<Tuple<Node, Node>> edges)
        {
            List<Tuple<Node, Node, int>> EdgeDistances = new List<Tuple<Node, Node, int>>();
            TokenDistribution tokenDistribution = new TokenDistribution();
            int distance;
            for (int i = 0; i < edges.Count; i++)
            {
                
                distance = tokenDistribution.GetDistance(edges[i].Item1, edges[i].Item2);
                EdgeDistances.Add(Tuple.Create(edges[i].Item1, edges[i].Item2, distance));
            }

            return EdgeDistances;
        }
    }
}
