<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insertcity.aspx.cs" Inherits="mid.insertcity" %>
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
                <asp:Label ID="Label1" runat="server" Text="المدن الرئيسية"></asp:Label>&nbsp;</td>
        </tr>
    
         <tr>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label3" runat="server" Text="الإسم بالعربي"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label4" runat="server" Text="الإسم بالإنجليزي"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="117px"></asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="الدولة"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Height="19px" Width="117px"></asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="الفرع"></asp:Label>
            </td>
        </tr>
         <tr>
             <td class="text-center">
                 <br />
                 <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
                 <br />
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
      
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
      <%-- <table>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="المدن الرئيسية"></asp:Label>&nbsp;</td>
        </tr>
    
         <tr>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label3" runat="server" Text="الإسم بالعربي"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label4" runat="server" Text="الإسم بالإنجليزي"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="117px"></asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="الدولة"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Height="19px" Width="117px"></asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="الفرع"></asp:Label>
            </td>
        </tr>
         <tr>
             <td class="text-center">
                 <br />
                 <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
                 <br />
             </td>
        </tr>
         
    </table>
--%>






</asp:Content>
