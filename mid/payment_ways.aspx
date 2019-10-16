<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="payment_ways.aspx.cs" Inherits="mid.payment_ways" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>

    <tr>

        <td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </td>
    </tr>
</table>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>


</asp:Content>
