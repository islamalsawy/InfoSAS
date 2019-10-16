using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_depstate : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {


                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.FixdDepStat.Find(id);
                TextBox1.Text = cn.DeprSt_No.ToString();
                TextBox2.Text = cn.DeprSt_Nm;
          

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdDepStat.Find(id);
            cn.DeprSt_No= Convert.ToInt16( TextBox1.Text);
            cn.DeprSt_Nm = TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("depstat.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdDepStat.Find(id);
            db.FixdDepStat.Remove(cn);
            db.SaveChanges();
            Response.Redirect("depstat.aspx");
        }
    }
}