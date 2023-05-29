using Farm_Central_Web_Application_Prototype.View.Farmer;
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
    public partial class Add_Farmer : System.Web.UI.Page
    {
        Models.Functions functions;
        protected void Page_Load(object sender, EventArgs e)
        {
            functions = new Models.Functions();
            ShowFarmer();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            // base.VerifyRenderingInServerForm(control);
        }
        //method to show data the farmer add to the database on the gridview
        private void ShowFarmer()
        {//select statement
            string Query = "Select * from FarmerTB";
            FarmerGV.DataSource = functions.getData(Query);
            FarmerGV.DataBind();
        }
        //submit button method
        protected void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {//checking empty textboxes
                if (fname.Value == "" || fcontact.Value == "" || femail.Value == "" || location.Value == "")
                { //error message
                    ErrorMessage.InnerText = "Missing Data, Please Check";
                }
                else
                {
                    string name = fname.Value;
                    string contact = fcontact.Value;
                    string email = femail.Value;
                    string Flocation = location.Value;
                    
                    //inserting statement to add data to the database 
                    string Query = "Insert into FarmerTB values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, name, contact, email, Flocation);
                    functions.setData(Query);
                    ShowFarmer();
                    ErrorMessage.InnerText = "Farmer Added Successfully!!";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage.InnerText += ex.Message;
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            try
            {//checking empty textboxes
                if (fname.Value == "" || fcontact.Value == "" || femail.Value == "" || location.Value == "")
                {
                    ErrorMessage.InnerText = "Missing Data, Please Check";
                }
                else
                {
                    string name = fname.Value;
                    string contact = fcontact.Value;
                    string email = femail.Value;
                    string Flocation = location.Value;

                    //updating statements to update farmer table in the database
                    string Query = "Update FarmerTB set FarmerName ='{0}',Contact ='{1}',Email ='{2}', Location ='{3}'where FarmerId = '{4}'";
                    Query = string.Format(Query, name, contact, email, Flocation, FarmerGV.SelectedRow.Cells[0].Text);
                    functions.setData(Query);
                    ShowFarmer();
                    ErrorMessage.InnerText = "Farmer Updated Successfully!!";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage.InnerText += ex.Message;
            }
        }
        int Key = 0;
        protected void FarmerGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            fname.Value = FarmerGV.SelectedRow.Cells[2].Text;
            fcontact.Value = FarmerGV.SelectedRow.Cells[3].Text;
            femail.Value = FarmerGV.SelectedRow.Cells[4].Text;
            location.Value = FarmerGV.SelectedRow.Cells[5].Text;
            

            if (fname.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FarmerGV.SelectedRow.Cells[2].Text);
            }
        }
        //delete button
        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (fname.Value == "")
                {
                    ErrorMessage.InnerText = "Missing Data, Please Check";
                }
                else
                {
                    string Pname = fname.Value;

                    //delete item from the database
                    string Query = "Delete from FarmerTB where FarmerId ='{0}'";
                    Query = string.Format(Query, FarmerGV.SelectedRow.Cells[2].Text);
                    functions.setData(Query);
                    ShowFarmer();
                    ErrorMessage.InnerText = "Farmer Deleted Successfully!!";

                }
            }
            catch (Exception ex)
            {
                ErrorMessage.InnerText += ex.Message;
            }
        }
    }
}