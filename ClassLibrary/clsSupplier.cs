using System;
namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 aSuppId;
        private Boolean aActive;
        private DateTime aDate;
        private Int64 aQuantity;
        private Decimal aCost;
        private Int32 aPhone;
        private string aSuppName;

        public Int32 SupplierId
        {
            get
            {
                return aSuppId;
            }
            set
            {
                aSuppId = value;
            }
        }

        public Boolean Active
        {
            get
            {
                return aActive;
            }
            set
            {
                aActive = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return aDate;
            }
            set
            {
                aDate = value;
            }
        }

        public Int64 Quantity
        {
            get
            {
                return aQuantity;
            }
            set
            {
                aQuantity = value;
            }
        }

        public Decimal Cost
        {
            get
            {
                return aCost;
            }
            set
            {
                aCost = value;

            }
        }
        public Int32 Phone
        {
            get
            {
                return aPhone;
            }
            set
            {
                aPhone = value;
            }
        }
        public string SupplierName
        {
            get
            {
                return aSuppName;
            }
            set
            {
                aSuppName = value;
            }
        }

        public string Valid(string phone, string supplierName, string cost, string dateAdded)
        {
            String Error = "";
            DateTime DateTemp;
            Decimal CostTemp;
            Decimal maxCost = 999.99m;
            
            if (supplierName.Length == 0)
            {
                Error = Error + "The name may not be blank : ";
            }
            if (supplierName.Length > 50)
            {
                Error = Error = "The name  must be less than 50 characters: ";
            }
            if (phone.Length == 0)
            {
                Error = Error + "The phone may not be blank : ";
            }
            if (phone.Length < 12)
            {
                Error = Error + "The phone cannot be less than 12 characters : ";
            }
            if (phone.Length > 14)
            {
                Error = Error + "The phone may not be more than 14 characters : ";
            }
            
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date must be the same day : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date must be the same day :";
                }
            }

            catch
            {
                Error = Error + "Invalid date : ";
            }
                CostTemp = Convert.ToDecimal(Cost);
            if (CostTemp < 0)
            {
                Error = Error + "The budget cannot be negative : ";
            }
            if (CostTemp > maxCost)
            {
                Error = Error + "The budget cannot be higher than 999.99 : ";
            }
            return Error;
        }

               
       public bool Find(int SupplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", SupplierId);
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");

            if (DB.Count == 1)
            {
                aSuppId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                aCost = Convert.ToDecimal(DB.DataTable.Rows[0]["Cost"]);
                aSuppName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                aPhone = Convert.ToInt32(DB.DataTable.Rows[0]["Phone"]);
                aDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                aActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                aQuantity = Convert.ToInt64(DB.DataTable.Rows[0]["Quantity"]);


                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
