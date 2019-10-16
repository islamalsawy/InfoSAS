<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="curncy.aspx.cs" Inherits="mid.curncy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="float:left; width:100%;margin-right:30px;">
    <table class="grid">

    <tr>

        <td>
            <asp:Label ID="Label1" runat="server" Text="العملات"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" />
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="ادخال" OnClick="Button2_Click" />
        </td>
    </tr>
</table>

    <asp:GridView ID="GridView1" CssClass="grid" GridLines="None" BackColor="White" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="updatedelecurncy.aspx?no={0}" HeaderText="edit&amp;delete" NavigateUrl="~/updatedelecurncy.aspx" Text="edit&amp;delete" />
        </Columns>
    </asp:GridView>

    </div>

</asp:Content>
