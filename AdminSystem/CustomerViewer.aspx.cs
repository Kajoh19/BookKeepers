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
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.CustomerId+ "\t");
        Response.Write(ACustomer.FullName + "\t");
        Response.Write(ACustomer.Email + "\t");
        Response.Write(ACustomer.UserPassword + "\t");
        Response.Write(ACustomer.Address + "\t");
        Response.Write(ACustomer.DateAdded + "\t");
        Response.Write(ACustomer.Active + "\t");
    }
}