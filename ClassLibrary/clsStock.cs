using System;

namespace ClassLibrary
{
    public class ClsStock
    {
        //private data member for the book Id property
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

        public bool Find(int bookId)
        {
            mBookId = 21;
            mBookDescription = "Test Book";
            mDateAdded = Convert.ToDateTime("01/01/2011");
            mPrice = 10.01;
            mQuantityAvailable = 1;
            mAvailable = true;
            return true;
        }
    }
}