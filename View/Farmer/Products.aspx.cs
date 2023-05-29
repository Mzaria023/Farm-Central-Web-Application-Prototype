using Farm_Central_Web_Application_Prototype.View.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Farm_Central_Web_Application_Prototype.View.Farmer
{
    public partial class Products : System.Web.UI.Page
    {
        Models.Functions functions;
        protected void Page_Load(object sender, EventArgs e)
        {
            functions = new Models.Functions();
            ShowProduct();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
           // base.VerifyRenderingInServerForm(control);
        }
        //method to show data the farmer add to the database on the gridview
        private void ShowProduct()
        {
            string Query = "Select * from ProductTB";
            ProductGV.DataSource = functions.getData(Query);
            ProductGV.DataBind();
        }
        //save button to store products
        protected void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {  //checking empty textboxes
                if (name.Value == "" || category.Value == "" || price.Value == "" || qty.Value == "" || ty.Value == "" || date.Value == "" || range.Value == ""|| farmer.Value == "")
                {
                    ErrorMessage.InnerText = "Missing Data, Please Check";
                }
                else
                {
                    string Pname = name.Value;
                    string Pcategory = category.Value;  
                    string Pprice = price.Value;    
                    string Pqty = qty.Value;    
                    string Pty = ty.Value;
                    string ExpDate = date.Value;
                    string Prange = range.Value;
                    string Pfarmer = farmer.Value;
                    //inserting statements to add product to the database
                    string Query = "Insert into ProductTB values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                    Query = string.Format(Query, Pname, Pcategory, Pprice, Pqty,Pty, ExpDate, Prange, Pfarmer);
                    functions.setData(Query);
                    ShowProduct();
                    ErrorMessage.InnerText = "Product Added Successfully!!";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage.InnerText += ex.Message;   
            }
        }
        int Key = 0;
        protected void ProductGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            name.Value = ProductGV.SelectedRow.Cells[2].Text;
            category.Value = ProductGV.SelectedRow.Cells[3].Text;
            price.Value = ProductGV.SelectedRow.Cells[4].Text;
            qty.Value = ProductGV.SelectedRow.Cells[5].Text;
            ty.Value = ProductGV.SelectedRow.Cells[6].Text;
            date.Value = ProductGV.SelectedRow.Cells[7].Text;
            range.Value = ProductGV.SelectedRow.Cells[8].Text;
            farmer.Value = ProductGV.SelectedRow.Cells[9].Text;

            if (name.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductGV.SelectedRow.Cells[2].Text);
            }
        }
        //edit button 
        protected void editBtn_Click(object sender, EventArgs e)
        {
            try
            {  //checking empty textboxes
                if (name.Value == "" || category.Value == "" || price.Value == "" || qty.Value == "" || ty.Value == "" || date.Value == "" || range.Value == "" || farmer.Value == "")
                {
                    ErrorMessage.InnerText = "Missing Data, Please Check";
                }
                else
                {
                    string Pname = name.Value;
                    string Pcategory = category.Value;
                    string Pprice = price.Value;
                    string Pqty = qty.Value;
                    string Pty = ty.Value;
                    string ExpDate = date.Value;
                    string Prange = range.Value;
                    string Pfarmer = farmer.Value;
                    //updating statements 
                    string Query = "Update ProductTB set ProdName ='{0}',ProdCat ='{1}',ProdPrice ='{2}',ProdQty ='{3}',ProdType ='{4}',ExpDate ='{5}',ProdRange ='{6}',FarmerName='{7}'where PdtId ='{8}'";
                    Query = string.Format(Query, Pname, Pcategory, Pprice, Pqty, Pty,ExpDate, Prange,Pfarmer, ProductGV.SelectedRow.Cells[0].Text);
                    functions.setData(Query);
                    ShowProduct();
                    ErrorMessage.InnerText = "Product Updated Successfully!!";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage.InnerText += ex.Message;
            }
        }
        //delete button
        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Value == "")
                {
                    ErrorMessage.InnerText = "Missing Data, Please Check";
                }
                else
                {
                    string Pname = name.Value;
                    
                    //delete statement
                    string Query = "Delete from ProductTB where PdtId ='{0}'";
                    Query = string.Format(Query,ProductGV.SelectedRow.Cells[2].Text);
                    functions.setData(Query);
                    ShowProduct();
                    ErrorMessage.InnerText = "Product Deleted Successfully!!";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage.InnerText += ex.Message;
            }
        }
    }
}