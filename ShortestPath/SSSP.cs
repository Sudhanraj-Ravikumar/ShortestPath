using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class SSSP
    {
        List<Token> nonVistedNodebranches = new List<Token>();
        List<int> VisisitedNodes = new List<int>();
        public List<Tuple<Node, int>> ExactSSSP(Node SourceNode, Node DestinationNode, IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token,int>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token,int>>();
            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;

            //To be recommented
            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();

            SkeletonGraphswithShortDistanceroute = getShortdistance(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistance);
            shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute,nodes,Edges);

            // number of token 
            numberofmessage =  GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        //ExactSSSP from Paper
        public List<Tuple<Node, int>> ExactSSSPAlgorithm(Node SourceNode, Node DestinationNode,List<Token> constructedgraph)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();

            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;


            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();
            EveryNodesDistancWithinMaxHopDistance = constructedgraph;
            EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, EveryNodesDistancWithinMaxHopDistance);
            EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            SkeletonGraphswithShortDistanceroute = getShortdistanceAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);
            
           
            // number of token 
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        //AppoxSSSP from Paper
        public List<Tuple<Node, int>> ApproxSSSPAlgorithm(Node SourceNode, Node DestinationNode, List<Token> constructedgraph)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();

            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;


            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();
            EveryNodesDistancWithinMaxHopDistance = constructedgraph;
            EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, EveryNodesDistancWithinMaxHopDistance);
            EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            SkeletonGraphswithShortDistanceroute = getShortdistanceAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            // number of token 
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        //Approx sssp own from own ides
        public List<Tuple<Node, int>> ApprpxAprroxSSPAlgorithm(Node SourceNode, Node DestinationNode, List<Token> constructedgraph)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();

            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;


            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();
            EveryNodesDistancWithinMaxHopDistance = constructedgraph;
            EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, EveryNodesDistancWithinMaxHopDistance);
            EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            SkeletonGraphswithShortDistanceroute = getShortdistanceOWnAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            // number of token 
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        //Cluster Based 
        public List<Tuple<Node, int>> ApprpxAprroxClusterAlgorithm(Node SourceNode, Node DestinationNode, List<Token> constructedgraph)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();

            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;


            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();
            EveryNodesDistancWithinMaxHopDistance = constructedgraph;
            EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, EveryNodesDistancWithinMaxHopDistance);
            EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceclusterNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            SkeletonGraphswithShortDistanceroute = getShortdistanceClusterAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            // number of token 
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        //Approx sssp Recursive Algorithm
        public List<Tuple<Node, int>> ApproximateRecursiveSSPAlgorithm(Node SourceNode, Node DestinationNode, List<Token> constructedgraph)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();

            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;


            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();
            EveryNodesDistancWithinMaxHopDistance = constructedgraph;
            EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, EveryNodesDistancWithinMaxHopDistance);
            EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceclusterNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            SkeletonGraphswithShortDistanceroute = getShortdistanceRecursiveAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            // number of token 
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        //Min Flow method
        public List<Tuple<Node, int>> ApprpxMinFLowSSPAlgorithm(Node SourceNode, Node DestinationNode, List<Token> constructedgraph)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();

            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;


            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();
            EveryNodesDistancWithinMaxHopDistance = constructedgraph;
            EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, EveryNodesDistancWithinMaxHopDistance);
            EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            SkeletonGraphswithShortDistanceroute = getShortdistanceMinFlowAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            // number of token 
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }
        //Dijikitras from Paper
        public List<Tuple<Node, int>> DijikitrasAlgorithm(Node SourceNode, Node DestinationNode, List<Token> constructedgraph)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();

            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;


            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();
            EveryNodesDistancWithinMaxHopDistance = constructedgraph;
            EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, EveryNodesDistancWithinMaxHopDistance);
            EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceDijikitrasNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            SkeletonGraphswithShortDistanceroute = getShortdistanceDjikitrasAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            // number of token 
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        //Filter within the max hop range 
        // max hop here is 2
        private List<Tuple<Token, double>> GetWithinHopDistanceNeighbourNodes(List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue = new List<Tuple<Token, double>>();
            
            
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                List<Tuple<Node, Node, int, int>> TokenwithinHop = new List<Tuple<Node, Node, int, int>>();
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage.Count; j++)
                {
                    //hop count = 2
                    if (everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j].Item4<=2)
                    {
                        TokenwithinHop.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j]);
                    }
                }
                Token token = new Token(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID,TokenwithinHop);
                everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue.Add(Tuple.Create(token, everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item2));
                
            }
            return everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue;
        }

        //in one hop
        //Dijikitras are mades to with one hop
        private List<Tuple<Token, double>> GetWithinHopDistanceDijikitrasNeighbourNodes(List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue = new List<Tuple<Token, double>>();


            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                List<Tuple<Node, Node, int, int>> TokenwithinHop = new List<Tuple<Node, Node, int, int>>();
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage.Count; j++)
                {
                    //hop count = 1
                    if (everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j].Item4 <= 1)
                    {
                        TokenwithinHop.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j]);
                    }
                }
                Token token = new Token(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID, TokenwithinHop);
                everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue.Add(Tuple.Create(token, everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item2));

            }
            return everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue;
        }

        //cluster
        private List<Tuple<Token, double>> GetWithinHopDistanceclusterNeighbourNodes(List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue = new List<Tuple<Token, double>>();


            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                List<Tuple<Node, Node, int, int>> TokenwithinHop = new List<Tuple<Node, Node, int, int>>();
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage.Count; j++)
                {
                    //hop count = 3 because within 2 is to do claculation within cluster and 
                    //to find the shortest nodes to 3rd node
                    if (everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j].Item4 <= 3)
                    {
                        TokenwithinHop.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j]);
                    }
                }
                Token token = new Token(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID, TokenwithinHop);
                everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue.Add(Tuple.Create(token, everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item2));

            }
            return everyNodesDistancWithinMaxHopDistanceinStartingphasereturnvalue;
        }
        public List<Tuple<Node, int>> ApproximateSSSP(Node SourceNode, Node DestinationNode, IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Token, int>> SkeletonGraphswithShortDistanceroute = new List<Tuple<Token, int>>();
            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;

            // to be recommented
            //EveryNodesDistancWithinMaxHopDistance = ConstructApproximateSkeletonGraph();

            SkeletonGraphswithShortDistanceroute = getShortdistance(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistance);
            shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute,nodes, Edges);

            //number of message
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        public List<Tuple<Node, int>> Approximate1SSSP(Node SourceNode, Node DestinationNode)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Token> SkeletonGraphswithShortDistanceroute = new List<Token>();
            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            List<Tuple<Token, double>> SkeletonGraphswithShortDistanceroute1 = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = new List<Tuple<Token, double>>();
            List<Token> SourceandDestinationTkoennodes = new List<Token>();

            int numberofmessage;

            //To be recommented
            //EveryNodesDistancWithinMaxHopDistance = ConstructApproximateSkeletonGraph();

            SourceandDestinationTkoennodes = getSourceandDestinationNodeTokens(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistance);
            if (SourceandDestinationTkoennodes?.Count != 0)
            {
                foreach (var item in SourceandDestinationTkoennodes)
                {
                    SkeletonGraphswithShortDistanceroute.Add(item);
                }
            }

            //total count * 2 rounds hint 
            SkeletonGraphswithShortDistanceroute = getShortdistanceApprox1(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistance);
            
            ////just trial from new exact sssp paper algorithm
            //EveryNodesDistancWithinMaxHopDistanceinStartingphase = GetintiialphaseNodedetails(SourceNode, SkeletonGraphswithShortDistanceroute);
            //EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance = GetWithinHopDistanceNeighbourNodes(EveryNodesDistancWithinMaxHopDistanceinStartingphase);

            //SkeletonGraphswithShortDistanceroute1 = getShortdistanceAlgorithm(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceinStartingphasewithinhopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            //number of message
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }

        private List<Token> getSourceandDestinationNodeTokens(Node sourceNode, Node destinationNode, List<Token> everyNodesDistancWithinMaxHopDistance)
        {
            List<Token> returnvalue = new List<Token>();

            for (int i = 0; i < everyNodesDistancWithinMaxHopDistance.Count; i++)
            {
                if (everyNodesDistancWithinMaxHopDistance[i].SourceID == sourceNode.ID || 
                    everyNodesDistancWithinMaxHopDistance[i].DestinationID== destinationNode.ID)
                {
                    returnvalue.Add(everyNodesDistancWithinMaxHopDistance[i]);
                }
            }
            return returnvalue;
        }

        //approx Exact
        public List<Tuple<Node, int>> ApproximateexactSSSP(Node SourceNode, Node DestinationNode)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Token> SkeletonGraphswithShortDistanceroute = new List<Token>();
            List<Tuple<Node, int>> shortpath = new List<Tuple<Node, int>>();
            int numberofmessage;

            //to be recommented
            //EveryNodesDistancWithinMaxHopDistance = ConstructExactSkeletonGraph();

            //total count * 2 rounds hint 
            SkeletonGraphswithShortDistanceroute = getShortdistanceApprox1(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistance);

            //shortpath = GEtNodeswithrespectivefromlis(SkeletonGraphswithShortDistanceroute);

            //number of message
            numberofmessage = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);
            //debugging to check the token counts
            return shortpath;
        }
        private List<Tuple<Node, int>> GEtNodeswithrespectivefromlis(List<Tuple<Token, int>> skeletonGraphswithShortDistanceroute, IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            
            IList<Node> Vertices = new List<Node>();
            Vertices = nodes;
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
            //TokenDistribution tokenDistribution = new TokenDistribution();
            //List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            //List<Token> EveryNodesDistancWithinMaxHopDistanceofMarkedNodes = new List<Token>();
            //List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            //List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();

            ////tokencopies = tokenDistribution.TokenMultiplication();
            //tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies);
            //EveryNodesDistancWithinMaxHopDistance = ConstructSkeletonGraph();

            ////Marked nodes threshold of number of copies
            //int TokenCopiesThreshold = 1000;

            //for (int i = 0; i < EveryNodesDistancWithinMaxHopDistance.Count; i++)
            //{
            //    for (int j = 0; j < tokencopieswithrespectivenodes.Count; j++)
            //    {
            //        if (EveryNodesDistancWithinMaxHopDistance[i].SourceID == tokencopieswithrespectivenodes[j].Item1 && tokencopieswithrespectivenodes[j].Item2 <= TokenCopiesThreshold)
            //        {
            //            EveryNodesDistancWithinMaxHopDistanceofMarkedNodes.Add(EveryNodesDistancWithinMaxHopDistance[i]);
            //        }
            //    }

            //}

            //return EveryNodesDistancWithinMaxHopDistanceofMarkedNodes;
            return null;
        }

        private List<Token> ConstructApproximateSkeletonGraph()
        {
            //TokenDistribution tokenDistribution = new TokenDistribution();
            //List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            //List<Token> EveryNodesDistancWithinMaxHopDistanceofMarkedNodes = new List<Token>();
            //List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            //List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();

            //tokencopies = tokenDistribution.TokenMultiplication();
            //tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies);
            //EveryNodesDistancWithinMaxHopDistance = ConstructSkeletonGraph();

            ////Marked nodes threshold of number of copies
            //int TokenCopiesThreshold = 43;

            //for (int i = 0; i < EveryNodesDistancWithinMaxHopDistance.Count; i++)
            //{
            //    for (int j = 0; j < tokencopieswithrespectivenodes.Count; j++)
            //    {
            //        if (EveryNodesDistancWithinMaxHopDistance[i].SourceID == tokencopieswithrespectivenodes[j].Item1 && tokencopieswithrespectivenodes[j].Item2 <= TokenCopiesThreshold)
            //        {
            //            EveryNodesDistancWithinMaxHopDistanceofMarkedNodes.Add(EveryNodesDistancWithinMaxHopDistance[i]);
            //        }
            //    }

            //}

            //return EveryNodesDistancWithinMaxHopDistanceofMarkedNodes;
            return null;
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
                token = tokenDistribution.LocalBroadcast(Edges, Vertices[i], Vertices);

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

            //NodeswithcandidatedistnceDummy = GetTheNodesWithinTwoHopWithUpdatedistance(NodeswithcandidatedistnceList, Dummy, visitedNodes);
            //var nodewithlessdistance2 = NodeswithcandidatedistnceDummy.OrderBy(x => x.Item2).First();
            //ShortestRoute.Add(nodewithlessdistance2);
            //Dummy.Clear();

            ////only this iteration for 20 nodes
            //foreach (var item in NodeswithcandidatedistnceDummy)
            //{
            //    Nodeswithcandidatedistnce.Add(item);
            //    NodeswithcandidatedistncewithRounds.Add(Tuple.Create(item.Item1, item.Item2, 3));

            //    Dummy.Add(item);
            //}
            //NodeswithcandidatedistnceDummy.Clear();

            return ShortestRoute;

        }

        //Source node with 0 and other nodes with inifinty distance. 
        //Its about the phase before starting the algorthm to updatye with the distances
        //starting phase
        private List<Tuple<Token, double>> GetintiialphaseNodedetails(Node sourceNode, List<Token> everyNodesDistancWithinMaxHopDistance)
        {
            List<Tuple<Token, double>> NodeswithdistanceTuple = new List<Tuple<Token, double>>();
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistance.Count; i++)
            {
                if (everyNodesDistancWithinMaxHopDistance[i].SourceID == sourceNode.ID)
                {
                    NodeswithdistanceTuple.Add(Tuple.Create(everyNodesDistancWithinMaxHopDistance[i], (double)0));
                    
                }
                else
                {
                    NodeswithdistanceTuple.Add(Tuple.Create(everyNodesDistancWithinMaxHopDistance[i], double.PositiveInfinity));
                }
            }
            return NodeswithdistanceTuple;

        }

        private List<Tuple<Token, double>> getShortdistanceAlgorithm(Node sourceNode, Node destinationNode, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphasedummy = new List<Tuple<Token, double>>();

            int count = 0;
            int numberofrounds;
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                count++;
                UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase =
                    GetupdatedDistancelistexact(everyNodesDistancWithinMaxHopDistanceinStartingphase[i],
                    everyNodesDistancWithinMaxHopDistanceinStartingphase);

                //everyNodesDistancWithinMaxHopDistanceinStartingphase.Clear();
                everyNodesDistancWithinMaxHopDistanceinStartingphase=UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase;
            }

            numberofrounds = (count * 2)-2;
            return everyNodesDistancWithinMaxHopDistanceinStartingphase;
        }

        //Min Flow
        private List<Tuple<Token, double>> getShortdistanceMinFlowAlgorithm(Node sourceNode, Node destinationNode, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphasedummy = new List<Tuple<Token, double>>();

            List<NodeObject> NeighbouronehopEdgesList = new List<NodeObject>(); // soruce destination edge, total neighbour of that edge
            List<int> MarkedNodeswithminimumEdgeCover = new List<int>();
            List<int> dupMarkedNodeswithminimumEdgeCover = new List<int>();

            NeighbouronehopEdgesList = getNEighbouringEdgesList(everyNodesDistancWithinMaxHopDistanceinStartingphase);
            MarkedNodeswithminimumEdgeCover.Add(sourceNode.ID);
            dupMarkedNodeswithminimumEdgeCover = GetMinimumEdgeCoverNodes(NeighbouronehopEdgesList);
            foreach (var item in dupMarkedNodeswithminimumEdgeCover)
            {
                MarkedNodeswithminimumEdgeCover.Add(item);
            }
            
            int count = 0;
            int numberofrounds;
            for (int j = 0; j < MarkedNodeswithminimumEdgeCover.Count; j++)
            {


                for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
                {
                    if (MarkedNodeswithminimumEdgeCover[j] == everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID)
                    {


                        count++;
                        UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase =
                            GetupdatedDistancelistexact(everyNodesDistancWithinMaxHopDistanceinStartingphase[i],
                            everyNodesDistancWithinMaxHopDistanceinStartingphase);

                        //everyNodesDistancWithinMaxHopDistanceinStartingphase.Clear();
                        everyNodesDistancWithinMaxHopDistanceinStartingphase = UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase;
                    }
                }
            }
            numberofrounds = (count * 2) - 2;
            return everyNodesDistancWithinMaxHopDistanceinStartingphase;
        }

        private List<int> GetMinimumEdgeCoverNodes(List<NodeObject> neighbouronehopEdgesList)
        {

            List<int> MArkedNoides = new List<int>();
            List<int> neigbourcounts = new List<int>();
            List<int> Vistednodes = new List<int>();
            Vistednodes.Add(10000);
            for (int i = 0; i < neighbouronehopEdgesList.Count; i++)
            {
                for (int j = 0; j < neighbouronehopEdgesList[i].Nodedetails?.Count; j++)
                {

                    neigbourcounts.Add(neighbouronehopEdgesList[i].Nodedetails[j].Item3);
                    
                }

            }
            var maxneighbourcount = neigbourcounts.Max();

            int max = maxneighbourcount+1;
            for (int j = 0; j<maxneighbourcount ; j++)
            {
                max--;

                for (int i = 0; i < neighbouronehopEdgesList.Count; i++)
                {
                    if (!CheckVisitedNodesint(neighbouronehopEdgesList[i].Source, Vistednodes))
                    {


                        if (neighbouronehopEdgesList[i].Nodedetails.Count == max)
                        {
                            MArkedNoides.Add(neighbouronehopEdgesList[i].Source);
                            Vistednodes.Add(neighbouronehopEdgesList[i].Source);

                            for (int k = 0; k < neighbouronehopEdgesList[i].Nodedetails.Count; k++)
                            {
                                Vistednodes.Add(neighbouronehopEdgesList[i].Nodedetails[k].Item2);
                                Vistednodes.Distinct();
                            }
                        }
                    }
                }
            }
            return MArkedNoides;
        }

        //neighbout nodes and their edges count
        private List<NodeObject> getNEighbouringEdgesList(List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<int, int, int>> nodedetails = new List<Tuple<int, int, int>>();
            
            List<NodeObject> nodeObject =  new List<NodeObject>();
            List<Tuple<int, NodeObject>> returnNeighbourList = new List<Tuple<int, NodeObject>>();
            int count;
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                List<Tuple<int, int, int>> duplicatenodedetails = new List<Tuple<int, int, int>>();
                count = 0;
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage.Count; j++)
                {
                    if (everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j].Item4 == 1)
                    {
                        duplicatenodedetails.Add(Tuple.Create(
                            everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j].Item1.ID,
                            everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.TokenMessage[j].Item2.ID,
                            count++));
                    }
                    
                }
                
                nodeObject.Add(new NodeObject(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID,
                        duplicatenodedetails));
                
            }

            return nodeObject;
        }

        List<int> ExploredVisitedNodes = new List<int>();
        List<int> ExploredVisitedNodesdj = new List<int>();
        List<int> ExploredVisitedNodesrec = new List<int>();

        //OWn Approx SSSP Greedy level based
        private List<Tuple<Token, double>> getShortdistanceOWnAlgorithm(Node sourceNode, Node destinationNode, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphasedummy = new List<Tuple<Token, double>>();
            ExploredVisitedNodes.Add(1500); //just to make the list non emply when i =1

            int count = 0;
            int numberofnodes;
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                
                if(!CheckVisitedNodesint(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID,ExploredVisitedNodes))
                {
                    UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase =
                        GetupdatedDistancelist(everyNodesDistancWithinMaxHopDistanceinStartingphase[i],
                        everyNodesDistancWithinMaxHopDistanceinStartingphase);
                    count++;
                    //everyNodesDistancWithinMaxHopDistanceinStartingphase.Clear();
                    everyNodesDistancWithinMaxHopDistanceinStartingphase = UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase;
                }
            }

            numberofnodes = (count * 2) - 2;
            return everyNodesDistancWithinMaxHopDistanceinStartingphase;
        }

        //Dijikitras
        private List<Tuple<Token, double>> getShortdistanceDjikitrasAlgorithm(Node sourceNode, Node destinationNode, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();

            ExploredVisitedNodesdj.Add(1500); //just to make the list non emply when i =1

            int count = 0;

            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {

                if (!CheckVisitedNodesint(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID, ExploredVisitedNodesdj))
                {
                    UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase =
                        GetupdatedDjikitrasDistancelist(everyNodesDistancWithinMaxHopDistanceinStartingphase[i],
                        everyNodesDistancWithinMaxHopDistanceinStartingphase);
                    count++;
                    //everyNodesDistancWithinMaxHopDistanceinStartingphase.Clear();
                    everyNodesDistancWithinMaxHopDistanceinStartingphase = UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase;
                }
            }
            return everyNodesDistancWithinMaxHopDistanceinStartingphase;
        }

        //SSSP Recursive
        private List<Tuple<Token, double>> getShortdistanceRecursiveAlgorithm(Node sourceNode, Node destinationNode, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphasedummy = new List<Tuple<Token, double>>();
            ExploredVisitedNodesrec.Add(1500); //just to make the list non emply when i =1

            Tuple<Token, double> NextNode = new Tuple<Token, double>(everyNodesDistancWithinMaxHopDistanceinStartingphase[0].Item1, everyNodesDistancWithinMaxHopDistanceinStartingphase[0].Item2);

            int count = 0;
            int numberofnodes;
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                if (everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID == NextNode.Item1.SourceID)
                {

                    if (!CheckVisitedNodesint(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID, ExploredVisitedNodesrec))
                    {
                        UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase =
                            GetupdatedRecursiveDistancelist(everyNodesDistancWithinMaxHopDistanceinStartingphase[i],
                            everyNodesDistancWithinMaxHopDistanceinStartingphase);

                        NextNode = GetNextNode(everyNodesDistancWithinMaxHopDistanceinStartingphase[i], everyNodesDistancWithinMaxHopDistanceinStartingphase); ;

                        count++;

                        everyNodesDistancWithinMaxHopDistanceinStartingphase = UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase;
                    }
                }
            }

            numberofnodes = (count * 2) - 2;
            return everyNodesDistancWithinMaxHopDistanceinStartingphase;
        }

        // Own Cluster based
        private List<Tuple<Token, double>> getShortdistanceClusterAlgorithm(Node sourceNode, Node destinationNode, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphasedummy = new List<Tuple<Token, double>>();
            ExploredVisitedNodes.Add(1500); //just to make the list non emply when i =1

            Tuple<Token, double> NextNode = new Tuple<Token, double>(everyNodesDistancWithinMaxHopDistanceinStartingphase[0].Item1,everyNodesDistancWithinMaxHopDistanceinStartingphase[0].Item2);

            int count = 0;
            int numberofnodes;
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                if (everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID == NextNode.Item1.SourceID)
                {

                    if (!CheckVisitedNodesint(everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID, ExploredVisitedNodes))
                    {
                        UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase =
                            GetupdatedclusterDistancelist(everyNodesDistancWithinMaxHopDistanceinStartingphase[i],
                            everyNodesDistancWithinMaxHopDistanceinStartingphase);

                        NextNode = GetNextNode(everyNodesDistancWithinMaxHopDistanceinStartingphase[i],everyNodesDistancWithinMaxHopDistanceinStartingphase);;

                        count++;
                        
                        everyNodesDistancWithinMaxHopDistanceinStartingphase = UpdatedeveryNodesDistancWithinMaxHopDistanceinStartingphase;
                    }
                }
            }

            numberofnodes = (count * 2) - 2;
            return everyNodesDistancWithinMaxHopDistanceinStartingphase;
        }

        private Tuple<Token, double> GetNextNode(Tuple<Token, double> tuple, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Node,Node,int,int>> nodesinAboveBoundaryhop = new List<Tuple<Node, Node, int, int>>();
            Tuple<Token, double> returnValue = null;

            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                if (tuple.Item1.TokenMessage[i].Item4==3)
                {
                    nodesinAboveBoundaryhop.Add(tuple.Item1.TokenMessage[i]);
                }
            }

            var minimumdistanceNode = nodesinAboveBoundaryhop.OrderBy(l => l.Item3).First();

            for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
            {
                if (everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID==minimumdistanceNode.Item2.ID)
                {
                    returnValue = everyNodesDistancWithinMaxHopDistanceinStartingphase[i];
                    break;
                }
            }

            return returnValue;
        }

        private List<Tuple<Token, double>> GetupdatedDjikitrasDistancelist(Tuple<Token, double> tuple, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> updateddistnace = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> updateddistnacelist = new List<Tuple<Token, double>>();

            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; j++)
                {
                    if (tuple.Item1.TokenMessage[i].Item2.ID == everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1.SourceID
                        /*&& !CheckVisitedNodesint(tuple.Item1.TokenMessage[i].Item2.ID, ExploredVisitedNodes)*/)
                    {
                        if ((tuple.Item1.TokenMessage[i].Item3 + tuple.Item2) < everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item2)
                        {
                            updateddistnace.Add(Tuple.Create(everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1, tuple.Item1.TokenMessage[i].Item3 + tuple.Item2));
                        }

                    }

                }

            }

            //explored nodes within one hop
            ExploredVisitedNodesdj.Add(tuple.Item1.SourceID);

            ExploredVisitedNodesdj = ExploredVisitedNodesdj.Distinct().ToList();

            int count = 0;

            if (updateddistnace?.Count > 0)
            {
                for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
                {
                    for (int j = 0; j < updateddistnace.Count; j++)
                    {
                        if (updateddistnace[j].Item1.SourceID == everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID)
                        {
                            updateddistnacelist.Add(updateddistnace[j]);
                            count++;
                            break;
                        }

                    }
                    if (count == 0)
                    {
                        updateddistnacelist.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i]);
                    }
                    count = 0;
                }
                return updateddistnacelist;
            }
            else
            {
                return everyNodesDistancWithinMaxHopDistanceinStartingphase;
            }
        }
        private List<Tuple<Token, double>> GetupdatedDistancelist(Tuple<Token, double> tuple, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> updateddistnace = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> updateddistnacelist = new List<Tuple<Token, double>>();

            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                for (int j = 0; j <everyNodesDistancWithinMaxHopDistanceinStartingphase.Count ; j++)
                {
                    if (tuple.Item1.TokenMessage[i].Item2.ID == everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1.SourceID
                        && tuple.Item1.TokenMessage[i].Item4<3)
                    {
                        if ((tuple.Item1.TokenMessage[i].Item3 + tuple.Item2)<everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item2)
                        {
                            updateddistnace.Add(Tuple.Create(everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1, tuple.Item1.TokenMessage[i].Item3 + tuple.Item2));
                        }

                    }

                }

            }

            //explored nodes within one hop
            ExploredVisitedNodesdj.Add(tuple.Item1.SourceID);
            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                if (tuple.Item1.TokenMessage[i].Item4<2)
                {
                    ExploredVisitedNodesdj.Add(tuple.Item1.TokenMessage[i].Item2.ID);
                }
            }
            ExploredVisitedNodesdj = ExploredVisitedNodesdj.Distinct().ToList();

            int count = 0;

            if (updateddistnace?.Count > 0)
            {
                for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
                {
                    for (int j = 0; j < updateddistnace.Count; j++)
                    {
                        if (updateddistnace[j].Item1.SourceID == everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID)
                        {
                            updateddistnacelist.Add(updateddistnace[j]);
                            count++;
                            break;
                        }

                    }
                    if (count == 0)
                    {
                        updateddistnacelist.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i]);
                    }
                    count = 0;
                }
                return updateddistnacelist;
            }
            else
            {
                return everyNodesDistancWithinMaxHopDistanceinStartingphase;
            }
        }

        //cluster
        private List<Tuple<Token, double>> GetupdatedclusterDistancelist(Tuple<Token, double> tuple, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> updateddistnace = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> updateddistnacelist = new List<Tuple<Token, double>>();

            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; j++)
                {
                    if (tuple.Item1.TokenMessage[i].Item2.ID == everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1.SourceID
                        /*&& !CheckVisitedNodesint(tuple.Item1.TokenMessage[i].Item2.ID, ExploredVisitedNodes)*/)
                    {
                        if ((tuple.Item1.TokenMessage[i].Item3 + tuple.Item2) < everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item2)
                        {
                            updateddistnace.Add(Tuple.Create(everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1, tuple.Item1.TokenMessage[i].Item3 + tuple.Item2));
                        }

                    }

                }

            }


            //explored nodes within max hop
            //MAx hop here is 2
            ExploredVisitedNodes.Add(tuple.Item1.SourceID);
            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                if (tuple.Item1.TokenMessage[i].Item4 < 3)
                {
                    ExploredVisitedNodes.Add(tuple.Item1.TokenMessage[i].Item2.ID);
                }
            }
            ExploredVisitedNodes = ExploredVisitedNodes.Distinct().ToList();

            int count = 0;

            if (updateddistnace?.Count > 0)
            {
                for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
                {
                    for (int j = 0; j < updateddistnace.Count; j++)
                    {
                        if (updateddistnace[j].Item1.SourceID == everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID)
                        {
                            updateddistnacelist.Add(updateddistnace[j]);
                            count++;
                            break;
                        }

                    }
                    if (count == 0)
                    {
                        updateddistnacelist.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i]);
                    }
                    count = 0;
                }
                return updateddistnacelist;
            }
            else
            {
                return everyNodesDistancWithinMaxHopDistanceinStartingphase;
            }
        }

        //REcursive Algorithm
        private List<Tuple<Token, double>> GetupdatedRecursiveDistancelist(Tuple<Token, double> tuple, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> updateddistnace = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> updateddistnacelist = new List<Tuple<Token, double>>();

            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; j++)
                {
                    
                    if (tuple.Item1.TokenMessage[i].Item2.ID == everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1.SourceID
                        /*&& !CheckVisitedNodesint(tuple.Item1.TokenMessage[i].Item2.ID, ExploredVisitedNodes)*/)
                    {
                        if ((tuple.Item1.TokenMessage[i].Item3 + tuple.Item2) < everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item2)
                        {
                            updateddistnace.Add(Tuple.Create(everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1, tuple.Item1.TokenMessage[i].Item3 + tuple.Item2));
                        }

                    }
                    

                }
                

            }


            //explored nodes within one hop
            ExploredVisitedNodesrec.Add(tuple.Item1.SourceID);
            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                if (tuple.Item1.TokenMessage[i].Item4 < 2)
                {
                    ExploredVisitedNodesrec.Add(tuple.Item1.TokenMessage[i].Item2.ID);
                }
            }
            ExploredVisitedNodesrec = ExploredVisitedNodesrec.Distinct().ToList();

            int count = 0;

            if (updateddistnace?.Count > 0)
            {
                for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
                {
                    for (int j = 0; j < updateddistnace.Count; j++)
                    {
                        if (updateddistnace[j].Item1.SourceID == everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID)
                        {
                            updateddistnacelist.Add(updateddistnace[j]);
                            count++;
                            break;
                        }

                    }
                    if (count == 0)
                    {
                        updateddistnacelist.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i]);
                    }
                    count = 0;
                }
                return updateddistnacelist;
            }
            else
            {
                return everyNodesDistancWithinMaxHopDistanceinStartingphase;
            }
        }
        private List<Tuple<Token, double>> GetupdatedDistancelistexact(Tuple<Token, double> tuple, List<Tuple<Token, double>> everyNodesDistancWithinMaxHopDistanceinStartingphase)
        {
            List<Tuple<Token, double>> updateddistnace = new List<Tuple<Token, double>>();
            List<Tuple<Token, double>> updateddistnacelist = new List<Tuple<Token, double>>();

            for (int i = 0; i < tuple.Item1.TokenMessage.Count; i++)
            {
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; j++)
                {
                    if (tuple.Item1.TokenMessage[i].Item2.ID == everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1.SourceID
                        )
                    {
                        if ((tuple.Item1.TokenMessage[i].Item3 + tuple.Item2) < everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item2)
                        {
                            updateddistnace.Add(Tuple.Create(everyNodesDistancWithinMaxHopDistanceinStartingphase[j].Item1, tuple.Item1.TokenMessage[i].Item3 + tuple.Item2));
                        }

                    }

                }

            }

            

            int count = 0;

            if (updateddistnace?.Count > 0)
            {
                for (int i = 0; i < everyNodesDistancWithinMaxHopDistanceinStartingphase.Count; i++)
                {
                    for (int j = 0; j < updateddistnace.Count; j++)
                    {
                        if (updateddistnace[j].Item1.SourceID == everyNodesDistancWithinMaxHopDistanceinStartingphase[i].Item1.SourceID)
                        {
                            updateddistnacelist.Add(updateddistnace[j]);
                            count++;
                            break;
                        }

                    }
                    if (count == 0)
                    {
                        updateddistnacelist.Add(everyNodesDistancWithinMaxHopDistanceinStartingphase[i]);
                    }
                    count = 0;
                }
                return updateddistnacelist;
            }
            else
            {
                return everyNodesDistancWithinMaxHopDistanceinStartingphase;
            }
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
        private int GetNumberofTokens(List<Token> ListofToken)
        {
            int count = 0;
            List<Token> ListofTokenwithin2hop = new List<Token>();

            for (int i = 0; i < ListofToken.Count; i++)
            {
                for (int j = 0; j < ListofToken[i].TokenMessage.Count; j++)
                {
                    if (ListofToken[i].TokenMessage[j].Item4<3)
                    {
                        count++;
                    }
                   
                }
            }
            return count;
        }

        
        private List<Token> getShortdistanceApprox1(Node sourceNode, Node destinationNode, List<Token> everyNodesDistancWithinMaxHopDistance)
        {

            List<Token> NonMarkedNodesExploring = new List<Token>();
            List<Token> NonMarkedNodesExploringduplicate = new List<Token>();
            List<Token> NonMarkedNodesExploringdistinct = new List<Token>();

            for (int i = 0; i < everyNodesDistancWithinMaxHopDistance.Count; i++)
            {
                if (everyNodesDistancWithinMaxHopDistance[i].SourceID==sourceNode.ID)
                {
                    VisisitedNodes.Add(sourceNode.ID);
                    nonVistedNodebranches.Add(everyNodesDistancWithinMaxHopDistance[i]);
                    break;
                }
            }

            int cnt=0;
            while (cnt < 10)
            {
                NonMarkedNodesExploringduplicate = GettheNextNonExlporedNodeWithTwoHops(everyNodesDistancWithinMaxHopDistance);
                foreach (var item in NonMarkedNodesExploringduplicate)
                {
                    NonMarkedNodesExploring.Add(item);
                }
                NonMarkedNodesExploringduplicate.Clear();
                cnt++;
            }

            var nonmarked = NonMarkedNodesExploring.Select(x => x.SourceID).Distinct().ToList();

            for (int i = 0; i < everyNodesDistancWithinMaxHopDistance.Count; i++)
            {
                for (int j = 0; j < nonmarked.Count; j++)
                {
                    if (everyNodesDistancWithinMaxHopDistance[i].SourceID==nonmarked[j])
                    {
                        NonMarkedNodesExploringdistinct.Add(everyNodesDistancWithinMaxHopDistance[i]);
                        break;
                    }
                }

            }

            return NonMarkedNodesExploringdistinct;
        }

        private List<Token> GettheNextNonExlporedNodeWithTwoHops(List<Token> everyNodesDistancWithinMaxHopDistance)
        {
            List<int> nonvistednodeint = new List<int>();
            List<Token> nonVisitedNodebranchesduplicate = new List<Token>();
            for (int i = 0; i < nonVistedNodebranches.Count; i++)
            {
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistance.Count; j++)
                {
                    if (nonVistedNodebranches[i].SourceID==everyNodesDistancWithinMaxHopDistance[j].SourceID)
                    {

                        for (int k = 0; k < everyNodesDistancWithinMaxHopDistance[j].TokenMessage.Count; k++)
                        {
                            if (everyNodesDistancWithinMaxHopDistance[j].TokenMessage[k].Item4<=1 
                                && !CheckVisitedNodesint(everyNodesDistancWithinMaxHopDistance[j].TokenMessage[k].Item2.ID,VisisitedNodes))
                            {
                                VisisitedNodes.Add(everyNodesDistancWithinMaxHopDistance[j].TokenMessage[k].Item2.ID);
                            }
                            if (everyNodesDistancWithinMaxHopDistance[j].TokenMessage[k].Item4 == 2
                                && !CheckVisitedNodesint(everyNodesDistancWithinMaxHopDistance[j].TokenMessage[k].Item2.ID, VisisitedNodes))
                            {
                                nonvistednodeint.Add(everyNodesDistancWithinMaxHopDistance[j].TokenMessage[k].Item2.ID);
                            }
                        }
                    }
                }
            }

            nonVistedNodebranches.Clear();
            for (int i = 0; i < nonvistednodeint.Count; i++)
            {
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistance.Count; j++)
                {
                    if (nonvistednodeint[i] == everyNodesDistancWithinMaxHopDistance[j].SourceID)
                    {
                        nonVistedNodebranches.Add(everyNodesDistancWithinMaxHopDistance[j]);
                        nonVisitedNodebranchesduplicate.Add(everyNodesDistancWithinMaxHopDistance[j]);
                    }
                }
            }

            return nonVisitedNodebranchesduplicate;
            
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

        private bool CheckVisitedNodesint(int iD, List<int> visitedNodes)
        {
            int count = 0;

            for (int i = 0; i < visitedNodes.Count; i++)
            {
                if (visitedNodes[i] == iD)
                {
                    count++;
                }
            }
            if (count > 0)
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

public class NodeObject
{
    private int source;
    

    private List<Tuple<int, int, int>> nodedetails = new List<Tuple<int, int, int>>();

    public NodeObject(int source, List<Tuple<int, int, int>> nodedetails)
    {
        this.source = source;
        this.nodedetails = nodedetails;
    }

    public List<Tuple<int, int, int>> Nodedetails
    {
        get => nodedetails;
        set => nodedetails = value;
    }

    public int Source
    {
        get => source;
        set => source = value;
    }



}
