using System;

namespace ClassLibrary
{
    public class clsStock
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
    }
}