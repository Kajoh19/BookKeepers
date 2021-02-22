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
        clsCustomer ACustomer = new clsCustomer();

        ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        ACustomer.Email = txtEmail.Text;
        ACustomer.UserPassword = txtUserPassword.Text;
        ACustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        ACustomer.Budget = Convert.ToDecimal(txtBudget.Text);
        ACustomer.Active = chkActive.Checked;

        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }


    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerId;
        Boolean Found = false;
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Found = ACustomer.Find(CustomerId);
        if (Found == true)
        {
            txtEmail.Text = ACustomer.Email;
            txtUserPassword.Text = ACustomer.UserPassword;
            txtBudget.Text = ACustomer.Budget.ToString();
            txtDateAdded.Text = ACustomer.DateAdded.ToString();

        }
    }
}