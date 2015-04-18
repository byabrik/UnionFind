using NUnit.Framework;
using UnionFindAlgorithm.UFAlgorithms;

namespace UnionFindAlgorithm.Tests
{
    public class UfEagerTest
    {
        [Test]
        public void CheckConnected()
        {
            UfEager ufEager = new UfEager(10);
            Assert.IsFalse(ufEager.Connected(0, 1));
            ufEager.Union(0,1);
            Assert.IsTrue(ufEager.Connected(0, 1));
        }

        [Test]
        public void CheckNotConnected()
        {
            UfEager ufEager = new UfEager(10);
            Assert.IsFalse(ufEager.Connected(0, 1));
        }
    }
}
