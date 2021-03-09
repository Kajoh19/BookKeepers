using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
        public class tstSupplier
    {
        string Phone = "123456";
        string SupplierName = "Some Name";
        string Cost = "123.12";
        string DateAdded = DateTime.Now.ToString();
             

        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Assert.IsNotNull(ASupplier);
        }

        [TestMethod]
        public void ActiveOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Boolean TestData = true;
            ASupplier.Active = TestData;
            Assert.AreEqual(ASupplier.Active, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            ASupplier.DateAdded = TestData;
            Assert.AreEqual(ASupplier.DateAdded, TestData);
        }

        [TestMethod]
        public void SupplierIdOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            int TestData = 1;
            ASupplier.SupplierId = TestData;
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }
         
        [TestMethod]
        public void CostOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            decimal TestData = 1.00m;
            ASupplier.Cost = TestData;
            Assert.AreEqual(ASupplier.Cost, TestData);
        }

        [TestMethod]
        public void PhoneOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int32 TestData = 123;
            ASupplier.Phone = TestData;
            Assert.AreEqual(ASupplier.Phone, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            Int64 TestData = 1234;
            ASupplier.Quantity = TestData;
            Assert.AreEqual(ASupplier.Quantity, TestData);
        }

        [TestMethod]
        public void SupplierNameOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            string TestData = "Some Name";
            ASupplier.SupplierName = TestData;
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            Error = ASupplier.Valid(Phone, SupplierName, Cost, DateAdded);
            Assert.AreEqual(Error, "");
        }



    }
}
