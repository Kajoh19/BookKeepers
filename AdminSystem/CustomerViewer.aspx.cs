﻿using System;
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
        Response.Write(ACustomer.CustomerId + "\n\n");
        Response.Write(ACustomer.Email + "\n\n");
        Response.Write(ACustomer.UserPassword + "\n\n");
        Response.Write(ACustomer.DateAdded + "\n\n");
        Response.Write(ACustomer.Height + "\n\n");
        Response.Write(ACustomer.Active + "\n\n");
    }
}