<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="insertbranch.aspx.cs" Inherits="mid.insertbranch" %>
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
                <tr>
                  <th>بيانات الفروع</th>
               
                </tr>
                </thead>
                <tbody>
              <tr>
       
        <td>اسم الفرع</td>
        <td>


            <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>



        </td>
   <td>رقم الفرع</td>
       <td>
           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       </td>
          </tr>
        <tr>
        <td>العنوان</td>
        <td>
            <asp:TextBox ID="TextBox3"  runat="server"></asp:TextBox></td>
        <td>البريد الالكترونى</td>
        <td>
            <asp:TextBox ID="TextBox4"   runat="server"></asp:TextBox></td>
    </tr>
        <tr>
        <td>تليفون</td>
        <td>
            <asp:TextBox ID="TextBox5"    runat="server"></asp:TextBox></td>
        <td>الشركه</td>
        <td>


            <asp:DropDownList ID="DropDownList2" runat="server" ></asp:DropDownList>


        </td>
    </tr>
        <tr>
        <td>الضريبه المضافه مصروفات</td>
        <td>
            <asp:TextBox ID="TextBox6"  runat="server"></asp:TextBox>

        <td>الضريبه المضافه ايرادات</td>
        <td>
            <asp:TextBox ID="TextBox7"    runat="server"></asp:TextBox></td>
    </tr>
   

        <tr>
            <td>مبيعات اجله</td>
             <td>
                 <asp:TextBox ID="TextBox8"   runat="server"></asp:TextBox></td>
             <td>مرتجع المبيعات</td>
             <td>
                 <asp:TextBox ID="TextBox9"   runat="server"></asp:TextBox></td>
            
             </tr>
        <tr>
            
            
             <td>حساب الصندوق </td>
             <td>
                 <asp:TextBox ID="TextBox10"   runat="server"></asp:TextBox></td>
             <td>محاسبة عملاء</td>
             <td>
                 <asp:TextBox ID="TextBox11"   runat="server"></asp:TextBox></td>
        </tr>
           <tr>
            <td>خصم نقدى مسموح</td>
             <td>
                 <asp:TextBox ID="TextBox12"   runat="server"></asp:TextBox></td>
             <td>مبيعات نقديه</td>
             <td>
                 <asp:TextBox ID="TextBox13"   runat="server"></asp:TextBox></td>
            </tr>
               <tr>
                <td>محاسبة موردين</td>
             <td>
                 <asp:TextBox ID="TextBox14"   runat="server"></asp:TextBox></td>
             <td>مشتريات اجله</td>
             <td>
                 <asp:TextBox ID="TextBox15"   runat="server"></asp:TextBox></td>
        </tr>
           <tr>
            <td>مرتجع مبيعات</td>
             <td>
                 <asp:TextBox ID="TextBox16"   runat="server"></asp:TextBox></td>
             <td>خصم نقدى مسموح</td>
             <td>
                 <asp:TextBox ID="TextBox17"  runat="server"></asp:TextBox></td>
            </tr>
        <tr>
             <td>مرتجع مشتريات</td>
             <td>
                 <asp:TextBox ID="TextBox18"   runat="server"></asp:TextBox></td>
             <td>cash purchase</td>
             <td>
                 <asp:TextBox ID="TextBox19"   runat="server"></asp:TextBox></td>
        </tr>
           <tr>
            <td>تكلفة المبيعات</td>
             <td>
                 <asp:TextBox ID="TextBox20"    runat="server"></asp:TextBox></td>
             <td>المخزون بالتكلفه</td>
             <td>
                 <asp:TextBox ID="TextBox21"    runat="server"></asp:TextBox></td>
             </tr>
               <tr>
                <td>خصم نقدى</td>
             <td>
                 <asp:TextBox ID="TextBox22"   runat="server"></asp:TextBox></td>
             <td>المخزون تحت التشغيل</td>
             <td>
                 <asp:TextBox ID="TextBox23"   runat="server"></asp:TextBox></td>
        </tr>
           <tr>
            <td>ارباح غير محققه</td>
             <td>
                 <asp:TextBox ID="TextBox24"   runat="server"></asp:TextBox></td>
            
             <td>مخزون المواد الخام</td>
             <td>
                 <asp:TextBox ID="TextBox25"   runat="server"></asp:TextBox></td>
            
                </tr>
               <tr>
                <td>مخزون الانتاج التام</td>
             <td>
                 <asp:TextBox ID="TextBox26"   runat="server"></asp:TextBox></td>
        <td></td>
          <td>
              <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" />
          </td>
               
               </tr>
        
              
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
       


</asp:Content>
