using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 BookId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of stock to be processed
        BookId = Convert.ToInt32(Session["BookId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (BookId != -1)
            {
                DisplayStock();
            }
        }

        }

    private void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ThisStock.Find(BookId);
        txtBookId.Text = Stock.ThisStock.BookId.ToString();
        txtBookDescription.Text = Stock.ThisStock.Description;
        txtPrice.Text = Stock.ThisStock.Price.ToString();
        txtQuantity.Text = Stock.ThisStock.Quantity.ToString();
        chkAvailable.Checked = Stock.ThisStock.Available;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
        //create a new instance of clsStock
        clsStock ABook = new clsStock();
        string BookDescription = txtBookDescription.Text;
        string Price = txtPrice.Text;
        string QuantityAvailable = txtQuantity.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
        if (Error == "")
        {
            ABook.BookId = Convert.ToInt32(BookId);
            ABook.Description = BookDescription;
            ABook.Price = Convert.ToDouble(Price);
            ABook.Quantity = Convert.ToInt32(QuantityAvailable);
            ABook.DateAdded = Convert.ToDateTime(DateAdded);
            ABook.Available = chkAvailable.Checked;
            clsStockCollection StockList = new clsStockCollection();

            if (BookId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = ABook;
                //add the new record 
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(BookId);
                StockList.ThisStock = ABook;
                StockList.Update();
            }
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
   
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock ABook = new clsStock();
        Int32 BookId;
        Boolean Found = false;
        BookId = Convert.ToInt32(txtBookId.Text);
        Found = ABook.Find(BookId);
        if (Found == true)
        {
            txtBookDescription.Text = ABook.Description;
            txtDateAdded.Text = ABook.DateAdded.ToString();
            txtPrice.Text = ABook.Price.ToString();
            txtQuantity.Text = ABook.Quantity.ToString();

        } 
    }
}