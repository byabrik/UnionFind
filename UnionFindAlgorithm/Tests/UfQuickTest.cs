using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnionFindAlgorithm.UFAlgorithms;

namespace UnionFindAlgorithm.Tests
{
    public class UfQuickTest
    {
        [Test]
        public void CheckConnected()
        {
            UfQuick ufQuick = new UfQuick(10);
            Assert.IsFalse(ufQuick.Connected(0, 1));
            ufQuick.Union(0, 1);
            Assert.IsTrue(ufQuick.Connected(0, 1));
        }

        [Test]
        public void CheckNotConnected()
        {
            UfQuick ufQuick = new UfQuick(10);
            Assert.IsFalse(ufQuick.Connected(0, 1));
        }
    }
}
