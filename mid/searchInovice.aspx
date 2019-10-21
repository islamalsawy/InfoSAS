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
                ShowFooter="True"
                DataKeyNames="">
                <Columns>
                <asp:BoundField DataField="RowNumber"  HeaderText="RowNumber" ReadOnly="true" SortExpression="RowNumber"/>  
 
                    <asp:TemplateField HeaderText="Itm_No" SortExpression="Itm_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Itm_No") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="label2" runat="server" Text='<%# Bind("Itm_No") %>'></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
         <asp:TextBox ID="txtInsertItm_No" runat="Server" OnTextChanged="txtInsertItm_No_TextChanged" AutoPostBack="true"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Loc_No" SortExpression="Loc_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Loc_No") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="TextBox5" runat="server" Text='<%# Bind("Loc_No") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="TextBox6" runat="Server"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Qty" SortExpression="Qty">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("Qty") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="label3" runat="server" Text='<%# Bind("Qty") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="TextBox9" runat="Server"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="taxp_Extra" SortExpression="taxp_Extra">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("taxp_Extra") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("taxp_Extra") %>'></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
         <asp:TextBox ID="TextBox10" runat="Server"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Itm_NmAr" SortExpression="Itm_NmAr">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("Itm_NmAr") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Itm_NmAr") %>'></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
                               <asp:DropDownList ID="drpInsertItm_NmAr" runat="Server" DataSourceID="SqlDataSource2" DataTextField="Itm_NmAr" DataValueField="Itm_No" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="drpInsertItm_NmAr_SelectedIndexChanged" />
                               <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:DefaultConnection2 %>' SelectCommand="SELECT [Itm_No], [Itm_NmAr] FROM [MtsItmmfs]"></asp:SqlDataSource>
                           </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Unit_NmAr" SortExpression="Unit_NmAr">
                        <EditItemTemplate>
                            <asp:DropDownList ID="drpEditUnit_NmAr" runat="server" Text='<%# Bind("Unit_NmAr") %>'></asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("Unit_NmAr") %>'></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
                               <asp:DropDownList ID="drpInsertUnit_NmAr" runat="Server" DataSourceID="SqlDataSource1" DataTextField="Unit_NmAr" DataValueField="Unit_No" />
                               <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:DefaultConnection2 %>' SelectCommand="SELECT [Unit_No], [Unit_NmAr] FROM [InvItmunit]"></asp:SqlDataSource>
                           </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="btnedit" runat="server" CommandName="Edit" Text="Edit" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="btnupdate" runat="server" CommandName="Update" Text="Update" />
                            <asp:LinkButton ID="btncancel" runat="server" CommandName="Cancel" Text="Cancel" />
                            <asp:LinkButton ID="btnDelete" runat="server" CommandName="Delete" Text="Delete" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="btnInsert" runat="Server" Text="Insert" CommandName="Insert" UseSubmitBehavior="False" />
                        </FooterTemplate>
                    </asp:TemplateField>      
                </Columns>


            </asp:GridView>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="AddNewRecord" />

           
        
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