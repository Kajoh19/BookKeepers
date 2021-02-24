using System;

namespace ClassLibrary
{
    public class ClsStock
    {
        //private
        private Int32 mBookId;
        private DateTime mDateAdded;
        private Boolean mAvailable;
        private String mBookDescription;
        private Int32 mQuantityAvailable;
        private Double mPrice;


        public string Description { get
            {
                return mBookDescription;
            } set
            {
                mBookDescription = value;
            }
        }

        public bool Available { get
            {
                return mAvailable;
            }

            set
            {
                mAvailable = value;
            }

        }

        public DateTime DateAdded { get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }
        }

        public int Quantity { get
            {
                return mQuantityAvailable;
            }

            set
            {
                mQuantityAvailable = value;
            }
        }

        public double Price { get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
            }

        public int BookId {
            get
            {
                return mBookId;
            }
            set
            {
                mBookId = value;
            }
            }

        public bool Find(int BookId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookId", BookId);
            DB.Execute("sproc_tblStock_FilterByBookId");

            if (DB.Count == 1)
            {
                mBookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);
                mBookDescription = Convert.ToString(DB.DataTable.Rows[0]["BookDescription"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mQuantityAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityAvailable"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string bookDescription, string dateAdded, string quantityAvailable, string price)
        {
            String Error = "";
            DateTime DateTemp;
            Int32 QuantityTemp;
            Double PriceTemp;
            if (bookDescription.Length == 0)
            {
                Error = Error + "The book decription may not be blank : ";
            }
            if (bookDescription.Length > 100)
            {
                Error = Error = "The book description must be less than 100 characters";
            }

            //Date Added
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
                Error = Error + "The date was not a valid date : ";
            }

            //Qaunitiy Available
            QuantityTemp = Convert.ToInt32(quantityAvailable);
            if (QuantityTemp < 0)
            {
                Error = Error + "The quanity can not be below 0 : ";
            }
            if (QuantityTemp > Int32.MaxValue)
            {
                Error = Error + "The quanity can not be above 2147483647 : ";

            }
            //Price 

            try
            {
                PriceTemp = Convert.ToDouble(price);
                Double MaxValue = 1000.00;
                if (PriceTemp < 0.00)
                {
                    Error = Error + "Item must have a cost : ";
                }
                if (PriceTemp > MaxValue)
                {
                    Error = Error + "The price cannot exceed max value : ";
                }
            }
            catch
            {

                Error = Error + "The price cannot exceed Double Max value : ";
            }
            return Error;
        }

    }
}
