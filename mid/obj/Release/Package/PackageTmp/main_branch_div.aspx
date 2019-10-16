<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="main_branch_div.aspx.cs" Inherits="mid.main_branch_div" %>
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
                <tr>
                  
               
                </tr>
                </thead>
                <tbody>
                <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="مكان تسليم البضاعة"></asp:Label>&nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </td>
        </tr>
 
         <tr>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label3" runat="server" Text="مكان التسليم بالعربي"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label4" runat="server" Text="مكان التسليم بالإنجليزي"></asp:Label></td>
        </tr>
         <tr>
             <td class="text-center">
                 <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
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
    
    
    
    
    
    
    
    
    
    
    
    
    
     <%--<table class="grid">
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="مكان تسليم البضاعة"></asp:Label>&nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </td>
        </tr>
 
         <tr>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label3" runat="server" Text="مكان التسليم بالعربي"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label4" runat="server" Text="مكان التسليم بالإنجليزي"></asp:Label></td>
        </tr>
         <tr>
             <td class="text-center">
                 <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
             </td>
        </tr>
         
    </table>
--%>















</asp:Content>
