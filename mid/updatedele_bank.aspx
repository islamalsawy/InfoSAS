﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updatedele_bank.aspx.cs" Inherits="mid.updatedele_bank" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-wrapper">
        
    <section class="content">
      <div class="row">
        <div class="col-xs-12">
          <div class="box">
            <div class="box-header">
              <h3 class="box-title"></h3>
            </div>
            <!-- /.box-header -->
              <div style="margin-right:35px">



            <div class="box-body">
              <table id="example2" class="table table-bordered table-hover">
                <thead>
              
                </thead>
                <tbody>
              <tr>
            <td></td>
            <td>
            <asp:Label ID="Label3" runat="server" Text="البيانات الاساسيه للبنوك"></asp:Label></td>
            
        </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="رقم البنك"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
       <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="اسم البنك"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
 <tr>
     <td>
<asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
     </td>
     <td>
 <asp:Button ID="Button2" runat="server" Text="delete" OnClick="Button2_Click" />
     </td>
 </tr>
                </tfoot>
              </table>
            </div>
                  </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

          
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
      
</div>
   
    
    
    
    
    
    
     <%--<table class="grid">
        <tr>
            <td></td>
            <td>
            <asp:Label ID="Label3" runat="server" Text="البيانات الاساسيه للبنوك"></asp:Label></td>
            <td></td>
        </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="رقم البنك"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
       <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="اسم البنك"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>--%>

<%--    <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="delete" OnClick="Button2_Click" />--%>



</asp:Content>
