<%@ Page Title="" Language="C#" MasterPageFile="~/View/Employee/EmployeeSite.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Farm_Central_Web_Application_Prototype.View.Employee.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="col-md-8">
                <!---Table here-->
         <asp:GridView runat="server" class="table table-hover" ID="ProductGV" AutoGenerateSelectButton="False" HorizontalAlign="Center"></asp:GridView> 
                
            </div>
    <div class="mb-3">
       <label for="search" class="form-label">Search Word</label>
        <input type="text" class="form-control" id="search" runat="server" required="required"/>
    </div>
    <asp:Button Text="Search" Class="btn btn-danger" runat="server" ID="showBtn" OnClick="showBtn_Click" />
</asp:Content>
