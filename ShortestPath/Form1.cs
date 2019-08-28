using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Display();
        }

        void Display()
        {
            IList<Node> nodes = new List<Node>();
            GraphLayout graphLayout = new GraphLayout();
            nodes = graphLayout.GetGraphLayout(); //recomment

            List<Token> skeletongraph = new List<Token>();
            List<Token> Constructedskeltongraph = new List<Token>();

            foreach (var item in nodes)
            {
                Graph.Series["Vertices"].Points.AddXY(item.X, item.Y);
            }

            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();
            LocalEdge localEdge = new LocalEdge();
            Edges = localEdge.GetGrapgEdges(nodes); // recommment

            //Edges = localEdge.GetGrapgEdges(nodes);
            //has to be recommented

            TokenDistribution tokenDistribution = new TokenDistribution();

            //contruct a skeleton graph
            Constructedskeltongraph = ConstructedSkeletonGraph(nodes, Edges);

            APSP aPSP = new APSP();
            Node Sourcenode, Destinationnode;
            Sourcenode = nodes[0];
            Destinationnode = nodes[nodes.Count - 1];

            SSSP sSSP = new SSSP();


            Graph.Series["SourceNode"].Points.AddXY(Sourcenode.X, Sourcenode.Y);
            Graph.Series["DestinationNode"].Points.AddXY(Destinationnode.X, Destinationnode.Y);

            if (Edges?.Count > 0)
            {
                foreach (var item in Edges)
                {
                    Graph.Series["Edges"].Points.AddXY(item.Item1.X, item.Item1.Y);
                    Graph.Series["Edges"].Points.AddXY(item.Item2.X, item.Item2.Y);
                }
            }
            // till here

            ////ExactAlgorithm

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //var ExactApspshortestpath = aPSP.ExactAPSP(Sourcenode, Destinationnode);

            //foreach (var item in ExactApspshortestpath)
            //{
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item1.X, item.Item1.Y);
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item2.X, item.Item2.Y);

            //}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

            ////Approximate APSP
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var ApproximateApspshortestpath = aPSP.ApproximateAPSP(Sourcenode, Destinationnode);
            //foreach (var item in ApproximateApspshortestpath)
            //{
            //    Graph.Series["ApproximateAPSP"].Points.AddXY(item.Item1.X, item.Item1.Y);
            //    Graph.Series["ApproximateAPSP"].Points.AddXY(item.Item2.X, item.Item2.Y);

            //}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

            ////ExactAlgorithm

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //var ExactApspshortestpath = aPSP.ExactAPSPAlgorithm(Sourcenode, Destinationnode);

            ////foreach (var item in ExactApspshortestpath)
            ////{
            ////    Graph.Series["ExactAPSP"].Points.AddXY(item.Item1.X, item.Item1.Y);
            ////    Graph.Series["ExactAPSP"].Points.AddXY(item.Item2.X, item.Item2.Y);

            ////}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

            ////Exact SSSP
            //Stopwatch stopwatches = new Stopwatch();
            //stopwatches.Start();

            //var SSSPExactshortestpath = sSSP.ExactSSSP(Sourcenode, Destinationnode);
            ////foreach (var item in SSSPExactshortestpath)
            ////{
            ////    Graph.Series["ExactSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            ////}
            //stopwatches.Stop();
            //var timees = stopwatches.Elapsed;


            ////Approximate SSSP
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var SSSPApproximateshortestpath = sSSP.ApproximateSSSP(Sourcenode, Destinationnode);
            //foreach (var item in SSSPApproximateshortestpath)
            //{
            //    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;


            //////Approximate SSSP111
            ////Stopwatch stopwatch = new Stopwatch();
            ////stopwatch.Start();

            ////var SSSPApproximateshortestpath = sSSP.Approximate1SSSP(Sourcenode, Destinationnode);
            //////foreach (var item in SSSPApproximateshortestpath)
            //////{
            //////    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //////}
            ////stopwatch.Stop();
            ////var time = stopwatch.Elapsed;
            ////int i = 0;

            //Exact SSSP algorrithm from paper

            Stopwatch stopwatchesp = new Stopwatch();
            stopwatchesp.Start();

            var SSSPApproximateshortestpathesp = sSSP.ExactSSSPAlgorithm(Sourcenode, Destinationnode, Constructedskeltongraph);
            //foreach (var item in SSSPApproximateshortestpath)
            //{
            //    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //}
            stopwatchesp.Stop();
            var time = stopwatchesp.Elapsed;


            //Approximate SSSP algorrithm from paper

            Stopwatch stopwatchasp = new Stopwatch();
            stopwatchasp.Start();

            var SSSPApproximateshortestpathasp = sSSP.ApproxSSSPAlgorithm(Sourcenode, Destinationnode, Constructedskeltongraph);
            //foreach (var item in SSSPApproximateshortestpath)
            //{
            //    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //}
            stopwatchasp.Stop();
            var timeasp = stopwatchasp.Elapsed;
            int i = 0;

            ////Approximate own algorithm new
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var SSSPApproximateshortestpath = sSSP.ApprpxAprroxSSPAlgorithm(Sourcenode, Destinationnode);
            ////foreach (var item in SSSPApproximateshortestpath)
            ////{
            ////    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            ////}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

            //Dijikitras algorithm new
            Stopwatch stopwatchdi = new Stopwatch();
            stopwatchdi.Start();

            var SSSPApproximateshortestpath = sSSP.DijikitrasAlgorithm(Sourcenode, Destinationnode, Constructedskeltongraph);
            //foreach (var item in SSSPApproximateshortestpath)
            //{
            //    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //}
            stopwatchdi.Stop();
            var timedi = stopwatchdi.Elapsed;


            //Cluster SSSP

            Stopwatch stopwatchc = new Stopwatch();
            stopwatchc.Start();
            var ExactApspshortestpathcl = sSSP.ApprpxAprroxClusterAlgorithm(Sourcenode, Destinationnode, Constructedskeltongraph);

            //foreach (var item in ExactApspshortestpath)
            //{
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item1.X, item.Item1.Y);
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item2.X, item.Item2.Y);

            //}
            stopwatchc.Stop();
            var timec = stopwatchc.Elapsed;


            //Recursive SSSP

            Stopwatch stopwatchr = new Stopwatch();
            stopwatchr.Start();
            var ExactApspshortestpath = sSSP.ApproximateRecursiveSSPAlgorithm(Sourcenode, Destinationnode, Constructedskeltongraph);

            //foreach (var item in ExactApspshortestpath)
            //{
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item1.X, item.Item1.Y);
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item2.X, item.Item2.Y);

            //}
            stopwatchr.Stop();
            var timer = stopwatchr.Elapsed;


            //Min Edge Cover SSSP

            Stopwatch stopwatchm = new Stopwatch();
            stopwatchm.Start();
            var ExactApspshortestpath1 = sSSP.ApprpxMinFLowSSPAlgorithm(Sourcenode, Destinationnode, Constructedskeltongraph);

            //foreach (var item in ExactApspshortestpath)
            //{
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item1.X, item.Item1.Y);
            //    Graph.Series["ExactAPSP"].Points.AddXY(item.Item2.X, item.Item2.Y);

            //}
            stopwatchm.Stop();
            var timem = stopwatchm.Elapsed;


            // debugging Section 

            //List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            //List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();
            //tokencopies =tokenDistribution.TokenMultiplication();
            //tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies);



        }
        private void Graph_Click(object sender, EventArgs e)
        {

        }
        private List<Token> ConstructedSkeletonGraph(IList<Node> nodes, List<Tuple<Node, Node>> Edges)
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            List<Token> EveryNodesDistancWithinMaxHopDistance = new List<Token>();
            List<Token> EveryNodesDistancWithinMaxHopDistanceofMarkedNodes = new List<Token>();
            List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();

            tokencopies = tokenDistribution.TokenMultiplication(nodes, Edges);
            tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies,nodes,Edges);
            EveryNodesDistancWithinMaxHopDistance = ConstructSkeletonGraph(nodes,Edges);

            //Marked nodes threshold of number of copies
            int TokenCopiesThreshold = 5000;

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
        private List<Token> ConstructSkeletonGraph(IList<Node> nodes, List<Tuple<Node, Node>> edges)
        {
            TokenDistribution tokenDistribution = new TokenDistribution();
            Token token;

            
            IList<Node> Vertices = new List<Node>();
            List<Token> TokenwithDistanceMessage = new List<Token>();
            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();

            //int MaxHopDistance = 15;

            Vertices = nodes;
            Edges = edges;

            for (int i = 0; i < Vertices.Count; i++)
            {
                List<Tuple<Node, Node, int, int>> dupliccatetokenmessage = new List<Tuple<Node, Node, int, int>>();
                token = tokenDistribution.LocalBroadcast(Edges, Vertices[i],Vertices);

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
        //private void Graph_Paint(object sender, PaintEventArgs e)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    Pen penJoin = new Pen(Color.FromArgb(255, 0, 0, 255), 8);

        //    List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();
        //    LocalEdge localEdge = new LocalEdge();
        //    Edges = localEdge.GetGrapgEdges();
        //    path.StartFigure();
        //    foreach (var item in Edges)
        //    {
        //        path.AddLine(new Point(item.Item1.X, item.Item1.Y), new Point(item.Item2.X, item.Item2.Y));
        //        //path.AddLine(new Point(100, 200), new Point(100, 250));
        //    }



        //    penJoin.LineJoin = LineJoin.Bevel;
        //    e.Graphics.DrawPath(penJoin, path);
        //}
    }
}
