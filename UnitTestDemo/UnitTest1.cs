using Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Practice")]
        [TestMethod]
        public void TestMethod1()
        {
            var dog = new Dog();
            var response = dog.Bark(1);
            Assert.AreEqual(1, response.Count);
        }

        [TestMethod]
        [Ignore]
        public void TestMethod2()
        {
            var dog = new Dog();
            var response = dog.Bark(1);
            Assert.AreEqual(1, response.Count);
        }


        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void Test_Add(int a, int b, int expected)
        {
            var actual = a + b;
            Assert.AreEqual(expected, actual);
        }
    }
}
