using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class testCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);

        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "test@testing.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
              
        }

        [TestMethod]
        public void UserPasswordPropertyOK()
        {   
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "ThisIsAPassword";
            ACustomer.UserPassword = TestData;
            Assert.AreEqual(ACustomer.UserPassword, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void HeightPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            decimal TestData = 175.55m;
            ACustomer.Height = TestData;
            Assert.AreEqual(ACustomer.Height, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerId != 21)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Email != "kk123@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserPasswordFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.UserPassword != "kk123!")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHeightFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Height != Convert.ToDecimal("175.54"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
          
            clsCustomer AnAddress = new clsCustomer();
            
            Boolean Found = false;
            
            Boolean OK = true;
            
            Int32 AddressNo = 21;
            
            Found = AnAddress.Find(AddressNo);
            
            if (AnAddress.DateAdded != Convert.ToDateTime("2/1/2001 12:34:32 PM"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
