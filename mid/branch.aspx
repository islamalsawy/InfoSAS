<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="branch.aspx.cs" Inherits="mid.branch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float:left; width:5%">
   
    </div>



    
    
     

        <div style="float:left; width:100%;margin-right:30px;">

    <table  class="grid" >
<tr>
    <td>    <asp:Label ID="Label1" runat="server" Text="رقم الفرع"></asp:Label> 
</td>
    <td>    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
</td>
    <td>    <asp:Button ID="Button1" runat="server" Text="بحث" OnClick="Button1_Click" />
</td>
    <td>
        <asp:Button ID="Button2" runat="server" Text="إدخال" OnClick="Button2_Click" /></td>
</tr>

    </table>

    <asp:GridView ID="GridView1"     GridLines="None"
    CssClass="grid" runat="server" Font-Size="12px" BackColor="White" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="رقم_الفرع" DataNavigateUrlFormatString="updatebranches.aspx?Brn_No={0}" HeaderText="تعديل" NavigateUrl="~/updatebranches.aspx" Text="تعديل" />
            <asp:HyperLinkField DataNavigateUrlFields="رقم_الفرع,إسم_الفرع" DataNavigateUrlFormatString="deletebranch.aspx?no={0}&amp;nm={1}" HeaderText="حذف" NavigateUrl="~/deletebranch.aspx" Text="حذف" />
        </Columns>
    </asp:GridView>

    </div>

</asp:Content>
