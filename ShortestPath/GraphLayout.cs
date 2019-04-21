using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class GraphLayout
    {
        IList<Node> Vertices = new List<Node>();

        //public IList<Node> GetGraphLayout()
        //{
        //    Vertices.Add(new Node(5, 10, 1, false));
        //    Vertices.Add(new Node(10, 5, 2,false));
        //    Vertices.Add(new Node(13, 16, 3,false));
        //    Vertices.Add(new Node(15, 11, 4, false));
        //    Vertices.Add(new Node(18, 16, 5, false));
        //    Vertices.Add(new Node(20, 5, 6, false));
        //    Vertices.Add(new Node(25, 8, 7, false));

        //    return Vertices;
        //}

        public IList<Node> GetGraphLayout()
        {
            Vertices.Add(new Node(5, 15, 1, false));
            Vertices.Add(new Node(10, 20, 2, false));
            Vertices.Add(new Node(15, 25, 3, false));
            Vertices.Add(new Node(15, 20, 4, false));
            Vertices.Add(new Node(15, 15, 5, false));
            Vertices.Add(new Node(10, 10, 6, false));
            Vertices.Add(new Node(20, 25, 7, false));
            Vertices.Add(new Node(20, 20, 8, false));
            Vertices.Add(new Node(20, 10, 9, false));
            Vertices.Add(new Node(15, 5, 10, false));
            Vertices.Add(new Node(25, 25, 11, false));
            Vertices.Add(new Node(25, 20, 12, false));
            Vertices.Add(new Node(25, 15, 13, false));
            Vertices.Add(new Node(25, 5, 14, false));
            Vertices.Add(new Node(30, 23, 15, false));
            Vertices.Add(new Node(35, 15, 16, false));
            Vertices.Add(new Node(35, 10, 17, false));
            Vertices.Add(new Node(35, 5, 18, false));
            Vertices.Add(new Node(35, 25, 19, false));
            Vertices.Add(new Node(40, 15, 20, false));

            return Vertices;
        }

    }
}
