using System.Linq;

namespace UnionFindAlgorithm.UFAlgorithms
{
    public class UfQuick
    {
        /// <summary>
        /// Checks whether two provided points are connected
        /// </summary>
        /// <returns>True if elements are connected</returns>
        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        /// <summary>
        /// Makes a connection between first and second element
        /// </summary>
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

        public UfQuick(int n)
        {
            ids = Enumerable.Range(0, n - 1).ToArray();
            sizes = Enumerable.Repeat(0, n).ToArray();
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

        private readonly int[] ids;
        private readonly int[] sizes;
    }
}
