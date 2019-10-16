using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedeleglastacntyp : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.GLAstAcntyp.Find(id);
                TextBox1.Text = cn.Ac_ty.ToString();
                TextBox2.Text = cn.Ac_NmAr.ToString();
                TextBox3.Text = cn.Ac_NmEn.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstAcntyp.Find(id);
            db.GLAstAcntyp.Remove(cn);
            db.SaveChanges();
            Response.Redirect("glastacntyp.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstAcntyp.Find(id);
            cn.Ac_ty = short.Parse(TextBox1.Text);
            cn.Ac_NmAr = TextBox2.Text;
            cn.Ac_NmEn = TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("glastacntyp.aspx");
        }
    }
}