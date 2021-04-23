using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(CustomerId);
        txtCustomerId.Text = Customer.ThisCustomer.CustomerId.ToString();
        txtEmail.Text = Customer.ThisCustomer.Email;
        txtUserPassword.Text = Customer.ThisCustomer.UserPassword;
        txtDateAdded.Text = Customer.ThisCustomer.DateAdded.ToString();
        txtBudget.Text = Customer.ThisCustomer.Budget.ToString();
        chkActive.Checked = Customer.ThisCustomer.Active;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        
        string Email = txtEmail.Text;
        string UserPassword = txtUserPassword.Text;
        string Budget = txtBudget.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = ACustomer.Valid(Email, UserPassword, Budget, DateAdded);
        if (Error == "")
        {
            ACustomer.CustomerId = CustomerId;
            ACustomer.Email = Email;
            ACustomer.UserPassword = UserPassword;
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            ACustomer.Budget = Convert.ToDecimal(Budget);
            ACustomer.Active = chkActive.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
                
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}