using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock ABook = new clsStock();
        string BookId = txtBookId.Text;
        string BookDescription = txtBookDescription.Text;
        string Price = txtPrice.Text;
        string QuantityAvailable = txtQuantity.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = ABook.Valid(BookDescription, Price, QuantityAvailable, DateAdded);
        if(Error == "")
        {
            ABook.Description = BookDescription;
            ABook.BookId = Convert.ToInt32(BookId);
            ABook.Price = Convert.ToDouble(Price);
            ABook.Quantity = Convert.ToInt32(QuantityAvailable);
            ABook.DateAdded = Convert.ToDateTime(DateAdded);
            ABook.Available = chkAvailable.Checked;
            clsStockCollection StockList = new clsStockCollection();
            StockList.ThisStock = ABook;
            StockList.Add();
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