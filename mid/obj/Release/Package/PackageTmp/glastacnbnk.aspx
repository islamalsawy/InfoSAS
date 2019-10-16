<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="glastacnbnk.aspx.cs" Inherits="mid.glastacnbnk" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
     <div style="float:left; width:100%;margin-right:30px;">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="بيانات البنوك و الصندوق"></asp:Label>
                    &nbsp;
                </td>
                <td>&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" Width="58px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" />
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
   
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" BackColor="White" CssClass="grid" GridLines="None" runat="server" Width="372px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="~/updatedeleglastacnbnk.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedeleglastacnbnk.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
