using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_asets_type : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.FixdAsetstype.Find(id);
                TextBox1.Text = cn.Ac_No1.ToString();
                TextBox2.Text = cn.Ac_Nm1;
                TextBox3.Text = cn.Dep_Prcnt.ToString();
                TextBox4.Text = cn.Cr_Acc;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdAsetstype.Find(id);
            cn.Ac_No1= Convert.ToInt16( TextBox1.Text) ;
            cn.Ac_Nm1= TextBox2.Text;
            cn.Dep_Prcnt=Convert.ToInt16( TextBox3.Text );
            cn.Cr_Acc= TextBox4.Text;
            db.SaveChanges();
            Response.Redirect("asets_type.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdAsetstype.Find(id);
            db.FixdAsetstype.Remove(cn);
            db.SaveChanges();
            Response.Redirect("asets_type.aspx");
        }
    }
}