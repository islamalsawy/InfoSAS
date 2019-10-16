using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_asets_status : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.FixdAstStatus.Find(id);
                TextBox1.Text = cn.AsetStat_No.ToString();
                TextBox2.Text = cn.AsetStat_NmAr;
              
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdAstStatus.Find(id);
            cn.AsetStat_No= Convert.ToInt16( TextBox1.Text) ;
            cn.AsetStat_NmAr=TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("asets_status.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdAstStatus.Find(id);
            db.FixdAstStatus.Remove(cn);
            db.SaveChanges();
            Response.Redirect("asets_status.aspx");
        }
    }
}