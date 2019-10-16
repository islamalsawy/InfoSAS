using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelelcpmwys : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.LcPymwys.Find(id);
                TextBox1.Text = cn.Pym_No.ToString();
                TextBox2.Text = cn.Pym_Nmar.ToString();
                TextBox3.Text = cn.Pym_Nm.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.LcPymwys.Find(id);
            cn.Pym_No = int.Parse(TextBox1.Text);
            cn.Pym_Nmar = TextBox2.Text;
            cn.Pym_Nm = TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("LcPymwys.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.LcPymwys.Find(id);
            db.LcPymwys.Remove(cn);
            db.SaveChanges();
            Response.Redirect("LcPymwys.aspx");
        }
    }
}