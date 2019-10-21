<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="searchInovice.aspx.cs" Inherits="mid.searchInovice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<!DOCTYPE html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link href="Content/StyleSheet.css" type="text/css" rel="stylesheet" />
    </head>
    <body>
        <div>
            <div>
                <table class="table">
                    <tr>
                        <td>الفرع</td>
                        <td>
                            <asp:DropDownList ID="drpBranch" runat="server"></asp:DropDownList></td>

                        <td>سند الادخال</td>
                        <td>
                            <asp:TextBox ID="txtSanad" runat="server" TextMode="Number" required="true" 
                       AutoPostBack="true"         OnTextChanged="txtSanad_TextChanged"></asp:TextBox>

                        </td>

                        <td>تاريخ السند</td>
                        <td>
                            <asp:TextBox ID="dateSanad" runat="server" TextMode="Date"></asp:TextBox>
                        </td>

                        <td>تاريخ السند هجري</td>
                        <td>
                            <asp:TextBox ID="dateSanadH" runat="server" TextMode="Date"></asp:TextBox></td>

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

        <div style="top: 0; bottom: 0; left: 0; right: 0; margin: auto; overflow: scroll; width: 1000px; height: 220px">
            <asp:GridView ID="grdPurchasing" runat="server" AutoGenerateColumns="False" CellSpacing="5" CellPadding="6" CssClass="Table table-bordered table-striped  table-hover" AllowSorting="True" ShowHeaderWhenEmpty="True"
                OnRowDataBound="grdPurchasing_RowDataBound"
                OnRowCommand="grdPurchasing_RowCommand"
                ShowFooter="True">
                <Columns>
                <asp:BoundField DataField="RowNumber"  HeaderText="RowNumber" ReadOnly="true" SortExpression="RowNumber"/>  
      
                    <asp:TemplateField HeaderText="Doc_No" SortExpression="Doc_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Doc_No") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Doc_No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ln_No" SortExpression="Ln_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Ln_No") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ln_No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Itm_No" SortExpression="Itm_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Itm_No") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Itm_No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Loc_No" SortExpression="Loc_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Loc_No") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Loc_No") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Qty" SortExpression="Qty">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Qty") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="taxp_Extra" SortExpression="taxp_Extra">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("taxp_Extra") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("taxp_Extra") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Itm_NmAr" SortExpression="Itm_NmAr">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("Itm_NmAr") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("Itm_NmAr") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Unit_NmAr" SortExpression="Unit_NmAr">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("Unit_NmAr") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("Unit_NmAr") %>'></asp:Label>
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
                        <asp:Button ID="btnSave" runat="server" Text="حفظ"  CssClass="btn btn-primary" style="border: 1px solid transparent;
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

    </html>

</asp:Content>