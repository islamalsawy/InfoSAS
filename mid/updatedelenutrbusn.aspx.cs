using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelenutrbusn : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

          
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.InvAstNutrbusn.Find(id);
                TextBox1.Text = cn.Short_Eng.ToString();
                TextBox2.Text = cn.Nutr_No.ToString();
                TextBox3.Text = cn.Nutr_NmAr;
                TextBox4.Text = cn.Nutr_Nm;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstNutrbusn.Find(id);
            cn.Short_Eng= TextBox1.Text ;
            cn.Nutr_No=Convert.ToInt16( TextBox2.Text) ;
            cn.Nutr_NmAr= TextBox3.Text ;
            cn.Nutr_Nm= TextBox4.Text;
            db.SaveChanges();
            Response.Redirect("nutrbusn.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstNutrbusn.Find(id);
            db.InvAstNutrbusn.Remove(cn);
            db.SaveChanges();
            Response.Redirect("nutrbusn.aspx");
        }
    }
}