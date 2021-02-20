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
            ClsStock ABook = new ClsStock();
            Assert.IsNotNull(ABook);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            ClsStock ABook = new ClsStock();
            string TestData = "Jungle book";
            ABook.Description = TestData;
            Assert.IsNotNull(ABook);
            Assert.AreEqual(ABook.Description, TestData);

        }

        [TestMethod]
        public void AvailabilityOK()
        {
            ClsStock ABook = new ClsStock();
            Boolean TestData = true;
            ABook.Available = TestData;
            Assert.AreEqual(ABook.Available, TestData);

        }

        [TestMethod]
        public void DateOK()
        {
            ClsStock ABook = new ClsStock();
            DateTime TestData = DateTime.Now.Date;
            ABook.DateAdded = TestData;
            Assert.AreEqual(ABook.DateAdded, TestData);
        }

        [TestMethod]
        public void QuanityAvailableOK()
        {
            ClsStock ABook = new ClsStock();
            Int32 TestData = 1;
            ABook.Quantity = TestData;
            Assert.AreEqual(ABook.Quantity, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            ClsStock ABook = new ClsStock();
            Double TestData = 1.0;
            ABook.Price = TestData;
            Assert.AreEqual(ABook.Price, TestData);
        }

        [TestMethod]
        public void BookIdOK()
        {
            ClsStock ABook = new ClsStock();
            Int32 TestData = 1;
            ABook.BookId = TestData;
            Assert.AreEqual(ABook.BookId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            ClsStock ABook = new ClsStock();
            Boolean Found = false;
            Int32 BookId = 21;
            Found = ABook.Find(bookId: BookId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            ClsStock ABook = new ClsStock();
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
            ClsStock ABook = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if(ABook.DateAdded != Convert.ToDateTime("01/01/2011"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            ClsStock ABook = new ClsStock();
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
            ClsStock ABook = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if (ABook.Description != "Test Book")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuanityAvailableFound()
        {
            ClsStock ABook = new ClsStock();
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
            ClsStock ABook = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 21;
            Found = ABook.Find(BookId);
            if(ABook.Price != 10.01)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

       
    }
}    

 