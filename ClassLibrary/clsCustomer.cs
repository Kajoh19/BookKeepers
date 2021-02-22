using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        private Boolean mActive;
        private DateTime mDateAdded;
        private String mEmail;
        private String mUserPassword;
        private Decimal mBudget;

        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

       public Boolean Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public String Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        public String UserPassword
        {
            get
            {
                return mUserPassword;
            }
            set
            {
                mUserPassword = value;
            }
        }

        public Decimal Budget
        {
            get
            {
                return mBudget;
            }
            set
            {
                mBudget = value;
            }
        }

        public bool Find(int CustomerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mUserPassword = Convert.ToString(DB.DataTable.Rows[0]["UserPassword"]);
                mBudget = Convert.ToDecimal(DB.DataTable.Rows[0]["Budget"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}