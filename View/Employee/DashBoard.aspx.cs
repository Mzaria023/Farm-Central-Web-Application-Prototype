using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farm_Central_Web_Application_Prototype.View.Employee
{
    public partial class DashBoard : System.Web.UI.Page
    {     Models.Functions functions;
        protected void Page_Load(object sender, EventArgs e)
        {
            functions = new Models.Functions();
            GetProducts();
            GetFarmer();
        }
        //get products method to show number of items in the category
        private void GetProducts()
        {//select statement
            string Query = "Select Count (*) as Number from ProductTB";
            LNum.InnerText = functions.getData(Query).Rows[0][0].ToString();
            LNum.DataBind();
        }
        //get farmers method to show number of items in the category
        private void GetFarmer()
        {//select statement
            string Query = "Select Count (*) as Number from FarmerTB";
            FNum.InnerText = functions.getData(Query).Rows[0][0].ToString();
            FNum.DataBind();
        }
    }
}