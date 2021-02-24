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
        Double MaxValue = 1000.00;


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
            Found = ABook.Find(BookId);
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
            if (ABook.Description != "TestBook")
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

        //Valid method
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        //Testing BookDescription Validity
        [TestMethod]
        public void BookDescriptionMinLessOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMin()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "a";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMinPlusOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "aa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMaxLessOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMax()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMid()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookdescriptionMaxPlusOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookdescriptionExtremeMax()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string BookDescription = "";
            BookDescription = BookDescription.PadRight(500, 'a');
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        //Testing Date Added Validity
        [TestMethod]
        public void DateAdddedExtremeMin()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddYears(-100);
            string DataAdded = TestData.ToString();
            Error = ABook.Valid(BookDescription, DataAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAdddedminLessOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddDays(-1);
            string DataAdded = TestData.ToString();
            Error = ABook.Valid(BookDescription, DataAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAdddedMin()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            string DataAdded = TestData.ToString();
            Error = ABook.Valid(BookDescription, DataAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAdddedMinPlusOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddDays(1);
            string DataAdded = TestData.ToString();
            Error = ABook.Valid(BookDescription, DataAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAdddedExtremeMax()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            DateTime TestData;
            TestData = DateTime.Now.Date;
            TestData = TestData.AddYears(100);
            string DataAdded = TestData.ToString();
            Error = ABook.Valid(BookDescription, DataAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAdddedInvalidData()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Quantity Available Validity 

        [TestMethod]
        public void QauntityAvailableMinLessOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Int32 TestData;
            TestData = 0;
            TestData = TestData - 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QauntityAvailableMin()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Int32 TestData;
            TestData = 0;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QauntityAvailableMinPlusOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Int32 TestData;
            TestData = 0;
            TestData = TestData + 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QauntityAvailableMaxLessOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Int32 TestData;
            TestData = 2147483647;
            TestData = TestData - 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QauntityAvailableMax()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Int32 TestData;
            TestData = 2147483647;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QauntityAvailableMaxPlusOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Int32 TestData;
            TestData = 2147483647;
            TestData = TestData + 1;
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QauntityAvailableMid()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Int32 TestData;
            TestData = Convert.ToInt32(1073741823.5);
            string QuantityAvailable = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        //Test price validity

        [TestMethod]
        public void PriceMinLessOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Double TestData;
            TestData = 0.00 - 1;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Double TestData;
            TestData = 0.01;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Double TestData;
            TestData = 0.00 + 1;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Double TestData;
            TestData = MaxValue - 1;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Double TestData;
            TestData = MaxValue;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Double TestData;
            TestData = MaxValue + 1;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            Double TestData;
            TestData = MaxValue / 2;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidData()
        {
            ClsStock ABook = new ClsStock();
            String Error = "";
            string Price = "this is not a price!";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
    }

}


 