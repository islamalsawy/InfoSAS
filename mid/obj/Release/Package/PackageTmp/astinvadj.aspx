<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="astinvadj.aspx.cs" Inherits="mid.astinvadj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div style="float:left; width:100%;margin-right:30px;">
        <table class="grid">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="حسابات التسويه بالمخازن"></asp:Label></td>
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
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="updatedele_astinvadj.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedele_astinvadj.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
