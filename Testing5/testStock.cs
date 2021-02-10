using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class testStock
    {
    

        [TestMethod]
        public void InstanceOK()
        {
            clsStock ABook = new clsStock();
            Assert.IsNotNull(ABook);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            clsStock ABook = new clsStock();
            string TestData = "Jungle Book";
            ABook.Description = TestData;
            Assert.IsNotNull(ABook);
            Assert.AreEqual(ABook.Description, TestData);

        }

        [TestMethod]
        public void AvailabilityOK()
        {
            clsStock ABook = new clsStock();
            Boolean TestData = true;
            ABook.Available = TestData;
            Assert.AreEqual(ABook.Available, TestData);

        }

        [TestMethod]
        public void DateOK()
        {
            clsStock ABook = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            ABook.DateAdded = TestData;
            Assert.AreEqual(ABook.DateAdded, TestData);
        }

        [TestMethod]
        public void QuanityAvailableOK()
        {
            clsStock ABook = new clsStock();
            Int32 TestData = 1;
            ABook.Quantity = TestData;
            Assert.AreEqual(ABook.Quantity, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsStock ABook = new clsStock();
            Double TestData = 1.0;
            ABook.Price = TestData;
            Assert.AreEqual(ABook.Price, TestData);
        }

        [TestMethod]
        public void BookIdOK()
        {
            clsStock ABook = new clsStock();
            Int32 TestData = 1;
            ABook.Id = TestData;
            Assert.AreEqual(ABook.Id, TestData);
        }

    }
}
