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
    public partial class purchasingInovice : System.Web.UI.Page
    {
        ICDBTrdAEntities DB = new ICDBTrdAEntities();
        public void Grid_Initializing()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            //dt.Columns.Add(new DataColumn("Column1", typeof(string)));


            dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("Column1", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column2", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column3", typeof(string)));//for DropDownList selected item 
            dt.Columns.Add(new DataColumn("Column4", typeof(string)));//for DropDownList 
            dt.Columns.Add(new DataColumn("Column5", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column6", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column7", typeof(string)));//for DropDownList selected item 
            dt.Columns.Add(new DataColumn("Column8", typeof(string)));//for DropDownList      
            dt.Columns.Add(new DataColumn("Column9", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column10", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column11", typeof(string)));//for DropDownList selected item 
            dt.Columns.Add(new DataColumn("Column12", typeof(string)));//for DropDownList 
            dt.Columns.Add(new DataColumn("Column13", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column14", typeof(string)));//for DropDownList selected item 
            dt.Columns.Add(new DataColumn("Column15", typeof(string)));//for DropDownList      
            dt.Columns.Add(new DataColumn("Column16", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column17", typeof(string)));//for TextBox value 
            dt.Columns.Add(new DataColumn("Column18", typeof(string)));//for DropDownList selected item 
            dt.Columns.Add(new DataColumn("Column19", typeof(string)));//for DropDownList 
            dt.Columns.Add(new DataColumn("Column20", typeof(string)));//for DropDownList 

            dr = dt.NewRow();
            dr["RowNumber"] = 1;
            dr["Column1"] = string.Empty;
            dr["Column4"] = string.Empty;
            dr["Column5"] = string.Empty;
            dr["Column6"] = string.Empty;
            dr["Column7"] = string.Empty;
            dr["Column8"] = string.Empty;
            dr["Column9"] = string.Empty;
            dr["Column10"] = string.Empty;
            dr["Column11"] = string.Empty;
            dr["Column12"] = string.Empty;
            dr["Column13"] = string.Empty;
            dr["Column14"] = string.Empty;
            dr["Column15"] = string.Empty;
            dr["Column16"] = string.Empty;
            dr["Column17"] = string.Empty;
            dr["Column18"] = string.Empty;
            dr["Column19"] = string.Empty;
            dr["Column20"] = string.Empty;
            dt.Rows.Add(dr);
            ViewState["CurrentTable"] = dt;
            grdPurchasing.DataSource = dt;
            grdPurchasing.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            dateSanadH.Text = DateTime.Now.ToString("yyyy/MM/dd", new System.Globalization.CultureInfo("ar-SA"));
            dateSanad.Text = DateTime.Now.ToString("yyyy/MM/dd", new System.Globalization.CultureInfo("ar-EG"));
            dateDue.Text = DateTime.Now.AddDays(60).ToString("yyy/MM/dd");

            if (!Page.IsPostBack)
            {
                //Islam 8-10-2019
                drpBranch.DataValueField = "Brn_No";
                drpBranch.DataTextField = "Brn_NmAr";
                drpBranch.DataSource = DB.MainBranch.ToList();
                drpBranch.DataBind();
                drpBranch.Items.Insert(0, new ListItem("اختر الفرع", ""));

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

                Grid_Initializing();
            }

            drpBranch.Items[0].Attributes["disabled"] = "disabled";
        }


        protected void drpItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtGrdItemNo = row.FindControl("txtGrdItemNo") as TextBox;
                DropDownList drpItem = row.FindControl("drpItem") as DropDownList;
                TextBox txtUnitPrice = row.FindControl("txtUnitPrice") as TextBox;
                TextBox txtSalePrice = row.FindControl("txtSalePrice") as TextBox;
                if (drpItem != null)
                {
                    try
                    {
                        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd = new SqlCommand("select Itm_No,Itm_Pur,Itm_Sal2 from MtsItmmfs where Itm_No=@Itm_No"))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = con;
                                con.Open();
                                cmd.Parameters.AddWithValue("@Itm_No", drpItem.SelectedValue);
                                SqlDataReader dr = cmd.ExecuteReader();
                                while (dr.Read())
                                {
                                    txtGrdItemNo.Text = dr["Itm_No"].ToString();
                                    txtUnitPrice.Text = dr["Itm_Pur"].ToString();
                                    txtSalePrice.Text = dr["Itm_Sal2"].ToString();
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

        protected void grdPurchasing_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            DropDownList drpItem = (DropDownList)e.Row.FindControl("drpItem") as DropDownList;
            DropDownList drpUnit = (DropDownList)e.Row.FindControl("drpUnit") as DropDownList;


            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (drpItem != null && drpUnit != null)
                {
                    drpItem.DataValueField = "Itm_No";
                    drpItem.DataTextField = "Itm_NmAr";
                    drpItem.DataSource = DB.MtsItmmfs.ToList();
                    drpItem.DataBind();

                    drpItem.AppendDataBoundItems = true;
                    drpItem.Items.Insert(0, new ListItem("اختر صنفاً", "0"));
                    drpItem.SelectedIndex = 0;

                    drpUnit.DataValueField = "Unit_No";
                    drpUnit.DataTextField = "Unit_NmAr";
                    drpUnit.DataSource = DB.ItmsUnit.ToList();
                    drpUnit.DataBind();

                    //drpItem.Items.Add(new ListItem("اختر صنفاً", "0"));
                    //drpItem.AppendDataBoundItems = true;
                    //drpItem.SelectedIndex = 0;
                }



            }
        }

        protected void drpGrdItemNo_TextChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtGrdItemNo = row.FindControl("txtGrdItemNo") as TextBox;
                DropDownList drpItem = row.FindControl("drpItem") as DropDownList;
                TextBox txtUnitPrice = row.FindControl("txtUnitPrice") as TextBox;
                TextBox txtSalePrice = row.FindControl("txtSalePrice") as TextBox;
                if (drpItem != null)
                {
                    try
                    {
                        string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                        using (SqlConnection con = new SqlConnection(constr))
                        {
                            using (SqlCommand cmd = new SqlCommand("select Itm_No,Itm_NmAr,Itm_Pur,Itm_Sal2 from MtsItmmfs where Itm_No=@Itm_No"))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = con;
                                con.Open();
                                cmd.Parameters.AddWithValue("@Itm_No", txtGrdItemNo.Text);
                                SqlDataReader dr = cmd.ExecuteReader();
                                while (dr.Read())
                                {
                                    drpItem.SelectedItem.Text = dr["Itm_NmAr"].ToString();
                                    txtUnitPrice.Text = dr["Itm_Pur"].ToString();
                                    txtSalePrice.Text = dr["Itm_Sal2"].ToString();
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

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtQuantity = row.FindControl("txtQuantity") as TextBox;
                TextBox txtTotalPrice = row.FindControl("txtTotalPrice") as TextBox;
                TextBox txtUnitPrice = row.FindControl("txtUnitPrice") as TextBox;
                TextBox txtItemPrice = row.FindControl("txtItemPrice") as TextBox;
                decimal output, output2;
                var txtQuantityD = decimal.TryParse(txtQuantity.Text, out output);

                var txtUnitPriceD = decimal.TryParse(txtUnitPrice.Text, out output2);

                txtTotalPrice.Text = (output * output2).ToString();
                //txtItemPrice.Text = txtTotalPrice.Text;
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
                        TextBox box9 = (TextBox)grdPurchasing.Rows[i].Cells[9].FindControl("txtBatch_No");
                        TextBox box10 = (TextBox)grdPurchasing.Rows[i].Cells[10].FindControl("txtDiscountPur1");
                        TextBox box11 = (TextBox)grdPurchasing.Rows[i].Cells[11].FindControl("txtDiscountQuantity");
                        TextBox box12 = (TextBox)grdPurchasing.Rows[i].Cells[12].FindControl("txtDiscountPur2");
                        TextBox box13 = (TextBox)grdPurchasing.Rows[i].Cells[13].FindControl("txtBonusPur");
                        TextBox box14 = (TextBox)grdPurchasing.Rows[i].Cells[14].FindControl("txtBonusQuantity");
                        TextBox box15 = (TextBox)grdPurchasing.Rows[i].Cells[15].FindControl("txtSalePrice");
                        TextBox box16 = (TextBox)grdPurchasing.Rows[i].Cells[16].FindControl("txtSaleQuantity");
                        TextBox box17 = (TextBox)grdPurchasing.Rows[i].Cells[17].FindControl("txtUnitCost");
                        TextBox box18 = (TextBox)grdPurchasing.Rows[i].Cells[18].FindControl("txtItemPrice");
                        TextBox box19 = (TextBox)grdPurchasing.Rows[i].Cells[19].FindControl("txtTax");
                        TextBox box20 = (TextBox)grdPurchasing.Rows[i].Cells[20].FindControl("txtTaxQuantity");



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
                        dtCurrentTable.Rows[i]["Column20"] = box20.Text;



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
                        DropDownList box2 = (DropDownList)grdPurchasing.Rows[i].Cells[2].FindControl("drpItem");
                        DropDownList box3 = (DropDownList)grdPurchasing.Rows[i].Cells[3].FindControl("drpUnit");
                        TextBox box4 = (TextBox)grdPurchasing.Rows[i].Cells[4].FindControl("txtSitNo");
                        TextBox box5 = (TextBox)grdPurchasing.Rows[i].Cells[5].FindControl("txtQuantity");
                        TextBox box6 = (TextBox)grdPurchasing.Rows[i].Cells[6].FindControl("txtUnitPrice");
                        TextBox box7 = (TextBox)grdPurchasing.Rows[i].Cells[7].FindControl("txtTotalPrice");
                        TextBox box8 = (TextBox)grdPurchasing.Rows[i].Cells[8].FindControl("txtVaildDate");
                        TextBox box9 = (TextBox)grdPurchasing.Rows[i].Cells[9].FindControl("txtBatch_No");
                        TextBox box10 = (TextBox)grdPurchasing.Rows[i].Cells[10].FindControl("txtDiscountPur1");
                        TextBox box11 = (TextBox)grdPurchasing.Rows[i].Cells[11].FindControl("txtDiscountQuantity");
                        TextBox box12 = (TextBox)grdPurchasing.Rows[i].Cells[12].FindControl("txtDiscountPur2");
                        TextBox box13 = (TextBox)grdPurchasing.Rows[i].Cells[13].FindControl("txtBonusPur");
                        TextBox box14 = (TextBox)grdPurchasing.Rows[i].Cells[14].FindControl("txtBonusQuantity");
                        TextBox box15 = (TextBox)grdPurchasing.Rows[i].Cells[15].FindControl("txtSalePrice");
                        TextBox box16 = (TextBox)grdPurchasing.Rows[i].Cells[16].FindControl("txtSaleQuantity");
                        TextBox box17 = (TextBox)grdPurchasing.Rows[i].Cells[17].FindControl("txtUnitCost");
                        TextBox box18 = (TextBox)grdPurchasing.Rows[i].Cells[18].FindControl("txtItemPrice");
                        TextBox box19 = (TextBox)grdPurchasing.Rows[i].Cells[19].FindControl("txtTax");
                        TextBox box20 = (TextBox)grdPurchasing.Rows[i].Cells[20].FindControl("txtTaxQuantity");



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
                            box20.Text = dt.Rows[i]["Column20"].ToString();
                        }

                        rowIndex++;
                    }
                }
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewRowToGrid();
        }

        protected void LinkDelete_Click(object sender, EventArgs e)
        {
            ImageButton lb = (ImageButton)sender;
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

        public void conn(int sql)
        {
            string sqlStatement = "select isnull(MAX(Doc_No),0)+1 from InvLoddtl as I,MainBranch as M where I.Dlv_Stor=m.Dlv_Stor and m.Dlv_Stor='" + sql + "'";
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlStatement))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        //   cmd.Parameters.AddWithValue("@Dlv_Stor", drpBranch.SelectedValue);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txtSanad.Text = dr[0].ToString();
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (drpBranch.SelectedIndex != 0)
            {


                foreach (GridViewRow row in grdPurchasing.Rows)
                {
                    TextBox txtGrdItemNo = row.FindControl("txtGrdItemNo") as TextBox;

                    DropDownList drpUnit = row.FindControl("drpUnit") as DropDownList;

                    DropDownList drpItem = row.FindControl("drpItem") as DropDownList;

                    TextBox txtSitNo = row.FindControl("txtSitNo") as TextBox;
                    TextBox txtQuantity = row.FindControl("txtQuantity") as TextBox;

                    TextBox Itm_Pur = row.FindControl("txtUnitPrice") as TextBox;
                    TextBox Titm_Pur = row.FindControl("txtTotalPrice") as TextBox;
                    TextBox Exp_Date = row.FindControl("txtVaildDate") as TextBox;
                    TextBox Batch_No = row.FindControl("txtBatch_No") as TextBox;
                    TextBox Disc1_Prct = row.FindControl("txtDiscountPur1") as TextBox;
                    TextBox Disc1_Val = row.FindControl("txtDiscountQuantity") as TextBox;
                    TextBox Disc2_Prct = row.FindControl("txtDiscountPur2") as TextBox;
                    TextBox BonusPur_Prct = row.FindControl("txtBonusPur") as TextBox;
                    TextBox BonusPur_Qty = row.FindControl("txtBonusQuantity") as TextBox;
                    TextBox Itm_Sal = row.FindControl("txtSalePrice") as TextBox;
                    TextBox Titm_Sal = row.FindControl("txtSaleQuantity") as TextBox;

                    TextBox Itm_Cost = row.FindControl("txtUnitCost") as TextBox;
                    TextBox Titm_Cost = row.FindControl("txtItemPrice") as TextBox;

                    TextBox taxp_Extra = row.FindControl("txtTax") as TextBox;
                    TextBox taxv_Extra = row.FindControl("txtTaxQuantity") as TextBox;


                    string insertStatement = "insert into InvLoddtl (StoreID,Doc_Ty,Doc_No,Dlv_Stor,Qty,Loc_No,Unit_No,Ln_No,Itm_No,Itm_Cost,Titm_Cost,Exp_Date, Batch_No,Disc1_Prct,Disc1_Val,Disc2_Prct,BonusPur_Prct,BonusPur_Qty,Itm_Sal,Titm_Sal,taxp_Extra,taxv_Extra,Itm_Pur,Titm_Pur) values(@StoreID,'2',@Doc_No,@Dlv_Stor,@Qty,@Loc_No,@Unit_No,@RowNumber,@Itm_No,@Itm_Cost,@Titm_Cost,@Exp_Date,@Batch_No,@Disc1_Prct,@Disc1_Val,@Disc2_Prct,@BonusPur_Prct,@BonusPur_Qty,@Itm_Sal,@Titm_Sal,@taxp_Extra,@taxv_Extra,@Itm_Pur,@Titm_Pur)";

                    string constr = ConfigurationManager.ConnectionStrings["DefaultConnection2"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand(insertStatement))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = con;
                            con.Open();
                            cmd.Parameters.AddWithValue("@StoreID", drpBranch.SelectedValue);
                            cmd.Parameters.AddWithValue("@Doc_No", txtSanad.Text);
                            cmd.Parameters.AddWithValue("@Dlv_Stor", drpBranch.SelectedValue);
                            cmd.Parameters.AddWithValue("@Unit_No", drpUnit.SelectedValue);
                            cmd.Parameters.AddWithValue("@RowNumber", row.Cells[0].Text);
                            cmd.Parameters.AddWithValue("@Qty", txtQuantity.Text);
                            cmd.Parameters.AddWithValue("@Loc_No", txtSitNo.Text);
                            cmd.Parameters.AddWithValue("@Itm_No", txtGrdItemNo.Text);
                            //cmd.Parameters.AddWithValue("@Itm_Cost", Itm_Cost.Text);
                            //cmd.Parameters.AddWithValue("@Titm_Cost", Titm_Cost.Text);
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

                            cmd.Parameters.AddWithValue("@Itm_Pur", Itm_Pur.Text);
                            cmd.Parameters.AddWithValue("@Titm_Pur", Titm_Pur.Text);

                            cmd.Parameters.AddWithValue("@taxp_Extra", taxp_Extra.Text);
                            cmd.Parameters.AddWithValue("@taxv_Extra", taxv_Extra.Text);





                            int result = cmd.ExecuteNonQuery();
                            Grid_Initializing();

                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('تم حفظ الفاتورة.')", true);
                            if (result < 0)
                            {
                                HttpContext.Current.Response.Write("حدث خطأ أثناء حفظ البيانات");
                            }

                            con.Close();
                        }
                    }
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('خطأ لابد من اختيار الفرع')", true);
            }

            #region MyRegion
            //    if (grdPurchasing.Rows.Count > 0)
            //    {
            //        DataTable dt = new DataTable();
            //        dt.Columns.AddRange(new DataColumn[19] {
            //            new DataColumn("Field1", typeof(string)),
            //            new DataColumn("Field2", typeof(string)),
            //            new DataColumn("Field3",typeof(string)),
            //            new DataColumn("Field4",typeof(string)),
            //            new DataColumn("Field5",typeof(string)),
            //            new DataColumn("Field6",typeof(string)),
            //            new DataColumn("Field7",typeof(string)),
            //            new DataColumn("Field8",typeof(string)),
            //            new DataColumn("Field9",typeof(string)),
            //            new DataColumn("Field10",typeof(string)),
            //            new DataColumn("Field11", typeof(string)),
            //            new DataColumn("Field12", typeof(string)),
            //            new DataColumn("Field13",typeof(string)),
            //            new DataColumn("Field14",typeof(string)),
            //            new DataColumn("Field15",typeof(string)),
            //            new DataColumn("Field16",typeof(string)),
            //            new DataColumn("Field17",typeof(string)),
            //            new DataColumn("Field18",typeof(string)),
            //            new DataColumn("Field19",typeof(string)),});

            //        foreach (GridViewRow row in grdPurchasing.Rows)
            //        {

            //            string box1 = ((TextBox)row.Cells[1].FindControl("txtGrdItemNo")).Text;
            //            string box2 = ((DropDownList)row.Cells[2].FindControl("drpItem")).SelectedItem.Text;
            //            string box3 = ((DropDownList)row.Cells[3].FindControl("drpUnit")).SelectedItem.Text;
            //            string box4 = ((TextBox)row.Cells[4].FindControl("txtSitNo")).Text;
            //            string box5 = ((TextBox)row.Cells[5].FindControl("txtQuantity")).Text;
            //            string box6 = ((TextBox)row.Cells[6].FindControl("txtUnitPrice")).Text;
            //            string box7 = ((TextBox)row.Cells[7].FindControl("txtTotalPrice")).Text;
            //            string box8 = ((TextBox)row.Cells[8].FindControl("txtVaildDate")).Text;
            //            string box9 = ((TextBox)row.Cells[9].FindControl("txtDiscountPur1")).Text;
            //            string box10 = ((TextBox)row.Cells[10].FindControl("txtDiscountQuantity")).Text;
            //            string box11 = ((TextBox)row.Cells[11].FindControl("txtDiscountPur2")).Text;
            //            string box12 = ((TextBox)row.Cells[12].FindControl("txtBonusPur")).Text;
            //            string box13 = ((TextBox)row.Cells[13].FindControl("txtBonusQuantity")).Text;
            //            string box14 = ((TextBox)row.Cells[14].FindControl("txtSalePrice")).Text;
            //            string box15 = ((TextBox)row.Cells[15].FindControl("txtSaleQuantity")).Text;
            //            string box16 = ((TextBox)row.Cells[16].FindControl("txtUnitCost")).Text;
            //            string box17 = ((TextBox)row.Cells[17].FindControl("txtItemPrice")).Text;
            //            string box18 = ((TextBox)row.Cells[18].FindControl("txtTax")).Text;
            //            string box19 = ((TextBox)row.Cells[19].FindControl("txtTaxQuantity")).Text;




            //            dt.Rows.Add(box1, box2, box3, box4, box5, box6, box7, box8, box9, box10, box11, box12, box13, box14, box15, box16, box17, box18, box19);
            //        }
            //        InsertRecords(dt);
            //    }
            #endregion
        }

        protected void drpBranch_PreRender(object sender, EventArgs e)
        {
            switch (drpBranch.SelectedValue)
            {
                case "1":
                    conn(1);
                    break;
                case "2":
                    conn(2);
                    break;
                case "3":
                    conn(3);
                    break;
                case "4":
                    conn(4);
                    break;
                case "5":
                    conn(5);
                    break;
                default:
                    break;
            }
        }

        protected void txtDiscountPur1_OnPreRender(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtDiscountPur1 = row.FindControl("txtDiscountPur1") as TextBox;
                // TextBox txtDiscountPur2 = row.FindControl("txtDiscountPur2") as TextBox;

                TextBox txtTotalPrice = row.FindControl("txtTotalPrice") as TextBox;
                TextBox txtDiscountQuantity = row.FindControl("txtDiscountQuantity") as TextBox;
                TextBox txtUnitCost = row.FindControl("txtUnitCost") as TextBox;

                TextBox txtItemPrice = row.FindControl("txtItemPrice") as TextBox;
                decimal output, output2;

                var txtDiscountPur1D = decimal.TryParse(txtDiscountPur1.Text,out output);
                //  double txtDiscountPur2D = Convert.ToDouble(txtDiscountPur2.Text);
                var txtTotalPriceD = decimal.TryParse(txtTotalPrice.Text, out output2);

                txtDiscountQuantity.Text = ((output) / 100 * (output2)).ToString();




              //  var txtDiscountQuantityD = decimal.TryParse(txtDiscountQuantity.Text,out output3);

                     // var txtItemPriceD = decimal.TryParse(txtItemPrice.Text, out output4);

             //   txtItemPrice.Text = (output2 - output3).ToString();

            }
        }



        protected void txtItemPrice_OnPreRender(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtDiscountPur1 = row.FindControl("txtDiscountPur1") as TextBox;
                TextBox txtDiscountPur2 = row.FindControl("txtDiscountPur2") as TextBox;

                TextBox txtTotalPrice = row.FindControl("txtTotalPrice") as TextBox;
                TextBox txtDiscountQuantity = row.FindControl("txtDiscountQuantity") as TextBox;
                TextBox txtUnitCost = row.FindControl("txtUnitCost") as TextBox;

                TextBox txtItemPrice = row.FindControl("txtItemPrice") as TextBox;

                decimal output, output2, output3;

                var txtDiscountQuantityD = decimal.TryParse(txtDiscountQuantity.Text, out output);
                //  double txtDiscountPur2D = Convert.ToDouble(txtDiscountPur2.Text);
                var txtTotalPriceD = decimal.TryParse(txtTotalPrice.Text, out output2);
                var txtDiscountPur2D = decimal.TryParse(txtDiscountPur2.Text, out output3); //10%



                var temp2 = (output2 - output) * (output3 / 100); //قيمة خصم شراء 2
                var temp = output2 - output - temp2; //المبلغ بعد خصم قيمة شراء 1 576



                //   txtDiscountQuantity.Text = ((output) / 100 * (output2)).ToString();
                txtItemPrice.Text = (temp).ToString();
                // txtItemPrice.Text = (temp2 - (temp2 * 10 / 100)).ToString();
            }
        }

        protected void txtDiscountQuantity_PreRender(object sender, EventArgs e)
        {
           
        }

        protected void txtBonusPur_OnTextChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {

                TextBox txtTotalPrice = row.FindControl("txtTotalPrice") as TextBox;
                TextBox txtBonusQuantity = row.FindControl("txtBonusQuantity") as TextBox;
                TextBox txtBonusPur = row.FindControl("txtBonusPur") as TextBox;
                TextBox txtUnitCost = row.FindControl("txtUnitCost") as TextBox;
                TextBox txtQuantity = row.FindControl("txtQuantity") as TextBox;
                TextBox txtItemPrice = row.FindControl("txtItemPrice") as TextBox;

                decimal output, output2, output3, output4;

               
                //  double txtDiscountPur2D = Convert.ToDouble(txtDiscountPur2.Text);
                var txtItemPriceD = decimal.TryParse(txtItemPrice.Text, out output2);
                var txtQuantityD = decimal.TryParse(txtQuantity.Text, out output3);
                var txtBonusPurD = decimal.TryParse(txtBonusPur.Text, out output4);


                //   txtDiscountQuantity.Text = ((output) / 100 * (output2)).ToString();

                txtBonusQuantity.Text = (output3 * output4 / 100).ToString();

                var txtBonusQuantityD = decimal.TryParse(txtBonusQuantity.Text, out output);
                txtUnitCost.Text = ((output2) / (output3+ output)).ToString();

            }
            }

        protected void txtBonusPur_PreRender(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtQuantity = row.FindControl("txtQuantity") as TextBox;    TextBox txtBonusPur = row.FindControl("txtBonusPur") as TextBox; 
                TextBox txtBonusQuantity = row.FindControl("txtBonusQuantity") as TextBox;


                decimal output, output2;

                var txtQuantityD = decimal.TryParse(txtQuantity.Text, out output);
                //  double txtDiscountPur2D = Convert.ToDouble(txtDiscountPur2.Text);
                var txtBonusPurD = decimal.TryParse(txtBonusPur.Text, out output2);



                txtBonusQuantity.Text = (output*(output2/100)).ToString();
                // txtItemPrice.Text = (temp2 - (temp2 * 10 / 100)).ToString();
            }
        }

        protected void txtBonusQuantity_OnTextChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdPurchasing.Rows)
            {
                TextBox txtQuantity = row.FindControl("txtQuantity") as TextBox; TextBox txtBonusPur = row.FindControl("txtBonusPur") as TextBox;
                TextBox txtBonusQuantity = row.FindControl("txtBonusQuantity") as TextBox;
                TextBox txtItemPrice = row.FindControl("txtItemPrice") as TextBox;
                TextBox txtUnitCost = row.FindControl("txtUnitCost") as TextBox;



                decimal output, output2, output3;

                var txtQuantityD = decimal.TryParse(txtQuantity.Text, out output);
                //  double txtDiscountPur2D = Convert.ToDouble(txtDiscountPur2.Text);
                var txtBonusQuantityD = decimal.TryParse(txtBonusQuantity.Text, out output2);
                var txtItemPriceD = decimal.TryParse(txtItemPrice.Text, out output3);




                txtBonusPur.Text = (output2 / output * 100).ToString();
                txtUnitCost.Text = ((output3) / (output + output2)).ToString();
                // txtItemPrice.Text = (temp2 - (temp2 * 10 / 100)).ToString();
            }
        }

        protected void txtDiscountPur1_TextChanged(object sender, EventArgs e)
        {
           
        }



        //protected void txtDiscountPur2_TextChanged(object sender, EventArgs e)
        //{
        //    foreach (GridViewRow row in grdPurchasing.Rows)
        //    {

        //        TextBox txtDiscountPur2 = row.FindControl("txtDiscountPur2") as TextBox;
        //        TextBox txtTotalPrice = row.FindControl("txtTotalPrice") as TextBox;
        //        TextBox txtItemPrice = row.FindControl("txtItemPrice") as TextBox;
        //        TextBox txtDiscountQuantity = row.FindControl("txtDiscountQuantity") as TextBox;

        //        decimal output, output2, output3, output4, output5;

        //        var txtDiscountPur2D = decimal.TryParse(txtDiscountPur2.Text, out output);
        //        var txtTotalPriceD = decimal.TryParse(txtTotalPrice.Text, out output2);
        //        var txtDiscountQuantityD = decimal.TryParse(txtDiscountQuantity.Text, out output3);


        //        var temp = output2 - output3; //576
        //        var txtItemPriceD = decimal.TryParse(txtItemPrice.Text,out output4);
        //        var temp2 = decimal.TryParse(txtItemPrice.Text, out output5);

        //        txtItemPrice.Text = (temp - (temp * output / 100)).ToString();





        //    }
        //}
    }

    }
    
    
    

