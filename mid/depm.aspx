<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="depm.aspx.cs" Inherits="mid.depm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<table class="grid">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="الرقم"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" /></td>
    </tr>
</table>

    <asp:GridView ID="GridView1" CssClass="grid" GridLines="None" runat="server">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Depm_No" DataNavigateUrlFormatString="updatedeledepm.aspx?no={0}" HeaderText="edit&amp;delete" NavigateUrl="~/updatedeledepm.aspx" Text="edit&amp;delete" />
        </Columns>
    </asp:GridView>




</asp:Content>
