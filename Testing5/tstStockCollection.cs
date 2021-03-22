using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            //created new instance of class
            Assert.IsNotNull(AllStock);

        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            //create new test data to assign to the property
            //data needs to be a list of ojects
            List<clsStock> TestList = new List<clsStock>();
            //add items to the list 
            //create the items of test data
            clsStock TestItem = new clsStock();
            //set its properties 
            TestItem.Available = true;
            TestItem.BookId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Description = "Matilda, Roald Dahl";
            TestItem.Price = 8.99;
            TestItem.Quantity = 40;
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            //created new instance of class
            //create test data and assign to property
            clsStock TestStock = new clsStock();
            TestStock.Available = true;
            TestStock.BookId = 1;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Description = "Matilda, Roald Dahl";
            TestStock.Price = 8.99;
            TestStock.Quantity = 40;
            AllStock.ThisStock = TestStock;
            //test to see that two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create new instance of class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects 
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list 
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //set its properties 
            TestItem.Available = true;
            TestItem.BookId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Description = "Matilda, Roald Dahl";
            TestItem.Price = 8.99;
            TestItem.Quantity = 40;
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Available = true;
            TestItem.BookId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Description = "Mr and Mrs Twit, Roald Dahl";
            TestItem.Price = 8.99;
            TestItem.Quantity = 30;
            //set this stock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.BookId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStock.ThisStock, TestItem);
            //assign the data to the property
        }
    }
}