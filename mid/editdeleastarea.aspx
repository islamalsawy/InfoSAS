<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="editdeleastarea.aspx.cs" Inherits="mid.editdeleastarea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="الرقم"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
        <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="الاسم"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
    </tr>
</table>
    <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="delete" OnClick="Button2_Click" />





</asp:Content>
