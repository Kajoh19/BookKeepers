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
        if(IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
         
    }

    protected void btnAdd_CLick(object sender, EventArgs e)
    {
        Session["BookId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }
    void DisplayStock()
        {
            clsStockCollection Stock = new clsStockCollection();
            lstStockList.DataSource = Stock.StockList;
            lstStockList.DataValueField = "BookId";
            lstStockList.DataTextField = "Description";
            lstStockList.DataBind();
        }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 BookId;
        //if a record has been selected from the list 
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            BookId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["BookId"] = BookId;
            //redirect to the delete page 
            Response.Redirect("StockConfirmDelete.aspx");

        } 
        else // if no record has been selected 
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 BookId;
        //if a record has been selected from the list 
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            BookId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["BookId"] = BookId;
            //redirect to the edit page 
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no records has been selected 
        {
            //display an error
            lblError.Text = "please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByBookDescription(txtFilter.Text);
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "BookId";
        //set the name of the fiels to display 
        lstStockList.DataTextField = "Description";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the stock collection 
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByBookDescription("");
        //clear any existing filter to tidy up the interface 
        txtFilter.Text = "";
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "BookId";
        //set the name of the field display
        lstStockList.DataTextField = "Decription";
        //bind the data tot he list 
        lstStockList.DataBind();
 
    }
}