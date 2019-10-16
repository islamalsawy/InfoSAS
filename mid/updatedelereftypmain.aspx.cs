using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelereftypmain : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.InvAstRefTypMain.Find(id);
                TextBox1.Text = cn.Main_Reftyp.ToString();
                TextBox2.Text = cn.RefTyp_NmAr;
                TextBox3.Text = cn.RefTyp_Nm;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstRefTypMain.Find(id);
            cn.Main_Reftyp=Convert.ToInt16(TextBox1.Text);
            cn.RefTyp_NmAr= TextBox2.Text;
            cn.RefTyp_Nm= TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("reftypmain.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstRefTypMain.Find(id);
            db.InvAstRefTypMain.Remove(cn);
            db.SaveChanges();
            Response.Redirect("reftypmain.aspx");
        }
    }
}