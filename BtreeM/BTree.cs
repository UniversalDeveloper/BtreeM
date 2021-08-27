using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtreeM
{
    class BTree
    {
        Node root = new Node();
        pablic int T;

        public BTree(int t)
        {
            T = t;
            root = new Node();
            root.countEl = 0;
            root.leaf = true;

        }
        // search key

        public Node search(Node x, int key)
        {
            int i = 0;
            if (x == null)
                return x;

            for (i = 0; i < x.countEl; i++)
            {
                if (key < x.keyData[i])
                {
                    break;
                }
                if (key == x.keyData[i])
                {
                    return x;
                }
            }

            if (x.leaf)
            {
                return null;
            }
            else
            {
                return search(x.child[i], key);
            }


        }
        public void split(Node x,int pos, Node y)
        {
            Node z = new Node();
            z.leaf = y.leaf;
            z.countEl = 4-1;
            for (int i = 0; i < T-1; i++)
            {
                z.keyData[i] = y.keyData[i + T];
            }
            if (!y.leaf)
            {
                for (int i = 0; i < T; i++)
                {
                    z.child[i] = y.child[i + T];

                }
            }
            y.countEl = T - 1;
            for (int i = x.countEl; i < length; i++)
            {

            }
        }
    }
}
