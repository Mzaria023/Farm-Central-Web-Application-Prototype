<%@ Page Title="" Language="C#" MasterPageFile="~/View/Farmer/FarmerSite.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="Farm_Central_Web_Application_Prototype.View.Farmer.DashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
   <!-- <h1>Dash Board</h1> -->
    <div class="container-fluid">
        <div class="row" style="height:80px"></div>
        <div class="col-md-3"></div>
         <div class="col-md-6"><img src="../../Assets/images/logo.jpeg" class="rounded" style="height:100px"/><h2 class="text-warning">Farmer DashBoard</h2></div>
         <div class="col-md-3"></div>
    <div class="row">
        <div class="col-1"></div>
        <div class="col-10">
            <div class="row">
                <div class="col-md-4 bg-primary rounded">
                    <div class="row">
                      <div class="col-md-2"><img src="../../Assets/images/add prod.jpeg" style="height:50px"/></div>
                       <div class="col-md-10">
                          <h3 class="text-white">Products</h3>
                          <h1 class="text-white" runat="server" id="PNum">Num</h1>
                      </div>
                    </div>                    
                </div>
          <div class="col-md-1 bg-light">
                    
                </div>
            </div>
        </div>
        <div class="col-1"></div>
    </div>
        <div class ="row">
            <div class="col-4"></div>
            <div class="col-4">
                <img src="../../Assets/images/field.png" style="height:300px"/>
            </div>
            <div class="col-4"></div>
        </div>
  </div>
</asp:Content>
