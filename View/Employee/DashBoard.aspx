<%@ Page Title="" Language="C#" MasterPageFile="~/View/Employee/EmployeeSite.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="Farm_Central_Web_Application_Prototype.View.Employee.DashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <!--<h1>Dash Board</h1>-->
     <div class="container-fluid">
        <div class="row" style="height:80px"></div>
         <div class="col-md-3"></div>
         
         <div class="col-md-6">
             <div class="row">
                 <div class="col-4"><img src="../../Assets/images/logo.jpeg" class="rounded" style="height:100px"/></div>
         </div>
             <div class="col-8"> <h2 class="text-warning">Employee DashBoard</h2></div>
        </div>
         <div class="col-md-3"></div>
    <div class="row">
        <div class="col-1"></div>
        <div class="col-10">
            <div class="row">
                
          <div class="col-md-1 bg-light">
                     
                </div>
                <div class="col-md-3 bg-info rounded" >
                    <div class="row">
                      <div class="col-md-2"><img src="../../Assets/images/list.png" style="height:50px"/></div>
                       <div class="col-md-10">
                          <h3 class="text-white"> Products List</h3>
                          <h1 class="text-white" runat="server" id="LNum">Num</h1>
                      </div>
                    </div>    
                </div>
                <div class="col-md-1 bg-light">
                     
                </div>
                <div class="col-md-3 bg-danger rounded">
                     <div class="row">
                      <div class="col-md-2"><img src="../../Assets/images/add.png" style="height:50px"/></div>
                       <div class="col-md-10">
                          <h3 class="text-white"> Add Farmer</h3>
                          <h1 class="text-white" runat="server" id="FNum">Num</h1>
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
