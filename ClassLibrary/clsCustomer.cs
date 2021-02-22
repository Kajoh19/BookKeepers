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
        private Decimal mHeight;

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

        public Decimal Height
        {
            get
            {
                return mHeight;
            }
            set
            {
                mHeight = value;
            }
        }

        public bool Find(int CustomerId)
        {
            mCustomerId = 21;
            mDateAdded = Convert.ToDateTime("2/1/2001 12:34:32 PM");
            mEmail = "kk123@gmail.com";
            mUserPassword = "kk123!";
            mHeight = Convert.ToDecimal("175.54");
            mActive = Convert.ToBoolean("true");
            return true;
        }
    }
}