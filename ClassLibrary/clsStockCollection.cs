using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data memeber thisStock
        clsStock mThisStock = new clsStock();

        //constructor for the class
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
          
        }

        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public clsStock ThisStock
        {
                get
            {
                //return the private data 
                return mThisStock;
            }
                set
            {
                //set the private data 
                mThisStock = value;
            }
        }
        public int Count {
            get
            {
                //return the count of the list
                return mStockList.Count;
            } 
            set
            {
                //
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisStock
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@BookDescription", mThisStock.Description);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@QuantityAvailable", mThisStock.Quantity);
            DB.AddParameter("@Available", mThisStock.Available);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblStock_Insert");


        }

        public void Delete()
        {
            //declare the record pointed to by thisStock 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@BookId", mThisStock.BookId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {

            //update an existing record on the values of thiStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookDescription", mThisStock.Description);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@QuantityAvailable", mThisStock.Quantity);
            DB.AddParameter("@Available", mThisStock.Available);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_Update");
        }

        public void ReportByBookDescription(string BookDescription)
        {
            //filters the record based on a full or partial Book Descritpion
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the book description parameter to the database 
            DB.AddParameter("@BookDescription", BookDescription);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_FilterByBookDescription");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records 
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process 
            while (Index <RecordCount)
            {
                //create a book item
                clsStock ABook = new clsStock();
                //read in the fields from the current record
                ABook.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                ABook.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                ABook.Description = Convert.ToString(DB.DataTable.Rows[Index]["BookDescription"]);
                ABook.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityAvailable"]);
                ABook.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the records to the private data memeber 
                mStockList.Add(ABook);
                //point at the next record 
                Index++;

            }
        }
    }
}