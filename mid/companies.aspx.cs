using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class companies : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from p in db.MainCmpnam
                        select new
                        {
                            رقم_الشركة = p.Cmp_No,
                            إسم_الشركة = p.Cmp_Nm,
                            إسم_الشركة_En = p.Cmp_Enm,
                            إسم_الشركة2 = p.Cmp_Nm2,
                            إسم_الشركة_En_2 = p.Cmp_Enm2,
                            العنوان = p.Cmp_Add,
                            العنوان_En = p.Cmp_Eadd,
                            الإيميل = p.Cmp_Email,
                            التليفون = p.Cmp_Tel

                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.MainCmpnam
                            where p.Cmp_No == id
                            select new
                            {
                                p.Cmp_No,
                                p.Cmp_Nm,
                                p.Cmp_Enm,
                                p.Cmp_Nm2,
                                p.Cmp_Enm2,
                                p.Cmp_Add,
                                p.Cmp_Eadd,
                                p.Cmp_Email,
                                p.Cmp_Tel

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
            Response.Redirect("insertcompanies.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;

            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var query = from p in db.MainCmpnam

                            select new
                            {
                                رقم_الشركة = p.Cmp_No,
                                إسم_الشركة = p.Cmp_Nm,
                                إسم_الشركة_En = p.Cmp_Enm,
                                إسم_الشركة2 = p.Cmp_Nm2,
                                إسم_الشركة_En_2 = p.Cmp_Enm2,
                                العنوان = p.Cmp_Add,
                                العنوان_En = p.Cmp_Eadd,
                                الإيميل = p.Cmp_Email,
                                التليفون = p.Cmp_Tel

                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else
            {
                try
                {
                    int id = int.Parse(TextBox1.Text);
                    var query = from p in db.MainCmpnam
                                where p.Cmp_No == id
                    select new
                    {
                      p.Cmp_No,
                      p.Cmp_Nm,
                      p.Cmp_Enm,
                      p.Cmp_Nm2,
                      p.Cmp_Enm2,
                      p.Cmp_Add,
                      p.Cmp_Eadd,
                      p.Cmp_Email,
                      p.Cmp_Tel
                    };
                    GridView1.DataSource = query.ToList();
                    GridView1.DataBind();
                }
                catch { }
            }
        }
    }
}