<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Farm_Central_Web_Application_Prototype.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="../Assets/lib/css/bootstrap.min.css"/>
</head>
<body>
   
    <div class="container-fluid">
        <div class="row" style="height:90px"> </div>
        <div class="row">
            <div class="col-md-2"></div>
              <div class="col-md-4">
                <img src="../../Assets/images/farmer_10things.jpg" class="img-fluid" style="height:450px"/>
              </div>
              <div class="col-md-4">
                  <h1 class="text-danger">Sign Up</h1>
                  <form runat="server">
                     <div class="mb-3">
                          <label for="Email" class="form-label">Email address</label>
                          <input type="email" class="form-control" id="Email1" runat="server" required="required"/>
                          <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                      </div>
                      <div class="mb-3">
                          <label for="Password" class="form-label">Password</label>
                          <input type="password" class="form-control" id="Password" runat="server" required="required"/>
                      </div>
                      <div class="mb-3 form-check">
                          <input type="radio" class="form-check-input" id="FarmerRadio" checked="true" name="Role" runat="server"/>
                          <label class="form-check-label" for="FarmerRadio">Farmer</label>
                      </div>
                      <div class="mb-3 form-check">
                          <input type="radio" class="form-check-input" id="EmployeeRadio" name="Role" runat="server" />
                          <label class="form-check-label" for="EmployeeRadio">Employee</label>
                      </div>
                       <div class="mb-3 d-grid">
                           <label id="InfoMsg" runat="server" class="text-danger"></label>
                           <asp:Button Text="Login" Class="btn btn-danger btn-block" runat="server" ID="loginBtn" OnClick="loginBtn_Click" />
               
                            
                      </div> 
                      </form>
              </div>
            
    </div>
 </div>
</body>
</html>
