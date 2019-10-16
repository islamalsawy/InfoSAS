<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="asets_status.aspx.cs" Inherits="mid.asets_status" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div style="float:left; width:100%;margin-right:30px;">
        <table class="grid">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="حالة الاصول"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" /></td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" />

                </td>
            </tr>
        </table>
    

    <asp:GridView ID="GridView1" BackColor="White" CssClass="grid" GridLines="None" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="رقم_الأصل" HeaderText="تعديل و حذف" Text="تعديل و حذف" DataNavigateUrlFormatString="updatedele_asets_status.aspx?no={0}" NavigateUrl="~/updatedele_asets_status.aspx" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>
