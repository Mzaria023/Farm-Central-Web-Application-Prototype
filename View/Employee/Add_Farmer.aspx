<%@ Page Title="" Language="C#" MasterPageFile="~/View/Employee/EmployeeSite.Master" AutoEventWireup="true" CodeBehind="Add_Farmer.aspx.cs" Inherits="Farm_Central_Web_Application_Prototype.View.Employee.Add_Farmer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="container-fluid">
        <div class="row"></div>
        <div class="col-md-8"><br /><img src="../../Assets/images/logo.jpeg" style="height:70px "/><h4>Manage Products</h4></div>
        <div class="row">
            <div class="col-md-4">
                <h2 class="text-danger">Add Farmer</h2>
               
                    <div class="mb-3">
                          <label for="name" class="form-label">Farmer's Name</label>
                          <input type="text" class="form-control" id="fname" runat="server"/>
                      </div>
                    <div class="mb-3">
                          <label for="contact" class="form-label">Farmer's Cotact</label>
                          <input type="text" class="form-control" id="fcontact" runat="server"/>
                      </div>
                    <div class="mb-3">
                          <label for="email" class="form-label">Farmer's Email</label>
                          <input type="text" class="form-control" id="femail" runat="server" />
                      </div>
                    <div class="mb-3">
                          <label for="location" class="form-label">Farmer's Location</label>
                          <input type="text" class="form-control" id="location" runat="server"/>
                      </div>
                <label id="ErrorMessage" runat="server" class="text-danger"></label><br />
                <asp:Button Text="Submit" Class="btn btn-danger" ID="submitBtn" runat="server" OnClick="submitBtn_Click" />
                <asp:Button Text="Edit" Class="btn btn-danger" ID="editBtn" runat="server" OnClick="editBtn_Click" />
                <asp:Button Text="Delete" Class="btn btn-danger" ID="deleteBtn" runat="server" OnClick="deleteBtn_Click" />
              
            </div>
            <div class="col-md-8">
                <!---Table here-->
                <asp:GridView runat="server" class="table table-hover" ID="FarmerGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="FarmerGV_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField></asp:BoundField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
