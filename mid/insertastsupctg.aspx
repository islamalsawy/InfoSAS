<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insertastsupctg.aspx.cs" Inherits="mid.insertsupctg" %>
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
        <td>

        </td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="تصنيف الموردين والعملاء"></asp:Label>
        </td>
     
    </tr>
    <tr>
        <td>النوع</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">عملاء</asp:ListItem>
                <asp:ListItem Value="2">موردين</asp:ListItem>
            </asp:DropDownList></td>
    </tr>
        <tr>
        <td>الاسم>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
     
    </tr>
    <tr>
     <td>
         <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" /></td>
        
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
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     <%--  <table class="grid">
    <tr>
        <td>

        </td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="تصنيف الموردين والعملاء"></asp:Label>
        </td>
        <td>

        </td>
    </tr>
    <tr>
        <td>النوع</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">عملاء</asp:ListItem>
                <asp:ListItem Value="2">موردين</asp:ListItem>
            </asp:DropDownList></td>
    </tr>
        <tr>
        <td>الاسم>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
     <td>
         <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" /></td>
           <td></td>
        <td></td>
    </tr>
</table>--%>




</asp:Content>
