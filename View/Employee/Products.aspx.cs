using Farm_Central_Web_Application_Prototype.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Farm_Central_Web_Application_Prototype.View.Employee
{
    public partial class Products : System.Web.UI.Page
    {
        Models.Functions functions;
        protected void Page_Load(object sender, EventArgs e)
        {
            functions = new Models.Functions();
            if (!IsPostBack)
            {
                GridV();
            }
        }
        //get data from the database and display on gridview
        protected void GridV()
        {//select statement
            string Query = "Select * from ProductTB";
            ProductGV.DataSource = functions.getData(Query);
            ProductGV.DataBind();
        }
        //search button 
        protected void showBtn_Click(object sender, EventArgs e)
        {//searches the database for requeated data
            string Query = "Select ProdName,ProdCat,ProdPrice,ProdQty,ProdType,ExpDate,ProdRange,FarmerName from ProductTB where FarmerName = '{0}'";
            Query = string.Format(Query,search.Value);
            ProductGV.DataSource = functions.getData(Query);
            ProductGV.DataBind();
        }
        
        
    }
}