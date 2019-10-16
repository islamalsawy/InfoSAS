using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_depart : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.AstDprtmnt.Find(id);
                TextBox1.Text = cn.Dpm_No.ToString();
                TextBox2.Text = cn.Dpm_NmAr;
                TextBox3.Text = cn.Dpm_Nm;
                TextBox4.Text = cn.Nof_Emp.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.AstDprtmnt.Find(id);
            cn.Dpm_No = Convert.ToInt16(TextBox1.Text);
            cn.Dpm_NmAr = TextBox2.Text;
            cn.Dpm_Nm = TextBox3.Text;
            cn.Nof_Emp =Convert.ToInt16( TextBox4.Text);
            db.SaveChanges();
            Response.Redirect("department.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.AstDprtmnt.Find(id);
            db.AstDprtmnt.Remove(cn);
            db.SaveChanges();
            Response.Redirect("department.aspx");
        }
    }
}