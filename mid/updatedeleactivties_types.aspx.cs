using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedeleactivties_types : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.ActivityTypes.Find(id);
                TextBox1.Text = cn.Actvty_No.ToString();
                TextBox2.Text = cn.Name_Arb;
                TextBox3.Text = cn.Name_Eng;
              
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.ActivityTypes.Find(id);
            cn.Actvty_No=Convert.ToInt16( TextBox1.Text );
            cn.Name_Arb= TextBox2.Text;
            cn.Name_Eng=TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("activity_types.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.ActivityTypes.Find(id);
            db.ActivityTypes.Remove(cn);
            db.SaveChanges();
            Response.Redirect("activity_types.aspx");
        }
    }
}