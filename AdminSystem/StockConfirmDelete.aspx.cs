using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 BookId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of Stock to be deleted from the session object
        BookId = Convert.ToInt32(Session["BookId"]);
    }




    protected void btnYes_Click1(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        //find the record table
        Stock.ThisStock.Find(BookId);
        //delete the record 
        Stock.Delete();
        //redirect back to the amin page 
        Response.Redirect("StockList.aspx");
    }
}