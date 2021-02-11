using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TestStock
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
            ABook.BookId = TestData;
            Assert.AreEqual(ABook.BookId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookId()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);

            if (ABook.BookId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
       
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if(ABook.DateAdded != Convert.ToDateTime("16/09/2010"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if (ABook.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestBookDescriptionFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if (ABook.Description != "Jungle Book")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuanityAvailableFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if(ABook.Quantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod] 
        public void TestPriceFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if(ABook.Price != 1.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }    
}
