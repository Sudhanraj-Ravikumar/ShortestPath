using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            tokenDistribution.DitributeToken(Edges);
            tokenDistribution.DistributeTokenusingGlobalEdge();
            //tokenDistribution.LocalBroadcast(Edges,nodes[0]);

            APSP aPSP = new APSP();
            var ExactApspshortestpath = aPSP.ExactAPSP(nodes[9],nodes[nodes.Count-1]);
            Graph.Series["ExactAPSP"].Points.AddXY(nodes[nodes.Count - 3].X, nodes[nodes.Count - 3].Y);
            foreach (var item in ExactApspshortestpath)
            {
                Graph.Series["ExactAPSP"].Points.AddXY(item.Item1.X, item.Item1.Y);
                Graph.Series["ExactAPSP"].Points.AddXY(item.Item2.X, item.Item2.Y);

            }
            foreach (var item in Edges)
            {
                Graph.Series["Edges"].Points.AddXY(item.Item1.X, item.Item1.Y);
                Graph.Series["Edges"].Points.AddXY(item.Item2.X, item.Item2.Y);
            }


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
