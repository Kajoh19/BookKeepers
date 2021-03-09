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
        string CustomerId = txtCustomerId.Text;
        string Email = txtEmail.Text;
        string UserPassword = txtUserPassword.Text;
        string Budget = txtBudget.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = ACustomer.Valid(Email, UserPassword, Budget, DateAdded);
        if (Error == "")
        {
            ACustomer.CustomerId = Convert.ToInt32(CustomerId);
            ACustomer.Email = Email;
            ACustomer.UserPassword = UserPassword;
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            ACustomer.Budget = Convert.ToDecimal(Budget);
            ACustomer.Active = chkActive.Checked;
            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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