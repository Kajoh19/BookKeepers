using System;
using System.Linq;

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

        public string Valid(string email, string userPassword, string budget, string dateAdded)
        {
            String Error = "";
            DateTime DateTemp;
            Decimal BudgetTemp;
            Decimal MaxValue = 999.99m;
            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (email.Length > 30)
            {
                Error = Error = "The email must be less than 30 characters: ";
            }
            if(userPassword.Length == 0)
            {
                Error = Error + "The password may not be blank : ";
            }
            if (userPassword.Length < 8)
            {
                Error = Error + "The password cannot be less than 8 characters : ";
            }
            if (userPassword.Length >20)
            {
                Error = Error + "The password may not be more than 20 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "Invalid date : ";
            }
            try
            {
                BudgetTemp = Convert.ToDecimal(budget);
                if (BudgetTemp <= 5.00m)
                {
                    Error = Error + "Budget must be higher than five : ";
                }
                if (BudgetTemp > MaxValue)
                {
                    Error = Error + "The budget cannot exceed max value : ";
                }
            }
            catch
            {

                Error = Error + "The price has to be in the range of 5-999.99  : ";
            }
            return Error;
        }
    }
}