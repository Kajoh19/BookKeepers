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
            Int32 BookId = 9;
            Found = ABook.Find(bookId: BookId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookIdFound()
        {
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 9;
            Found = ABook.Find(BookId);

            if (ABook.BookId != 9)
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
            Int32 BookId = 9;
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
            Int32 BookId = 9;
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
            Int32 BookId = 9;
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
            clsStock ABook = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BookId = 9;
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
            Int32 BookId = 9;
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
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        //Testing BookDescription Validity
        [TestMethod]
        public void BookDescriptionMinLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMin()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "a";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMinPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMaxLessOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMax()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookDescriptionMid()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookdescriptionMaxPlusOne()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string BookDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookdescriptionExtremeMax()
        {
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }

        //Testing Quantity Available Validity 

        [TestMethod]
        public void QauntityAvailableMinLessOne()
        {
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = 0.00 - 1;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void  PriceMin() 
        {
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
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
            clsStock ABook = new clsStock();
            String Error = "";
            Double TestData;
            TestData = MaxValue/2;
            string Price = TestData.ToString();
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidData()
        {
            clsStock ABook = new clsStock();
            String Error = "";
            string Price = "this is not a price!";
            Error = ABook.Valid(BookDescription, DateAdded, QuantityAvailable, Price);
            Assert.AreNotEqual(Error, "");
        }
    }
}    

 