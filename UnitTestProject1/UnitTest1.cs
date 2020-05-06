using System;
using ChainingAssertion_demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Class1.Add(1, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(InputException))]
        public void 例外のテスト()
        {
            Assert.AreEqual(3, Class1.Add(-1, 2));
        }
    }
}
