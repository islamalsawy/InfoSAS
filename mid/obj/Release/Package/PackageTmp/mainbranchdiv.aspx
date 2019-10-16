<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mainbranchdiv.aspx.cs" Inherits="mid.mainbranchdiv" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
      <div style="float:left; width:100%;margin-right:30px;">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="مكان تسليم البضاعة"></asp:Label></td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" /></td>
                <td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" />
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label></td>
            </tr>

        </table>
   
    <br />
    <asp:GridView ID="GridView1" BackColor="White" CssClass="grid" GridLines="None" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="~/updatedelemainbranchdiv.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedelemainbranchdiv.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>
            </div>

</asp:Content>
