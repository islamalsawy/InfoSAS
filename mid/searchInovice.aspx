<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="searchInovice.aspx.cs" Inherits="mid.searchInovice" EnableEventValidation="false"  %>

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
                            <asp:TextBox ID="dateSanad" runat="server" ></asp:TextBox>
                        </td>

                        <td>تاريخ السند هجري</td>
                        <td>
                            <asp:TextBox ID="dateSanadH" runat="server"></asp:TextBox></td>

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
            <asp:GridView ID="grdPurchasing" runat="server" AutoGenerateColumns="False" CellSpacing="1" CellPadding="2"  CssClass="Table table-bordered table-striped  table-hover"  ShowHeaderWhenEmpty="True"
                HeaderStyle-HorizontalAlign="Center"
                HeaderStyle-VerticalAlign="Middle"
                RowStyle-HorizontalAlign="Center"
                RowStyle-VerticalAlign="Middle"
                FooterStyle-HorizontalAlign="Center"
                FooterStyle-VerticalAlign="Middle"
                OnRowDataBound="grdPurchasing_RowDataBound"
                OnRowCommand="grdPurchasing_RowCommand"
                OnRowEditing="grdPurchasing_RowEditing"
                OnRowUpdating="grdPurchasing_RowUpdating"
                OnRowDeleting="grdPurchasing_RowDeleting"
                OnRowCancelingEdit="grdPurchasing_RowCancelingEdit"
                ShowFooter="True"
                DataKeyNames="Ln_No">
                <Columns>
                <asp:BoundField DataField="RowNumber"  HeaderText="م" ReadOnly="true" SortExpression="RowNumber" />  
 <asp:TemplateField>
     <ItemTemplate>
         <asp:Label ID="Ln_No" Visible="false"  runat="server" Text='<%# Bind("Ln_No") %>' Width="0px"></asp:Label>
     </ItemTemplate>
 </asp:TemplateField>

                    <asp:TemplateField HeaderText="رقم الصنف" SortExpression="Itm_No" HeaderStyle-Width="60px">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditItm_No" runat="server" Text='<%# Bind("Itm_No") %>' TextMode="Number" Width="60px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="label2" runat="server" Text='<%# Bind("Itm_No") %>' Width="60px"></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
         <asp:TextBox ID="txtInsertItm_No" runat="Server" OnTextChanged="txtInsertItm_No_TextChanged" AutoPostBack="true" TextMode="Number" Width="60px"/>
                         </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="اسم الصنف" SortExpression="Itm_NmAr" ItemStyle-Width="100px">
                        <EditItemTemplate>
                            <asp:DropDownList ID="drpEditItm_NmAr" runat="server" SelectedValue='<%# Bind("Itm_No") %>' DataSourceID="SqlDataSource3" DataTextField="Itm_NmAr" DataValueField="Itm_No" Width="125px" AutoPostBack="true" >
                            </asp:DropDownList>                            
                            <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:DefaultConnection2 %>' SelectCommand="SELECT [Itm_No], [Itm_NmAr] FROM [MtsItmmfs]"></asp:SqlDataSource>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Itm_NmAr") %>' Width="125px"></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
                               <asp:DropDownList ID="drpInsertItm_NmAr" runat="Server" DataSourceID="SqlDataSource2" DataTextField="Itm_NmAr" DataValueField="Itm_No" Width="125px" AutoPostBack="True" OnSelectedIndexChanged="drpInsertItm_NmAr_SelectedIndexChanged" AppendDataBoundItems="true">        <asp:ListItem Selected="True" Value="0">اختر صنفاً</asp:ListItem>
                               </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="revDdlMatch" runat="server" ControlToValidate="drpInsertItm_NmAr" InitialValue="0" ErrorMessage="اختر صنفاً" ForeColor="Red"></asp:RequiredFieldValidator>
                               <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:DefaultConnection2 %>' SelectCommand="SELECT [Itm_No], [Itm_NmAr] FROM [MtsItmmfs]"></asp:SqlDataSource>
                           </FooterTemplate>
                    </asp:TemplateField>

                    
                    <asp:TemplateField HeaderText="الوحدة" SortExpression="Unit_NmAr">
                        <EditItemTemplate>
                            <asp:DropDownList ID="drpEditUnit_NmAr" runat="server" SelectedItem='<%# Bind("Unit_NmAr") %>'  DataSourceID="SqlDataSource4" DataTextField="Unit_NmAr" DataValueField="Unit_No" Width="45px"></asp:DropDownList>
                            <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:DefaultConnection2 %>' SelectCommand="SELECT [Unit_No], [Unit_NmAr] FROM [ItmsUnit]"></asp:SqlDataSource>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("Unit_NmAr") %>' Width="30px"></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
                               <asp:DropDownList ID="drpInsertUnit_NmAr" runat="Server" DataSourceID="SqlDataSource1" DataTextField="Unit_NmAr" DataValueField="Unit_No" Width="40px" />
                               <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:DefaultConnection2 %>' SelectCommand="SELECT [Unit_No], [Unit_NmAr] FROM [InvItmunit]"></asp:SqlDataSource>     
                  </FooterTemplate>                   
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="الموقع" SortExpression="Loc_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditLoc_No" runat="server" Text='<%# Bind("Loc_No") %>' TextMode="Number" Width="20px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="TextBox5" runat="server" Text='<%# Bind("Loc_No") %>'  Width="30px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="TextBox6" runat="Server" TextMode="Number"  Width="30px"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="الكمية" SortExpression="Qty">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditQty" runat="server" Text='<%# Bind("Qty") %>' TextMode="Number"  Width="35px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="label3" runat="server" Text='<%# Bind("Qty") %>' Width="35px" ></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="TextBox9" runat="Server" TextMode="Number" Width="30px"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="سعر شراء الوحدة" SortExpression="Itm_Pur">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtItm_Pur" runat="server" Text='<%# Bind("Itm_Pur") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblItm_Pur" runat="server" Text='<%# Bind("Itm_Pur") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="txtItm_PurFooter" runat="Server" TextMode="Number" Width="40px"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="القيمة الإجمالية" SortExpression="Titm_Pur">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTitm_Pur" runat="server" Text='<%# Bind("Titm_Pur") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTitm_Pur" runat="server" Text='<%# Bind("Titm_Pur") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="txtTitm_PurFooter" runat="Server" TextMode="Number" Width="40px"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                          <asp:TemplateField HeaderText="تاريخ الصلاحية" SortExpression="Exp_Date">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtExp_Date" runat="server" Text='<%# Bind("Exp_Date") %>' placeholder="يوم/سنة" Width="45px"></asp:TextBox>
                            <asp:RegularExpressionValidator runat="server" ControlToValidate="txtExp_Date"  ValidationExpression="(0[1-9]|1[012])[/]\d{4}"  SetFocusOnError="true">
                       </asp:RegularExpressionValidator >
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblExp_Date" runat="server" Text='<%# Bind("Exp_Date") %>' Width="45px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Exp_DateFooter" runat="Server" placeholder="يوم/سنة" Width="45px"/> 
                              <asp:RegularExpressionValidator runat="server" ControlToValidate="Exp_DateFooter"  ValidationExpression="(0[1-9]|1[012])[/]\d{4}"  SetFocusOnError="true">
                       </asp:RegularExpressionValidator >
                         </FooterTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="رقم التشغيلة" SortExpression="Batch_No">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBatch_No" runat="server" Text='<%# Bind("Batch_No") %>' Width="30px" ></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblBatch_No" runat="server" Text='<%# Bind("Batch_No") %>' Width="35px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Batch_NoFooter" runat="Server" Width="35px" />                      </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="نسبة خصم 1 %" SortExpression="Disc1_Prct">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDisc1_Prct" runat="server" Text='<%# Bind("Disc1_Prct") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDisc1_Prct" runat="server" Text='<%# Bind("Disc1_Prct") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Disc1_PrctFooter" runat="Server" TextMode="Number" Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>

                   
                      <asp:TemplateField HeaderText="قيمة الخصم" SortExpression="Disc1_Val">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDisc1_Val" runat="server" Text='<%# Bind("Disc1_Val") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDisc1_Val" runat="server" Text='<%# Bind("Disc1_Val") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Disc1_ValFooter" runat="Server" TextMode="Number" Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="نسبة خصم 2 %" SortExpression="Disc2_Prct">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDisc2_Prct" runat="server" Text='<%# Bind("Disc2_Prct") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblDisc2_Prct" runat="server" Text='<%# Bind("Disc2_Prct") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Disc2_PrctFooter" runat="Server" TextMode="Number" Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="نسبة بونص شراء 1 %" SortExpression="BonusPur_Prct">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBonusPur_Prct" runat="server" Text='<%# Bind("BonusPur_Prct") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblBonusPur_Prct" runat="server" Text='<%# Bind("BonusPur_Prct") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="BonusPur_PrctFooter" runat="Server" TextMode="Number" Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="كمية بونص الشراء" SortExpression="BonusPur_Qty">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBonusPur_Qty" runat="server" Text='<%# Bind("BonusPur_Qty") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblBonusPur_Qty" runat="server" Text='<%# Bind("BonusPur_Qty") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="BonusPur_QtyFooter" runat="Server" TextMode="Number" Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="سعر البيع" SortExpression="Itm_Sal">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtItm_Sal" runat="server" Text='<%# Bind("Itm_Sal") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblItm_Sal" runat="server" Text='<%# Bind("Itm_Sal") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Itm_SalFooter" runat="Server" TextMode="Number" Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="قيمة البيع" SortExpression="Titm_Sal">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTitm_Sal" runat="server" Text='<%# Bind("Titm_Sal") %>' TextMode="Number" Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTitm_Sal" runat="server" Text='<%# Bind("Titm_Sal") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Titm_SalFooter" runat="Server" TextMode="Number" Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="تكلفة الصنف" SortExpression="Titm_Cost">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTitm_Cost" runat="server" Text='<%# Bind("Titm_Cost") %>' TextMode="Number"  Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblTitm_Cost" runat="server" Text='<%# Bind("Titm_Cost") %>'  Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Titm_CostFooter" runat="Server" TextMode="Number"  Width="40px"/>
                        </FooterTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="تكلفة الوحدة" SortExpression="Itm_Cost">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtItm_Cost" runat="server" Text='<%# Bind("Itm_Cost") %>' TextMode="Number"  Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblItm_Cost" runat="server" Text='<%# Bind("Itm_Cost") %>'  Width="40px"></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
         <asp:TextBox ID="Itm_CostFooter" runat="Server" TextMode="Number"  Width="40px"/>                      </FooterTemplate>
                    </asp:TemplateField>



                    <asp:TemplateField HeaderText="ضريبة % " SortExpression="taxp_Extra">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEditTaxp_Extra" runat="server" Text='<%# Bind("taxp_Extra") %>' Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("taxp_Extra") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
         <asp:TextBox ID="TextBox10" runat="Server" Width="40px"/>               
                         </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText=" قيمة الضريبة " SortExpression="taxv_Extra">
                        <EditItemTemplate>
                            <asp:TextBox ID="taxv_Extra_Extra" runat="server" Text='<%# Bind("taxv_Extra") %>' Width="40px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbltaxv_Extra" runat="server" Text='<%# Bind("taxv_Extra") %>' Width="40px"></asp:Label>
                        </ItemTemplate>
                           <FooterTemplate>
         <asp:TextBox ID="taxv_ExtraFooter" runat="Server" Width="40px"/>               
                         </FooterTemplate>
                    </asp:TemplateField>



                   


                    <asp:TemplateField HeaderText="تعديل">
                        <ItemTemplate >
                            <asp:ImageButton ID="btnedit" runat="server" CommandName="Edit" Text="Edit"  ImageUrl="~/wp-content/image/84380.png" Width="20px" Height="20px" ToolTip="تعديل" AlternateText="تعديل" CausesValidation="false" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ID="btnupdate" runat="server" CommandName="Update" Text="Update" ImageUrl="~/wp-content/image/save.png" Width="20px" Height="20px" ToolTip="تحديث" AlternateText="تحديث" CausesValidation="false"/>
                            <asp:ImageButton ID="btncancel" runat="server" CommandName="Cancel" Text="Cancel" ImageUrl="~/wp-content/image/cancel-solid-icon-614x460.png" Width="30px" Height="30px" ToolTip="الغاء" AlternateText="الغاء" CausesValidation="false"/>
                            <asp:ImageButton ID="btnDelete" runat="server" CommandName="Delete" Text="Delete" ImageUrl="~/wp-content/image/DeleteDustbin-512.png" Width="20px" Height="20px" ToolTip="حذف" AlternateText="حذف" CausesValidation="false" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ID="btnInsert" runat="Server" Text="Insert" CommandName="Insert" UseSubmitBehavior="False" ImageUrl="~/wp-content/image/new_artboard_file_create_post-512.png" Width="20px" Height="20px" ToolTip="ادخال" AlternateText="ادخال" />
                        </FooterTemplate> 
                        
                    </asp:TemplateField>
         
                    <asp:TemplateField>
                        <HeaderTemplate> <asp:ImageButton ID="btnAdd" runat="server" Text="Add" OnClick="AddNewRecord"  ImageUrl="~/wp-content/image/add-logo.png" Width="30px" Height="20px" ToolTip="اضافة صف جديد" AlternateText="اضافة صف جديد" /></HeaderTemplate>
                         
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
                        <asp:Button ID="btnSave" runat="server" Text="تحديث"  CssClass="btn btn-primary" style="border: 1px solid transparent;
    padding: 0.375rem 0.75rem;" OnClick="btnSave_Click"/>
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