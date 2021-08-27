using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtreeM
{
    class Node
    {
        int size;// input size of length data in node
        public int countEl;// order of the tree n
        public int[] keyData;
        public Node[] child;
        public bool leaf;

        public Node()
        {
            size = 4;
            keyData = new int[size];
            child = new Node[size + 1];
            leaf = true;
        }

        public int find(int k)
        {
            for (int i = 0; i < this.countEl; i++)
            {
                if (this.keyData[i] == k)
                    return i;
            }
            return -1;

        }





    }
}
