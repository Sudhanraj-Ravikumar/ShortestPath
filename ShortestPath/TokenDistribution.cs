using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class TokenDistribution
    {
       
        
        

        public List<Tuple<Node, Token>> DitributeToken(List<Tuple<Node, Node>> Edges)
        {
            GraphLayout graphLayout = new GraphLayout();
            LocalEdge LocalEdge = new LocalEdge();
            IList<Node> Vertices = new List<Node>();

            Vertices = graphLayout.GetGraphLayout();
            Edges = LocalEdge.GetGrapgEdges(Vertices);
            List<Tuple<Node, Token>> VertexWithToken = new List<Tuple<Node, Token>>();

            int IDcount = 1;
            int tokenId = 0;
            int distance;

            while (IDcount< Vertices.Count+1)
            {
                for (int i = 0; i < Edges.Count; i++)
                {
                    if (Edges?.Count != 0 && Edges[i].Item1.ID == IDcount)
                    {
                        tokenId++;
                        Edges[i].Item1.IsToken = true;
                        distance = GetDistance(Edges[i].Item1, Edges[i].Item2);
                        VertexWithToken.Add(Tuple.Create(Edges[i].Item2, new Token(Edges[i].Item1.ID, Edges[i].Item2.ID, distance, tokenId)));
                    }
                }
                IDcount++;
            }
            List<Tuple<Node, Token>> orderedVertexWithToken = new List<Tuple<Node, Token>>();

            orderedVertexWithToken = VertexWithToken.OrderBy(x => x.Item1.ID).ToList();

            //Logger logger = new Logger();
            //foreach (var item in orderedVertexWithToken)
            //{
                
            //    logger.LogWrite(item.Item2.SourceID.ToString(),
            //        item.Item2.DestinationID.ToString(),item.Item2.Distance.ToString(),item.Item1.ID.ToString());
                
            //}
           
            return VertexWithToken;

        }

        //using global edge

        public void DistributeTokenusingGlobalEdge()
        {
            GraphLayout graphLayout = new GraphLayout();
            LocalEdge LocalEdge = new LocalEdge();
            IList<Node> Vertices = new List<Node>();
            string message = "WERTYUHG"; // message lenght to debug .. it should rewal message strings lenght.. token length

            
            Vertices = graphLayout.GetGraphLayout();

            GlobalEdge globalEdge = new GlobalEdge();

            List<Tuple<Node, Node, int>> globaledegeswithdistanc = new List<Tuple<Node, Node, int>>();
            
                globaledegeswithdistanc= globalEdge.SendGlobalEdge(Vertices[0], Vertices, message);
           
            //Logger logger = new Logger();
            //foreach (var item in globaledegeswithdistanc)
            //{

            //    logger.LogWrite(item.Item1.ID.ToString(),
            //        item.Item2.ID.ToString(), item.Item3.ToString(), item.Item2.ID.ToString());

            //}
        }


        // each knows all its neighbours distance using local edges and the token is created with message of node to all nodes distance
        public Token LocalBroadcast(List<Tuple<Node, Node>> Edges, Node Source)
        {
            GraphLayout graphLayout = new GraphLayout();
            LocalEdge LocalEdge = new LocalEdge();
            IList<Node> Vertices = new List<Node>();

            
            List<int> Route = new List<int>();
            Route.Add(Source.ID);
            List<Tuple<Node, Node, int, int>> VerticesWithUpdatedDistance = new List<Tuple<Node, Node, int,int>>(); // node to dnode , distance
            List<Tuple<Node, Node, int, int>> VerticesWithUpdatedDistanceWithMaxHopDistance = new List<Tuple<Node, Node, int, int>>(); //With Max 2 Hopcount with route list =>node1=>node=node3

            //Token TokenMessage;
            
            Vertices = graphLayout.GetGraphLayout();

            Edges = LocalEdge.GetGrapgEdges(Vertices);

            int HopCount = 1;

            //First Round of brodcast through local in first hop

            for(int i=0; i < Edges.Count; i++)
            {
                if(Edges[i].Item1.ID == Source.ID)
                {
                    int distance = GetDistance(Source, Edges[i].Item2);
                    VerticesWithUpdatedDistance.Add(Tuple.Create(Source, Edges[i].Item2, distance, HopCount));
                    
                }
            }

            HopCount++;
            VerticesWithUpdatedDistanceWithMaxHopDistance = GetBroadcast(VerticesWithUpdatedDistance, Edges,Source, Route, HopCount);

            foreach (var item in VerticesWithUpdatedDistanceWithMaxHopDistance)
            {
                VerticesWithUpdatedDistance.Add(Tuple.Create(item.Item1, item.Item2, item.Item3, item.Item4));
                Route.Add(item.Item2.ID);
            }
            
            for (int i = 0; i < Vertices.Count; i++)
            {
               
                var DistinctVertices = VerticesWithUpdatedDistance.Select(x => x.Item2.ID).Distinct().ToList();
                Route = GetVisitedVertices(DistinctVertices);
                if ( DistinctVertices.Count<=Vertices.Count)
                {
                    HopCount++;
                    List<Tuple<Node, Node, int, int>> VerticesWithUpdatedDistanceWithMaxHopDistance1 = new List<Tuple<Node, Node, int, int>>();
                    VerticesWithUpdatedDistanceWithMaxHopDistance1 = GetBroadcast(VerticesWithUpdatedDistanceWithMaxHopDistance, Edges, Source,Route, HopCount);
                    foreach (var item in VerticesWithUpdatedDistanceWithMaxHopDistance1)
                    {
                        VerticesWithUpdatedDistance.Add(Tuple.Create(item.Item1, item.Item2, item.Item3, item.Item4));
                        
                    }
                    VerticesWithUpdatedDistanceWithMaxHopDistance.Clear();
                    foreach (var item in VerticesWithUpdatedDistanceWithMaxHopDistance1)
                    {
                        VerticesWithUpdatedDistanceWithMaxHopDistance.Add(Tuple.Create(item.Item1, item.Item2, item.Item3, item.Item4));
                       
                    }
                    
                    VerticesWithUpdatedDistanceWithMaxHopDistance1.Clear();
                    Route.Clear();
                }

                if (DistinctVertices.Count==20)
                {
                    break;
                }
                
                

            }
            Logger logger = new Logger();
            foreach (var item in VerticesWithUpdatedDistance)
            {

                logger.LogWrite(item.Item1.ID.ToString(),
                    item.Item2.ID.ToString(), item.Item3.ToString(), item.Item4.ToString());

            }

            Token TokenMessage = new Token(Source.ID, VerticesWithUpdatedDistance);
            return TokenMessage;

        }

        private List<int> GetVisitedVertices(List<int> distinctVertices)
        {
            List<int> Route = new List<int>();
            for (int i = 0; i < distinctVertices.Count; i++)
            {
                Route.Add(distinctVertices[i]);
            }
            return Route;
        }

        private List<Tuple<Node, Node, int, int>> GetBroadcast(List<Tuple<Node, Node, int, int>> VerticesUpdated, List<Tuple<Node, Node>> Edges,
             Node Source,List<int> Routelist,int HopCount)
        {

            List<Tuple<Node, Node, int, int>> VerticesWithUpdatedDistanceWithMaxHopDistance = new List<Tuple<Node, Node, int, int>>();
            
            for (int i = 0; i < VerticesUpdated.Count; i++)
            {
                for (int j = 0; j < Edges.Count; j++)
                {
                    //for (int k = 0; k < Routelist.Count; k++)
                    //{


                        if (VerticesUpdated[i].Item2.ID == Edges[j].Item1.ID && CheckAlreadyVisitedVertices(Routelist,Edges[j].Item2.ID))
                        {
                        int distance = GetDistance(VerticesUpdated[i].Item2, Edges[j].Item2);
                            VerticesWithUpdatedDistanceWithMaxHopDistance.Add(Tuple.Create(Source, Edges[j].Item2,
                                VerticesUpdated[i].Item3 + distance, HopCount));
                        }
                    //}
                }
            }
            return VerticesWithUpdatedDistanceWithMaxHopDistance;
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
        private int GetDistance(Node item1, Node item2)
        {
            int dist, dist1;
            dist = (int)Math.Abs(((item2.X - item1.X) * (item2.X - item1.X)) + ((item2.Y - item1.Y) * (item2.Y - item1.Y)));
            dist1 =(int) Math.Sqrt(dist);
            return dist1;
        }

        //Multpication of tokens Section
        public List<Tuple<int, int>> TokenMultiplication()
        {
            List<Token> Nodesiwthtokens = new List<Token>();
            List<Tuple<int, int>> Tokencounts = new List<Tuple<int, int>>(); // sourcdenode,token recieved from node, token copy number
            
            //list of nodes with tokens consisting of the distaces of all the nodes through local edges
            Nodesiwthtokens = GetEveryNodesDistance();

            // loop until rounds of number of tokens in the system 
            for (int j = 0; j < Nodesiwthtokens.Count; j++) // usually vertices/number of tokens rounds 
            {
                for (int i = 0; i < Nodesiwthtokens.Count; i++)
                {
                    List<Tuple<int, int>> dummyTokencounts = new List<Tuple<int, int>>();
                    dummyTokencounts = MultiplyTokens(Nodesiwthtokens[i], Nodesiwthtokens);
                    Tokencounts.Add(dummyTokencounts[0]);
                    Tokencounts.Add(dummyTokencounts[1]);
                    dummyTokencounts.Clear();
                }
            }
            
            return Tokencounts;

        }

        private List<Tuple<int, int>> MultiplyTokens(Token token, List<Token> nodesiwthtokens)
        {
            Random random = new Random();
            List<Tuple<int, int>> NodeswithRandommultilpiedcopies = new List<Tuple<int, int>>();
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(100); // delay to get random numbers 
                int node = random.Next(0, nodesiwthtokens.Count - 1);
                NodeswithRandommultilpiedcopies.Add(Tuple.Create(token.SourceID, nodesiwthtokens[node].SourceID));
            }
             return NodeswithRandommultilpiedcopies;
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
                token = tokenDistribution.LocalBroadcast(Edges, Vertices[i]);
                TokenwithDistanceMessage.Add(token);
            }
            return TokenwithDistanceMessage;
        }

        //nodes with number of copies after token multplication 
        public List<Tuple<int, int>> GetNumberofNodeswithTokenCopies(List<Tuple<int, int>> tokencopieslistaftermultipication)
        {
            List<Tuple<int, int>> MultipleTokenCopiesList = new List<Tuple<int, int>>(tokencopieslistaftermultipication);
            List<Tuple<int, int>> TokenwithrespectivenumberofCopies = new List<Tuple<int, int>>();//token,copycount
            List<Token> Nodesiwthtokens = new List<Token>();
            Tuple<int, int> TokenwithrespectivenumberofCopy;
            //list of nodes with tokens consisting of the distaces of all the nodes through local edges
            Nodesiwthtokens = GetEveryNodesDistance();

            for (int i = 0; i < Nodesiwthtokens.Count; i++)
            {
                TokenwithrespectivenumberofCopy = GetNumberofCopieswithToken(Nodesiwthtokens[i].SourceID, tokencopieslistaftermultipication);
                TokenwithrespectivenumberofCopies.Add(TokenwithrespectivenumberofCopy);
            }
            return TokenwithrespectivenumberofCopies;
        }

        private Tuple<int, int> GetNumberofCopieswithToken(int sourceID, List<Tuple<int, int>> tokencopieslistaftermultipication)
        {
            
            int count = 0;
            for (int i = 0; i < tokencopieslistaftermultipication.Count; i++)
            {
                if (sourceID==tokencopieslistaftermultipication[i].Item2)
                {
                    count++;
                }
            }
            
            return Tuple.Create(sourceID, count); 
        }
    }
}
