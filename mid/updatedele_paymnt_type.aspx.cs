using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_paymnt_type : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.HrAstPymntype.Find(id);
                TextBox1.Text = cn.Pymnt_No.ToString();
                TextBox2.Text = cn.Pymnt_NmAr;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.HrAstPymntype.Find(id);
            cn.Pymnt_No=Convert.ToInt16( TextBox1.Text );
            cn.Pymnt_NmAr= TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("pymnt_type.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.HrAstPymntype.Find(id);
            db.HrAstPymntype.Remove(cn);
            db.SaveChanges();
            Response.Redirect("pymnt_type.aspx");
        }
    }
}