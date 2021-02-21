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
        ABook.Description = txtBookDescription.Text;
        ABook.BookId = Convert.ToInt32(txtBookId.Text);
        ABook.Price = Convert.ToDouble(txtPrice.Text);
        ABook.Quantity = Convert.ToInt32(txtQuantity.Text);
        ABook.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        ABook.Available = chkAvailable.Checked;
        Session["ABook"] = ABook;
        Response.Redirect("StockViewer.aspx");
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