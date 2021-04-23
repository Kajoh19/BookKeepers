using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);

        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data 
                return mThisCustomer;
            }
            set
            {
                //set the private data 
                mThisCustomer = value;
            }


        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set { }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@UserPassword", mThisCustomer.UserPassword);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Budget", mThisCustomer.Budget);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblCustomer_Insert");


        }

        public void Delete()
        {
            //declare the record pointed to by thisCustomer 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {

            //update an existing record on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@UserPassword", mThisCustomer.UserPassword);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Budget", mThisCustomer.Budget);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByEmail(string Email)
        {
            //filters the record based on a full or partial Email
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the email parameter to the database 
            DB.AddParameter("@Email", Email);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByEmail");
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
            mCustomerList = new List<clsCustomer>();
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.UserPassword = Convert.ToString(DB.DataTable.Rows[Index]["UserPassword"]);
                ACustomer.Budget = Convert.ToDecimal(DB.DataTable.Rows[Index]["Budget"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                //add the records to the private data memeber 
                mCustomerList.Add(ACustomer);
                //point at the next record 
                Index++;

            }
        }
    }
}
