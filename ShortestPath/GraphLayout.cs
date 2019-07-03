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
        //    Vertices.Add(new Node(10, 5, 2, false));
        //    Vertices.Add(new Node(13, 16, 3, false));
        //    Vertices.Add(new Node(15, 11, 4, false));
        //    Vertices.Add(new Node(18, 16, 5, false));
        //    Vertices.Add(new Node(20, 5, 6, false));
        //    Vertices.Add(new Node(25, 8, 7, false));

        //    return Vertices;
        //}

        //public IList<Node> GetGraphLayout()
        //{
        //    Vertices.Add(new Node(5, 15, 1, false));
        //    Vertices.Add(new Node(10, 20, 2, false));
        //    Vertices.Add(new Node(15, 25, 3, false));
        //    Vertices.Add(new Node(15, 20, 4, false));
        //    Vertices.Add(new Node(15, 15, 5, false));
        //    Vertices.Add(new Node(10, 10, 6, false));
        //    Vertices.Add(new Node(20, 25, 7, false));
        //    Vertices.Add(new Node(20, 20, 8, false));
        //    Vertices.Add(new Node(20, 10, 9, false));
        //    Vertices.Add(new Node(15, 5, 10, false));
        //    Vertices.Add(new Node(25, 25, 11, false));
        //    Vertices.Add(new Node(25, 20, 12, false));
        //    Vertices.Add(new Node(25, 15, 13, false));
        //    Vertices.Add(new Node(25, 5, 14, false));
        //    Vertices.Add(new Node(30, 23, 15, false));
        //    Vertices.Add(new Node(35, 15, 16, false));
        //    Vertices.Add(new Node(35, 10, 17, false));
        //    Vertices.Add(new Node(35, 5, 18, false));
        //    Vertices.Add(new Node(35, 25, 19, false));
        //    Vertices.Add(new Node(40, 15, 20, false));

        //    return Vertices;
        //}

        // 50 Nodes
        //public IList<Node> GetGraphLayout()
        //{
        //    Vertices.Add(new Node(5, 25, 1, false));
        //    Vertices.Add(new Node(10, 30, 2, false));
        //    Vertices.Add(new Node(10, 25, 3, false));
        //    Vertices.Add(new Node(10, 20, 4, false));
        //    Vertices.Add(new Node(10, 15, 5, false));
        //    Vertices.Add(new Node(15, 30, 6, false));
        //    Vertices.Add(new Node(15, 25, 7, false));
        //    Vertices.Add(new Node(15, 20, 8, false));
        //    Vertices.Add(new Node(15, 15, 9, false));
        //    Vertices.Add(new Node(20, 30, 10, false));
        //    Vertices.Add(new Node(20, 25, 11, false));
        //    Vertices.Add(new Node(20, 20, 12, false));
        //    Vertices.Add(new Node(20, 15, 13, false));
        //    Vertices.Add(new Node(25, 30, 14, false));
        //    Vertices.Add(new Node(25, 25, 15, false));
        //    Vertices.Add(new Node(25, 20, 16, false));
        //    Vertices.Add(new Node(25, 15, 17, false));
        //    Vertices.Add(new Node(25, 10, 18, false));
        //    Vertices.Add(new Node(30, 30, 19, false));
        //    Vertices.Add(new Node(30, 25, 20, false));
        //    Vertices.Add(new Node(30, 20, 21, false));
        //    Vertices.Add(new Node(30, 15, 22, false));
        //    Vertices.Add(new Node(30, 10, 23, false));
        //    Vertices.Add(new Node(35, 35, 24, false));
        //    Vertices.Add(new Node(35, 30, 25, false));
        //    Vertices.Add(new Node(35, 25, 26, false));
        //    Vertices.Add(new Node(35, 20, 27, false));
        //    Vertices.Add(new Node(35, 15, 28, false));
        //    Vertices.Add(new Node(35, 10, 29, false));
        //    Vertices.Add(new Node(40, 35, 30, false));
        //    Vertices.Add(new Node(40, 30, 31, false));
        //    Vertices.Add(new Node(40, 25, 32, false));
        //    Vertices.Add(new Node(40, 20, 33, false));
        //    Vertices.Add(new Node(40, 15, 34, false));
        //    Vertices.Add(new Node(40, 10, 35, false));
        //    Vertices.Add(new Node(45, 35, 36, false));
        //    Vertices.Add(new Node(45, 30, 37, false));
        //    Vertices.Add(new Node(45, 25, 38, false));
        //    Vertices.Add(new Node(45, 20, 39, false));
        //    Vertices.Add(new Node(45, 15, 40, false));
        //    Vertices.Add(new Node(50, 35, 41, false));
        //    Vertices.Add(new Node(50, 30, 42, false));
        //    Vertices.Add(new Node(50, 25, 43, false));
        //    Vertices.Add(new Node(50, 20, 44, false));
        //    Vertices.Add(new Node(50, 15, 45, false));
        //    Vertices.Add(new Node(55, 30, 46, false));
        //    Vertices.Add(new Node(55, 25, 47, false));
        //    Vertices.Add(new Node(55, 20, 48, false));
        //    Vertices.Add(new Node(55, 15, 49, false));
        //    Vertices.Add(new Node(60, 25, 50, false)); //sink


        //    return Vertices;
        //}

        // 86 Nodes

        public IList<Node> GetGraphLayout()
        {
            Vertices.Add(new Node(5, 25, 1, false));
            Vertices.Add(new Node(10, 30, 2, false));
            Vertices.Add(new Node(10, 25, 3, false));
            Vertices.Add(new Node(10, 20, 4, false));
            Vertices.Add(new Node(10, 15, 5, false));
            Vertices.Add(new Node(15, 30, 6, false));
            Vertices.Add(new Node(15, 25, 7, false));
            Vertices.Add(new Node(15, 20, 8, false));
            Vertices.Add(new Node(15, 15, 9, false));
            Vertices.Add(new Node(20, 30, 10, false));
            Vertices.Add(new Node(20, 25, 11, false));
            Vertices.Add(new Node(20, 20, 12, false));
            Vertices.Add(new Node(20, 15, 13, false));
            Vertices.Add(new Node(25, 30, 14, false));
            Vertices.Add(new Node(25, 25, 15, false));
            Vertices.Add(new Node(25, 20, 16, false));
            Vertices.Add(new Node(25, 15, 17, false));
            Vertices.Add(new Node(25, 10, 18, false));
            Vertices.Add(new Node(30, 30, 19, false));
            Vertices.Add(new Node(30, 25, 20, false));
            Vertices.Add(new Node(30, 20, 21, false));
            Vertices.Add(new Node(30, 15, 22, false));
            Vertices.Add(new Node(30, 10, 23, false));
            Vertices.Add(new Node(35, 35, 24, false));
            Vertices.Add(new Node(35, 30, 25, false));
            Vertices.Add(new Node(35, 25, 26, false));
            Vertices.Add(new Node(35, 20, 27, false));
            Vertices.Add(new Node(35, 15, 28, false));
            Vertices.Add(new Node(35, 10, 29, false));
            Vertices.Add(new Node(40, 35, 30, false));
            Vertices.Add(new Node(40, 30, 31, false));
            Vertices.Add(new Node(40, 25, 32, false));
            Vertices.Add(new Node(40, 20, 33, false));
            Vertices.Add(new Node(40, 15, 34, false));
            Vertices.Add(new Node(40, 10, 35, false));
            Vertices.Add(new Node(45, 35, 36, false));
            Vertices.Add(new Node(45, 30, 37, false));
            Vertices.Add(new Node(45, 25, 38, false));
            Vertices.Add(new Node(45, 20, 39, false));
            Vertices.Add(new Node(45, 15, 40, false));
            Vertices.Add(new Node(50, 35, 41, false));
            Vertices.Add(new Node(50, 30, 42, false));
            Vertices.Add(new Node(50, 25, 43, false));
            Vertices.Add(new Node(50, 20, 44, false));
            Vertices.Add(new Node(50, 15, 45, false));
            Vertices.Add(new Node(55, 30, 46, false));
            Vertices.Add(new Node(55, 25, 47, false));
            Vertices.Add(new Node(55, 20, 48, false));
            Vertices.Add(new Node(55, 15, 49, false));
            Vertices.Add(new Node(60, 25, 50, false));
            Vertices.Add(new Node(60, 35, 51, false));
            Vertices.Add(new Node(60, 35, 52, false));
            Vertices.Add(new Node(65, 30, 53, false));
            Vertices.Add(new Node(65, 25, 54, false));
            Vertices.Add(new Node(65, 20, 55, false));
            Vertices.Add(new Node(65, 15, 56, false));
            Vertices.Add(new Node(65, 10, 57, false));
            Vertices.Add(new Node(70, 40, 58, false));
            Vertices.Add(new Node(70, 35, 59, false));
            Vertices.Add(new Node(70, 30, 60, false));
            Vertices.Add(new Node(70, 25, 61, false));
            Vertices.Add(new Node(70, 20, 62, false));
            Vertices.Add(new Node(75, 35, 63, false));
            Vertices.Add(new Node(75, 30, 64, false));
            Vertices.Add(new Node(75, 25, 65, false));
            Vertices.Add(new Node(75, 20, 66, false));
            Vertices.Add(new Node(75, 15, 67, false));
            Vertices.Add(new Node(80, 40, 68, false));
            Vertices.Add(new Node(80, 35, 69, false));
            Vertices.Add(new Node(80, 30, 70, false));
            Vertices.Add(new Node(80, 25, 71, false));
            Vertices.Add(new Node(80, 20, 72, false));
            Vertices.Add(new Node(80, 15, 73, false));
            Vertices.Add(new Node(85, 35, 74, false));
            Vertices.Add(new Node(85, 30, 75, false));
            Vertices.Add(new Node(85, 25, 76, false));
            Vertices.Add(new Node(85, 20, 77, false));
            Vertices.Add(new Node(85, 15, 78, false));
            Vertices.Add(new Node(85, 10, 79, false));
            Vertices.Add(new Node(90, 40, 80, false));
            Vertices.Add(new Node(90, 35, 81, false));
            Vertices.Add(new Node(90, 30, 82, false));
            Vertices.Add(new Node(90, 25, 83, false));
            Vertices.Add(new Node(90, 20, 84, false));
            Vertices.Add(new Node(90, 15, 85, false));
            Vertices.Add(new Node(95, 25, 86, false));


            return Vertices;
        }

        // 122 Nodes

        //public IList<Node> GetGraphLayout()
        //{
        //    Vertices.Add(new Node(5, 25, 1, false));
        //    Vertices.Add(new Node(10, 30, 2, false));
        //    Vertices.Add(new Node(10, 25, 3, false));
        //    Vertices.Add(new Node(10, 20, 4, false));
        //    Vertices.Add(new Node(10, 15, 5, false));
        //    Vertices.Add(new Node(15, 30, 6, false));
        //    Vertices.Add(new Node(15, 25, 7, false));
        //    Vertices.Add(new Node(15, 20, 8, false));
        //    Vertices.Add(new Node(15, 15, 9, false));
        //    Vertices.Add(new Node(20, 30, 10, false));
        //    Vertices.Add(new Node(20, 25, 11, false));
        //    Vertices.Add(new Node(20, 20, 12, false));
        //    Vertices.Add(new Node(20, 15, 13, false));
        //    Vertices.Add(new Node(25, 30, 14, false));
        //    Vertices.Add(new Node(25, 25, 15, false));
        //    Vertices.Add(new Node(25, 20, 16, false));
        //    Vertices.Add(new Node(25, 15, 17, false));
        //    Vertices.Add(new Node(25, 10, 18, false));
        //    Vertices.Add(new Node(30, 30, 19, false));
        //    Vertices.Add(new Node(30, 25, 20, false));
        //    Vertices.Add(new Node(30, 20, 21, false));
        //    Vertices.Add(new Node(30, 15, 22, false));
        //    Vertices.Add(new Node(30, 10, 23, false));
        //    Vertices.Add(new Node(35, 35, 24, false));
        //    Vertices.Add(new Node(35, 30, 25, false));
        //    Vertices.Add(new Node(35, 25, 26, false));
        //    Vertices.Add(new Node(35, 20, 27, false));
        //    Vertices.Add(new Node(35, 15, 28, false));
        //    Vertices.Add(new Node(35, 10, 29, false));
        //    Vertices.Add(new Node(40, 35, 30, false));
        //    Vertices.Add(new Node(40, 30, 31, false));
        //    Vertices.Add(new Node(40, 25, 32, false));
        //    Vertices.Add(new Node(40, 20, 33, false));
        //    Vertices.Add(new Node(40, 15, 34, false));
        //    Vertices.Add(new Node(40, 10, 35, false));
        //    Vertices.Add(new Node(45, 35, 36, false));
        //    Vertices.Add(new Node(45, 30, 37, false));
        //    Vertices.Add(new Node(45, 25, 38, false));
        //    Vertices.Add(new Node(45, 20, 39, false));
        //    Vertices.Add(new Node(45, 15, 40, false));
        //    Vertices.Add(new Node(50, 35, 41, false));
        //    Vertices.Add(new Node(50, 30, 42, false));
        //    Vertices.Add(new Node(50, 25, 43, false));
        //    Vertices.Add(new Node(50, 20, 44, false));
        //    Vertices.Add(new Node(50, 15, 45, false));
        //    Vertices.Add(new Node(55, 30, 46, false));
        //    Vertices.Add(new Node(55, 25, 47, false));
        //    Vertices.Add(new Node(55, 20, 48, false));
        //    Vertices.Add(new Node(55, 15, 49, false));
        //    Vertices.Add(new Node(60, 25, 50, false));
        //    Vertices.Add(new Node(60, 35, 51, false));
        //    Vertices.Add(new Node(60, 35, 52, false));
        //    Vertices.Add(new Node(65, 30, 53, false));
        //    Vertices.Add(new Node(65, 25, 54, false));
        //    Vertices.Add(new Node(65, 20, 55, false));
        //    Vertices.Add(new Node(65, 15, 56, false));
        //    Vertices.Add(new Node(65, 10, 57, false));
        //    Vertices.Add(new Node(70, 40, 58, false));
        //    Vertices.Add(new Node(70, 35, 59, false));
        //    Vertices.Add(new Node(70, 30, 60, false));
        //    Vertices.Add(new Node(70, 25, 61, false));
        //    Vertices.Add(new Node(70, 20, 62, false));
        //    Vertices.Add(new Node(75, 35, 63, false));
        //    Vertices.Add(new Node(75, 30, 64, false));
        //    Vertices.Add(new Node(75, 25, 65, false));
        //    Vertices.Add(new Node(75, 20, 66, false));
        //    Vertices.Add(new Node(75, 15, 67, false));
        //    Vertices.Add(new Node(80, 40, 68, false));
        //    Vertices.Add(new Node(80, 35, 69, false));
        //    Vertices.Add(new Node(80, 30, 70, false));
        //    Vertices.Add(new Node(80, 25, 71, false));
        //    Vertices.Add(new Node(80, 20, 72, false));
        //    Vertices.Add(new Node(80, 15, 73, false));
        //    Vertices.Add(new Node(85, 35, 74, false));
        //    Vertices.Add(new Node(85, 30, 75, false));
        //    Vertices.Add(new Node(85, 25, 76, false));
        //    Vertices.Add(new Node(85, 20, 77, false));
        //    Vertices.Add(new Node(85, 15, 78, false));
        //    Vertices.Add(new Node(85, 10, 79, false));
        //    Vertices.Add(new Node(90, 40, 80, false));
        //    Vertices.Add(new Node(90, 35, 81, false));
        //    Vertices.Add(new Node(90, 30, 82, false));
        //    Vertices.Add(new Node(90, 25, 83, false));
        //    Vertices.Add(new Node(90, 20, 84, false));
        //    Vertices.Add(new Node(90, 15, 85, false));
        //    Vertices.Add(new Node(95, 25, 86, false));
        //    Vertices.Add(new Node(95, 40, 87, false));
        //    Vertices.Add(new Node(95, 15, 88, false));
        //    Vertices.Add(new Node(100, 40, 89, false));
        //    Vertices.Add(new Node(100, 35, 90, false));
        //    Vertices.Add(new Node(100, 30, 91, false));
        //    Vertices.Add(new Node(100, 25, 92, false));
        //    Vertices.Add(new Node(100, 15, 93, false));
        //    Vertices.Add(new Node(100, 10, 94, false));
        //    Vertices.Add(new Node(105, 40, 95, false));
        //    Vertices.Add(new Node(105, 35, 96, false));
        //    Vertices.Add(new Node(105, 30, 97, false));
        //    Vertices.Add(new Node(105, 25, 98, false));
        //    Vertices.Add(new Node(105, 20, 99, false));
        //    Vertices.Add(new Node(105, 15, 100, false));
        //    Vertices.Add(new Node(110, 40, 101, false));
        //    Vertices.Add(new Node(110, 35, 102, false));
        //    Vertices.Add(new Node(110, 30, 103, false));
        //    Vertices.Add(new Node(110, 25, 104, false));
        //    Vertices.Add(new Node(110, 20, 105, false));
        //    Vertices.Add(new Node(110, 15, 106, false));
        //    Vertices.Add(new Node(115, 40, 107, false));
        //    Vertices.Add(new Node(115, 35, 108, false));
        //    Vertices.Add(new Node(115, 20, 109, false));
        //    Vertices.Add(new Node(115, 15, 110, false));
        //    Vertices.Add(new Node(115, 10, 111, false));
        //    Vertices.Add(new Node(115, 5, 112, false));
        //    Vertices.Add(new Node(120, 40, 113, false));
        //    Vertices.Add(new Node(120, 35, 114, false));
        //    Vertices.Add(new Node(120, 30, 115, false));
        //    Vertices.Add(new Node(120, 20, 116, false));
        //    Vertices.Add(new Node(120, 10, 117, false));
        //    Vertices.Add(new Node(125, 40, 118, false));
        //    Vertices.Add(new Node(125, 20, 119, false));
        //    Vertices.Add(new Node(125, 10, 120, false));
        //    Vertices.Add(new Node(125, 5, 121, false));
        //    Vertices.Add(new Node(130, 25, 122, false));


        //    return Vertices;
        //}


    }
}
