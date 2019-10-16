using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedeledepm : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.HrAstDeprtmnt.Find(id);
                TextBox1.Text = cn.Depm_No.ToString();
                TextBox2.Text = cn.Depm_NmAr;
                TextBox3.Text = cn.Depm_Aprv;
               

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.HrAstDeprtmnt.Find(id);
            TextBox1.Text = cn.Depm_No.ToString();
            TextBox2.Text = cn.Depm_NmAr;
            TextBox3.Text = cn.Depm_Aprv;
            db.SaveChanges();
            Response.Redirect("depm.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.HrAstDeprtmnt.Find(id);
            db.HrAstDeprtmnt.Remove(cn);
            db.SaveChanges();
            Response.Redirect("depm.aspx");
        }
    }
}