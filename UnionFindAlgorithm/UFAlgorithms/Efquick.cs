using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace UnionFindAlgorithm.UFAlgorithms
{
    public class EfQuick
    {
        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        private int Root(int el)
        {
            while (el != ids[el])
            {
                ids[el] = ids[ids[el]];
                el = ids[el];
            }

            return el;
        }

        public void Union(int p, int q)
        {
            if (Connected(p, q))
                return;

            int rootP = Root(p);
            int rootQ = Root(q);
            if (sizes[rootP] > sizes[rootQ])
            {
                ids[rootQ] = rootP;
                sizes[rootP] += sizes[rootQ];
            }
            else
            {
                ids[rootP] = rootQ;
                sizes[rootQ] += sizes[rootP];
            }

        }

        public EfQuick(int n)
        {
            ids = Enumerable.Range(0, n - 1).ToArray();
            sizes = Enumerable.Repeat(0, n).ToArray();
        }

        private readonly int[] ids;
        private readonly int[] sizes;
    }
}
