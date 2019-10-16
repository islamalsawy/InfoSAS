using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelegljrntyp : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.GLAstJrntyp.Find(id);
                TextBox1.Text = cn.Jr_Ty.ToString();
                TextBox2.Text = cn.Jrty_Nm.ToString();
                TextBox3.Text = cn.Jrty_NmEn.ToString();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstJrntyp.Find(id);
            db.GLAstJrntyp.Remove(cn);
            db.SaveChanges();
            Response.Redirect("gljrntyp.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstJrntyp.Find(id);
            cn.Jrty_Nm = TextBox2.Text;
            cn.Jrty_NmEn = TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("gljrntyp.aspx");
        }
    }
}