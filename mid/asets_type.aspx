<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="asets_type.aspx.cs" Inherits="mid.asets_type" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--<table class="grid">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="الرقم"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="الاسم"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
    </tr>
      <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="الاهلاك"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        <td>
            <asp:Label ID="Label4" runat="server" Text="رقم الحساب"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
    </tr>
      <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="مركز التكلفه"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
        <td>
            <asp:Label ID="Label6" runat="server" Text="رقم حساب مجمع الاهلاك "></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
    </tr>
</table>
    <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="delete" OnClick="Button2_Click" />--%>
      <div style="float:left; width:100%;margin-right:30px;">
        <table class="grid">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="انواع الاصول"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click1" /></td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
 
    <asp:GridView ID="GridView1" BackColor="White" CssClass="grid" GridLines="None" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="2">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="updatedele_asets_type.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedele_asets_type.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
