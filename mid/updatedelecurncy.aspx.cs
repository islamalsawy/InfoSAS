using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelecurncy : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.InvAstCurncy.Find(id);
                TextBox1.Text = cn.Curncy_No.ToString();
                TextBox2.Text = cn.Curncy_Nmar;
                TextBox3.Text = cn.Curncy_Nm;
                TextBox4.Text =cn.Curncy_Rate.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstCurncy.Find(id);
            cn.Curncy_No=Convert.ToInt16(TextBox1.Text );
            cn.Curncy_Nmar= TextBox2.Text ;
            cn.Curncy_Nm= TextBox3.Text;
            cn.Curncy_Rate=decimal.Parse(TextBox4.Text);
            db.SaveChanges();
            Response.Redirect("curncy.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstCurncy.Find(id);
            db.InvAstCurncy.Remove(cn);
            db.SaveChanges();
            Response.Redirect("curncy.aspx");
        }
    }
}