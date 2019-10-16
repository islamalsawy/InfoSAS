<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updatedelelcpmwys.aspx.cs" Inherits="mid.updatedelelcpmwys" %>
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
                <asp:Label ID="Label1" runat="server" Text="طرق الدفع"></asp:Label>&nbsp;</td>
        </tr>
         <tr>
             <td class="text-center">
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label2" runat="server" Text="رقم"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label3" runat="server" Text="البيان بالعربي"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label4" runat="server" Text="البيان بالإنجليزي"></asp:Label></td>
        </tr>
         <tr>
             <td class="text-center">
                 <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    <%--<table>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="طرق الدفع"></asp:Label>&nbsp;</td>
        </tr>
         <tr>
             <td class="text-center">
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label2" runat="server" Text="رقم"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label3" runat="server" Text="البيان بالعربي"></asp:Label></td>
        </tr>
         <tr>
             <td>
                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
             <td class="text-center">
                 <asp:Label ID="Label4" runat="server" Text="البيان بالإنجليزي"></asp:Label></td>
        </tr>
         <tr>
             <td class="text-center">
                 <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button2" runat="server" Text="delete" OnClick="Button2_Click" />
             </td>
        </tr>
         
    </table>--%>
</asp:Content>
