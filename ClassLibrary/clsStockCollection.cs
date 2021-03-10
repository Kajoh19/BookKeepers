using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

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
        public clsStock ThisStock { get; set; }
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
    }
}