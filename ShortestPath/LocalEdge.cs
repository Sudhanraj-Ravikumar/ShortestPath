using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class LocalEdge : IEdge
    {
        IList<Node> Vertices = new List<Node>();
        GraphLayout graphLayout = new GraphLayout();
        List<Tuple<Node, Node>> LocalIncidentEdges = new List<Tuple<Node, Node>>();


        //public List<Tuple<Node, Node>> GetGrapgEdges(IList<Node> vertices)
        //{
        //    Vertices = graphLayout.GetGraphLayout();
        //    vertices = Vertices;
        //    if (vertices?.Count != 0)
        //    {
        //        //vertex 1 Edges
        //        AddEdges(vertices[0], vertices[1]);
        //        AddEdges(vertices[0], vertices[2]);

        //        //vertex 3 Edges
        //        AddEdges(vertices[2], vertices[3]);
        //        AddEdges(vertices[2], vertices[0]);

        //        //vertex 4 Edges
        //        AddEdges(vertices[3], vertices[2]);
        //        AddEdges(vertices[3], vertices[5]);
        //        AddEdges(vertices[3], vertices[1]);

        //        //vertex 6 Edges
        //        AddEdges(vertices[5], vertices[6]);
        //        AddEdges(vertices[5], vertices[4]);
        //        AddEdges(vertices[5], vertices[3]);


        //        //vertex 5 Edges
        //        AddEdges(vertices[4], vertices[6]);
        //        AddEdges(vertices[4], vertices[5]);
        //        AddEdges(vertices[4], vertices[2]);


        //        //vertex 2 Edges
        //        AddEdges(vertices[1], vertices[3]);
        //        AddEdges(vertices[1], vertices[5]);
        //        AddEdges(vertices[1], vertices[0]);

        //        //vertex 7 Edges
        //        AddEdges(vertices[6], vertices[4]);
        //        AddEdges(vertices[6], vertices[5]);

        //    }
        //    return LocalIncidentEdges;

        //}
        public List<Tuple<Node, Node>> GetGrapgEdges(IList<Node> vertices)
        {
            Vertices = graphLayout.GetGraphLayout();
            vertices = Vertices;
            if (vertices?.Count != 0)
            {
                //vertex 1 Edges
                AddEdges(vertices[0], vertices[1]);
                AddEdges(vertices[0], vertices[5]);

                //vertex 3 Edges
                AddEdges(vertices[2], vertices[1]);
                AddEdges(vertices[2], vertices[6]);

                //vertex 4 Edges
                AddEdges(vertices[3], vertices[4]);
                AddEdges(vertices[3], vertices[1]);

                //vertex 6 Edges
                AddEdges(vertices[5], vertices[9]);
                AddEdges(vertices[5], vertices[4]);


                //vertex 5 Edges
                AddEdges(vertices[4], vertices[7]);
                AddEdges(vertices[4], vertices[8]);
                AddEdges(vertices[4], vertices[5]);
                AddEdges(vertices[4], vertices[3]);

                //vertex 2 Edges
                AddEdges(vertices[1], vertices[2]);
                AddEdges(vertices[1], vertices[3]);
                AddEdges(vertices[1], vertices[0]);

                //vertex 7 Edges
                AddEdges(vertices[6], vertices[10]);
                AddEdges(vertices[6], vertices[7]);
                AddEdges(vertices[6], vertices[2]);

                //vertex 8 Edges
                AddEdges(vertices[7], vertices[11]);
                AddEdges(vertices[7], vertices[4]);

                //vertex 9 Edeges
                AddEdges(vertices[8], vertices[12]);
                AddEdges(vertices[8], vertices[13]);
                AddEdges(vertices[8], vertices[9]);
                AddEdges(vertices[8], vertices[4]);

                //Vertex 10 Edges
                AddEdges(vertices[9], vertices[13]);
                AddEdges(vertices[9], vertices[8]);
                AddEdges(vertices[9], vertices[5]);

                //Vertex 11 Edges
                AddEdges(vertices[10], vertices[18]);
                AddEdges(vertices[10], vertices[14]);
                AddEdges(vertices[10], vertices[6]);

                //Vertex 12 Edges
                AddEdges(vertices[11], vertices[14]);
                AddEdges(vertices[11], vertices[12]);
                AddEdges(vertices[11], vertices[7]);

                //Vertex 13 Edges
                AddEdges(vertices[12], vertices[8]);

                //Vertex 14 Edges
                AddEdges(vertices[13], vertices[16]);
                AddEdges(vertices[13], vertices[17]);
                AddEdges(vertices[13], vertices[8]);
                AddEdges(vertices[13], vertices[9]);

                //Vertec 15 Edges
                AddEdges(vertices[14], vertices[10]);
                AddEdges(vertices[14], vertices[11]);
                AddEdges(vertices[14], vertices[18]);
                AddEdges(vertices[14], vertices[15]);

                //Vertex 16 Edges
                AddEdges(vertices[15], vertices[19]);
                AddEdges(vertices[15], vertices[16]);
                AddEdges(vertices[15], vertices[14]);

                //Vertex 17 Edges
                AddEdges(vertices[16], vertices[17]);
                AddEdges(vertices[16], vertices[15]);
                AddEdges(vertices[16], vertices[13]);

                //Vertex 18 Edges
                AddEdges(vertices[17], vertices[19]);
                AddEdges(vertices[17], vertices[13]);

                //Vertex 19
                AddEdges(vertices[18], vertices[10]);
                AddEdges(vertices[18], vertices[14]);
                AddEdges(vertices[18], vertices[19]);

            }
            return LocalIncidentEdges;

        }
        public List<Tuple<Node, Node>> AddEdges(Node vertex1, Node vertex2)
        {
            LocalIncidentEdges.Add(Tuple.Create(vertex1, vertex2));
            return LocalIncidentEdges;
        }
    }
}
