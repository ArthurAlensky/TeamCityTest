using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCityTest;

namespace ServiceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var svc = new Service1();
            var res = svc.GetData(1);
            Assert.IsNotNull(res, "res is not null");
        }
    }
}
