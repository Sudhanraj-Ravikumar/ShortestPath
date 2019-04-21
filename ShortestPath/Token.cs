using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class Token
    {
        private int sourceid;
        private int destinationid;
        private int distance;
        private int tokenid;
        private List<Tuple<Node, Node, int, int>> tokenmessage = new List<Tuple<Node, Node, int, int>>();
        public Token(int sourceid, int destinationid, int distance, int tokenid)
        {
            this.sourceid = sourceid;
            this.destinationid = destinationid;
            this.distance = distance;
            this.tokenid = tokenid;
            
        }
        public Token(int sourceid, List<Tuple<Node, Node, int, int>> tokenmessage)
        {
            this.sourceid = sourceid;
            this.tokenmessage = tokenmessage;
            this.tokenid = tokenid;

        }
        public int SourceID
        {
            get => sourceid;
            set => sourceid = value;
        }
        public int DestinationID
        {
            get => destinationid;
            set => destinationid = value;
        }

        public int Distance
        {
            get => distance;
            set => distance = value;
        }

        public int TokenID
        {
            get => tokenid;
            set => tokenid = value;
        }

        public List<Tuple<Node, Node, int, int>> TokenMessage
        {
            get => tokenmessage;
            set => tokenmessage = value;
        }

    }
}
