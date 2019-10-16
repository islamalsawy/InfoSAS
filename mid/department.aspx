<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="mid.department" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:100%">
        <table class="grid">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="الإدارات و الأقسام"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
    </div>
    <asp:GridView ID="GridView1" BackColor="White" CssClass="grid" runat="server" AllowPaging="True" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="updatedele_depart.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedele_depart.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>

</asp:Content>
