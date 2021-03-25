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
            //var for the index
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsStock ABook = new clsStock();

                ABook.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                ABook.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["BookId"]);
                ABook.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ABook.Description = Convert.ToString(DB.DataTable.Rows[Index]["BookDescription"]);
                ABook.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                ABook.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["QuantityAvailable"]);
                //add the record to the private data member
                mStockList.Add(ABook);
                //pint at the next record 
                Index++;
            }
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
    }
}