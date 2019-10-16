<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insertcurncy.aspx.cs" Inherits="mid.insertcurncy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="content-wrapper">
        
    <section class="content" style="width:1000px;">
      <div class="row">
        <div class="col-xs-12">
          <div class="box">
            <div class="box-header">
              <h3 class="box-title"></h3>
            </div>
            <!-- /.box-header -->
              <div style="margin-right:35px">



            <div class="box-body">
              <table id="example2" class="table table-bordered table-hover" >
                <thead>
              
                </thead>
                <tbody>
              <tr>
            <td>

            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="العملات"></asp:Label>
            </td>
            <td>

            </td>
        </tr>
     <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="إسم العملة بالعربي"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
        </td>
    </tr>
     <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="إسم العملة بالإنجليزي"></asp:Label></td>
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
    </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="معدل العملة"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
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
    
    
    
    
    
     <%--<table>
        <tr>
            <td>

            </td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="العملات"></asp:Label>
            </td>
            <td>

            </td>
        </tr>
     <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="إسم العملة بالعربي"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
        </td>
    </tr>
     <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="إسم العملة بالإنجليزي"></asp:Label></td>
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
    </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="معدل العملة"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" /></td>
      
    </tr>
</table>--%>

</asp:Content>
