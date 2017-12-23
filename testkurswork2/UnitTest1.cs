using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kurswork2;

namespace testkurswork2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPut()
        {
            int s= Program.Put(2, 1);

            Assert.AreEqual<int>(2, s);
        }
    }
}
