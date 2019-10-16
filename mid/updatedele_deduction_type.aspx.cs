using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_deduction_type : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.HrAstdeductntyp.Find(id);
                TextBox1.Text = cn.Deduc_No.ToString();
                TextBox2.Text = cn.Deduc_NmAr;
            

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.HrAstdeductntyp.Find(id);
            cn.Deduc_No= Convert.ToInt16( TextBox1.Text);
            cn.Deduc_NmAr= TextBox2.Text;

            db.SaveChanges();
            Response.Redirect("deduction_type.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.HrAstdeductntyp.Find(id);
            db.HrAstdeductntyp.Remove(cn);
            db.SaveChanges();
            Response.Redirect("deduction_type.aspx");
        }
    }
}