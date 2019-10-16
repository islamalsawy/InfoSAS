<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="asets_loc.aspx.cs" Inherits="mid.asets_loc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div style="float:left; width:100%;margin-right:30px;">
<table class="grid">
    <tr>
    <td>
        <asp:Label ID="Label1" runat="server" Text="مواقع الاصول"></asp:Label></td>
    <td>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
    <td>
        <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" /></td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="إدخال"
            OnClick="Button2_Click" />
        </td>
        </tr>
</table>

    <asp:GridView BackColor="White" ID="GridView1" CssClass="grid" GridLines="None" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="رقم_الموقع" DataNavigateUrlFormatString="updatedele_asetsloc.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedele_asetsloc.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>
  </div>

</asp:Content>
