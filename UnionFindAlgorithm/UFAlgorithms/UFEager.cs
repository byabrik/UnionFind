using System.Linq;

namespace UnionFindAlgorithm.UFAlgorithms
{
    public class UfEager
    {
        /// <summary>
        /// Checks whether two provided points are connected
        /// </summary>
        /// <returns>True if elements are connected</returns>
        public bool Connected(int p, int q)
        {
            if (p >= sites.Length || q >= sites.Length)
                return false;

            return sites[p] == sites[q];
        }

        /// <summary>
        /// Makes a connection between first and second element
        /// </summary>
        public void Union(int p, int q)
        {
            if (p >= sites.Length || q >= sites.Length || Connected(p, q)) return;
            int pid = sites[p];
            int qid = sites[q];

            for (int i = 0; i < sites.Length; i++)
            {
                if (sites[i] == pid) sites[i] = qid;
            }
        }

        public UfEager(int n)
        {
            sites = Enumerable.Range(0, n - 1).ToArray();
        }

        private readonly int[] sites;
    }
}
