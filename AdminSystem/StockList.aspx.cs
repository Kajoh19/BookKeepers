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
}