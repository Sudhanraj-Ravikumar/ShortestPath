﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class APSP
    {
        List<int> VistiedNodes = new List<int>();
        public List<Tuple<Node, Node, int, int>> ExactAPSP(Node SourceNode, Node DestinationNode, IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Token> SkeletonGraphs = new List<Token>();
            List<Tuple<Node, Node, int, int>> shortpath = new List<Tuple<Node, Node, int, int>>();

            int numberofmessages;
            int numberofrounds;

            
            //EverynodesDistance = GetEveryNodesDistance();
            EveryNodesDistancWithinMaxHopDistance =ConstructExactSkeletonGraph(nodes,Edges);
            
            SkeletonGraphs = getSkeletongroupofGraphs(SourceNode,DestinationNode, EveryNodesDistancWithinMaxHopDistance,out shortpath);

            // number of message as paramenter study 
            numberofmessages = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);

            //total rounds for parameter study
            numberofrounds = GetTotalExactalgorithmRounds(shortpath);
            
            //debugging to check the token counts
            return shortpath;
        }

        

        public List<Tuple<Node, Node, int, int>> ApproximateAPSP(Node SourceNode, Node DestinationNode, IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            List<Token> SkeletonGraphs = new List<Token>();
            List<Token> EveryNodesDistancWithinMaxHopDistanceMarkedNodes = new List<Token>();
            List<Tuple<Node, Node, int, int>> shortpath = new List<Tuple<Node, Node, int, int>>();
            int numberofmessages;
            int numberofrounds;

            EveryNodesDistancWithinMaxHopDistanceMarkedNodes = ConstructApproximateSkeletonGraph(nodes,Edges);
            SkeletonGraphs = getSkeletongroupofGraphs(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistanceMarkedNodes, out shortpath);

            // total number of message parameter study
            numberofmessages = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistanceMarkedNodes);

            //total rounds for parameter study
            numberofrounds = GetTotalApproxalgorithmRounds(shortpath);

            return shortpath;

        }

        //Exact APSP from the paper
        public List<Tuple<Node, Node, int, int>> ExactAPSPAlgorithm(Node SourceNode, Node DestinationNode, IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            
            List<Token> EverynodesDistance = new List<Token>();
            List<Token> SkeletonGraphs = new List<Token>();
            List<Tuple<Node, Node, int, int>> shortpath = new List<Tuple<Node, Node, int, int>>();

            int numberofmessages;
            int numberofrounds;


            //EverynodesDistance = GetEveryNodesDistance();
            EveryNodesDistancWithinMaxHopDistance = ConstructExactAlgoSkeletonGraph(nodes,Edges);

            double[,] InitialDistnaceMAtrix = new double[EverynodesDistance.Count, EverynodesDistance.Count];
            double[,] FinalDistnaceMAtrix = new double[EverynodesDistance.Count, EverynodesDistance.Count];

            //Construct a initial Distance Matrix
            InitialDistnaceMAtrix = GetIntiialDistanceMAtrix(EveryNodesDistancWithinMaxHopDistance);
            FinalDistnaceMAtrix = GetUpdatedShotestPAth(InitialDistnaceMAtrix,EveryNodesDistancWithinMaxHopDistance.Count);

            SkeletonGraphs = getSkeletongroupofGraphs(SourceNode, DestinationNode, EveryNodesDistancWithinMaxHopDistance, out shortpath);

            // number of message as paramenter study 
            numberofmessages = GetNumberofTokens(EveryNodesDistancWithinMaxHopDistance);

            //total rounds for parameter study
            numberofrounds = GetTotalExactalgorithmRounds(shortpath);

            //debugging to check the token counts
            return shortpath;
        }

        private double[,] GetUpdatedShotestPAth(double[,] initialDistnaceMAtrix,int MatrizSize)
        {
            for (int k = 0; k < MatrizSize; k++)
            {
                for (int i = 0; i < MatrizSize; i++)
                {
                    for (int j = 0; j < MatrizSize; j++)
                    {
                        if (initialDistnaceMAtrix[i, k] + initialDistnaceMAtrix[k, j] < initialDistnaceMAtrix[i, j])
                            initialDistnaceMAtrix[i, j] = initialDistnaceMAtrix[i, k] + initialDistnaceMAtrix[k, j];
                    }
                }
            }

            return initialDistnaceMAtrix;
        }

        //Initial Distance MAtrix 


        private double[,] GetIntiialDistanceMAtrix(List<Token> everyNodesDistancWithinMaxHopDistance)
        {
            double[,] initialmatrix =  new double[everyNodesDistancWithinMaxHopDistance.Count,everyNodesDistancWithinMaxHopDistance.Count];
            for (int i = 0; i < everyNodesDistancWithinMaxHopDistance.Count; i++)
            {
                for (int j = 0; j < everyNodesDistancWithinMaxHopDistance[i].Tokenmessagewithupdateddistance.Count; j++)
                {
                    initialmatrix[i, j] = everyNodesDistancWithinMaxHopDistance[i].Tokenmessagewithupdateddistance[j].Item5;
                }
            }

            return initialmatrix;
            
        }

        

        private List<Token> GetEveryNodesDistance()
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            Token token;

            LocalEdge localEdge = new LocalEdge();
            GraphLayout graphLayout = new GraphLayout();
            IList<Node> Vertices = new List<Node>();
            List<Token> TokenwithDistanceMessage = new List<Token>();
            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();

            

            Vertices = graphLayout.GetGraphLayout();
            Edges = localEdge.GetGrapgEdges(Vertices);

            for (int i = 0; i < Vertices.Count; i++)
            {                
                token = tokenDistribution.LocalBroadcast(Edges, Vertices[i], Vertices);
                TokenwithDistanceMessage.Add(token);
            }
            return TokenwithDistanceMessage;
        }
       
        /*List of Moarked nodes for Approximate lgorithm */
        private List<Token> ConstructApproximateSkeletonGraph(IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EveryNodesDistancWithinMaxHopDistanceofMarkedNodes = new List<Token>();
            List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();

            tokencopies = tokenDistribution.TokenMultiplication(nodes,Edges);
            tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies,nodes,Edges);
            EveryNodesDistancWithinMaxHopDistance = ConstructSkeletonGraph();

            //Marked nodes threshold of number of copies
            // 20=45. 50=112, 86=178
            int TokenCopiesThreshold = 115;

            for (int i = 0; i < EveryNodesDistancWithinMaxHopDistance.Count; i++)
            {
                for (int j = 0; j < tokencopieswithrespectivenodes.Count; j++)
                {
                    if (EveryNodesDistancWithinMaxHopDistance[i].SourceID==tokencopieswithrespectivenodes[j].Item1 && tokencopieswithrespectivenodes[j].Item2<=TokenCopiesThreshold)
                    {
                        EveryNodesDistancWithinMaxHopDistanceofMarkedNodes.Add(EveryNodesDistancWithinMaxHopDistance[i]);
                    }
                }
                
            }

            return EveryNodesDistancWithinMaxHopDistanceofMarkedNodes;
        }

        private List<Token> ConstructExactSkeletonGraph(IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EveryNodesDistancWithinMaxHopDistanceofMarkedNodes = new List<Token>();
            List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();

            tokencopies = tokenDistribution.TokenMultiplication(nodes,Edges);
            tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies,nodes,Edges);
            EveryNodesDistancWithinMaxHopDistance = ConstructSkeletonGraph();

            //Marked nodes threshold of number of copies 
            // 20 =100 ; 50= 200
            int TokenCopiesThreshold = 1000;

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

        //Exact Algorithm From Paper Construct Skeleton 

        private List<Token> ConstructExactAlgoSkeletonGraph(IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EveryNodesDistancWithinMaxHopDistanceofMarkedNodes = new List<Token>();
            List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();

            tokencopies = tokenDistribution.TokenMultiplication(nodes,Edges);
            tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies,nodes, Edges);
            EveryNodesDistancWithinMaxHopDistance = ConstructAlgoSkeletonGraph();

            //Marked nodes threshold of number of copies 
            // 20 =100 ; 50= 200
            int TokenCopiesThreshold = 1000;

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


        /*node to nodes within the max hop distance (Exact)*/
        private List<Token> ConstructSkeletonGraph()
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            Token token;
            
            LocalEdge localEdge = new LocalEdge();
            GraphLayout graphLayout = new GraphLayout();
            IList<Node> Vertices = new List<Node>();
            List<Token> TokenwithDistanceMessage = new List<Token>();
            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();
            
            int MaxHopDistance = 20;

            Vertices = graphLayout.GetGraphLayout();
            Edges = localEdge.GetGrapgEdges(Vertices);

            for (int i = 0; i <Vertices.Count; i++)
            {
                List<Tuple<Node, Node, int, int>> dupliccatetokenmessage = new List<Tuple<Node, Node, int, int>>();
                token =tokenDistribution.LocalBroadcast(Edges, Vertices[i], Vertices);

                for (int j = 0; j < token.TokenMessage.Count; j++)
                {
                    if(token.TokenMessage[j].Item3 < MaxHopDistance)
                    {
                        dupliccatetokenmessage.Add(token.TokenMessage[j]);
                       
                    }
                }
                
                Token duplicate = new Token(token.SourceID, dupliccatetokenmessage);
                TokenwithDistanceMessage.Add(duplicate);
                
            }
            return TokenwithDistanceMessage;
        }

        //Construct Exact Algorithm From Graph from skeleton

        private List<Token> ConstructAlgoSkeletonGraph()
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            Token token;

            LocalEdge localEdge = new LocalEdge();
            GraphLayout graphLayout = new GraphLayout();
            IList<Node> Vertices = new List<Node>();
            List<Token> TokenwithDistanceMessage = new List<Token>();
            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();

            List<int> veticesNumber = new List<int>();
            

            int MaxHopDistance = 20;

            Vertices = graphLayout.GetGraphLayout();
            Edges = localEdge.GetGrapgEdges(Vertices);

            for (int i = 0; i < Vertices.Count; i++)
            {
                veticesNumber.Add(Vertices[i].ID);
            }

            for (int i = 0; i < Vertices.Count; i++)
            {
                List<Tuple<Node, Node, int, int,double>> dupliccatetokenmessage = new List<Tuple<Node, Node, int, int,double>>();
                token = tokenDistribution.LocalBroadcast(Edges, Vertices[i], Vertices);

                for (int j = 0; j < token.TokenMessage.Count; j++)
                {
                    //within 2 hop counts
                    if (token.TokenMessage[j].Item4 < 3)
                    {
                        dupliccatetokenmessage.Add(Tuple.Create(token.TokenMessage[j].Item1,
                            token.TokenMessage[j].Item2,token.TokenMessage[j].Item3,token.TokenMessage[j].Item4,
                            (double)token.TokenMessage[j].Item3));

                    }
                    else
                    {
                        dupliccatetokenmessage.Add(Tuple.Create(token.TokenMessage[j].Item1,
                            token.TokenMessage[j].Item2, token.TokenMessage[j].Item3, token.TokenMessage[j].Item4,
                            double.PositiveInfinity));
                    }
                }
                List<Tuple<Node, Node, int, int, double>> Uniquedupliccatetokenmessage = new List<Tuple<Node, Node, int, int, double>>();
                Tuple<Node, Node, int, int, double> unique;
                if (dupliccatetokenmessage?.Count != 0)
                {
                    for (int k = 0; k < veticesNumber.Count; k++)
                    {
                        if (veticesNumber[k] != dupliccatetokenmessage[0].Item1.ID)
                        {
                            unique = GetUniqueVeticesToken(veticesNumber[k], dupliccatetokenmessage);
                            Uniquedupliccatetokenmessage.Add(unique);
                        }
                        else
                        {
                            Uniquedupliccatetokenmessage.Add(Tuple.Create(dupliccatetokenmessage[i].Item1,
                                dupliccatetokenmessage[k].Item1, 0, 0, (double)0));
                        }
                    }
                }
                var orderedDuplicatemessage = Uniquedupliccatetokenmessage.OrderBy(x => x.Item2.ID).ToList();
                Token duplicate = new Token(token.SourceID, orderedDuplicatemessage);
                TokenwithDistanceMessage.Add(duplicate);

            }
            return TokenwithDistanceMessage;
        }

        private Tuple<Node, Node, int, int, double> GetUniqueVeticesToken(int v, List<Tuple<Node, Node, int, int, double>> dupliccatetokenmessage)
        {
            List<Tuple<Node, Node, int, int, double>> dup = new List<Tuple<Node, Node, int, int, double>>();
            int count = 0;
            for (int i = 0; i < dupliccatetokenmessage.Count; i++)
            {
                if (v==dupliccatetokenmessage[i].Item2.ID)
                {
                    count++;
                    dup.Add(dupliccatetokenmessage[i]);
                }
            }

            if (count > 1)
            {
                var min = dup.OrderBy(x => x.Item3).First();
                return min;
            }
            else
            {
                return dup[0];
            }
            
        }

        //Grouping or forming skelton graph with max hop distance
        private List<Token> getSkeletongroupofGraphs(Node sourcenode, Node destinationnode, List<Token> everyNodesTokeswithDistance,out List<Tuple<Node, Node, int, int>> shortpath)
        {
            List<Token> DuplicateEveryNodesTokenwitmessage = new List<Token>(everyNodesTokeswithDistance);
            
            List<Tuple<Node, Node, int, int>> Shortpath = new List<Tuple<Node, Node, int, int>>();
            List<Token> SkeletonGraph = new List<Token>();
            List<Token> DuplicateSkeletonGraph = new List<Token>();
            //List<int> VistiedNodes = new List<int>();

            

            for (int i = 0; i < DuplicateEveryNodesTokenwitmessage.Count; i++)
            {
                if (DuplicateEveryNodesTokenwitmessage[i].SourceID==sourcenode.ID)
                {
                    SkeletonGraph.Add(DuplicateEveryNodesTokenwitmessage[i]);
                    VistiedNodes.Add(DuplicateEveryNodesTokenwitmessage[i].SourceID);
                    DuplicateEveryNodesTokenwitmessage.TrimExcess();
                }
            }


            var MinDistanceVertices = SkeletonGraph[0].TokenMessage.OrderBy(l => l.Item3).First();
            if (MinDistanceVertices != null)
            {

                Shortpath.Add(MinDistanceVertices);
            }
            
            
            //var MinDistanceVertices = SkeletonGraph.OrderBy(x => x.TokenMessage.Min(y => y.Item3)).First();
            for (int i = 0; i < SkeletonGraph[0].TokenMessage.Count; i++)
            {

                VistiedNodes.Add(SkeletonGraph[0].TokenMessage[i].Item2.ID);
            }

            var MinDistanceVertices1 = GetNextShotestVertix(MinDistanceVertices, DuplicateEveryNodesTokenwitmessage, VistiedNodes,destinationnode);
            Shortpath.Add(MinDistanceVertices1);
            int j = 1;
            for (int i = 0; i < DuplicateEveryNodesTokenwitmessage.Count; i++)
            {
                
                var MinDistanceVertices2 = GetNextShotestVertix(Shortpath[j], DuplicateEveryNodesTokenwitmessage, VistiedNodes,destinationnode);
                if (MinDistanceVertices2!=null)
                {

                    Shortpath.Add(MinDistanceVertices2);
                }
               
                if (CheckDestinationNode(VistiedNodes,destinationnode.ID))
                {
                    break;
                }
                
                j++;
            }
            shortpath = Shortpath;
            return SkeletonGraph;
        }

        

        private Tuple<Node, Node, int, int> GetNextShotestVertix(Tuple<Node, Node, int, int> minDistanceVertices, List<Token> duplicateEveryNodesTokenwitmessage, List<int> vistiedNodes, Node destinationnode)
        {
            
            List<Token> duplicate = new List<Token>(duplicateEveryNodesTokenwitmessage);
            List<Token> DuplicateSkelitonGraph = new List<Token>();
            List<Token> SkelitonGraph = new List<Token>();
            List<Token> dummy = new List<Token>();
            List<Tuple<Node, Node, int, int>> dummyTokenMessage = new List<Tuple<Node, Node, int, int>>();
            List<Token> EverynodesDistance = new List<Token>();
            List<Tuple<Node, Node, int, int, int>> TokenwithDestinationDistanceDetails = new List<Tuple<Node, Node, int, int, int>>();
           EverynodesDistance = GetEveryNodesDistance();

            for (int i = 0; i < duplicate?.Count; i++)
            {
                if (minDistanceVertices.Item2.ID==duplicate[i].SourceID)
                {
                    DuplicateSkelitonGraph.Add(duplicate[i]);
                }
            }
            for (int i = 0; i < DuplicateSkelitonGraph[0].TokenMessage?.Count; i++)
            {
                if (CheckAlreadyVisitedVertices(vistiedNodes,DuplicateSkelitonGraph[0].TokenMessage[i].Item2.ID))
                {
                    dummyTokenMessage.Add(DuplicateSkelitonGraph[0].TokenMessage[i]);
                }
            }

            dummy.Add(new Token(DuplicateSkelitonGraph[0].SourceID, dummyTokenMessage));
            for (int i = 0; i < dummy[0].TokenMessage?.Count; i++)
            {

                VistiedNodes.Add(dummy[0].TokenMessage[i].Item2.ID);
            }
            VistiedNodes = VistiedNodes.Distinct().ToList();
            

            //Finding the total minimum distance to destination
            for (int i = 0; i < dummy[0].TokenMessage?.Count; i++)
            {
                for (int j = 0; j < EverynodesDistance?.Count; j++)
                {
                    if (dummy[0].TokenMessage[i].Item2.ID==EverynodesDistance[j].SourceID)
                    {
                        for (int k = 0; k < EverynodesDistance[j].TokenMessage.Count; k++)
                        {
                            if (EverynodesDistance[j].TokenMessage[k].Item2.ID==destinationnode.ID)
                            {
                                TokenwithDestinationDistanceDetails.Add(Tuple.Create(dummy[0].TokenMessage[i].Item1,
                                    dummy[0].TokenMessage[i].Item2, dummy[0].TokenMessage[i].Item3,
                                    dummy[0].TokenMessage[i].Item4, EverynodesDistance[j].TokenMessage[k].Item3));
                            }
                        }
                    }

                }
            }
            if (TokenwithDestinationDistanceDetails?.Count!=0)
            {


                var MinDistanceVerticesoderederewithMinimumDistance = TokenwithDestinationDistanceDetails.OrderBy(l => l.Item5).First();
                List<Tuple<Node, Node, int, int>> MinDistanceVertices = new List<Tuple<Node, Node, int, int>>();

                MinDistanceVertices.Add(Tuple.Create(MinDistanceVerticesoderederewithMinimumDistance.Item1, MinDistanceVerticesoderederewithMinimumDistance.Item2,
                    MinDistanceVerticesoderederewithMinimumDistance.Item3, MinDistanceVerticesoderederewithMinimumDistance.Item4));
                return MinDistanceVertices[0];
            }
            else
            {
                return null;
            }
        }

        //get the total number token messages passed
        private int GetNumberofTokens(List<Token> ListofToken)
        {
            int count = 0;
            for (int i = 0; i < ListofToken.Count; i++)
            {
                count = count + ListofToken[i].TokenMessage.Count;
            }
            return count;
        }

        //Get the total number of the rounds
        private int GetnumberofroundsforLocalExploration(List<Token> nodeswitheveryDistance)
        {
            int RoundCounts;
            List<int> hops = new List<int>();
            for (int i = 0; i < nodeswitheveryDistance.Count; i++)
            {
                for (int j = 0; j < nodeswitheveryDistance[i].TokenMessage.Count; j++)
                {
                    hops.Add(nodeswitheveryDistance[i].TokenMessage[j].Item4);
                }
            }
            RoundCounts = hops.Max();

            return RoundCounts;
        }

        // Exact rounds
        private int GetTotalExactalgorithmRounds(List<Tuple<Node, Node, int, int>> shortpath)
        {
            int localexplorationrounds;
            List<int> hops = new List<int>();
            List<Token> tokenwithlocalexplorationdistance = new List<Token>();
            int totalrounds;

            tokenwithlocalexplorationdistance = GetEveryNodesDistance();
            localexplorationrounds = GetnumberofroundsforLocalExploration(tokenwithlocalexplorationdistance);

            for (int i = 0; i < shortpath?.Count; i++)
            {
                hops.Add(shortpath[i].Item4);
            }

            totalrounds = shortpath.Count * (hops.Max()) + localexplorationrounds;
            return totalrounds;
        }

        //approx Rounds
        private int GetTotalApproxalgorithmRounds(List<Tuple<Node, Node, int, int>> shortpath)
        {
            int localexplorationrounds;
            List<int> hops = new List<int>();
            List<Token> tokenwithlocalexplorationdistance = new List<Token>();
            int totalrounds;

            tokenwithlocalexplorationdistance = GetEveryNodesDistance();
            localexplorationrounds = GetnumberofroundsforLocalExploration(tokenwithlocalexplorationdistance);

            for (int i = 0; i < shortpath?.Count; i++)
            {
                hops.Add(shortpath[i].Item4);
            }

            totalrounds = shortpath.Count + localexplorationrounds;
            return totalrounds;
        }

        private bool CheckAlreadyVisitedVertices(List<int> GivenID, int SourceID)
        {
            int count = 1;
            for (int i = 0; i < GivenID.Count; i++)
            {
                if (GivenID[i] == SourceID)
                {
                    count++;
                }

            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckDestinationNode(List<int> vistiedNodes, int iD)
        {
            int count = 1;

            for (int i = 0; i < VistiedNodes.Count; i++)
            {
                if (vistiedNodes[i] == iD)
                {
                    count++;

                }
            }
            if (count > 1)
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
