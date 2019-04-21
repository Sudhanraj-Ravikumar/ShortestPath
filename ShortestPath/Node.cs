using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class Node
    {
        private int x;
        private int y;
        private int id;
        private bool isToken;
        public Node(int x, int y, int id, bool isToken)
        {
            this.x = x;
            this.y = y;
            this.id = id;
            this.isToken = isToken;

        }


        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
        public int ID
        {
            get => id;
            set => id = value;
        }
        public bool IsToken
        {
            get => isToken;
            set => isToken = value;
        }

    }
}
