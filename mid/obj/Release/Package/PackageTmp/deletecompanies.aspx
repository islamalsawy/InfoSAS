<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="deletecompanies.aspx.cs" Inherits="mid.deletecompanies" %>
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
           <td>Are you sure you want to delete 
               <br />
               <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</td>
<td>
      <asp:Button ID="Button1" runat="server" Text="delete" OnClick="Button1_Click" />
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












<%--<table class="grid" style="margin-right:10px" >
        <tr>
           <td>Are you sure you want to delete 
               <br />
               <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</td>
<td>
      <asp:Button ID="Button1" runat="server" Text="delete" OnClick="Button1_Click" />
</td>
        </tr>
        
    </table>--%>
</asp:Content>
