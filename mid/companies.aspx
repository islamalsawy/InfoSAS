<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="companies.aspx.cs" Inherits="mid.companies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    
    
    
      <div style="float:left; width:100%;margin-right:30px;">

        <table class="grid">
         <tr>
             <td>    <asp:Label ID="Label1" runat="server" Text="رقم الشركة"></asp:Label></td>
              <td>    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
              <td>    <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" /></td>
             <td>
                 <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" />
             </td>
         </tr>
     </table>
         
    <asp:GridView ID="GridView1"  CssClass="grid" GridLines="None" runat="server" BackColor="White" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="رقم_الشركة" DataNavigateUrlFormatString="updatecompanies.aspx?cmp={0}" HeaderText="تعديل" NavigateUrl="~/updatecompanies.aspx" Text="تعديل" />
            <asp:HyperLinkField DataNavigateUrlFields="رقم_الشركة,إسم_الشركة" DataNavigateUrlFormatString="deletecompanies.aspx?co={0}&amp;cn={1}" HeaderText="حذف" NavigateUrl="~/deletecompanies.aspx" Text="حذف" />
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
