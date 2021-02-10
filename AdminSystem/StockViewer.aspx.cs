using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock ABook = new clsStock();
        ABook = (clsStock)Session["ABook"];
        Response.Write(ABook.Description + "\n\n");
        Response.Write(ABook.Id + "\n\n");
        Response.Write(ABook.Price + "\n\n");
        Response.Write(ABook.Quantity + "\n\n");
        Response.Write(ABook.DateAdded + "\n\n");
        Response.Write(ABook.Available + "\n\n");
    }
}