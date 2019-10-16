using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class activity_types : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from p in db.ActivityTypes
                       // where p.Actvty_No == id
                        select new
                        {
                            الرقم = p.Actvty_No,
                            الإسم_بالعربي = p.Name_Arb,
                            الإسم_بالإنجليزي = p.Name_Eng

                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.ActivityTypes
                            where p.Actvty_No == id
                            select new
                            {
                                الرقم = p.Actvty_No ,
                                الإسم_بالعربي = p.Name_Arb,
                                الإسم_بالإنجليزي = p.Name_Eng

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
            Response.Redirect("insertactivities_types.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                try
                {
                    var query = from p in db.ActivityTypes
                                    // where p.Actvty_No == id
                                select new
                                {
                                    الرقم = p.Actvty_No,
                                    الإسم_بالعربي = p.Name_Arb,
                                    الإسم_بالإنجليزي = p.Name_Eng
                                };
                    GridView1.DataSource = query.ToList();
                    GridView1.DataBind();
                }
                catch
                {

                }
            }
            else
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.ActivityTypes
                            where p.Actvty_No == id
                            select new
                            {
                                الرقم = p.Actvty_No,
                                الإسم_بالعربي = p.Name_Arb,
                                الإسم_بالإنجليزي = p.Name_Eng

                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
        }
    }
}