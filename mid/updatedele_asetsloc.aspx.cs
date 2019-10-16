using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedele_asetsloc : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.FixdAsetsLoc.Find(id);
                
                TextBox2.Text = cn.Loc_Nm;
                TextBox3.Text = cn.Acc_DB.ToString();
                TextBox4.Text = cn.Acc_CR.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdAsetsLoc.Find(id);
          
            cn.Loc_Nm= TextBox2.Text;
            cn.Acc_DB= Convert.ToInt32( TextBox3.Text);
            cn.Acc_CR= Convert.ToInt32( TextBox4.Text );
            db.SaveChanges();
            Response.Redirect("asets_loc.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.FixdAsetsLoc.Find(id);
            db.FixdAsetsLoc.Remove(cn);
            db.SaveChanges();
            Response.Redirect("asets_loc.aspx");
        }
    }
}