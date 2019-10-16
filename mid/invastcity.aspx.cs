using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class invastcity : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var query = from p in db.InvAstCity
                            /*where p.Jr_Ty == id*/
                            select new
                            {
                              الرقم =  p.City_No,
                              الإسم_بالعربي = p.City_NmAR,
                              الإسم_بالإنجليزي =  p.City_NmEN
                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else
            {
                try
                {
                    int id = int.Parse(TextBox1.Text);
                    var query = from p in db.InvAstCity
                                where p.City_No == id
                                select new
                                {
                                 الرقم =   p.City_No,
                                 الإسم_بالعربي = p.City_NmAR,
                                 الإسم_بالإنجليزي =     p.City_NmEN
                                };

                    GridView1.DataBind();
                    GridView1.DataSource = query.ToList();
                }
                catch (Exception ex)
                {
                    Label2.Text = " (من فضلك أدخل قيم صحيحة (أرقام";
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.InvAstCity
                            where p.City_No == id
                            select new
                            {
                                الرقم = p.City_No,
                                الإسم_بالعربي = p.City_NmAR,
                                الإسم_بالإنجليزي = p.City_NmEN
                            };
                
                GridView1.DataBind();
                GridView1.DataSource = query.ToList();
            }
            catch
            {
              
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var query = from p in db.InvAstCity
                            /*where p.Jr_Ty == id*/
                            select new
                            {
                                الرقم = p.City_No,
                                الإسم_بالعربي = p.City_NmAR,
                                الإسم_بالإنجليزي = p.City_NmEN
                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else
            {
                try
                {
                    int id = int.Parse(TextBox1.Text);
                    var query = from p in db.InvAstCity
                                where p.City_No == id
                                select new
                                {
                                    الرقم = p.City_No,
                                    الإسم_بالعربي = p.City_NmAR,
                                    الإسم_بالإنجليزي = p.City_NmEN
                                };

                    GridView1.DataBind();
                    GridView1.DataSource = query.ToList();
                }
                catch
                {
                    Label2.Text = " (من فضلك أدخل قيم صحيحة (أرقام";
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertcity.aspx");
        }
    }
}