<%@ Page Title="" Language="C#" MasterPageFile="~/View/Farmer/FarmerSite.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Farm_Central_Web_Application_Prototype.View.Farmer.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">

    <div class="container-fluid">
        <div class="row"></div>
        <div class="col-md-8"><img src="../../Assets/images/logo.jpeg" style="height:50px"/><h4>Manage Products</h4></div>
        <div class="row">
            <div class="col-md-4">
                <h2 class="text-danger">Product Details</h2>
               
                    <div class="mb-3">
                          <label for="name" class="form-label">Product Name</label>
                          <input type="text" class="form-control" id="name" runat="server" />
                      </div>
                    <div class="mb-3">
                          <label for="cat" class="form-label">Product Category</label>
                          <input type="text" class="form-control" id="category" runat="server"/>
                      </div>
                    <div class="mb-3">
                          <label for="price" class="form-label">Product Price</label>
                          <input type="text" class="form-control" id="price" runat="server"/>
                      </div>
                    <div class="mb-3">
                          <label for="qty" class="form-label">Product Quantity</label>
                          <input type="text" class="form-control" id="qty" runat="server"/>
                      </div>
                    <div class="mb-3">
                          <label for="ty" class="form-label">Product Type</label>
                          <input type="text" class="form-control" id="ty" runat="server" />
                      </div>
                    <div class="mb-3">
                          <label for="exp" class="form-label">Expiration Date</label>
                          <input type="date" class="form-control" id="date" runat="server"/>
                      </div>
                    <div class="mb-3">
                          <label for="range" class="form-label">Product Range</label>
                          <input type="text" class="form-control" id="range" runat="server" />
                      </div>
                <div class="mb-3">
                          <label for="farmer" class="form-label">Farmer's Name</label>
                          <input type="text" class="form-control" id="farmer" runat="server" />
                      </div>
                <label id="ErrorMessage" runat="server" class="text-danger"></label><br />
                <asp:Button Text="Save" Class="btn btn-danger" runat="server" ID="saveBtn" OnClick="saveBtn_Click" />
                <asp:Button Text="Edit" Class="btn btn-danger" runat="server" ID="editBtn" OnClick="editBtn_Click" />
                <asp:Button Text="Delete" Class="btn btn-danger" runat="server" ID="deleteBtn" OnClick="deleteBtn_Click" />
                
            </div>
            <div class="col-md-8">
                <!---Table here-->
                <asp:GridView runat="server" class="table table-hover" ID="ProductGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="ProductGV_SelectedIndexChanged" AutoGenerateColumns="True">
                    <Columns>
                        <asp:BoundField></asp:BoundField>
                    </Columns>
                </asp:GridView>
                
            </div>
        </div>
    </div>
</asp:Content>
