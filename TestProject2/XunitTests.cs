using System;
using System.Threading;
using Xunit;

namespace XunitTests2 {
    public class Tests {
        [Fact]
        public void Test1() {
            Thread.Sleep(10000);
            Assert.True(true);
        }
    }
}