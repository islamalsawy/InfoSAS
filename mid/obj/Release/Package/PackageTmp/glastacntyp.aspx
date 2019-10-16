<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="glastacntyp.aspx.cs" Inherits="mid.glastacntyp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
     <div style="float:left; width:100%;margin-right:30px;">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="أنواع الحسابات اليومية"></asp:Label>
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
                    <asp:Button ID="Button2" runat="server" Text="ادخال" OnClick="Button2_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </td>
            </tr>

        </table>

    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" BackColor="White" CssClass="grid" GridLines="None" runat="server" Width="372px" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" PageSize="2">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="~/updatedeleglastacntyp.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedeleglastacntyp.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
