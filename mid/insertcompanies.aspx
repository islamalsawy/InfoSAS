<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insertcompanies.aspx.cs" Inherits="mid.insertcompanies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="content-wrapper">
        
    <section class="content">
      <div class="row">
        <div class="col-xs-12">
          <div class="box">
            <div class="box-header">
              <h3 class="box-title"></h3>
            </div>
            <!-- /.box-header -->
              <div style="margin-right:35px">



            <div class="box-body">
              <table id="example2" class="table table-bordered table-hover">
                <thead>
              
                </thead>
                <tbody>
              <tr>
        <td>
            company no
        </td>
          <td>
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          </td>
        <td>الرقم الضريبى</td>
          <td>
              <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
          </td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>main company name</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td>cashier printed spc</td>
        <td>
            <asp:CheckBox ID="CheckBox1" runat="server" /></td>
    </tr>
      <tr>
        <td>sub company name</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td>sales invoice spc</td>
        <td>
            <asp:CheckBox ID="CheckBox2" runat="server" /></td>
    </tr>
      <tr>
        <td>company adress</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td>purchase invoice spc</td>
        <td>
            <asp:CheckBox ID="CheckBox3" runat="server" /></td>
    </tr>
      <tr>
        <td>E-mail</td>
        <td>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
        <td>inventorey spc</td>
        <td>
            <asp:CheckBox ID="CheckBox4" runat="server" /></td>
    </tr>
      <tr>
        <td>Tel no</td>
        <td>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
        <td>recipt-payment voucher</td>
        <td>
            <asp:CheckBox ID="CheckBox5" runat="server" /></td>
    </tr>
      <tr>
        <td>Fax no</td>
        <td>
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
        <td>issue store recipt voucher</td>
        <td>
            <asp:CheckBox ID="CheckBox6" runat="server" /></td>
    </tr>
      <tr>
        <td>branch</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
        <td>issue delivery note voucher</td>
        <td>
            <asp:CheckBox ID="CheckBox7" runat="server" /></td>
    </tr>
      <tr>
        <td></td>
        <td>
        <td>Issue sales invoice before dn</td>
        <td>
            <asp:CheckBox ID="CheckBox8" runat="server" /></td>
    </tr>
      <tr>
        <td>اعداد سند القبض اليا بالمبيعات النقديه</td>
        <td>
            <asp:CheckBox ID="CheckBox9" runat="server" /></td>
        <td>issue purchase invoice before srv</td>
        <td>
            <asp:CheckBox ID="CheckBox10" runat="server" /></td>
    </tr>
      <tr>
        <td>اعداد سند الصرف اليا بالمشتريات النقديه</td>
        <td>
            <asp:CheckBox ID="CheckBox11" runat="server" /></td>
        <td>delivery note with out cost</td>
        <td>
            <asp:CheckBox ID="CheckBox12" runat="server" /></td>
    </tr>
      <tr>
        <td>تسلسل قيود اليوميه اليا حسب الشهر</td>
        <td>
            <asp:CheckBox ID="CheckBox13" runat="server" /></td>
        <td>srv with out cost</td>
        <td>
            <asp:CheckBox ID="CheckBox14" runat="server" /></td>
    </tr>
        <tr>
        <td>ترحيل صافى المبيعات للحسابات</td>
        <td>
            <asp:CheckBox ID="CheckBox15" runat="server" /></td>
        <td>item search by reference no</td>
        <td>
            <asp:CheckBox ID="CheckBox16" runat="server" /></td>
    </tr>
          <tr>
        <td>transaction by hiridate</td>
        <td>
            <asp:CheckBox ID="CheckBox17" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="clear" OnClick="Button2_Click" />
        </td>
        <td></td>
        <td></td>
    </tr>--
 
                </tfoot>
              </table>
            </div>
                  </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

          
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
      
</div>
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     <%--<table>
    <tr>
        <td>
            company no
        </td>
          <td>
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
          </td>
        <td>الرقم الضريبى</td>
          <td>
              <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
          </td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>main company name</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td>cashier printed spc</td>
        <td>
            <asp:CheckBox ID="CheckBox1" runat="server" /></td>
    </tr>
      <tr>
        <td>sub company name</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td>sales invoice spc</td>
        <td>
            <asp:CheckBox ID="CheckBox2" runat="server" /></td>
    </tr>
      <tr>
        <td>company adress</td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
        <td>purchase invoice spc</td>
        <td>
            <asp:CheckBox ID="CheckBox3" runat="server" /></td>
    </tr>
      <tr>
        <td>E-mail</td>
        <td>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
        <td>inventorey spc</td>
        <td>
            <asp:CheckBox ID="CheckBox4" runat="server" /></td>
    </tr>
      <tr>
        <td>Tel no</td>
        <td>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
        <td>recipt-payment voucher</td>
        <td>
            <asp:CheckBox ID="CheckBox5" runat="server" /></td>
    </tr>
      <tr>
        <td>Fax no</td>
        <td>
            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
        <td>issue store recipt voucher</td>
        <td>
            <asp:CheckBox ID="CheckBox6" runat="server" /></td>
    </tr>
      <tr>
        <td>branch</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
        <td>issue delivery note voucher</td>
        <td>
            <asp:CheckBox ID="CheckBox7" runat="server" /></td>
    </tr>
      <tr>
        <td></td>
        <td>
        <td>Issue sales invoice before dn</td>
        <td>
            <asp:CheckBox ID="CheckBox8" runat="server" /></td>
    </tr>
      <tr>
        <td>اعداد سند القبض اليا بالمبيعات النقديه</td>
        <td>
            <asp:CheckBox ID="CheckBox9" runat="server" /></td>
        <td>issue purchase invoice before srv</td>
        <td>
            <asp:CheckBox ID="CheckBox10" runat="server" /></td>
    </tr>
      <tr>
        <td>اعداد سند الصرف اليا بالمشتريات النقديه</td>
        <td>
            <asp:CheckBox ID="CheckBox11" runat="server" /></td>
        <td>delivery note with out cost</td>
        <td>
            <asp:CheckBox ID="CheckBox12" runat="server" /></td>
    </tr>
      <tr>
        <td>تسلسل قيود اليوميه اليا حسب الشهر</td>
        <td>
            <asp:CheckBox ID="CheckBox13" runat="server" /></td>
        <td>srv with out cost</td>
        <td>
            <asp:CheckBox ID="CheckBox14" runat="server" /></td>
    </tr>
        <tr>
        <td>ترحيل صافى المبيعات للحسابات</td>
        <td>
            <asp:CheckBox ID="CheckBox15" runat="server" /></td>
        <td>item search by reference no</td>
        <td>
            <asp:CheckBox ID="CheckBox16" runat="server" /></td>
    </tr>
          <tr>
        <td>transaction by hiridate</td>
        <td>
            <asp:CheckBox ID="CheckBox17" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" Text="clear" OnClick="Button2_Click" />
        </td>
        <td></td>
        <td></td>
    </tr>--%>
</table>






</asp:Content>
