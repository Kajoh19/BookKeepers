using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }


    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerId";
        lstCustomers.DataTextField = "Email";
        lstCustomers.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");
                
        }
        else
        {
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByEmail(txtFilter.Text);
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerId";
        lstCustomers.DataTextField = "Email";
        lstCustomers.DataBind();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ReportByEmail("");
        txtFilter.Text = "";
        lstCustomers.DataSource = Customer.CustomerList;
        lstCustomers.DataValueField = "CustomerId";
        lstCustomers.DataTextField = "Email";
        lstCustomers.DataBind();
    }
}