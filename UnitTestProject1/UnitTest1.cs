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
            //Assert.AreEqual(3, Class1.Add(1, 2));
            Class1.Add(1, 2).Is(3);

            var ex = AssertEx.Throws<InputException>(() => Class1.Add(-1, 2));
            //Assert.AreEqual("マイナス値は入力できません", ex.Message);
            ex.Message.Is("マイナス値は入力できません");
        }

        //[TestMethod]
        //[ExpectedException(typeof(InputException))]
        //public void 例外のテスト()
        //{
        //    Assert.AreEqual(3, Class1.Add(-1, 2));
        //}
    }
}
