using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            clssStaff AnStaff = new clssStaff();
            Assert.IsNotNull(AnStaff);
        }
    }
}
