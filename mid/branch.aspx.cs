using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class branch : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from p in db.MainBranch
                        
                        select new
                        {
                           رقم_الفرع=  p.Brn_No,
                            إسم_الفرع = p.Brn_NmAr,
                            التليفون = p.Brn_Tel,
                            الشركة = p.Cmp_No,
                            المصروفات = p.Acc_TaxExtraDb,
                            الإيرادات = p.Acc_TaxExtraCR,
                            حساب_عميل = p.Acc_Customer,
                            الصندوق = p.Acc_Cashier,
                            حساب_مورد = p.Acc_Suplier
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.MainBranch
                            where p.Brn_No == id
                            select new
                            {
                                p.Brn_No,
                                p.Brn_NmAr,


                                p.Brn_Tel,
                                p.Cmp_No,
                                p.Acc_TaxExtraDb,
                                p.Acc_TaxExtraCR,

                                p.Acc_Customer,
                                p.Acc_Cashier,
                                p.Acc_Suplier




                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            catch { }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertbranch.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var query = from p in db.MainBranch
                            select new
                {
                    رقم_الفرع = p.Brn_No,
                    إسم_الفرع = p.Brn_NmAr,
                    التليفون = p.Brn_Tel,
                    الشركة = p.Cmp_No,
                    المصروفات = p.Acc_TaxExtraDb,
                    الإيرادات = p.Acc_TaxExtraCR,
                    حساب_عميل = p.Acc_Customer,
                    الصندوق = p.Acc_Cashier,
                    حساب_مورد = p.Acc_Suplier
                };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else
            {
                try
                {
                    int id = int.Parse(TextBox1.Text);
                    var query = from p in db.MainBranch
                                where p.Brn_No == id
                                select new
                                {
                                    p.Brn_No,
                                    p.Brn_NmAr,


                                    p.Brn_Tel,
                                    p.Cmp_No,
                                    p.Acc_TaxExtraDb,
                                    p.Acc_TaxExtraCR,

                                    p.Acc_Customer,
                                    p.Acc_Cashier,
                                    p.Acc_Suplier




                                };
                    GridView1.DataSource = query.ToList();
                    GridView1.DataBind();
                }
                catch { }

            }
        }
    }
}