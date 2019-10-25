using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace mid
{
    public partial class searchInovice : System.Web.UI.Page
    {
        ICDBTrdAEntities DB = new ICDBTrdAEntities();
        DataTable dt = new DataTable();
    
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {

                //Islam 8-10-2019
               

                drpBranch.DataValueField = "Brn_No";
                drpBranch.DataTextField = "Brn_NmAr";
                drpBranch.DataSource = DB.MainBranch.ToList();
                drpBranch.DataBind();

                drpPayment.DataValueField = "Pym_No";
                drpPayment.DataTextField = "Pym_Nmar";
                drpPayment.DataSource = DB.InvAstPymwys.ToList();
                drpPayment.DataBind();

                drpCurrency.DataValueField = "Curncy_No";
                drpCurrency.DataTextField = "Curncy_Nmar";
                drpCurrency.DataSource = DB.InvAstCurncy.ToList();
                drpCurrency.DataBind();

                drpSuppliers.DataValueField = "Sup_No";
                drpSuppliers.DataTextField = "Sup_NmAr";
                drpSuppliers.DataSource = DB.MtsSuplir.ToList();
                drpSuppliers.DataBind();

                drpReceiver.DataValueField = "Brn_No";
                drpReceiver.DataTextField = "Brn_NmAr";
                drpReceiver.DataSource = DB.MainBranch.ToList();
                drpReceiver.DataBind();

               
             

               // dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
               // dt.Columns.Add(new DataColumn("Column1", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column2", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column3", typeof(string)));//for DropDownList selected item 
               // dt.Columns.Add(new DataColumn("Column4", typeof(string)));//for DropDownList 
               // dt.Columns.Add(new DataColumn("Column5", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column6", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column7", typeof(string)));//for DropDownList selected item 
               // dt.Columns.Add(new DataColumn("Column8", typeof(string)));//for DropDownList      
               // dt.Columns.Add(new DataColumn("Column9", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column10", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column11", typeof(string)));//for DropDownList selected item 
               // dt.Columns.Add(new DataColumn("Column12", typeof(string)));//for DropDownList 
               // dt.Columns.Add(new DataColumn("Column13", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column14", typeof(string)));//for DropDownList selected item 
               // dt.Columns.Add(new DataColumn("Column15", typeof(string)));//for DropDownList      
               // dt.Columns.Add(new DataColumn("Column16", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column17", typeof(string)));//for TextBox value 
               // dt.Columns.Add(new DataColumn("Column18", typeof(string)));//for DropDownList selected item 
               // dt.Columns.Add(new DataColumn("Column19", typeof(string)));//for DropDownList 

               // dr = dt.NewRow();
               // dr["RowNumber"] = 1;
               // dr["Column1"] = string.Empty;
               // dr["Column4"] = string.Empty;
               // dr["Column5"] = string.Empty;
               // dr["Column6"] = string.Empty;
               // dr["Column7"] = string.Empty;
               // dr["Column8"] = string.Empty;
               // dr["Column9"] = string.Empty;
               // dr["Column10"] = string.Empty;
               // dr["Column11"] = string.Empty;
               // dr["Column12"] = string.Empty;
               // dr["Column13"] = string.Empty;
               // dr["Column14"] = string.Empty;
               // dr["Column15"] = string.Empty;
               // dr["Column16"] = string.Empty;
               // dr["Column17"] = string.Empty;
               // dr["Column18"] = string.Empty;
               // dr["Column19"] = string.Empty;
               // dt.Rows.Add(dr);
               // ViewState["CurrentTable"] = dt;
               //grdPurchasing.DataSource = dt;
               // grdPurchasing.DataBind();





            }
        }

        protected void grdPurchasing_RowDataBound(object sender, GridViewRowEventArgs e)
        {
       
            //    //DropDownList drpUnit = (DropDownList)e.Row.FindControl("drpUnit") as DropDownList;

          
            //    if (e.Row.RowType == DataControlRowType.DataRow)
            //    {
            //        if (drpInsertItm_NmAr != null /*&& drpUnit != null*/)
            //        {
            //            drpInsertItm_NmAr.DataValueField = "Itm_No";
            //            drpInsertItm_NmAr.DataTextField = "Itm_NmAr";
            //            drpInsertItm_NmAr.DataSource = DB.MtsItmmfs.ToList();
            //            drpInsertItm_NmAr.DataBind();

            //            drpInsertItm_NmAr.AppendDataBoundItems = true;
            //            drpInsertItm_NmAr.Items.Insert(0, new ListItem("اختر صنفاً", "0"));
            //            drpInsertItm_NmAr.SelectedIndex = 0;

            //drpUnit.DataValueField = "Unit_No";
            //drpUnit.DataTextField = "Unit_NmAr";
            //drpUnit.DataSource = DB.ItmsUnit.ToList();
            //drpUnit.DataBind();

            //drpItem.Items.Add(new ListItem("اختر صنفاً", "0"));
            //drpItem.AppendDataBoundItems = true;
            //drpItem.SelectedIndex = 0;
            //    }



            //}
        }

        protected void drpGrdItemNo_TextChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtGrdItemNo = row.FindControl("txtGrdItemNo") as TextBox;
                DropDownList drpItem = row.FindControl("drpItem") as DropDownList;
                if (drpItem != null)
                {
                    try
                    {
                        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd = new SqlCommand("select Itm_No,Itm_NmAr from MtsItmmfs where Itm_No=@Itm_No"))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = con;
                                con.Open();
                                cmd.Parameters.AddWithValue("@Itm_No", txtGrdItemNo.Text);
                                SqlDataReader dr = cmd.ExecuteReader();
                                while (dr.Read())
                                {
                                    drpItem.SelectedItem.Text = dr["Itm_NmAr"].ToString();
                                }
                                con.Close();
                            }
                        }
                    }
                    catch (Exception s)
                    {
                        HttpContext.Current.Response.Write("Error Occured " + s.Message);
                    }
                }
            }

        }

        private void AddNewRowToGrid()
        {

            if (ViewState["CurrentTable"] != null)
            {
                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                DataRow drCurrentRow = null;
                if (dtCurrentTable.Rows.Count > 0)
                {
                    drCurrentRow = dtCurrentTable.NewRow();
                    drCurrentRow["RowNumber"] = dtCurrentTable.Rows.Count + 1;
                    //add new row to DataTable 
                    dtCurrentTable.Rows.Add(drCurrentRow);
                    for (int i = 0; i < dtCurrentTable.Rows.Count - 1; i++)
                    {
                        //extract the TextBox & Drp values 

                        TextBox box1 = (TextBox)grdPurchasing.Rows[i].Cells[1].FindControl("txtGrdItemNo");
                        DropDownList box2 = (DropDownList)grdPurchasing.Rows[i].Cells[2].FindControl("drpItem");
                        DropDownList box3 = (DropDownList)grdPurchasing.Rows[i].Cells[3].FindControl("drpUnit");
                        TextBox box4 = (TextBox)grdPurchasing.Rows[i].Cells[4].FindControl("txtSitNo");
                        TextBox box5 = (TextBox)grdPurchasing.Rows[i].Cells[5].FindControl("txtQuantity");
                        TextBox box6 = (TextBox)grdPurchasing.Rows[i].Cells[6].FindControl("txtUnitPrice");
                        TextBox box7 = (TextBox)grdPurchasing.Rows[i].Cells[7].FindControl("txtTotalPrice");
                        TextBox box8 = (TextBox)grdPurchasing.Rows[i].Cells[8].FindControl("txtVaildDate");
                        TextBox box9 = (TextBox)grdPurchasing.Rows[i].Cells[9].FindControl("txtDiscountPur1");
                        TextBox box10 = (TextBox)grdPurchasing.Rows[i].Cells[10].FindControl("txtDiscountQuantity");
                        TextBox box11 = (TextBox)grdPurchasing.Rows[i].Cells[11].FindControl("txtDiscountPur2");
                        TextBox box12 = (TextBox)grdPurchasing.Rows[i].Cells[12].FindControl("txtBonusPur");
                        TextBox box13 = (TextBox)grdPurchasing.Rows[i].Cells[13].FindControl("txtBonusQuantity");
                        TextBox box14 = (TextBox)grdPurchasing.Rows[i].Cells[14].FindControl("txtSalePrice");
                        TextBox box15 = (TextBox)grdPurchasing.Rows[i].Cells[15].FindControl("txtSaleQuantity");
                        TextBox box16 = (TextBox)grdPurchasing.Rows[i].Cells[16].FindControl("txtUnitCost");
                        TextBox box17 = (TextBox)grdPurchasing.Rows[i].Cells[17].FindControl("txtItemPrice");
                        TextBox box18 = (TextBox)grdPurchasing.Rows[i].Cells[18].FindControl("txtTax");
                        TextBox box19 = (TextBox)grdPurchasing.Rows[i].Cells[19].FindControl("txtTaxQuantity");

                        // Update the DataRow with the DDL Selected Items & TextBox values 


                        dtCurrentTable.Rows[i]["Column1"] = box1.Text;
                        dtCurrentTable.Rows[i]["Column2"] = box2.SelectedItem.Text;
                        dtCurrentTable.Rows[i]["Column3"] = box3.SelectedItem.Text;
                        dtCurrentTable.Rows[i]["Column4"] = box4.Text;
                        dtCurrentTable.Rows[i]["Column5"] = box5.Text;
                        dtCurrentTable.Rows[i]["Column6"] = box6.Text;
                        dtCurrentTable.Rows[i]["Column7"] = box7.Text;
                        dtCurrentTable.Rows[i]["Column8"] = box8.Text;
                        dtCurrentTable.Rows[i]["Column9"] = box9.Text;
                        dtCurrentTable.Rows[i]["Column10"] = box10.Text;
                        dtCurrentTable.Rows[i]["Column11"] = box11.Text;
                        dtCurrentTable.Rows[i]["Column12"] = box12.Text;
                        dtCurrentTable.Rows[i]["Column13"] = box13.Text;
                        dtCurrentTable.Rows[i]["Column14"] = box14.Text;
                        dtCurrentTable.Rows[i]["Column15"] = box15.Text;
                        dtCurrentTable.Rows[i]["Column16"] = box16.Text;
                        dtCurrentTable.Rows[i]["Column17"] = box17.Text;
                        dtCurrentTable.Rows[i]["Column18"] = box18.Text;
                        dtCurrentTable.Rows[i]["Column19"] = box19.Text;
                    }

                    //Store the current data to ViewState for future reference 
                    ViewState["CurrentTable"] = dtCurrentTable;


                    //Rebind the Grid with the current data to reflect changes 
                    grdPurchasing.DataSource = dtCurrentTable;
                    grdPurchasing.DataBind();
                }
            }
            else
            {
                Response.Write("ViewState is null");

            }
            //Set Previous Data on Postbacks 
            SetPreviousData();
        }

        private void SetPreviousData()
        {

            int rowIndex = 0;
            if (ViewState["CurrentTable"] != null)
            {
                DataTable dt = (DataTable)ViewState["CurrentTable"];
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TextBox box1 = (TextBox)grdPurchasing.Rows[i].Cells[1].FindControl("txtGrdItemNo");
                        DropDownList box2 = (DropDownList)grdPurchasing.Rows[rowIndex].Cells[2].FindControl("drpItem");
                        DropDownList box3 = (DropDownList)grdPurchasing.Rows[rowIndex].Cells[3].FindControl("drpUnit");
                        TextBox box4 = (TextBox)grdPurchasing.Rows[i].Cells[4].FindControl("txtSitNo");
                        TextBox box5 = (TextBox)grdPurchasing.Rows[i].Cells[5].FindControl("txtQuantity");
                        TextBox box6 = (TextBox)grdPurchasing.Rows[i].Cells[6].FindControl("txtUnitPrice");
                        TextBox box7 = (TextBox)grdPurchasing.Rows[i].Cells[7].FindControl("txtTotalPrice");
                        TextBox box8 = (TextBox)grdPurchasing.Rows[i].Cells[8].FindControl("txtVaildDate");
                        TextBox box9 = (TextBox)grdPurchasing.Rows[i].Cells[9].FindControl("txtDiscountPur1");
                        TextBox box10 = (TextBox)grdPurchasing.Rows[i].Cells[10].FindControl("txtDiscountQuantity");
                        TextBox box11 = (TextBox)grdPurchasing.Rows[i].Cells[11].FindControl("txtDiscountPur2");
                        TextBox box12 = (TextBox)grdPurchasing.Rows[i].Cells[12].FindControl("txtBonusPur");
                        TextBox box13 = (TextBox)grdPurchasing.Rows[i].Cells[13].FindControl("txtBonusQuantity");
                        TextBox box14 = (TextBox)grdPurchasing.Rows[i].Cells[14].FindControl("txtSalePrice");
                        TextBox box15 = (TextBox)grdPurchasing.Rows[i].Cells[15].FindControl("txtSaleQuantity");
                        TextBox box16 = (TextBox)grdPurchasing.Rows[i].Cells[16].FindControl("txtUnitCost");
                        TextBox box17 = (TextBox)grdPurchasing.Rows[i].Cells[17].FindControl("txtItemPrice");
                        TextBox box18 = (TextBox)grdPurchasing.Rows[i].Cells[18].FindControl("txtTax");
                        TextBox box19 = (TextBox)grdPurchasing.Rows[i].Cells[19].FindControl("txtTaxQuantity");



                        //Fill the DropDownList with Data 

                        if (i < dt.Rows.Count - 1)
                        {

                            //Assign the value from DataTable to the TextBox 
                            box1.Text = dt.Rows[i]["Column1"].ToString();

                            //Set the Previous Selected Items on Each DropDownList  on Postbacks 

                            box2.ClearSelection();
                            box2.Items.FindByText(dt.Rows[i]["Column2"].ToString()).Selected = true;

                            box3.ClearSelection();
                            box3.Items.FindByText(dt.Rows[i]["Column3"].ToString()).Selected = true;

                            box4.Text = dt.Rows[i]["Column4"].ToString();
                            box5.Text = dt.Rows[i]["Column5"].ToString();
                            box6.Text = dt.Rows[i]["Column6"].ToString();
                            box7.Text = dt.Rows[i]["Column7"].ToString();
                            box8.Text = dt.Rows[i]["Column8"].ToString();
                            box9.Text = dt.Rows[i]["Column9"].ToString();
                            box10.Text = dt.Rows[i]["Column10"].ToString();
                            box11.Text = dt.Rows[i]["Column11"].ToString();
                            box12.Text = dt.Rows[i]["Column12"].ToString();
                            box13.Text = dt.Rows[i]["Column13"].ToString();
                            box14.Text = dt.Rows[i]["Column14"].ToString();
                            box15.Text = dt.Rows[i]["Column15"].ToString();
                            box16.Text = dt.Rows[i]["Column16"].ToString();
                            box17.Text = dt.Rows[i]["Column17"].ToString();
                            box18.Text = dt.Rows[i]["Column18"].ToString();
                            box19.Text = dt.Rows[i]["Column19"].ToString();
                        }

                        rowIndex++;
                    }
                }
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
           
        }

        protected void LinkDelete_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            GridViewRow gvRow = (GridViewRow)lb.NamingContainer;
            int rowID = gvRow.RowIndex;
            if (ViewState["CurrentTable"] != null)
            {

                DataTable dt = (DataTable)ViewState["CurrentTable"];
                if (dt.Rows.Count > 1)
                {
                    if (gvRow.RowIndex < dt.Rows.Count - 1)
                    {
                        //Remove the Selected Row data and reset row number
                        dt.Rows.Remove(dt.Rows[rowID]);
                        ResetRowID(dt);
                    }
                }

                //Store the current data in ViewState for future reference
                ViewState["CurrentTable"] = dt;

                //Re bind the GridView for the updated data
                grdPurchasing.DataSource = dt;
                grdPurchasing.DataBind();
            }

            //Set Previous Data on Postbacks
            SetPreviousData();
        }

        private void ResetRowID(DataTable dt)
        {
            int rowNumber = 1;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    row[0] = rowNumber;
                    rowNumber++;
                }
            }
        }

        protected void txtSanad_TextChanged(object sender, EventArgs e)
        {     

                BindGridView();
        }
        void BindGridView()
        {

                string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("select ROW_NUMBER () OVER(ORDER BY Ln_No) AS RowNumber, I.Doc_No, I.Ln_No, I.Itm_No, I.Loc_No, I.Qty, I.taxp_Extra, M.Itm_NmAr,U.Unit_NmAr,I.Itm_Cost,I.Titm_Cost,I.Exp_Date,I.Batch_No,I.Disc1_Prct,I.Disc1_Val,I.Disc2_Prct,I.BonusPur_Prct,I.BonusPur_Qty,I.Itm_Pur,I.Titm_Pur,I.taxv_Extra,I.Itm_Sal,I.Titm_Sal from MtsItmmfs as M right join InvLoddtl as I on M.Itm_No=I.Itm_No left join InvItmunit as U on U.Unit_No=I.Unit_No where I.Doc_No=@Doc_No"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        cmd.Parameters.AddWithValue("@Doc_No", txtSanad.Text);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            grdPurchasing.DataSource = dt;
                            grdPurchasing.DataBind();
                            grdPurchasing.ShowFooter = true;
                        }
                        else
                        {
                            dt.Rows.Add(dt.NewRow());
                            grdPurchasing.DataSource = dt;
                            grdPurchasing.DataBind();
                            grdPurchasing.Rows[0].Cells.Clear();
                            grdPurchasing.Rows[0].Cells.Add(new TableCell());

                            grdPurchasing.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;

                            grdPurchasing.Rows[0].Cells[0].Text = "لا يوجد بيانات لسند الادخال";

                            grdPurchasing.Rows[0].Cells[0]
    .HorizontalAlign = HorizontalAlign.Center;
                            grdPurchasing.ShowFooter = false;
                        }


                        con.Close();

                    }
                }
            
        }
        protected void grdPurchasing_RowCommand(object sender, GridViewCommandEventArgs e)
        {

         //   int LastRow = grdPurchasing.Rows.Count - 1;
         //   int Balance = ( Convert.ToInt16(grdPurchasing.Rows[LastRow].Cells[0].Text) + (1));

            // Label RowNumber = row.FindControl("RowNumber") as Label;
            //Label Doc_No = row.FindControl("Doc_No") as Label;

            if (e.CommandName.Equals("Insert"))
                {
                    TextBox TextBox2 = grdPurchasing.FooterRow.FindControl("txtInsertItm_No") as TextBox;
                    TextBox TextBox6 = grdPurchasing.FooterRow.FindControl("TextBox6") as TextBox;
                    TextBox TextBox9 = grdPurchasing.FooterRow.FindControl("TextBox9") as TextBox;
                    TextBox TextBox10 = grdPurchasing.FooterRow.FindControl("TextBox10") as TextBox;
                    TextBox TextBox12 = grdPurchasing.FooterRow.FindControl("TextBox12") as TextBox;
                    TextBox TextBox14 = grdPurchasing.FooterRow.FindControl("TextBox14") as TextBox;
                    DropDownList drpInsertUnit_NmAr = grdPurchasing.FooterRow.FindControl("drpInsertUnit_NmAr") as DropDownList;
                DropDownList drpInsertItm_NmAr = grdPurchasing.FooterRow.FindControl("drpInsertItm_NmAr") as DropDownList;

                TextBox txtItm_PurFooter = grdPurchasing.FooterRow.FindControl("txtItm_PurFooter") as TextBox;
                TextBox txtTitm_PurFooter = grdPurchasing.FooterRow.FindControl("txtTitm_PurFooter") as TextBox;
                TextBox Exp_DateFooter = grdPurchasing.FooterRow.FindControl("Exp_DateFooter") as TextBox;
                TextBox Batch_NoFooter = grdPurchasing.FooterRow.FindControl("Batch_NoFooter") as TextBox;
                TextBox Disc1_PrctFooter = grdPurchasing.FooterRow.FindControl("Disc1_PrctFooter") as TextBox;
                TextBox Disc1_ValFooter = grdPurchasing.FooterRow.FindControl("Disc1_ValFooter") as TextBox;
                TextBox Disc2_PrctFooter = grdPurchasing.FooterRow.FindControl("Disc2_PrctFooter") as TextBox;
                TextBox BonusPur_PrctFooter = grdPurchasing.FooterRow.FindControl("BonusPur_PrctFooter") as TextBox;
                TextBox BonusPur_QtyFooter = grdPurchasing.FooterRow.FindControl("BonusPur_QtyFooter") as TextBox;
                TextBox Itm_SalFooter = grdPurchasing.FooterRow.FindControl("Itm_SalFooter") as TextBox;
                TextBox Titm_SalFooter = grdPurchasing.FooterRow.FindControl("Titm_SalFooter") as TextBox;
                TextBox Titm_CostFooter = grdPurchasing.FooterRow.FindControl("Titm_CostFooter") as TextBox;
                TextBox Itm_CostFooter = grdPurchasing.FooterRow.FindControl("Itm_CostFooter") as TextBox;
                TextBox taxv_ExtraFooter = grdPurchasing.FooterRow.FindControl("taxv_ExtraFooter") as TextBox;



                string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("insert into Invloddtl (Ln_No,StoreID,Doc_Ty,Doc_No,Itm_No,Unit_No,Loc_No,Qty,taxp_Extra,Dlv_Stor,Itm_Cost,Titm_Cost,Exp_Date,Batch_No,Disc1_Prct,Disc1_Val,Disc2_Prct,BonusPur_Prct,BonusPur_Qty,Itm_Sal,Titm_Sal,taxv_Extra,Itm_Pur,Titm_Pur) Values ((select max (Ln_No)+1 from Invloddtl where Doc_No=@Doc_No),@StoreID,2,@Doc_No,@Itm_No,@Unit_No,@Loc_No,@Qty,@taxp_Extra,@Dlv_Stor,@Itm_Cost,@Titm_Cost,@Exp_Date,@Batch_No,@Disc1_Prct,@Disc1_Val,@Disc2_Prct,@BonusPur_Prct,@BonusPur_Qty,@Itm_Sal,@Titm_Sal,@taxv_Extra,@Itm_Pur,@Titm_Pur )"))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = con;
                            con.Open();
                        cmd.Parameters.AddWithValue("@StoreID", drpBranch.SelectedValue);
                        cmd.Parameters.AddWithValue("@Dlv_Stor", drpBranch.SelectedValue);
                        cmd.Parameters.AddWithValue("@Itm_No", TextBox2.Text);
                            cmd.Parameters.AddWithValue("@Loc_No", TextBox6.Text);
                            cmd.Parameters.AddWithValue("@Doc_No", txtSanad.Text);
                     //   cmd.Parameters.AddWithValue("@RowNumber", Balance);
                            cmd.Parameters.AddWithValue("@Qty", TextBox9.Text);
                            cmd.Parameters.AddWithValue("@taxp_Extra", TextBox10.Text);
                            cmd.Parameters.AddWithValue("@Unit_No", drpInsertUnit_NmAr.SelectedValue);

                        cmd.Parameters.AddWithValue("@Itm_Pur", txtItm_PurFooter.Text);
                        cmd.Parameters.AddWithValue("@Titm_Pur", txtTitm_PurFooter.Text);
                        cmd.Parameters.AddWithValue("@Exp_Date", Exp_DateFooter.Text);
                        cmd.Parameters.AddWithValue("@Batch_No", Batch_NoFooter.Text);
                        cmd.Parameters.AddWithValue("@Disc1_Prct", Disc1_PrctFooter.Text);
                        cmd.Parameters.AddWithValue("@Disc1_Val", Disc1_ValFooter.Text);
                        cmd.Parameters.AddWithValue("@Disc2_Prct", Disc2_PrctFooter.Text);
                        cmd.Parameters.AddWithValue("@BonusPur_Prct", BonusPur_PrctFooter.Text);
                        cmd.Parameters.AddWithValue("@BonusPur_Qty", BonusPur_QtyFooter.Text);
                        cmd.Parameters.AddWithValue("@Itm_Sal", Itm_SalFooter.Text);
                        cmd.Parameters.AddWithValue("@Titm_Sal", Titm_SalFooter.Text);
                        cmd.Parameters.AddWithValue("@Itm_Cost", Itm_CostFooter.Text);
                        cmd.Parameters.AddWithValue("@Titm_Cost", Titm_CostFooter.Text);
                        cmd.Parameters.AddWithValue("@taxv_Extra", taxv_ExtraFooter.Text);


                        cmd.ExecuteNonQuery();
                            grdPurchasing.ShowFooter = false;
                            BindGridView();
                       
                    }
                   
                }
            }
        }

        protected void AddNewRecord(object sender, EventArgs e)
        {
            grdPurchasing.ShowFooter = true;
            BindGridView();
        }

        protected void drpInsertItm_NmAr_SelectedIndexChanged(object sender, EventArgs e)
        {
        
                 //    TextBox txtInsertItm_No = row.FindControl("txtInsertItm_No") as TextBox;
              //  DropDownList drpInsertItm_NmAr = row.FindControl("drpInsertItm_NmAr") as DropDownList;

              TextBox txtInsertItm_No = grdPurchasing.FooterRow.FindControl("txtInsertItm_No") as TextBox;

               DropDownList drpInsertItm_NmAr = grdPurchasing.FooterRow.FindControl("drpInsertItm_NmAr") as DropDownList;

                if (drpInsertItm_NmAr != null)
                {
                    try
                    {
                        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd = new SqlCommand("select Itm_No from MtsItmmfs where Itm_No=@Itm_No"))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = con;
                                con.Open();
                                cmd.Parameters.AddWithValue("@Itm_No", drpInsertItm_NmAr.SelectedValue);
                                SqlDataReader dr = cmd.ExecuteReader();
                                while (dr.Read())
                                {
                                    txtInsertItm_No.Text = dr["Itm_No"].ToString();
                                }
                                con.Close();
                            }
                        }
                    }
                    catch (Exception s)
                    {
                        HttpContext.Current.Response.Write("Error Occured " + s.Message);
                    }
                }



                #region 
                //DropDownList drpItem = (DropDownList)grdPurchasing.FindControl("drpItem") as DropDownList;

                //TextBox txtGrdItemNo = (TextBox)grdPurchasing.FindControl("txtGrdItemNo")as TextBox;
                //DropDownList drpItem = (DropDownList)grdPurchasing.FindControl("drpItem") as DropDownList;



                //}

                //var query = from p in DB.MtsItmmfs
                //            where drpItem.SelectedItem.Value == Convert.ToString(p.Itm_No)
                //            select new
                //            {
                //                p.Itm_No,

                //            };


                //txtGrdItemNo.Text = query.ToString();
                #endregion
            
        }

        protected void txtInsertItm_No_TextChanged(object sender, EventArgs e)
        {

            TextBox txtInsertItm_No = grdPurchasing.FooterRow.FindControl("txtInsertItm_No") as TextBox;
            DropDownList drpInsertItm_NmAr = grdPurchasing.FooterRow.FindControl("drpInsertItm_NmAr") as DropDownList;

            if (drpInsertItm_NmAr != null)
                {
                    try
                    {
                        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd = new SqlCommand("select Itm_No,Itm_NmAr from MtsItmmfs where Itm_No=@Itm_No"))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = con;
                                con.Open();
                                cmd.Parameters.AddWithValue("@Itm_No", txtInsertItm_No.Text);
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.Read())
                                {
                                drpInsertItm_NmAr.SelectedItem.Text = dr["Itm_NmAr"].ToString();
                                }
                            else
                            {
                                Response.Write("لا يوجد صنف بهذا الرقم");
                            }
                                con.Close();
                            }
                        }
                    }
                    catch (Exception s)
                    {
                        HttpContext.Current.Response.Write("Error Occured " + s.Message);
                    }
                
            }
        }

        protected void grdPurchasing_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdPurchasing.EditIndex = e.NewEditIndex;
            BindGridView();

        }

        protected void grdPurchasing_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //string ID = grdPurchasing.DataKeys[e.RowIndex].Value.ToString();
            GridViewRow row = grdPurchasing.Rows[e.RowIndex];


            TextBox txtEditItm_No = (TextBox)row.FindControl("txtEditItm_No");
            TextBox txtEditLoc_No = (TextBox)row.FindControl("txtEditLoc_No");
            TextBox txtEditQty = (TextBox)row.FindControl("txtEditQty");
            TextBox txtEditTaxp_Extra = (TextBox)row.FindControl("txtEditTaxp_Extra");
            DropDownList drpEditItm_NmAr = (DropDownList)row.FindControl("drpEditItm_NmAr");
            DropDownList drpEditUnit_NmAr = (DropDownList)row.FindControl("drpEditUnit_NmAr");

            TextBox txtSitNo = row.FindControl("txtSitNo") as TextBox;
            TextBox txtQuantity = row.FindControl("txtQuantity") as TextBox;

            TextBox Itm_Pur = row.FindControl("txtItm_Pur") as TextBox;
            TextBox Titm_Pur = row.FindControl("txtTitm_Pur") as TextBox;
            TextBox Exp_Date = row.FindControl("txtExp_Date") as TextBox;
            TextBox Batch_No = row.FindControl("txtBatch_No") as TextBox;
            TextBox Disc1_Prct = row.FindControl("txtDisc1_Prct") as TextBox;
            TextBox Disc1_Val = row.FindControl("txtDisc1_Val") as TextBox;
            TextBox Disc2_Prct = row.FindControl("txtDisc2_Prct") as TextBox;
            TextBox BonusPur_Prct = row.FindControl("txtBonusPur_Prct") as TextBox;
            TextBox BonusPur_Qty = row.FindControl("txtBonusPur_Qty") as TextBox;
            TextBox Itm_Sal = row.FindControl("txtItm_Sal") as TextBox;
            TextBox Titm_Sal = row.FindControl("txtTitm_Sal") as TextBox;

            TextBox Itm_Cost = row.FindControl("txtItm_Cost") as TextBox;
            TextBox Titm_Cost = row.FindControl("txtTitm_Cost") as TextBox;

            TextBox taxp_Extra = row.FindControl("txtEditTaxp_Extra") as TextBox;
            TextBox taxv_Extra = row.FindControl("taxv_Extra_Extra") as TextBox;



            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Update Invloddtl set  StoreID=@StoreID,Doc_Ty=2,Itm_No=@Itm_No,Unit_No=@Unit_No,Loc_No=@Loc_No,Qty=@Qty,taxp_Extra=@taxp_Extra,taxv_Extra=@taxv_Extra,Itm_Cost=@Itm_Cost,Titm_Cost=@Titm_Cost,Exp_Date=@Exp_Date,Batch_No=@Batch_No,Disc1_Prct=@Disc1_Prct,Disc1_Val=@Disc1_Val,Disc2_Prct=@Disc2_Prct,BonusPur_Prct=@BonusPur_Prct,BonusPur_Qty=@BonusPur_Qty,Itm_Sal=@Itm_Sal,Titm_Sal=@Titm_Sal,Itm_Pur=@Itm_Pur,Titm_Pur=@Titm_Pur where Doc_No=@Doc_No and Ln_No=@RowNumber"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();

                    cmd.Parameters.AddWithValue("@Itm_No", drpEditItm_NmAr.SelectedValue);
                    cmd.Parameters.AddWithValue("@Loc_No", txtEditLoc_No.Text);
                    cmd.Parameters.AddWithValue("@Doc_No", txtSanad.Text);
                    cmd.Parameters.AddWithValue("@Qty", txtEditQty.Text);
                    cmd.Parameters.AddWithValue("@taxp_Extra", txtEditTaxp_Extra.Text);                  
                    cmd.Parameters.AddWithValue("@Unit_No", drpEditUnit_NmAr.SelectedValue);              
                    cmd.Parameters.AddWithValue("@RowNumber", row.Cells[0].Text);

                    cmd.Parameters.AddWithValue("@Itm_Pur", Itm_Pur.Text);
                    cmd.Parameters.AddWithValue("@Titm_Pur", Titm_Pur.Text);
                    cmd.Parameters.AddWithValue("@Exp_Date", Exp_Date.Text);
                    cmd.Parameters.AddWithValue("@Batch_No", Batch_No.Text);
                    cmd.Parameters.AddWithValue("@Disc1_Prct", Disc1_Prct.Text);
                    cmd.Parameters.AddWithValue("@Disc1_Val", Disc1_Val.Text);
                    cmd.Parameters.AddWithValue("@Disc2_Prct", Disc2_Prct.Text);
                    cmd.Parameters.AddWithValue("@BonusPur_Prct", BonusPur_Prct.Text);
                    cmd.Parameters.AddWithValue("@BonusPur_Qty", BonusPur_Qty.Text);
                    cmd.Parameters.AddWithValue("@Itm_Sal", Itm_Sal.Text);
                    cmd.Parameters.AddWithValue("@Titm_Sal", Titm_Sal.Text);
                    cmd.Parameters.AddWithValue("@Itm_Cost", Itm_Cost.Text);
                    cmd.Parameters.AddWithValue("@Titm_Cost", Titm_Cost.Text);
                    cmd.Parameters.AddWithValue("@taxv_Extra", taxv_Extra.Text);



                    cmd.ExecuteNonQuery();
                    grdPurchasing.EditIndex = -1;
                    BindGridView();
                }

            }

        }

        protected void grdPurchasing_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdPurchasing.EditIndex = -1;
            BindGridView();

        }

        protected void grdPurchasing_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


          //  GridViewRow row = grdPurchasing.Rows[e.RowIndex];
            int ItemID = int.Parse(grdPurchasing.DataKeys[e.RowIndex].Value.ToString());

            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("Delete from Invloddtl where Doc_No=@Doc_No and Ln_No=@RowNumber"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();

                        cmd.Parameters.AddWithValue("@Doc_No", txtSanad.Text);
                        cmd.Parameters.AddWithValue("@RowNumber", ItemID);
                        cmd.ExecuteNonQuery();
                        grdPurchasing.EditIndex = -1;
                        BindGridView();
                    }
                }
            }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string script = "alert(\"تم تحديث البيانات بنجاح\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }
    }

   

    }


