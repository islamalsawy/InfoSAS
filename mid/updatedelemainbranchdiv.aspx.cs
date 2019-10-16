using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelemainbranchdiv : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.MainBranchDlv.Find(id);
                TextBox1.Text = cn.Dlv_Stor.ToString();
                TextBox2.Text = cn.Dlv_NmAr.ToString();
                TextBox3.Text = cn.Dlv_NmEn.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.MainBranchDlv.Find(id);
            //cn.Dlv_Stor = int.Parse(TextBox1.Text);
            cn.Dlv_NmAr = TextBox2.Text;
            cn.Dlv_NmEn = TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("mainbranchdiv.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.MainBranchDlv.Find(id);
            db.MainBranchDlv.Remove(cn);
            db.SaveChanges();
            Response.Redirect("mainbranchdiv.aspx");
        }
    }
}