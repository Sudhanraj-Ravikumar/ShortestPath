using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class SSSP
    {
        public List<Tuple<Node, int>> ExactSSSP(Node SourceNode, Node DestinationNode)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token,int>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token,int>>();
            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();



            EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();

            SkeletonGraphswithShortDistanceroute = getShortdistance(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistance);
            shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);
            //debugging to check the token counts
            return shortpath;
        }

        private List<Tuple<Node, int>> GEtNodeswithrespectivefromlis(List<Tuple<Token, int>> skeletonGraphswithShortDistanceroute)
        {
            GraphLayout graphLayout = new GraphLayout();
            IList<Node> Vertices = new List<Node>();
            Vertices = graphLayout.GetGraphLayout();
            List<Tuple<Node, int>> reuturningValueofNode = new List<Tuple<Node, int>>();
            for (int i = 0; i < skeletonGraphswithShortDistanceroute.Count; i++)
            {
                for (int j = 0; j < Vertices.Count; j++)
                {
                    if (skeletonGraphswithShortDistanceroute[i].Item1.SourceID==Vertices[j].ID)
                    {
                        reuturningValueofNode.Add(Tuple.Create(Vertices[j], skeletonGraphswithShortDistanceroute[i].Item2));
                    }
                }
            }
            return reuturningValueofNode;
        }



        //Nodes with token copies
        private List<Token> ConstructExactSkeletonGraph()
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EveryNodesDistancWithinMaxHopDistanceofMarkedNodes = new List<Token>();
            List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();

            tokencopies = tokenDistribution.TokenMultiplication();
            tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies);
            EveryNodesDistancWithinMaxHopDistance = ConstructSkeletonGraph();

            //Marked nodes threshold of number of copies
            int TokenCopiesThreshold = 100;

            for (int i = 0; i < EveryNodesDistancWithinMaxHopDistance.Count; i++)
            {
                for (int j = 0; j < tokencopieswithrespectivenodes.Count; j++)
                {
                    if (EveryNodesDistancWithinMaxHopDistance[i].SourceID == tokencopieswithrespectivenodes[j].Item1 && tokencopieswithrespectivenodes[j].Item2 <= TokenCopiesThreshold)
                    {
                        EveryNodesDistancWithinMaxHopDistanceofMarkedNodes.Add(EveryNodesDistancWithinMaxHopDistance[i]);
                    }
                }

            }

            return EveryNodesDistancWithinMaxHopDistanceofMarkedNodes;
        }

        private List<Token> ConstructSkeletonGraph()
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            Token token;

            LocalEdge localEdge = new LocalEdge();
            GraphLayout graphLayout = new GraphLayout();
            IList<Node> Vertices = new List<Node>();
            List<Token> TokenwithDistanceMessage = new List<Token>();
            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();

            //int MaxHopDistance = 15;

            Vertices = graphLayout.GetGraphLayout();
            Edges = localEdge.GetGrapgEdges(Vertices);

            for (int i = 0; i < Vertices.Count; i++)
            {
                List<Tuple<Node, Node, int, int>> dupliccatetokenmessage = new List<Tuple<Node, Node, int, int>>();
                token = tokenDistribution.LocalBroadcast(Edges, Vertices[i]);

                for (int j = 0; j < token.TokenMessage.Count; j++)
                {
                    //if (token.TokenMessage[j].Item3 < MaxHopDistance)
                    //{
                        dupliccatetokenmessage.Add(token.TokenMessage[j]);

                    //}
                }
                Token duplicate = new Token(token.SourceID, dupliccatetokenmessage);
                TokenwithDistanceMessage.Add(duplicate);

            }
            return TokenwithDistanceMessage;
        }
        List<Token> visitedNodes = new List<Token>();
        private List<Tuple<Token, int>> getShortdistance(Node sourceNode, Node destinationNode, List<Token> everyNodesDistancWithinMaxHopDistance)
        {
            List<Tuple<Token, int>> Nodeswithcandidatedistnce = new List<Tuple<Token, int>>();
            List<Tuple<Token, int>> NodeswithcandidatedistnceDummy = new List<Tuple<Token, int>>();
            List<Tuple<Token, int,int>> NodeswithcandidatedistncewithRounds = new List<Tuple<Token, int,int>>(); // toke,updated distance, rounds

            List<Tuple<Token, int>> NodeswithcandidatedistnceList = new List<Tuple<Token, int>>();
            List<Token> DuplicateeveryNodesDistancWithinMaxHopDistance = new List<Token>(everyNodesDistancWithinMaxHopDistance);

            List<Tuple<Token, int>> ShortestRoute = new List<Tuple<Token, int>>();


            List<Token> VisitedNodesdummy = new List<Token>();

            List<Tuple<Token, int>> Dummy = new List<Tuple<Token, int>>();

            NodeswithcandidatedistnceList = GetInitialNodeswithSeroDistance(DuplicateeveryNodesDistancWithinMaxHopDistance);

            for (int i = 0; i < NodeswithcandidatedistnceList.Count; i++)
            {
                if (NodeswithcandidatedistnceList[i].Item1.SourceID==sourceNode.ID)
                {
                    visitedNodes.Add(NodeswithcandidatedistnceList[i].Item1);
                    Nodeswithcandidatedistnce.Add(NodeswithcandidatedistnceList[i]);
                    
                    NodeswithcandidatedistncewithRounds.Add(Tuple.Create(NodeswithcandidatedistnceList[i].Item1, NodeswithcandidatedistnceList[i].Item2, 0));
                    Dummy.Add(NodeswithcandidatedistnceList[i]);
                    NodeswithcandidatedistnceDummy = GetTheNodesWithinTwoHopWithUpdatedistance(NodeswithcandidatedistnceList, Dummy, visitedNodes);
                    var nodewithlessdistance = NodeswithcandidatedistnceDummy.OrderBy(x => x.Item2).First();
                    ShortestRoute.Add(nodewithlessdistance);
                    Dummy.Clear();

                    foreach (var item in NodeswithcandidatedistnceDummy)
                    {
                        Nodeswithcandidatedistnce.Add(item);
                        NodeswithcandidatedistncewithRounds.Add(Tuple.Create(item.Item1, item.Item2, 1));

                        Dummy.Add(item);
                    }
                    NodeswithcandidatedistnceDummy.Clear();
                }
            }

            NodeswithcandidatedistnceDummy = GetTheNodesWithinTwoHopWithUpdatedistance(NodeswithcandidatedistnceList, Dummy, visitedNodes);
            var nodewithlessdistance1 = NodeswithcandidatedistnceDummy.OrderBy(x => x.Item2).First();
            ShortestRoute.Add(nodewithlessdistance1);
            Dummy.Clear();

            foreach (var item in NodeswithcandidatedistnceDummy)
            {
                Nodeswithcandidatedistnce.Add(item);
                NodeswithcandidatedistncewithRounds.Add(Tuple.Create(item.Item1, item.Item2, 2));

                Dummy.Add(item);
            }
            NodeswithcandidatedistnceDummy.Clear();

            NodeswithcandidatedistnceDummy = GetTheNodesWithinTwoHopWithUpdatedistance(NodeswithcandidatedistnceList, Dummy, visitedNodes);
            var nodewithlessdistance2 = NodeswithcandidatedistnceDummy.OrderBy(x => x.Item2).First();
            ShortestRoute.Add(nodewithlessdistance2);
            Dummy.Clear();

            //only this iteration for 20 nodes
            foreach (var item in NodeswithcandidatedistnceDummy)
            {
                Nodeswithcandidatedistnce.Add(item);
                NodeswithcandidatedistncewithRounds.Add(Tuple.Create(item.Item1, item.Item2, 3));

                Dummy.Add(item);
            }
            NodeswithcandidatedistnceDummy.Clear();

            return ShortestRoute;

        }

        //Token with Distance as 0 intially before the traversal
        private List<Tuple<Token, int>> GetInitialNodeswithSeroDistance(List<Token> duplicateeveryNodesDistancWithinMaxHopDistance)
        {
            List<Tuple<Token, int>> EverynodesDistancewithZeroInitialDistance = new List<Tuple<Token, int>>();

            for (int i = 0; i < duplicateeveryNodesDistancWithinMaxHopDistance.Count; i++)
            {
                EverynodesDistancewithZeroInitialDistance.Add(Tuple.Create(duplicateeveryNodesDistancWithinMaxHopDistance[i], 0));
            }
            return EverynodesDistancewithZeroInitialDistance;
        }

        private List<Tuple<Token, int>> GetTheNodesWithinTwoHopWithUpdatedistance(List<Tuple<Token, int>> nodeswithcandidatedistnceList, List<Tuple<Token, int>> dummy, List<Token> visitedNodes)
        {
            List<Tuple<Token, int>> nodeswithcandidatedistnceListDummy = new List<Tuple<Token, int>>();
            List<Tuple<Token, int>> dummyDummy = new List<Tuple<Token, int>>(dummy);
            List<Token> visitedNodesDummy = new List<Token>();

            List<Tuple<Token, int>> nodeswithUpdatedDistance = new List<Tuple<Token, int>>();
            List<Tuple<Token, int>> nodeswithUpdatedDistanceDummy = new List<Tuple<Token, int>>();

            for (int i = 0; i < dummyDummy.Count; i++)
            {
                for (int j = 0; j < nodeswithcandidatedistnceList.Count; j++)
                {
                    if (dummyDummy[i].Item1.SourceID== nodeswithcandidatedistnceList[j].Item1.SourceID)
                    {
                        nodeswithUpdatedDistanceDummy = GettheNodesWithinTwoHopswithDistanceUpdted(nodeswithcandidatedistnceList[j].Item1.TokenMessage, nodeswithcandidatedistnceList, visitedNodes);
                        visitedNodesDummy = GetVisitedNodes(nodeswithcandidatedistnceList[j].Item1.TokenMessage, nodeswithcandidatedistnceList);

                        foreach (var item in nodeswithUpdatedDistanceDummy)
                        {
                            nodeswithUpdatedDistance.Add(item);
                        }
                        foreach (var item in visitedNodesDummy)
                        {
                            visitedNodes.Add(item);
                        }

                    }
                }
            }
            return nodeswithUpdatedDistance;

        }

        private List<Token> GetVisitedNodes(List<Tuple<Node, Node, int, int>> tokenMessage, List<Tuple<Token, int>> nodeswithcandidatedistnceList)
        {
            List<Token> Visited = new List<Token>();
            for (int i = 0; i < tokenMessage.Count; i++)
            {
                
                if (tokenMessage[i].Item4 <= 2 )
                {
                    for (int j = 0; j < nodeswithcandidatedistnceList.Count; j++)
                    {
                        if (nodeswithcandidatedistnceList[j].Item1.SourceID == tokenMessage[i].Item2.ID)
                        {
                            Visited.Add(nodeswithcandidatedistnceList[j].Item1);

                        }
                    }
                }
            }
            return Visited;
        }

        private List<Tuple<Token, int>> GettheNodesWithinTwoHopswithDistanceUpdted(List<Tuple<Node, Node, int, int>> tokenMessage, List<Tuple<Token, int>> nodeswithcandidatedistnceList, List<Token> visitedNodes)
        {
            List<Tuple<Token, int>> NodesWithUpdatedDistance = new List<Tuple<Token, int>>();
            List<Tuple<Token, int>> nodeswithcandidatedistnceListDummy = new List<Tuple<Token, int>>(nodeswithcandidatedistnceList);

            for (int i = 0; i < tokenMessage.Count; i++)
            {
                bool check = CheckVisitedNodes(tokenMessage[i].Item2.ID, visitedNodes);
                if(tokenMessage[i].Item4==2 && !check)
                {
                    for (int j = 0; j < nodeswithcandidatedistnceListDummy.Count; j++)
                    {
                        if (nodeswithcandidatedistnceListDummy[j].Item1.SourceID==tokenMessage[i].Item2.ID)
                        {
                            nodeswithcandidatedistnceList.Add(Tuple.Create(nodeswithcandidatedistnceListDummy[j].Item1, tokenMessage[i].Item3 + nodeswithcandidatedistnceListDummy[j].Item2));
                            NodesWithUpdatedDistance.Add(Tuple.Create(nodeswithcandidatedistnceListDummy[j].Item1, tokenMessage[i].Item3 + nodeswithcandidatedistnceListDummy[j].Item2));

                            nodeswithcandidatedistnceListDummy.Remove(nodeswithcandidatedistnceListDummy[j]);
                           
                        }
                    }
                }
            }
            return NodesWithUpdatedDistance;
        }

        private bool CheckVisitedNodes(int iD, List<Token> visitedNodes)
        {
            int count = 0;

            for (int i = 0; i < visitedNodes.Count; i++)
            {
                if (visitedNodes[i].SourceID==iD)
                {
                    count++;
                }
            }
            if (count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
}
