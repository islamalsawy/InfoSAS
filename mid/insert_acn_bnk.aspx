<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insert_acn_bnk.aspx.cs" Inherits="mid.insert_acn_bnk" %>
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
               <tr><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td>
            <asp:Label ID="Label2" runat="server" Text="إسم الحساب بالعربي"></asp:Label></td></tr>
        <tr><td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td>
            <asp:Label ID="Label3" runat="server" Text="إسم الحساب بالإنجليزي"></asp:Label></td></tr>
        <tr><td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td>
            <asp:Label ID="Label4" runat="server" Text="الحساب بالبنك"></asp:Label></td></tr>
        <tr><td>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="جمع النقدية" /></td><td>
                <asp:CheckBox ID="CheckBox2" runat="server" Text="سندات صرف الشيك" /></td>
            </tr>
                    <tr>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" Text="البنوك" /></td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" Text="الصندوق" /></td></tr>
        <tr><td>
            <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
        </td></tr>
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
        
        
        <tr><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td>
            <asp:Label ID="Label2" runat="server" Text="إسم الحساب بالعربي"></asp:Label></td></tr>
        <tr><td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td>
            <asp:Label ID="Label3" runat="server" Text="إسم الحساب بالإنجليزي"></asp:Label></td></tr>
        <tr><td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td>
            <asp:Label ID="Label4" runat="server" Text="الحساب بالبنك"></asp:Label></td></tr>
        <tr><td>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="جمع النقدية" /></td><td>
                <asp:CheckBox ID="CheckBox2" runat="server" Text="سندات صرف الشيك" /></td>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" Text="البنوك" /></td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" Text="الصندوق" /></td></tr>
        <tr><td>
            <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
        </td></tr>
    </table>--%>




</asp:Content>
