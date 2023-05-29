using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Farm_Central_Web_Application_Prototype.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            functions = new Models.Functions();
        }
        //declarong variable
        public static string logName;
        public static int logKey;
        public override void VerifyRenderingInServerForm(Control control)
        {
            // base.VerifyRenderingInServerForm(control);
        }
        Models.Functions functions;
        //login button
        protected void loginBtn_Click(object sender, EventArgs e)

        {    //checking if the farmer radio button has been clicked
            if (FarmerRadio.Checked)
            {
               if (Email1.Value == "farmer@gmail.com" && Password.Value == "farmer")
                { 
                    //redirects to default page
                    //Response.Redirect("Farmer/Products.aspx");
                    FormsAuthentication.RedirectFromLoginPage(Email1.Value, true);
                }
                else
                {
                    InfoMsg.InnerText = "Invalid Farmer!!!";
                }
            }
            else
            {   //select statement for farmerTable to check farmer's info
                String Query = "Select FarmerId,FarmerName,Contact,Email,Location from FarmerTB where Email = '{0}'";
                Query = string.Format (Query, Email1.Value, Password.Value);    
                DataTable dt = functions.getData(Query);
                if(dt.Rows.Count == 0)
                {
                    InfoMsg.InnerText = "Invalid User !!!";
                }
                else
                {
                    logName = Email1.Value;
                    logKey = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Farmer/Dashboard.aspx");
                }
                //checking if the farmer radio button has been clicked
                if (EmployeeRadio.Checked)
                {
                    string email = Email1.Value;
                    string password = Password.Value;
                    string data = "Insert into EmployeeTB values('{0}','{1}')";
                    data = string.Format(data, email, password);
                    functions.setData(data);

                    if (Email1.Value == email && Password.Value == password)
                    {
                         Response.Redirect("Employee/DashBoard.aspx");
                    }
                    //errorMessage
                    else
                    {
                        InfoMsg.InnerText = "Invalid Employee!!!";
                    }
                }
                else
                {   //selecting employee's details if they have once signedup or logged in before
                    string data = "Select Email, Password from EmployeeTB where Email = '{0}'";
                    data = string.Format(Query, Email1.Value, Password.Value);
                    DataTable table = functions.getData(Query);
                    if (table.Rows.Count == 0)
                    {
                        InfoMsg.InnerText = "Invalid User !!!";
                    }
                    else
                    {
                        logName = Email1.Value;
                        logKey = Convert.ToInt32(dt.Rows[0][0].ToString());
                        FormsAuthentication.RedirectFromLoginPage(logName, true);
                        //Response.Redirect("Employee/Dashboard.aspx");
                    }
                }
            }
        }
    }
}