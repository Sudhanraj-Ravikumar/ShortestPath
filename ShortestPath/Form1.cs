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
            nodes = graphLayout.GetGraphLayout();


            foreach (var item in nodes)
            {
                Graph.Series["Vertices"].Points.AddXY(item.X, item.Y);
            }

            List<Tuple<Node, Node>> Edges = new List<Tuple<Node, Node>>();
            LocalEdge localEdge = new LocalEdge();
            Edges = localEdge.GetGrapgEdges(nodes);
           

            TokenDistribution tokenDistribution = new TokenDistribution();
            //tokenDistribution.DitributeToken(Edges);
            //tokenDistribution.DistributeTokenusingGlobalEdge();
            //tokenDistribution.LocalBroadcast(Edges,nodes[0]);

            APSP aPSP = new APSP();
            Node Sourcenode, Destinationnode;
            Sourcenode = nodes[0];
            Destinationnode = nodes[nodes.Count-1];

            SSSP sSSP = new SSSP();
            

            Graph.Series["SourceNode"].Points.AddXY(Sourcenode.X, Sourcenode.Y);
            Graph.Series["DestinationNode"].Points.AddXY(Destinationnode.X, Destinationnode.Y);

            foreach (var item in Edges)
            {
                Graph.Series["Edges"].Points.AddXY(item.Item1.X, item.Item1.Y);
                Graph.Series["Edges"].Points.AddXY(item.Item2.X, item.Item2.Y);
            }

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

            ////Exact SSSP
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var SSSPExactshortestpath = sSSP.ExactSSSP(Sourcenode, Destinationnode);
            //foreach (var item in SSSPExactshortestpath)
            //{
            //    Graph.Series["ExactSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

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

            ////Exact SSSP algorrithm from paper

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var SSSPApproximateshortestpath = sSSP.ExactSSSPAlgorithm(Sourcenode, Destinationnode);
            ////foreach (var item in SSSPApproximateshortestpath)
            ////{
            ////    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            ////}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

            //Approximate SSSP algorrithm from paper

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var SSSPApproximateshortestpath = sSSP.ApproxSSSPAlgorithm(Sourcenode, Destinationnode);
            ////foreach (var item in SSSPApproximateshortestpath)
            ////{
            ////    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            ////}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

            ////Approximate own algorithm new
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //var SSSPApproximateshortestpath = sSSP.ApprpxAprroxSSPAlgorithm(Sourcenode, Destinationnode);
            //foreach (var item in SSSPApproximateshortestpath)
            //{
            //    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //}
            //stopwatch.Stop();
            //var time = stopwatch.Elapsed;
            //int i = 0;

            //Dijikitras algorithm new
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var SSSPApproximateshortestpath = sSSP.DijikitrasAlgorithm(Sourcenode, Destinationnode);
            //foreach (var item in SSSPApproximateshortestpath)
            //{
            //    Graph.Series["ApproximateSSSP"].Points.AddXY(item.Item1.X, item.Item1.Y);


            //}
            stopwatch.Stop();
            var time = stopwatch.Elapsed;
            int i = 0;

            // debugging Section 
            //List<Tuple<int, int>> tokencopies = new List<Tuple<int, int>>();
            //List<Tuple<int, int>> tokencopieswithrespectivenodes = new List<Tuple<int, int>>();
            //tokencopies =tokenDistribution.TokenMultiplication();
            //tokencopieswithrespectivenodes = tokenDistribution.GetNumberofNodeswithTokenCopies(tokencopies);

        }
        private void Graph_Click(object sender, EventArgs e)
        {

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
