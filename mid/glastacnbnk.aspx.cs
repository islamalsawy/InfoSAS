using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class glastacnbnk : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from p in db.GLAstAcnBnk
                        /*where p.Jr_Ty == id*/
                        select new
                        {
                            الرقم =  p.ACC_No,
                            الإسم_بالعربي = p.Acc_NmAr,
                            الإسم_بالإنجليزي =  p.Acc_NmEn,
                            الرقم_البنكي = p.Acc_Bank_No,
                            إيصال_الإستلام = p.Rcp_Voucher,
                            إيصال_نقدي = p.Csh_voucher,
                            الشيك =p.Chk_Voucher,
                           التقرير_النقدي = p.Cash_Rpt
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.GLAstAcnBnk
                            where p.ACC_No == id
                            select new
                            {
                                الرقم = p.ACC_No,
                                الإسم_بالعربي = p.Acc_NmAr,
                                الإسم_بالإنجليزي = p.Acc_NmEn,
                                الرقم_البنكي = p.Acc_Bank_No,
                                إيصال_الإستلام = p.Rcp_Voucher,
                                إيصال_نقدي = p.Csh_voucher,
                                الشيك = p.Chk_Voucher,
                                التقرير_النقدي = p.Cash_Rpt
                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            catch
            {
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insert_acn_bnk.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var query = from p in db.GLAstAcnBnk
                                /*where p.Jr_Ty == id*/
                            select new
                            {
                                الرقم = p.ACC_No,
                                الإسم_بالعربي = p.Acc_NmAr,
                                الإسم_بالإنجليزي = p.Acc_NmEn,
                                الرقم_البنكي = p.Acc_Bank_No,
                                إيصال_الإستلام = p.Rcp_Voucher,
                                إيصال_نقدي = p.Csh_voucher,
                                الشيك = p.Chk_Voucher,
                                التقرير_النقدي = p.Cash_Rpt
                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else
            {
                try
                {
                    int id = int.Parse(TextBox1.Text);
                    var query = from p in db.GLAstAcnBnk
                                where p.ACC_No == id
                                select new
                                {
                                    الرقم = p.ACC_No,
                                    الإسم_بالعربي = p.Acc_NmAr,
                                    الإسم_بالإنجليزي = p.Acc_NmEn,
                                    الرقم_البنكي = p.Acc_Bank_No,
                                    إيصال_الإستلام = p.Rcp_Voucher,
                                    إيصال_نقدي = p.Csh_voucher,
                                    الشيك = p.Chk_Voucher,
                                    التقرير_النقدي = p.Cash_Rpt
                                };
                    GridView1.DataSource = query.ToList();
                    GridView1.DataBind();
                }
                catch
                {

                }
            }
        }
    }
}