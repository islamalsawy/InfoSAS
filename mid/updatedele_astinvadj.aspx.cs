using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_astinvadj : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.GLAstinvAdj.Find(id);
                TextBox1.Text = cn.ACC_No.ToString();
                TextBox2.Text = cn.Acc_NmAr;
                TextBox3.Text = cn.Acc_NmEn;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstinvAdj.Find(id);
            cn.ACC_No= Convert.ToInt32( TextBox1.Text) ;
            cn.Acc_NmAr= TextBox2.Text;
            cn.Acc_NmEn= TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("astinvadj.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstinvAdj.Find(id);
            db.GLAstinvAdj.Remove(cn);
            db.SaveChanges();
            Response.Redirect("astinvadj.aspx");
        }
    }
}