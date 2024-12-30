using System;
using System.Threading;
using NUnit.Framework;

namespace NunitParallel {
    [TestFixture]
    public class Tests {
        [Test]
        public void Test1() {
            Thread.Sleep(10000);
            Assert.True(true);
        }
        
        [Test]
        public void Test12() {
            Assert.True(true);
        }
        
        [Test]
        public void Test13() {
            Assert.True(true);
        }
        
        [Test]
        public void Test14() {
            Assert.True(true);
        }
        
        [Test]
        public void Test15() {
            Assert.True(true);
        }
        
        [Test]
        public void Test16() {
            Assert.True(true);
        }
        
        [Test]
        public void Test17() {
            Assert.True(true);
        }
        
        [Test]
        public void Test18() {
            Assert.True(true);
        }
        
        [Test]
        public void Test19() {
            Assert.True(true);
        }
        
        [Test]
        public void Test111() {
            Assert.True(true);
        }
        
        [Test]
        public void Test112() {
            Assert.True(true);
        }
    }
}