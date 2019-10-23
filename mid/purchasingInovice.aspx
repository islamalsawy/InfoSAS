<%--Islam 7-10-2019--%>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="purchasingInovice.aspx.cs" Inherits="mid.purchasingInovice" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  
<!DOCTYPE html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="Content/StyleSheet.css" type="text/css" rel="stylesheet" />
         <Style>
    input[type=number]::-webkit-inner-spin-button, input[type=month]::-webkit-inner-spin-button {
        -webkit-appearance: none;
         display: none;
         }
    </style>
    <script type="text/javascript">
        var control = document.getElementById("txtSanad");
        control.disabled = true;
     
    </script>
    </head>
    <body>
        <div>
            <div>
                <table class="table" id="data">
                    <tr>
                        <td>الفرع</td>
                        <td>
                            <asp:DropDownList ID="drpBranch" runat="server" AutoPostBack="true"                   OnPreRender="drpBranch_PreRender">
                            </asp:DropDownList></td>

                        <td>سند الادخال</td>
                        <td>
                            <asp:TextBox ID="txtSanad" runat="server"  Enabled="false" TextMode="Number" required="true" AutoPostBack="true"></asp:TextBox>

                        </td>

                        <td>تاريخ السند</td>
                        <td>
                            <asp:TextBox ID="dateSanad" runat="server"></asp:TextBox>
                          
                        </td>
                        
                        <td>تاريخ السند هجري</td>
                        <td>
                            <asp:TextBox ID="dateSanadH" runat="server" ></asp:TextBox></td>

                        <td>الدفع</td>
                        <td>
                            <asp:DropDownList ID="drpPayment" runat="server"></asp:DropDownList></td>
                    </tr>

                    <tr>
                        <td>العملة</td>
                        <td>
                            <asp:DropDownList ID="drpCurrency" runat="server"></asp:DropDownList></td>
                        <td>معدل الصرف</td>
                        <td>
                            <asp:TextBox ID="txtRate" runat="server"></asp:TextBox></td>
                        <td>المورد</td>
                        <td>
                            <asp:DropDownList ID="drpSuppliers" runat="server"></asp:DropDownList></td>
                    </tr>

                    <tr>

                        <td>المستلم للبضاعة</td>
                        <td>
                            <asp:DropDownList ID="drpReceiver" runat="server"></asp:DropDownList></td>

                        <td>مرجع المورد</td>
                        <td>
                            <asp:TextBox ID="txtResoures" runat="server"></asp:TextBox></td>

                        <td>فاتورة المورد</td>
                        <td>
                            <asp:TextBox ID="txtBill" runat="server"></asp:TextBox></td>

                        <td>تاريخ الاستلام</td>
                        <td>
                            <asp:TextBox ID="dateRecieving" runat="server" TextMode="Date"></asp:TextBox></td>

                        <td>تاريخ الاستحقاق</td>
                        <td>
                            <asp:TextBox ID="dateDue" runat="server" TextMode="Date"></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td>مدة السداد</td>
                        <td>
                            <asp:TextBox ID="txtPeriod" runat="server"></asp:TextBox></td>
                        <td>ملاحظات</td>
                        <td>
                            <asp:TextBox ID="txtNotice" runat="server"></asp:TextBox></td>

                        <td>نوع المرجع</td>
                        <td>
                            <asp:DropDownList ID="drpReferenceType" runat="server"></asp:DropDownList></td>

                        <td>رقم المرجع</td>
                        <td>
                            <asp:DropDownList ID="drpReferenceNumber" runat="server"></asp:DropDownList></td>

                    </tr>
                </table>
            </div>
        </div>

        <div style="top: 0; bottom: 0; left: 0; right: 0; margin: auto; overflow: scroll; width: 1100px; height: 220px">
            <asp:GridView ID="grdPurchasing" runat="server" AutoGenerateColumns="False" CellSpacing="1" CellPadding="2"  CssClass="Table table-bordered table-striped  table-hover" AllowPaging="True" AllowSorting="True" ShowHeaderWhenEmpty="true"
                OnRowDataBound="grdPurchasing_RowDataBound"
                ShowFooter="true"
                HeaderStyle-HorizontalAlign="Center"
                HeaderStyle-VerticalAlign="Middle"
                RowStyle-HorizontalAlign="Center"
                RowStyle-VerticalAlign="Middle"
           
                >

                <Columns>
                    <%--       <asp:TemplateField HeaderText="م" >
                            <ItemTemplate >
                                <%# Container.DataItemIndex + 1 %>
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                    <asp:BoundField DataField="RowNumber"  HeaderText="م" />

                    <asp:TemplateField HeaderText="رقم الصنف">
                        <ItemTemplate>

                            <asp:TextBox ID="txtGrdItemNo" runat="server" Width="60px" AutoPostBack="true" OnTextChanged="drpGrdItemNo_TextChanged" TextMode="Number" Required="true" ></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="اسم الصنف">
                        <ItemTemplate>
                            <asp:DropDownList ID="drpItem" runat="server" AutoPostBack="true" Width="140px" OnSelectedIndexChanged="drpItem_SelectedIndexChanged">
                            </asp:DropDownList>

                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="الوحدة">
                        <ItemTemplate>
                            <asp:DropDownList ID="drpUnit" runat="server" AutoPostBack="false"  Width="40px">
                            </asp:DropDownList>                     
                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="رقم الموقع">
                        <ItemTemplate>
                            <asp:TextBox ID="txtSitNo" runat="server" Width="40px" TextMode="Number" Required="true">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="الكمية">
                        <ItemTemplate>
                            <asp:TextBox ID="txtQuantity" runat="server" Width="40px" TextMode="Number" Required="true">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="سعر شراء الوحدة">
                        <ItemTemplate>
                            <asp:TextBox ID="txtUnitPrice" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="القيمة الإجمالية">
                        <ItemTemplate>
                            <asp:TextBox ID="txtTotalPrice" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="تاريخ الصلاحية">
                        <ItemTemplate>
                        <asp:TextBox runat="server" ID="txtVaildDate" Width="60px" placeholder="يوم/سنة" >
                        </asp:TextBox>
                       <asp:RegularExpressionValidator runat="server" ControlToValidate="txtVaildDate"  ValidationExpression="(0[1-9]|1[012])[/]\d{4}"  SetFocusOnError="true">
                       </asp:RegularExpressionValidator >
                    
                     </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="رقم التشغيلة">
                        <ItemTemplate>
                            <asp:TextBox ID="txtBatch_No" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>



                    <asp:TemplateField HeaderText=" خصم 1 شراء %">
                        <ItemTemplate>
                            <asp:TextBox ID="txtDiscountPur1" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="قيمة الخصم">
                        <ItemTemplate>
                            <asp:TextBox ID="txtDiscountQuantity" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="خصم 2 شراء %">
                        <ItemTemplate>
                            <asp:TextBox ID="txtDiscountPur2" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="بونص % شراء">
                        <ItemTemplate>
                            <asp:TextBox ID="txtBonusPur" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="بونص كمية">
                        <ItemTemplate>
                            <asp:TextBox ID="txtBonusQuantity" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="سعر البيع">
                        <ItemTemplate>
                            <asp:TextBox ID="txtSalePrice" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="قيمة البيع">
                        <ItemTemplate>
                            <asp:TextBox ID="txtSaleQuantity" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="تكلفة الوحدة">
                        <ItemTemplate>
                            <asp:TextBox ID="txtUnitCost" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="تكلفة الصنف">
                        <ItemTemplate>
                            <asp:TextBox ID="txtItemPrice" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="الضريبة %">
                        <ItemTemplate>
                            <asp:TextBox ID="txtTax" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="قيمة الضريبة">
                        <ItemTemplate>
                            <asp:TextBox ID="txtTaxQuantity" runat="server" Width="40px" TextMode="Number">

                            </asp:TextBox>
                        </ItemTemplate>
                        <FooterStyle HorizontalAlign="Center" />
                        <FooterTemplate>
                            <asp:ImageButton ID="ButtonAdd" runat="server"
                                Text="أضف صنف جديد"
                                OnClick="ButtonAdd_Click"
                     CausesValidation="False" Height="30px" Width="30px" ImageUrl="~/wp-content/image/add-logo.png" ToolTip="أضف صف جديد" AlternateText="أضف صف جديد"/>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="حذف">
                        <ItemTemplate>
                            <asp:ImageButton ID="LinkDelete" runat="server"
                                OnClick="LinkDelete_Click" ImageUrl="~/wp-content/image/DeleteDustbin-512.png" Width="20px" Height="20px" ToolTip="حذف" AlternateText="حذف"></asp:ImageButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div style="margin: 10px">
            <table class="table " style="width: 400px; height: 50px;">
                <tr>
                    <td>الاجمالي</td>
                    <td>
                        <asp:TextBox ID="txtTotalPriceFooter" runat="server"></asp:TextBox></td>

                    <td>بعد الخصم</td>
                    <td>
                        <asp:TextBox ID="txtAfterDiscountFooter" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>خصم اصناف</td>
                    <td>
                        <asp:TextBox ID="txtDiscountItemsFooter" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtDiscountItems2Footer" runat="server"></asp:TextBox>
                    </td>
                    <td>الضرائب</td>
                    <td>
                        <asp:TextBox ID="txtTaxFooter" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>خصم اضافي</td>
                    <td>
                        <asp:TextBox ID="txtAdditionalDiscountFooter" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtAdditionalDiscount2Footer" runat="server"></asp:TextBox>
                    </td>
                    <td>الصافي</td>
                    <td>
                        <asp:TextBox ID="txtNetFooter" runat="server"></asp:TextBox></td>
                    <td>قيمة البونص</td>
                    <td>
                        <asp:TextBox ID="txtBonusQuantityFooter" runat="server"></asp:TextBox></td>
                    <td>بضاعة بسعر</td>
                    <td>
                        <asp:TextBox ID="txtGoodsPriceFooter" runat="server"></asp:TextBox></td>
                </tr>
            </table>
                   <div class="modal-footer">
            <table class="table" style= "width:250px;padding:0;margin:auto">
                <tr>   
                    <td> 
                        <asp:Button ID="btnSave" runat="server" Text="حفظ" OnClick="btnSave_Click" CssClass="btn btn-primary" style="border: 1px solid transparent;
    padding: 0.375rem 0.75rem;"/>
                    </td>
                    <td>
                        <asp:Button ID="btnCancel" runat="server" Text="الغاء"  CssClass="btn btn-primary" style="background-color:firebrick;border: 1px solid transparent;
    padding: 0.375rem 0.75rem;"/>   
                        
                    </td>
                   
                </tr>
            </table>
        </div>
        </div>

 
    </body>

 

</asp:Content>
