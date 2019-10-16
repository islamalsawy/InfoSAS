<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="astcity.aspx.cs" Inherits="mid.astcity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="المدن الرئيسيه"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </td>
    </tr>
</table>

    <asp:GridView ID="GridView1" CssClass="grid" runat="server"></asp:GridView>


</asp:Content>
