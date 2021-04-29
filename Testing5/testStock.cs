using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TestStock
    {
        string BookDescription = "Jungle book, Rudyard Kipling";
        string DateAdded = DateTime.Now.Date.ToString();
        string QuantityAvailable = "22";
        string Price = "4.99";
        Double maxValue = 1000.00;


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
            string TestData = "Jungle book";
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
        public void TestBookIdFound()
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
            if(ABook.DateAdded != Convert.ToDateTime("01/01/2011"))
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
            if (ABook.Description != "TestBook")
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
            if(ABook.Price != 10.01)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //Valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        //Testing BookDescription Validity
        [TestMethod]
        public void BookDescriptionMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "a";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aa";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMaxLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMid()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookdescriptionMaxPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionExtremeMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "";
            BookDescription = BookDescription.PadRight(500, 'a');
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        //Testing Date Added Validity
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedminLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Quantity Available Validity 

        [TestMethod]
        public void QuantityAvailableMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Int32 TestData;
            TestData = 0;
            TestData = TestData - 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Int32 TestData;
            TestData = 0;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Int32 TestData;
            TestData = 0;
            TestData = TestData + 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMaxLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Int32 TestData;
            TestData = 2147483647;
            TestData = TestData - 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Int32 TestData;
            TestData = 2147483647;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMaxPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Int32 TestData;
            TestData = 2147483647;
            TestData = TestData + 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityAvailableMid()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Int32 TestData;
            TestData = Convert.ToInt32(1073741823.5);
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        //Test price validity

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = 0.00 - 1.00;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = 0.01;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = 0.00 + 1.00;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = maxValue - 1.00;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = maxValue;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = maxValue + 1.00;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = maxValue / 2.00;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
            Assert.AreEqual(Error, "");
        }
    }

}


 