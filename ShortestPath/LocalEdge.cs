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

        // 20 Nodes
        //public List<Tuple<Node, Node>> GetGrapgEdges(IList<Node> vertices)
        //{
        //    Vertices = graphLayout.GetGraphLayout();
        //    vertices = Vertices;
        //    if (vertices?.Count != 0)
        //    {
        //        //vertex 1 Edges
        //        AddEdges(vertices[0], vertices[1]);
        //        AddEdges(vertices[0], vertices[5]);

        //        //vertex 3 Edges
        //        AddEdges(vertices[2], vertices[1]);
        //        AddEdges(vertices[2], vertices[6]);

        //        //vertex 4 Edges
        //        AddEdges(vertices[3], vertices[4]);
        //        AddEdges(vertices[3], vertices[1]);

        //        //vertex 6 Edges
        //        AddEdges(vertices[5], vertices[9]);
        //        AddEdges(vertices[5], vertices[4]);


        //        //vertex 5 Edges
        //        AddEdges(vertices[4], vertices[7]);
        //        AddEdges(vertices[4], vertices[8]);
        //        AddEdges(vertices[4], vertices[5]);
        //        AddEdges(vertices[4], vertices[3]);

        //        //vertex 2 Edges
        //        AddEdges(vertices[1], vertices[2]);
        //        AddEdges(vertices[1], vertices[3]);
        //        AddEdges(vertices[1], vertices[0]);

        //        //vertex 7 Edges
        //        AddEdges(vertices[6], vertices[10]);
        //        AddEdges(vertices[6], vertices[7]);
        //        AddEdges(vertices[6], vertices[2]);

        //        //vertex 8 Edges
        //        AddEdges(vertices[7], vertices[11]);
        //        AddEdges(vertices[7], vertices[4]);

        //        //vertex 9 Edeges
        //        AddEdges(vertices[8], vertices[12]);
        //        AddEdges(vertices[8], vertices[13]);
        //        AddEdges(vertices[8], vertices[9]);
        //        AddEdges(vertices[8], vertices[4]);

        //        //Vertex 10 Edges
        //        AddEdges(vertices[9], vertices[13]);
        //        AddEdges(vertices[9], vertices[8]);
        //        AddEdges(vertices[9], vertices[5]);

        //        //Vertex 11 Edges
        //        AddEdges(vertices[10], vertices[18]);
        //        AddEdges(vertices[10], vertices[14]);
        //        AddEdges(vertices[10], vertices[6]);

        //        //Vertex 12 Edges
        //        AddEdges(vertices[11], vertices[14]);
        //        AddEdges(vertices[11], vertices[12]);
        //        AddEdges(vertices[11], vertices[7]);

        //        //Vertex 13 Edges
        //        AddEdges(vertices[12], vertices[8]);

        //        //Vertex 14 Edges
        //        AddEdges(vertices[13], vertices[16]);
        //        AddEdges(vertices[13], vertices[17]);
        //        AddEdges(vertices[13], vertices[8]);
        //        AddEdges(vertices[13], vertices[9]);

        //        //Vertec 15 Edges
        //        AddEdges(vertices[14], vertices[10]);
        //        AddEdges(vertices[14], vertices[11]);
        //        AddEdges(vertices[14], vertices[18]);
        //        AddEdges(vertices[14], vertices[15]);

        //        //Vertex 16 Edges
        //        AddEdges(vertices[15], vertices[19]);
        //        AddEdges(vertices[15], vertices[16]);
        //        AddEdges(vertices[15], vertices[14]);

        //        //Vertex 17 Edges
        //        AddEdges(vertices[16], vertices[17]);
        //        AddEdges(vertices[16], vertices[15]);
        //        AddEdges(vertices[16], vertices[13]);

        //        //Vertex 18 Edges
        //        AddEdges(vertices[17], vertices[19]);
        //        AddEdges(vertices[17], vertices[13]);

        //        //Vertex 19
        //        AddEdges(vertices[18], vertices[10]);
        //        AddEdges(vertices[18], vertices[14]);
        //        AddEdges(vertices[18], vertices[19]);

        //    }
        //    return LocalIncidentEdges;

        //}

        //50 nodes

        //public List<Tuple<Node, Node>> GetGrapgEdges(IList<Node> vertices)
        //{
        //    Vertices = graphLayout.GetGraphLayout();
        //    vertices = Vertices;
        //    if (vertices?.Count != 0)
        //    {
        //        //vertex 1 Edges
        //        AddEdges(vertices[0], vertices[1]);
        //        AddEdges(vertices[0], vertices[2]);
        //        AddEdges(vertices[0], vertices[3]);
        //        AddEdges(vertices[0], vertices[4]);

        //        //vertex 2 Edges
        //        AddEdges(vertices[1], vertices[5]);
        //        AddEdges(vertices[1], vertices[0]);

        //        //vertex 3 Edges
        //        AddEdges(vertices[2], vertices[6]);
        //        AddEdges(vertices[2], vertices[0]);

        //        //vertex 4 Edges
        //        AddEdges(vertices[3], vertices[7]);
        //        AddEdges(vertices[3], vertices[0]);

        //        //vertex 5 Edges
        //        AddEdges(vertices[4], vertices[8]);
        //        AddEdges(vertices[4], vertices[0]);

        //        //vertex 6 Edges
        //        AddEdges(vertices[5], vertices[9]);
        //        AddEdges(vertices[5], vertices[1]);

        //        //vertex 7 Edges
        //        AddEdges(vertices[6], vertices[10]);
        //        AddEdges(vertices[6], vertices[11]);
        //        AddEdges(vertices[6], vertices[2]);

        //        //vertex 8 Edges
        //        AddEdges(vertices[7], vertices[11]);
        //        AddEdges(vertices[7], vertices[3]);

        //        //vertex 9 Edeges
        //        AddEdges(vertices[8], vertices[12]);
        //        AddEdges(vertices[8], vertices[4]);


        //        //Vertex 10 Edges
        //        AddEdges(vertices[9], vertices[13]);
        //        AddEdges(vertices[9], vertices[5]);

        //        //Vertex 11 Edges
        //        AddEdges(vertices[10], vertices[13]);
        //        AddEdges(vertices[10], vertices[14]);
        //        AddEdges(vertices[10], vertices[6]);

        //        //Vertex 12 Edges
        //        AddEdges(vertices[11], vertices[14]);
        //        AddEdges(vertices[11], vertices[7]);

        //        //Vertex 13 Edges
        //        AddEdges(vertices[12], vertices[16]);
        //        AddEdges(vertices[12], vertices[17]);
        //        AddEdges(vertices[12], vertices[8]);

        //        //Vertex 14 Edges
        //        AddEdges(vertices[13], vertices[18]);
        //        AddEdges(vertices[13], vertices[9]);
        //        AddEdges(vertices[13], vertices[10]);

        //        //Vertec 15 Edges
        //        AddEdges(vertices[14], vertices[19]);
        //        AddEdges(vertices[14], vertices[10]);
        //        AddEdges(vertices[14], vertices[11]);

        //        //Vertex 16 Edges
        //        AddEdges(vertices[15], vertices[20]);

        //        //Vertex 17 Edges
        //        AddEdges(vertices[16], vertices[21]);
        //        AddEdges(vertices[16], vertices[17]);
        //        AddEdges(vertices[16], vertices[12]);

        //        //Vertex 18 Edges
        //        AddEdges(vertices[17], vertices[22]);
        //        AddEdges(vertices[17], vertices[21]);
        //        AddEdges(vertices[17], vertices[16]);
        //        AddEdges(vertices[17], vertices[12]);

        //        //Vertex 19
        //        AddEdges(vertices[18], vertices[23]);
        //        AddEdges(vertices[18], vertices[24]);
        //        AddEdges(vertices[18], vertices[13]);

        //        //Vertex20
        //        AddEdges(vertices[19], vertices[24]);
        //        AddEdges(vertices[19], vertices[25]);
        //        AddEdges(vertices[19], vertices[14]);

        //        //Vertex 21
        //        AddEdges(vertices[20], vertices[26]);
        //        AddEdges(vertices[20], vertices[15]);

        //        //Vertex 22
        //        AddEdges(vertices[21], vertices[26]);
        //        AddEdges(vertices[21], vertices[22]);
        //        AddEdges(vertices[21], vertices[16]);
        //        AddEdges(vertices[21], vertices[17]);

        //        //Vertex 23
        //        AddEdges(vertices[22], vertices[27]);
        //        AddEdges(vertices[22], vertices[21]);
        //        AddEdges(vertices[22], vertices[17]);

        //        //Vertex 24
        //        AddEdges(vertices[23], vertices[18]);
        //        AddEdges(vertices[23], vertices[29]);

        //        //Vertex 25
        //        AddEdges(vertices[24], vertices[30]);
        //        AddEdges(vertices[24], vertices[25]);
        //        AddEdges(vertices[24], vertices[19]);
        //        AddEdges(vertices[24], vertices[18]);

        //        //Vertex 26
        //        AddEdges(vertices[25], vertices[31]);
        //        AddEdges(vertices[25], vertices[24]);
        //        AddEdges(vertices[25], vertices[19]);
        //        AddEdges(vertices[25], vertices[26]);

        //        //Vertex 27
        //        AddEdges(vertices[26], vertices[32]);
        //        AddEdges(vertices[26], vertices[20]);
        //        AddEdges(vertices[26], vertices[25]);
        //        AddEdges(vertices[26], vertices[21]);

        //        //Vertex 28
        //        AddEdges(vertices[27], vertices[33]);
        //        AddEdges(vertices[27], vertices[34]);
        //        AddEdges(vertices[27], vertices[28]);
        //        AddEdges(vertices[27], vertices[22]);

        //        //Vertex 29
        //        AddEdges(vertices[28], vertices[27]);

        //        //Vertex 30
        //        AddEdges(vertices[29], vertices[35]);
        //        AddEdges(vertices[29], vertices[23]);

        //        //Vertex 31
        //        AddEdges(vertices[30], vertices[36]);
        //        AddEdges(vertices[30], vertices[24]);

        //        //Vertex 32
        //        AddEdges(vertices[31], vertices[36]);
        //        AddEdges(vertices[31], vertices[37]);
        //        AddEdges(vertices[31], vertices[32]);
        //        AddEdges(vertices[31], vertices[25]);

        //        //Vertex 33
        //        AddEdges(vertices[32], vertices[38]);
        //        AddEdges(vertices[32], vertices[33]);
        //        AddEdges(vertices[32], vertices[31]);
        //        AddEdges(vertices[32], vertices[26]);

        //        //Vertex 34
        //        AddEdges(vertices[33], vertices[32]);
        //        AddEdges(vertices[33], vertices[39]);
        //        AddEdges(vertices[33], vertices[34]);
        //        AddEdges(vertices[33], vertices[27]);

        //        //Vertex 35
        //        AddEdges(vertices[34], vertices[39]);
        //        AddEdges(vertices[34], vertices[33]);

        //        //Vertex 36
        //        AddEdges(vertices[35], vertices[40]);
        //        AddEdges(vertices[35], vertices[29]);

        //        //Vertex 37
        //        AddEdges(vertices[36], vertices[41]);
        //        AddEdges(vertices[36], vertices[42]);
        //        AddEdges(vertices[36], vertices[37]);
        //        AddEdges(vertices[36], vertices[30]);
        //        AddEdges(vertices[36], vertices[31]);

        //        //Vertex 38
        //        AddEdges(vertices[37], vertices[42]);
        //        AddEdges(vertices[37], vertices[31]);
        //        AddEdges(vertices[37], vertices[38]);
        //        AddEdges(vertices[37], vertices[36]);

        //        //Vertex 39
        //        AddEdges(vertices[38], vertices[43]);
        //        AddEdges(vertices[38], vertices[32]);

        //        //Vertex 40 
        //        AddEdges(vertices[39], vertices[44]);
        //        AddEdges(vertices[39], vertices[33]);

        //        //Vertex 41
        //        AddEdges(vertices[40], vertices[35]);
        //        AddEdges(vertices[40], vertices[45]);

        //        //Vertex 42
        //        AddEdges(vertices[41], vertices[45]);
        //        AddEdges(vertices[41], vertices[36]);

        //        //Vertex 43
        //        AddEdges(vertices[42], vertices[46]);
        //        AddEdges(vertices[42], vertices[36]);
        //        AddEdges(vertices[42], vertices[37]);
        //        AddEdges(vertices[42], vertices[43]);

        //        //Vertex 44
        //        AddEdges(vertices[43], vertices[47]);
        //        AddEdges(vertices[43], vertices[42]);
        //        AddEdges(vertices[43], vertices[38]);

        //        //Vertex 45
        //        AddEdges(vertices[44], vertices[48]);
        //        AddEdges(vertices[44], vertices[47]);
        //        AddEdges(vertices[44], vertices[39]);

        //        //Vertex 46
        //        AddEdges(vertices[45], vertices[49]);
        //        AddEdges(vertices[45], vertices[40]);
        //        AddEdges(vertices[45], vertices[41]);

        //        //Vertex 47
        //        AddEdges(vertices[46], vertices[49]);
        //        AddEdges(vertices[46], vertices[42]);

        //        //Vertex 48
        //        AddEdges(vertices[47], vertices[49]);
        //        AddEdges(vertices[47], vertices[43]);
        //        AddEdges(vertices[47], vertices[44]);

        //        //Vertex 49
        //        AddEdges(vertices[48], vertices[49]);
        //        AddEdges(vertices[48], vertices[44]);

        //    }
        //    return LocalIncidentEdges;

        //}

        // 86 Nodes
        public List<Tuple<Node, Node>> GetGrapgEdges(IList<Node> vertices)
        {
            Vertices = graphLayout.GetGraphLayout();
            vertices = Vertices;
            if (vertices?.Count != 0)
            {
                //vertex 1 Edges
                AddEdges(vertices[0], vertices[1]);
                AddEdges(vertices[0], vertices[2]);
                AddEdges(vertices[0], vertices[3]);
                AddEdges(vertices[0], vertices[4]);

                //vertex 2 Edges
                AddEdges(vertices[1], vertices[5]);
                AddEdges(vertices[1], vertices[0]);

                //vertex 3 Edges
                AddEdges(vertices[2], vertices[6]);
                AddEdges(vertices[2], vertices[0]);

                //vertex 4 Edges
                AddEdges(vertices[3], vertices[7]);
                AddEdges(vertices[3], vertices[0]);

                //vertex 5 Edges
                AddEdges(vertices[4], vertices[8]);
                AddEdges(vertices[4], vertices[0]);

                //vertex 6 Edges
                AddEdges(vertices[5], vertices[9]);
                AddEdges(vertices[5], vertices[1]);

                //vertex 7 Edges
                AddEdges(vertices[6], vertices[10]);
                AddEdges(vertices[6], vertices[11]);
                AddEdges(vertices[6], vertices[2]);

                //vertex 8 Edges
                AddEdges(vertices[7], vertices[11]);
                AddEdges(vertices[7], vertices[3]);

                //vertex 9 Edeges
                AddEdges(vertices[8], vertices[12]);
                AddEdges(vertices[8], vertices[4]);


                //Vertex 10 Edges
                AddEdges(vertices[9], vertices[13]);
                AddEdges(vertices[9], vertices[5]);

                //Vertex 11 Edges
                AddEdges(vertices[10], vertices[13]);
                AddEdges(vertices[10], vertices[14]);
                AddEdges(vertices[10], vertices[6]);

                //Vertex 12 Edges
                AddEdges(vertices[11], vertices[14]);
                AddEdges(vertices[11], vertices[7]);

                //Vertex 13 Edges
                AddEdges(vertices[12], vertices[16]);
                AddEdges(vertices[12], vertices[17]);
                AddEdges(vertices[12], vertices[8]);

                //Vertex 14 Edges
                AddEdges(vertices[13], vertices[18]);
                AddEdges(vertices[13], vertices[9]);
                AddEdges(vertices[13], vertices[10]);

                //Vertec 15 Edges
                AddEdges(vertices[14], vertices[19]);
                AddEdges(vertices[14], vertices[10]);
                AddEdges(vertices[14], vertices[11]);

                //Vertex 16 Edges
                AddEdges(vertices[15], vertices[20]);

                //Vertex 17 Edges
                AddEdges(vertices[16], vertices[21]);
                AddEdges(vertices[16], vertices[17]);
                AddEdges(vertices[16], vertices[12]);

                //Vertex 18 Edges
                AddEdges(vertices[17], vertices[22]);
                AddEdges(vertices[17], vertices[21]);
                AddEdges(vertices[17], vertices[16]);
                AddEdges(vertices[17], vertices[12]);

                //Vertex 19
                AddEdges(vertices[18], vertices[23]);
                AddEdges(vertices[18], vertices[24]);
                AddEdges(vertices[18], vertices[13]);

                //Vertex20
                AddEdges(vertices[19], vertices[24]);
                AddEdges(vertices[19], vertices[25]);
                AddEdges(vertices[19], vertices[14]);

                //Vertex 21
                AddEdges(vertices[20], vertices[26]);
                AddEdges(vertices[20], vertices[15]);

                //Vertex 22
                AddEdges(vertices[21], vertices[26]);
                AddEdges(vertices[21], vertices[22]);
                AddEdges(vertices[21], vertices[16]);
                AddEdges(vertices[21], vertices[17]);

                //Vertex 23
                AddEdges(vertices[22], vertices[27]);
                AddEdges(vertices[22], vertices[21]);
                AddEdges(vertices[22], vertices[17]);

                //Vertex 24
                AddEdges(vertices[23], vertices[18]);
                AddEdges(vertices[23], vertices[29]);

                //Vertex 25
                AddEdges(vertices[24], vertices[30]);
                AddEdges(vertices[24], vertices[25]);
                AddEdges(vertices[24], vertices[19]);
                AddEdges(vertices[24], vertices[18]);

                //Vertex 26
                AddEdges(vertices[25], vertices[31]);
                AddEdges(vertices[25], vertices[24]);
                AddEdges(vertices[25], vertices[19]);
                AddEdges(vertices[25], vertices[26]);

                //Vertex 27
                AddEdges(vertices[26], vertices[32]);
                AddEdges(vertices[26], vertices[20]);
                AddEdges(vertices[26], vertices[25]);
                AddEdges(vertices[26], vertices[21]);

                //Vertex 28
                AddEdges(vertices[27], vertices[33]);
                AddEdges(vertices[27], vertices[34]);
                AddEdges(vertices[27], vertices[28]);
                AddEdges(vertices[27], vertices[22]);

                //Vertex 29
                AddEdges(vertices[28], vertices[27]);

                //Vertex 30
                AddEdges(vertices[29], vertices[35]);
                AddEdges(vertices[29], vertices[23]);

                //Vertex 31
                AddEdges(vertices[30], vertices[36]);
                AddEdges(vertices[30], vertices[24]);

                //Vertex 32
                AddEdges(vertices[31], vertices[36]);
                AddEdges(vertices[31], vertices[37]);
                AddEdges(vertices[31], vertices[32]);
                AddEdges(vertices[31], vertices[25]);

                //Vertex 33
                AddEdges(vertices[32], vertices[38]);
                AddEdges(vertices[32], vertices[33]);
                AddEdges(vertices[32], vertices[31]);
                AddEdges(vertices[32], vertices[26]);

                //Vertex 34
                AddEdges(vertices[33], vertices[32]);
                AddEdges(vertices[33], vertices[39]);
                AddEdges(vertices[33], vertices[34]);
                AddEdges(vertices[33], vertices[27]);

                //Vertex 35
                AddEdges(vertices[34], vertices[39]);
                AddEdges(vertices[34], vertices[33]);

                //Vertex 36
                AddEdges(vertices[35], vertices[40]);
                AddEdges(vertices[35], vertices[29]);

                //Vertex 37
                AddEdges(vertices[36], vertices[41]);
                AddEdges(vertices[36], vertices[42]);
                AddEdges(vertices[36], vertices[37]);
                AddEdges(vertices[36], vertices[30]);
                AddEdges(vertices[36], vertices[31]);

                //Vertex 38
                AddEdges(vertices[37], vertices[42]);
                AddEdges(vertices[37], vertices[31]);
                AddEdges(vertices[37], vertices[38]);
                AddEdges(vertices[37], vertices[36]);

                //Vertex 39
                AddEdges(vertices[38], vertices[43]);
                AddEdges(vertices[38], vertices[32]);

                //Vertex 40 
                AddEdges(vertices[39], vertices[44]);
                AddEdges(vertices[39], vertices[33]);


                //Vertex 41
                AddEdges(vertices[40], vertices[35]);
                AddEdges(vertices[40], vertices[45]);
                AddEdges(vertices[40], vertices[50]);

                //Vertex 42
                AddEdges(vertices[41], vertices[45]);
                AddEdges(vertices[41], vertices[36]);

                //Vertex 43
                AddEdges(vertices[42], vertices[46]);
                AddEdges(vertices[42], vertices[36]);
                AddEdges(vertices[42], vertices[37]);
                AddEdges(vertices[42], vertices[43]);

                //Vertex 44
                AddEdges(vertices[43], vertices[47]);
                AddEdges(vertices[43], vertices[42]);
                AddEdges(vertices[43], vertices[38]);

                //Vertex 45
                AddEdges(vertices[44], vertices[48]);
                AddEdges(vertices[44], vertices[47]);
                AddEdges(vertices[44], vertices[39]);


                //Vertex 46
                AddEdges(vertices[45], vertices[49]);
                AddEdges(vertices[45], vertices[40]);
                AddEdges(vertices[45], vertices[41]);
                AddEdges(vertices[45], vertices[50]);


                //Vertex 47
                AddEdges(vertices[46], vertices[49]);
                AddEdges(vertices[46], vertices[42]);

                //Vertex 48
                AddEdges(vertices[47], vertices[49]);
                AddEdges(vertices[47], vertices[43]);
                AddEdges(vertices[47], vertices[44]);

                //Vertex 49
                AddEdges(vertices[48], vertices[49]);
                AddEdges(vertices[48], vertices[44]);
                AddEdges(vertices[48], vertices[51]);

                //Vertex 50
                AddEdges(vertices[49], vertices[45]);
                AddEdges(vertices[49], vertices[46]);
                AddEdges(vertices[49], vertices[47]);
                AddEdges(vertices[49], vertices[48]);
                AddEdges(vertices[49], vertices[50]);
                AddEdges(vertices[49], vertices[51]);
                AddEdges(vertices[49], vertices[53]);
                AddEdges(vertices[49], vertices[54]);

                //Vertex 51
                AddEdges(vertices[50], vertices[40]);
                AddEdges(vertices[50], vertices[45]);
                AddEdges(vertices[50], vertices[49]);
                AddEdges(vertices[50], vertices[52]);

                //Vertex 52
                AddEdges(vertices[51], vertices[49]);
                AddEdges(vertices[51], vertices[48]);
                AddEdges(vertices[51], vertices[54]);
                AddEdges(vertices[51], vertices[56]);

                //Vertex 53
                AddEdges(vertices[52], vertices[57]);
                AddEdges(vertices[52], vertices[58]);
                AddEdges(vertices[52], vertices[50]);

                //Vertex 54
                AddEdges(vertices[53], vertices[58]);
                AddEdges(vertices[53], vertices[49]);

                //Vertex 55
                AddEdges(vertices[54], vertices[55]);
                AddEdges(vertices[54], vertices[49]);
                AddEdges(vertices[54], vertices[51]);

                //Vertex 56
                AddEdges(vertices[55], vertices[54]);
                AddEdges(vertices[55], vertices[60]);

                //Vertex 57
                AddEdges(vertices[56], vertices[60]);
                AddEdges(vertices[56], vertices[61]);
                AddEdges(vertices[56], vertices[51]);

                //Vertex 58
                AddEdges(vertices[57], vertices[52]);
                AddEdges(vertices[57], vertices[62]);

                //Vertex 59
                AddEdges(vertices[58], vertices[52]);
                AddEdges(vertices[58], vertices[53]);
                AddEdges(vertices[58], vertices[59]);
                AddEdges(vertices[58], vertices[63]);

                //Vertex 60
                AddEdges(vertices[59], vertices[58]);
                AddEdges(vertices[59], vertices[64]);
                AddEdges(vertices[59], vertices[60]);

                //Vertex 61
                AddEdges(vertices[60], vertices[59]);
                AddEdges(vertices[60], vertices[55]);
                AddEdges(vertices[60], vertices[56]);
                AddEdges(vertices[60], vertices[65]);

                //Vertex 62
                AddEdges(vertices[61], vertices[65]);
                AddEdges(vertices[61], vertices[56]);

                //Vertex 63
                AddEdges(vertices[62], vertices[57]);
                AddEdges(vertices[62], vertices[63]);
                AddEdges(vertices[62], vertices[67]);
                AddEdges(vertices[62], vertices[68]);

                //Vertex 64
                AddEdges(vertices[63], vertices[58]);
                AddEdges(vertices[63], vertices[69]);
                AddEdges(vertices[63], vertices[64]);
                AddEdges(vertices[63], vertices[62]);

                //Vertex 65
                AddEdges(vertices[64], vertices[59]);
                AddEdges(vertices[64], vertices[63]);
                AddEdges(vertices[64], vertices[70]);
                AddEdges(vertices[64], vertices[65]);

                //Vertex 66
                AddEdges(vertices[65], vertices[60]);
                AddEdges(vertices[65], vertices[61]);
                AddEdges(vertices[65], vertices[64]);
                AddEdges(vertices[65], vertices[70]);
                AddEdges(vertices[65], vertices[71]);

                //vertex 67
                AddEdges(vertices[66], vertices[71]);
                AddEdges(vertices[66], vertices[72]);

                //Vertex 68
                AddEdges(vertices[67], vertices[62]);
                AddEdges(vertices[67], vertices[79]);

                //Vertex 69
                AddEdges(vertices[68], vertices[62]);
                AddEdges(vertices[68], vertices[79]);

                //Vertec 70
                AddEdges(vertices[69], vertices[73]);
                AddEdges(vertices[69], vertices[70]);
                AddEdges(vertices[69], vertices[63]);

                //Vertex 71
                AddEdges(vertices[70], vertices[69]);
                AddEdges(vertices[70], vertices[71]);
                AddEdges(vertices[70], vertices[65]);
                AddEdges(vertices[70], vertices[64]);

                //Vertex 72
                AddEdges(vertices[71], vertices[75]);
                AddEdges(vertices[71], vertices[76]);
                AddEdges(vertices[71], vertices[70]);
                AddEdges(vertices[71], vertices[65]);
                AddEdges(vertices[71], vertices[66]);

                //Vertex 73
                AddEdges(vertices[72], vertices[77]);
                AddEdges(vertices[72], vertices[78]);
                AddEdges(vertices[72], vertices[66]);

                //Vertex 74
                AddEdges(vertices[73], vertices[69]);
                AddEdges(vertices[73], vertices[80]);

                //Vertex 75
                AddEdges(vertices[74], vertices[80]);
                AddEdges(vertices[74], vertices[81]);
                AddEdges(vertices[74], vertices[75]);

                //Vertex 76
                AddEdges(vertices[75], vertices[74]);
                AddEdges(vertices[75], vertices[71]);
                AddEdges(vertices[75], vertices[81]);
                AddEdges(vertices[75], vertices[82]);

                //Vertex 77
                AddEdges(vertices[76], vertices[71]);
                AddEdges(vertices[76], vertices[77]);
                AddEdges(vertices[76], vertices[83]);

                //Vertex 78 
                AddEdges(vertices[77], vertices[76]);
                AddEdges(vertices[77], vertices[72]);
                AddEdges(vertices[77], vertices[78]);
                AddEdges(vertices[77], vertices[84]);

                //Vertec 79
                AddEdges(vertices[78], vertices[77]);
                AddEdges(vertices[78], vertices[72]);
                AddEdges(vertices[78], vertices[84]);

                //Vertex 80
                AddEdges(vertices[79], vertices[67]);
                AddEdges(vertices[79], vertices[68]);
                AddEdges(vertices[79], vertices[85]);

                //Vertex 81
                AddEdges(vertices[80], vertices[73]);
                AddEdges(vertices[80], vertices[74]);
                AddEdges(vertices[80], vertices[85]);

                //Vertex 82
                AddEdges(vertices[81], vertices[74]);
                AddEdges(vertices[81], vertices[75]);
                AddEdges(vertices[81], vertices[85]);

                //Vertex 83
                AddEdges(vertices[82], vertices[85]);
                AddEdges(vertices[82], vertices[85]);

                //Vertex 84
                AddEdges(vertices[83], vertices[76]);
                AddEdges(vertices[83], vertices[84]);
                AddEdges(vertices[83], vertices[85]);

                //Vertex 85
                AddEdges(vertices[84], vertices[83]);
                AddEdges(vertices[84], vertices[77]);
                AddEdges(vertices[84], vertices[78]);



            }
            return LocalIncidentEdges;

        }

        // 122 nodes
        //public List<Tuple<Node, Node>> GetGrapgEdges(IList<Node> vertices)
        //{
        //    Vertices = graphLayout.GetGraphLayout();
        //    vertices = Vertices;
        //    if (vertices?.Count != 0)
        //    {
        //        //vertex 1 Edges
        //        AddEdges(vertices[0], vertices[1]);
        //        AddEdges(vertices[0], vertices[2]);
        //        AddEdges(vertices[0], vertices[3]);
        //        AddEdges(vertices[0], vertices[4]);

        //        //vertex 2 Edges
        //        AddEdges(vertices[1], vertices[5]);
        //        AddEdges(vertices[1], vertices[0]);

        //        //vertex 3 Edges
        //        AddEdges(vertices[2], vertices[6]);
        //        AddEdges(vertices[2], vertices[0]);

        //        //vertex 4 Edges
        //        AddEdges(vertices[3], vertices[7]);
        //        AddEdges(vertices[3], vertices[0]);

        //        //vertex 5 Edges
        //        AddEdges(vertices[4], vertices[8]);
        //        AddEdges(vertices[4], vertices[0]);

        //        //vertex 6 Edges
        //        AddEdges(vertices[5], vertices[9]);
        //        AddEdges(vertices[5], vertices[1]);

        //        //vertex 7 Edges
        //        AddEdges(vertices[6], vertices[10]);
        //        AddEdges(vertices[6], vertices[11]);
        //        AddEdges(vertices[6], vertices[2]);

        //        //vertex 8 Edges
        //        AddEdges(vertices[7], vertices[11]);
        //        AddEdges(vertices[7], vertices[3]);

        //        //vertex 9 Edeges
        //        AddEdges(vertices[8], vertices[12]);
        //        AddEdges(vertices[8], vertices[4]);


        //        //Vertex 10 Edges
        //        AddEdges(vertices[9], vertices[13]);
        //        AddEdges(vertices[9], vertices[5]);

        //        //Vertex 11 Edges
        //        AddEdges(vertices[10], vertices[13]);
        //        AddEdges(vertices[10], vertices[14]);
        //        AddEdges(vertices[10], vertices[6]);

        //        //Vertex 12 Edges
        //        AddEdges(vertices[11], vertices[14]);
        //        AddEdges(vertices[11], vertices[7]);

        //        //Vertex 13 Edges
        //        AddEdges(vertices[12], vertices[16]);
        //        AddEdges(vertices[12], vertices[17]);
        //        AddEdges(vertices[12], vertices[8]);

        //        //Vertex 14 Edges
        //        AddEdges(vertices[13], vertices[18]);
        //        AddEdges(vertices[13], vertices[9]);
        //        AddEdges(vertices[13], vertices[10]);

        //        //Vertec 15 Edges
        //        AddEdges(vertices[14], vertices[19]);
        //        AddEdges(vertices[14], vertices[10]);
        //        AddEdges(vertices[14], vertices[11]);

        //        //Vertex 16 Edges
        //        AddEdges(vertices[15], vertices[20]);

        //        //Vertex 17 Edges
        //        AddEdges(vertices[16], vertices[21]);
        //        AddEdges(vertices[16], vertices[17]);
        //        AddEdges(vertices[16], vertices[12]);

        //        //Vertex 18 Edges
        //        AddEdges(vertices[17], vertices[22]);
        //        AddEdges(vertices[17], vertices[21]);
        //        AddEdges(vertices[17], vertices[16]);
        //        AddEdges(vertices[17], vertices[12]);

        //        //Vertex 19
        //        AddEdges(vertices[18], vertices[23]);
        //        AddEdges(vertices[18], vertices[24]);
        //        AddEdges(vertices[18], vertices[13]);

        //        //Vertex20
        //        AddEdges(vertices[19], vertices[24]);
        //        AddEdges(vertices[19], vertices[25]);
        //        AddEdges(vertices[19], vertices[14]);

        //        //Vertex 21
        //        AddEdges(vertices[20], vertices[26]);
        //        AddEdges(vertices[20], vertices[15]);

        //        //Vertex 22
        //        AddEdges(vertices[21], vertices[26]);
        //        AddEdges(vertices[21], vertices[22]);
        //        AddEdges(vertices[21], vertices[16]);
        //        AddEdges(vertices[21], vertices[17]);

        //        //Vertex 23
        //        AddEdges(vertices[22], vertices[27]);
        //        AddEdges(vertices[22], vertices[21]);
        //        AddEdges(vertices[22], vertices[17]);

        //        //Vertex 24
        //        AddEdges(vertices[23], vertices[18]);
        //        AddEdges(vertices[23], vertices[29]);

        //        //Vertex 25
        //        AddEdges(vertices[24], vertices[30]);
        //        AddEdges(vertices[24], vertices[25]);
        //        AddEdges(vertices[24], vertices[19]);
        //        AddEdges(vertices[24], vertices[18]);

        //        //Vertex 26
        //        AddEdges(vertices[25], vertices[31]);
        //        AddEdges(vertices[25], vertices[24]);
        //        AddEdges(vertices[25], vertices[19]);
        //        AddEdges(vertices[25], vertices[26]);

        //        //Vertex 27
        //        AddEdges(vertices[26], vertices[32]);
        //        AddEdges(vertices[26], vertices[20]);
        //        AddEdges(vertices[26], vertices[25]);
        //        AddEdges(vertices[26], vertices[21]);

        //        //Vertex 28
        //        AddEdges(vertices[27], vertices[33]);
        //        AddEdges(vertices[27], vertices[34]);
        //        AddEdges(vertices[27], vertices[28]);
        //        AddEdges(vertices[27], vertices[22]);

        //        //Vertex 29
        //        AddEdges(vertices[28], vertices[27]);

        //        //Vertex 30
        //        AddEdges(vertices[29], vertices[35]);
        //        AddEdges(vertices[29], vertices[23]);

        //        //Vertex 31
        //        AddEdges(vertices[30], vertices[36]);
        //        AddEdges(vertices[30], vertices[24]);

        //        //Vertex 32
        //        AddEdges(vertices[31], vertices[36]);
        //        AddEdges(vertices[31], vertices[37]);
        //        AddEdges(vertices[31], vertices[32]);
        //        AddEdges(vertices[31], vertices[25]);

        //        //Vertex 33
        //        AddEdges(vertices[32], vertices[38]);
        //        AddEdges(vertices[32], vertices[33]);
        //        AddEdges(vertices[32], vertices[31]);
        //        AddEdges(vertices[32], vertices[26]);

        //        //Vertex 34
        //        AddEdges(vertices[33], vertices[32]);
        //        AddEdges(vertices[33], vertices[39]);
        //        AddEdges(vertices[33], vertices[34]);
        //        AddEdges(vertices[33], vertices[27]);

        //        //Vertex 35
        //        AddEdges(vertices[34], vertices[39]);
        //        AddEdges(vertices[34], vertices[33]);

        //        //Vertex 36
        //        AddEdges(vertices[35], vertices[40]);
        //        AddEdges(vertices[35], vertices[29]);

        //        //Vertex 37
        //        AddEdges(vertices[36], vertices[41]);
        //        AddEdges(vertices[36], vertices[42]);
        //        AddEdges(vertices[36], vertices[37]);
        //        AddEdges(vertices[36], vertices[30]);
        //        AddEdges(vertices[36], vertices[31]);

        //        //Vertex 38
        //        AddEdges(vertices[37], vertices[42]);
        //        AddEdges(vertices[37], vertices[31]);
        //        AddEdges(vertices[37], vertices[38]);
        //        AddEdges(vertices[37], vertices[36]);

        //        //Vertex 39
        //        AddEdges(vertices[38], vertices[43]);
        //        AddEdges(vertices[38], vertices[32]);

        //        //Vertex 40 
        //        AddEdges(vertices[39], vertices[44]);
        //        AddEdges(vertices[39], vertices[33]);


        //        //Vertex 41
        //        AddEdges(vertices[40], vertices[35]);
        //        AddEdges(vertices[40], vertices[45]);
        //        AddEdges(vertices[40], vertices[50]);

        //        //Vertex 42
        //        AddEdges(vertices[41], vertices[45]);
        //        AddEdges(vertices[41], vertices[36]);

        //        //Vertex 43
        //        AddEdges(vertices[42], vertices[46]);
        //        AddEdges(vertices[42], vertices[36]);
        //        AddEdges(vertices[42], vertices[37]);
        //        AddEdges(vertices[42], vertices[43]);

        //        //Vertex 44
        //        AddEdges(vertices[43], vertices[47]);
        //        AddEdges(vertices[43], vertices[42]);
        //        AddEdges(vertices[43], vertices[38]);

        //        //Vertex 45
        //        AddEdges(vertices[44], vertices[48]);
        //        AddEdges(vertices[44], vertices[47]);
        //        AddEdges(vertices[44], vertices[39]);


        //        //Vertex 46
        //        AddEdges(vertices[45], vertices[49]);
        //        AddEdges(vertices[45], vertices[40]);
        //        AddEdges(vertices[45], vertices[41]);
        //        AddEdges(vertices[45], vertices[50]);


        //        //Vertex 47
        //        AddEdges(vertices[46], vertices[49]);
        //        AddEdges(vertices[46], vertices[42]);

        //        //Vertex 48
        //        AddEdges(vertices[47], vertices[49]);
        //        AddEdges(vertices[47], vertices[43]);
        //        AddEdges(vertices[47], vertices[44]);

        //        //Vertex 49
        //        AddEdges(vertices[48], vertices[49]);
        //        AddEdges(vertices[48], vertices[44]);
        //        AddEdges(vertices[48], vertices[51]);

        //        //Vertex 50
        //        AddEdges(vertices[49], vertices[45]);
        //        AddEdges(vertices[49], vertices[46]);
        //        AddEdges(vertices[49], vertices[47]);
        //        AddEdges(vertices[49], vertices[48]);
        //        AddEdges(vertices[49], vertices[50]);
        //        AddEdges(vertices[49], vertices[51]);
        //        AddEdges(vertices[49], vertices[53]);
        //        AddEdges(vertices[49], vertices[54]);

        //        //Vertex 51
        //        AddEdges(vertices[50], vertices[40]);
        //        AddEdges(vertices[50], vertices[45]);
        //        AddEdges(vertices[50], vertices[49]);
        //        AddEdges(vertices[50], vertices[52]);

        //        //Vertex 52
        //        AddEdges(vertices[51], vertices[49]);
        //        AddEdges(vertices[51], vertices[48]);
        //        AddEdges(vertices[51], vertices[54]);
        //        AddEdges(vertices[51], vertices[56]);

        //        //Vertex 53
        //        AddEdges(vertices[52], vertices[57]);
        //        AddEdges(vertices[52], vertices[58]);
        //        AddEdges(vertices[52], vertices[50]);

        //        //Vertex 54
        //        AddEdges(vertices[53], vertices[58]);
        //        AddEdges(vertices[53], vertices[49]);

        //        //Vertex 55
        //        AddEdges(vertices[54], vertices[55]);
        //        AddEdges(vertices[54], vertices[49]);
        //        AddEdges(vertices[54], vertices[51]);

        //        //Vertex 56
        //        AddEdges(vertices[55], vertices[54]);
        //        AddEdges(vertices[55], vertices[60]);

        //        //Vertex 57
        //        AddEdges(vertices[56], vertices[60]);
        //        AddEdges(vertices[56], vertices[61]);
        //        AddEdges(vertices[56], vertices[51]);

        //        //Vertex 58
        //        AddEdges(vertices[57], vertices[52]);
        //        AddEdges(vertices[57], vertices[62]);

        //        //Vertex 59
        //        AddEdges(vertices[58], vertices[52]);
        //        AddEdges(vertices[58], vertices[53]);
        //        AddEdges(vertices[58], vertices[59]);
        //        AddEdges(vertices[58], vertices[63]);

        //        //Vertex 60
        //        AddEdges(vertices[59], vertices[58]);
        //        AddEdges(vertices[59], vertices[64]);
        //        AddEdges(vertices[59], vertices[60]);

        //        //Vertex 61
        //        AddEdges(vertices[60], vertices[59]);
        //        AddEdges(vertices[60], vertices[55]);
        //        AddEdges(vertices[60], vertices[56]);
        //        AddEdges(vertices[60], vertices[65]);

        //        //Vertex 62
        //        AddEdges(vertices[61], vertices[65]);
        //        AddEdges(vertices[61], vertices[56]);

        //        //Vertex 63
        //        AddEdges(vertices[62], vertices[57]);
        //        AddEdges(vertices[62], vertices[63]);
        //        AddEdges(vertices[62], vertices[67]);
        //        AddEdges(vertices[62], vertices[68]);

        //        //Vertex 64
        //        AddEdges(vertices[63], vertices[58]);
        //        AddEdges(vertices[63], vertices[69]);
        //        AddEdges(vertices[63], vertices[64]);
        //        AddEdges(vertices[63], vertices[62]);

        //        //Vertex 65
        //        AddEdges(vertices[64], vertices[59]);
        //        AddEdges(vertices[64], vertices[63]);
        //        AddEdges(vertices[64], vertices[70]);
        //        AddEdges(vertices[64], vertices[65]);

        //        //Vertex 66
        //        AddEdges(vertices[65], vertices[60]);
        //        AddEdges(vertices[65], vertices[61]);
        //        AddEdges(vertices[65], vertices[64]);
        //        AddEdges(vertices[65], vertices[70]);
        //        AddEdges(vertices[65], vertices[71]);

        //        //vertex 67
        //        AddEdges(vertices[66], vertices[71]);
        //        AddEdges(vertices[66], vertices[72]);

        //        //Vertex 68
        //        AddEdges(vertices[67], vertices[62]);
        //        AddEdges(vertices[67], vertices[79]);

        //        //Vertex 69
        //        AddEdges(vertices[68], vertices[62]);
        //        AddEdges(vertices[68], vertices[79]);

        //        //Vertec 70
        //        AddEdges(vertices[69], vertices[73]);
        //        AddEdges(vertices[69], vertices[70]);
        //        AddEdges(vertices[69], vertices[63]);

        //        //Vertex 71
        //        AddEdges(vertices[70], vertices[69]);
        //        AddEdges(vertices[70], vertices[71]);
        //        AddEdges(vertices[70], vertices[65]);
        //        AddEdges(vertices[70], vertices[64]);

        //        //Vertex 72
        //        AddEdges(vertices[71], vertices[75]);
        //        AddEdges(vertices[71], vertices[76]);
        //        AddEdges(vertices[71], vertices[70]);
        //        AddEdges(vertices[71], vertices[65]);
        //        AddEdges(vertices[71], vertices[66]);

        //        //Vertex 73
        //        AddEdges(vertices[72], vertices[77]);
        //        AddEdges(vertices[72], vertices[78]);
        //        AddEdges(vertices[72], vertices[66]);

        //        //Vertex 74
        //        AddEdges(vertices[73], vertices[69]);
        //        AddEdges(vertices[73], vertices[80]);

        //        //Vertex 75
        //        AddEdges(vertices[74], vertices[80]);
        //        AddEdges(vertices[74], vertices[81]);
        //        AddEdges(vertices[74], vertices[75]);

        //        //Vertex 76
        //        AddEdges(vertices[75], vertices[74]);
        //        AddEdges(vertices[75], vertices[71]);
        //        AddEdges(vertices[75], vertices[81]);
        //        AddEdges(vertices[75], vertices[82]);

        //        //Vertex 77
        //        AddEdges(vertices[76], vertices[71]);
        //        AddEdges(vertices[76], vertices[77]);
        //        AddEdges(vertices[76], vertices[83]);

        //        //Vertex 78 
        //        AddEdges(vertices[77], vertices[76]);
        //        AddEdges(vertices[77], vertices[72]);
        //        AddEdges(vertices[77], vertices[78]);
        //        AddEdges(vertices[77], vertices[84]);

        //        //Vertec 79
        //        AddEdges(vertices[78], vertices[77]);
        //        AddEdges(vertices[78], vertices[72]);
        //        AddEdges(vertices[78], vertices[84]);
        //        AddEdges(vertices[78], vertices[87]);

        //        //Vertex 80
        //        AddEdges(vertices[79], vertices[67]);
        //        AddEdges(vertices[79], vertices[68]);
        //        AddEdges(vertices[79], vertices[85]);
        //        AddEdges(vertices[79], vertices[86]);

        //        //Vertex 81
        //        AddEdges(vertices[80], vertices[73]);
        //        AddEdges(vertices[80], vertices[74]);
        //        AddEdges(vertices[80], vertices[85]);

        //        //Vertex 82
        //        AddEdges(vertices[81], vertices[74]);
        //        AddEdges(vertices[81], vertices[75]);
        //        AddEdges(vertices[81], vertices[85]);

        //        //Vertex 83
        //        AddEdges(vertices[82], vertices[85]);
        //        AddEdges(vertices[82], vertices[85]);

        //        //Vertex 84
        //        AddEdges(vertices[83], vertices[76]);
        //        AddEdges(vertices[83], vertices[84]);
        //        AddEdges(vertices[83], vertices[85]);

        //        //Vertex 85
        //        AddEdges(vertices[84], vertices[83]);
        //        AddEdges(vertices[84], vertices[77]);
        //        AddEdges(vertices[84], vertices[78]);

        //        //Vertex 86
        //        AddEdges(vertices[85], vertices[79]);
        //        AddEdges(vertices[85], vertices[80]);
        //        AddEdges(vertices[85], vertices[81]);
        //        AddEdges(vertices[85], vertices[82]);
        //        AddEdges(vertices[85], vertices[83]);
        //        AddEdges(vertices[85], vertices[90]);
        //        AddEdges(vertices[85], vertices[91]);

        //        //Vertex 87
        //        AddEdges(vertices[86], vertices[79]);
        //        AddEdges(vertices[86], vertices[88]);
        //        AddEdges(vertices[86], vertices[89]);

        //        //Vertex 88
        //        AddEdges(vertices[87], vertices[92]);
        //        AddEdges(vertices[87], vertices[92]);
        //        AddEdges(vertices[87], vertices[78]);

        //        //Vertex 89
        //        AddEdges(vertices[88], vertices[86]);
        //        AddEdges(vertices[88], vertices[94]);
        //        AddEdges(vertices[88], vertices[95]);

        //        //Vertex 90
        //        AddEdges(vertices[89], vertices[86]);
        //        AddEdges(vertices[89], vertices[95]);
        //        AddEdges(vertices[89], vertices[96]);

        //        //Vertex 91
        //        AddEdges(vertices[90], vertices[85]);
        //        AddEdges(vertices[90], vertices[96]);
        //        AddEdges(vertices[90], vertices[97]);

        //        //Vertex 92
        //        AddEdges(vertices[91], vertices[85]);
        //        AddEdges(vertices[91], vertices[97]);
        //        AddEdges(vertices[91], vertices[98]);

        //        //Vertex 93
        //        AddEdges(vertices[92], vertices[98]);
        //        AddEdges(vertices[92], vertices[87]);

        //        //Vertex 94
        //        AddEdges(vertices[93], vertices[98]);
        //        AddEdges(vertices[93], vertices[99]);
        //        AddEdges(vertices[93], vertices[87]);

        //        //Vertex 95
        //        AddEdges(vertices[94], vertices[106]);
        //        AddEdges(vertices[94], vertices[88]);

        //        //Vertex 96
        //        AddEdges(vertices[95], vertices[100]);
        //        AddEdges(vertices[95], vertices[88]);
        //        AddEdges(vertices[95], vertices[89]);

        //        //Vertex 97
        //        AddEdges(vertices[96], vertices[89]);
        //        AddEdges(vertices[96], vertices[90]);
        //        AddEdges(vertices[96], vertices[101]);

        //        //Vertex 98
        //        AddEdges(vertices[97], vertices[102]);
        //        AddEdges(vertices[97], vertices[90]);
        //        AddEdges(vertices[97], vertices[91]);

        //        //Vertex 99
        //        AddEdges(vertices[98], vertices[103]);
        //        AddEdges(vertices[98], vertices[91]);
        //        AddEdges(vertices[98], vertices[92]);
        //        AddEdges(vertices[98], vertices[93]);

        //        //Vertex 100
        //        AddEdges(vertices[99], vertices[93]);
        //        AddEdges(vertices[99], vertices[105]);

        //        //Vertex 101
        //        AddEdges(vertices[100], vertices[107]);
        //        AddEdges(vertices[100], vertices[95]);

        //        //Vertex 102
        //        AddEdges(vertices[101], vertices[108]);
        //        AddEdges(vertices[101], vertices[96]);

        //        //Vertex 103
        //        AddEdges(vertices[102], vertices[108]);
        //        AddEdges(vertices[102], vertices[97]);

        //        //Vertex 104
        //        AddEdges(vertices[103], vertices[98]);
        //        AddEdges(vertices[103], vertices[104]);
        //        AddEdges(vertices[103], vertices[108]);

        //        //Vertex 105
        //        AddEdges(vertices[104], vertices[109]);
        //        AddEdges(vertices[104], vertices[110]);
        //        AddEdges(vertices[104], vertices[103]);

        //        //Vertex 106
        //        AddEdges(vertices[105], vertices[111]);
        //        AddEdges(vertices[105], vertices[94]);

        //        //Vertex 107
        //        AddEdges(vertices[106], vertices[112]);
        //        AddEdges(vertices[106], vertices[94]);

        //        //Vertex 108
        //        AddEdges(vertices[107], vertices[112]);
        //        AddEdges(vertices[107], vertices[113]);
        //        AddEdges(vertices[107], vertices[100]);

        //        //Vertex 109
        //        AddEdges(vertices[108], vertices[114]);
        //        AddEdges(vertices[108], vertices[115]);
        //        AddEdges(vertices[108], vertices[101]);
        //        AddEdges(vertices[108], vertices[102]);
        //        AddEdges(vertices[108], vertices[103]);

        //        //Vertex 110
        //        AddEdges(vertices[109], vertices[115]);
        //        AddEdges(vertices[109], vertices[104]);

        //        //Vertex 111
        //        AddEdges(vertices[110], vertices[104]);
        //        AddEdges(vertices[110], vertices[116]);

        //        //Vertex 112
        //        AddEdges(vertices[111], vertices[115]);
        //        AddEdges(vertices[111], vertices[116]);
        //        AddEdges(vertices[111], vertices[105]);

        //        //Vertex 113
        //        AddEdges(vertices[112], vertices[117]);
        //        AddEdges(vertices[112], vertices[118]);
        //        AddEdges(vertices[112], vertices[106]);
        //        AddEdges(vertices[112], vertices[107]);

        //        //Vertex 114
        //        AddEdges(vertices[113], vertices[118]);
        //        AddEdges(vertices[113], vertices[119]);
        //        AddEdges(vertices[113], vertices[107]);

        //        //Vertex 115
        //        AddEdges(vertices[114], vertices[119]);
        //        AddEdges(vertices[114], vertices[108]);

        //        //Vertex 116
        //        AddEdges(vertices[115], vertices[119]);
        //        AddEdges(vertices[115], vertices[108]);
        //        AddEdges(vertices[115], vertices[109]);
        //        AddEdges(vertices[115], vertices[111]);

        //        //Vertex 117
        //        AddEdges(vertices[116], vertices[120]);
        //        AddEdges(vertices[116], vertices[110]);
        //        AddEdges(vertices[116], vertices[111]);

        //        //Vertex 118
        //        AddEdges(vertices[117], vertices[121]);
        //        AddEdges(vertices[117], vertices[118]);
        //        AddEdges(vertices[117], vertices[112]);

        //        //Vertex 119
        //        AddEdges(vertices[118], vertices[117]);
        //        AddEdges(vertices[118], vertices[112]);
        //        AddEdges(vertices[118], vertices[113]);

        //        //Vertex 120
        //        AddEdges(vertices[119], vertices[121]);
        //        AddEdges(vertices[119], vertices[114]);
        //        AddEdges(vertices[119], vertices[113]);
        //        AddEdges(vertices[119], vertices[115]);

        //        //Vertex 121
        //        AddEdges(vertices[120], vertices[121]);
        //        AddEdges(vertices[120], vertices[116]);




        //    }
        //    return LocalIncidentEdges;

        //}
        public List<Tuple<Node, Node>> AddEdges(Node vertex1, Node vertex2)
        {
            LocalIncidentEdges.Add(Tuple.Create(vertex1, vertex2));
            return LocalIncidentEdges;
        }
    }
}
