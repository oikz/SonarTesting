using System;
using System.Threading;
using NUnit.Framework;

namespace TestProject2 {
    [TestFixture]
    public class Tests {
        [Test]
        public void Test1() {
            Thread.Sleep(10000);
            Assert.True(true);
        }
    }
}