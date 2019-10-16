<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insert_jrntyp.aspx.cs" Inherits="mid.insert_jrntyp" %>
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
            <td><asp:Label ID="Label1" runat="server" Text="انواع القيود اليومية"></asp:Label></td>
        </tr>
        
        <tr>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="وصف القيد بالعربية"></asp:Label> </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="وصف القيد بالإنجليزية"></asp:Label></td>
        </tr>
        <tr>
            <td>
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
      
    
    
    
    
    
    
     <%--  <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="انواع القيود اليومية"></asp:Label></td>
        </tr>
        
        <tr>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="وصف القيد بالعربية"></asp:Label> </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="وصف القيد بالإنجليزية"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
            
</td>
        </tr>
    </table>--%>








</asp:Content>
