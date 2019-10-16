<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reftypmain.aspx.cs" Inherits="mid.reftypmain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div style="float:left; width:100%;margin-right:30px;">
       
     <table class="grid"><tr>
       <td>
     <asp:Label ID="Label1" runat="server" Text="أنواع المراجع للسندات"></asp:Label>
   </td>
       <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
       <td>
           <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" />
      </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="insert" OnClick="Button2_Click" />
            </td>
            </tr></table>
        
    <asp:GridView ID="GridView1" GridLines="None" CssClass="grid" BackColor="White" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="رقم_النوع" DataNavigateUrlFormatString="updatedelereftypmain.aspx?no={0}" HeaderText="edit&amp;delete" NavigateUrl="~/updatedelereftypmain.aspx" Text="edit&amp;delete" />
        </Columns>
        </asp:GridView>

    </div>

</asp:Content>
