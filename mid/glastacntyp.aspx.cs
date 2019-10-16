using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class glastacntyp : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from p in db.GLAstAcntyp
                        /*where p.Jr_Ty == id*/
                        select new
                        {
                            الرقم = p.Ac_ty,
                            الإسم_بالعربي = p.Ac_NmAr,
                            الإسم_بالإنجليزي = p.Ac_NmEn
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.GLAstAcntyp
                            where p.Ac_ty == id
                            select new
                            {
                                الرقم = p.Ac_ty,
                                الإسم_بالعربي = p.Ac_NmAr,
                                الإسم_بالإنجليزي = p.Ac_NmEn
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
            Response.Redirect("insert_acn_type.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var query = from p in db.GLAstAcntyp
                                /*where p.Jr_Ty == id*/
                            select new
                            {
                                الرقم = p.Ac_ty,
                                الإسم_بالعربي = p.Ac_NmAr,
                                الإسم_بالإنجليزي = p.Ac_NmEn
                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else
            {
                try
                {
                    int id = int.Parse(TextBox1.Text);
                    var query = from p in db.GLAstAcntyp
                                where p.Ac_ty == id
                                select new
                                {
                                    الرقم = p.Ac_ty,
                                    الإسم_بالعربي = p.Ac_NmAr,
                                    الإسم_بالإنجليزي = p.Ac_NmEn
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