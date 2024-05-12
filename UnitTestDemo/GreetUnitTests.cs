using Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestDemo
{
    [TestClass]
    public class GreetUnitTests
    {

        private GreetForTest _greet;

        [TestInitialize]
        public void SetUp()
        {
            _greet = new GreetForTest();
        }

        [TestMethod]
        public void today_is_newyear()
        {
            GivenToday(1, 1);
            ResponseShouldBe("Happy New Year");
        }


        [TestMethod]
        public void today_is_not_newyear()
        {
            GivenToday(1, 2);
            ResponseShouldBe("Today is not New Year");
        }

        private void ResponseShouldBe(string expected)
        {
            Assert.AreEqual(expected, _greet.SayHello());
        }

        private void GivenToday(int month, int day)
        {
            _greet.Today = new DateTime(2020, month, day);
        }
    }


    public class GreetForTest : Greet
    {
        private DateTime _today;

        public DateTime Today
        {
            set => _today = value;
        }

        protected override DateTime GetToday()
        {
            return _today;
        }
    }
}
