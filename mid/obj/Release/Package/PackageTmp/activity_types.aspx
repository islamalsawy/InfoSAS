<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="activity_types.aspx.cs" Inherits="mid.activity_types" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    <%--<table>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="الرقم"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="البيان"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>


</table>--%>
    



    
    
     

       <div style="float:left; width:100%;margin-right:30px;">
    <table class="grid">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="الانشطه بالشركه"></asp:Label></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" /></td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" />
            </td>

        </tr>
    </table>

    <div style="width: 100px; position:center;
	height: 100px;	  	
	justify-content:center; width:100%">
    <asp:GridView ID="GridView1" BackColor="White" CssClass="grid" GridLines="None" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="الرقم" DataNavigateUrlFormatString="updatedeleactivties_types.aspx?no={0}" HeaderText="تعديل و حذف" NavigateUrl="~/updatedeleactivties_types.aspx" Text="تعديل و حذف" />
        </Columns>
    </asp:GridView>
</div>

</div>



</asp:Content>
