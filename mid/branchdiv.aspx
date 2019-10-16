<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="branchdiv.aspx.cs" Inherits="mid.branchdiv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <table class="grid"><tr>
       <td>
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
   </td>
       <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
       <td>
           <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" />
      </td>
            </tr></table>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>




</asp:Content>
