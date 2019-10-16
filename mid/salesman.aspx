<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="salesman.aspx.cs" Inherits="mid.salesman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="float:left; width:100%;margin-right:30px;">

     <table class="grid">
        <tr>
            <td></td>
            <td class="text-center">
                <asp:Label ID="Label2" runat="server" Text="مندوبين المبيعات"></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="الرقم"></asp:Label></td>
             <td>
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
             <td>
                 <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" /></td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="insert" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
       
    <asp:GridView ID="GridView1" CssClass="grid" GridLines="None" BackColor="White" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="updatedelesalesman.aspx?no={0}" HeaderText="edit&amp;delete" NavigateUrl="~/updatedelesalesman.aspx" Text="edit&amp;delete" />
        </Columns>
    </asp:GridView>
         </div>
 <%--   <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="رقم"></asp:Label></td>
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
                <asp:Label ID="Label3" runat="server" Text="رصيد اول المده مدين"></asp:Label></td>
              <td>
                  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="الفرع للمتدرب"></asp:Label></td>
              <td>
                  <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
        </tr>
                <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="رصيد اول المده دائن"></asp:Label></td>
              <td>
                  <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
        </tr>
    </table>--%>



</asp:Content>
