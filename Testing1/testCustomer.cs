using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class testCustomer
    {
            string Email = "someemail@gmail.com";
            string UserPassword = "mypassword123";
            string Budget = " 150.32";
            string DateAdded = DateTime.Now.Date.ToString();
        

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);

        }

        [TestMethod]
        public void AddressListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.Email = "jk123@gmail.com";
            TestItem.UserPassword = "JohnK123!";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Budget = 150.50m;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllAddresses.AddressList, TestList);
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
        public void BudgetPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            decimal TestData = 175.55m;
            ACustomer.Budget = TestData;
            Assert.AreEqual(ACustomer.Budget, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(Email, UserPassword, Budget, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.CustomerId != 1)
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
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Email != "jk123@gmail.com")
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
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.UserPassword != "jk123!")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBudgetFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Budget != Convert.ToDecimal("175.50"))
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
            Int32 CustomerId = 1;
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
            
            Int32 AddressNo = 1;
            
            Found = AnAddress.Find(AddressNo);
            
            if (AnAddress.DateAdded != Convert.ToDateTime("22/02/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
