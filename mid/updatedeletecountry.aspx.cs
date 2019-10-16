using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedeletecountry : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["con"]);
                var cn = db.InvAstCntry.Find(id);
                TextBox1.Text = cn.Cntry_No.ToString();
                TextBox2.Text = cn.Cntry_NmAr;
                TextBox3.Text =cn.Cntry_Nm ;
            }

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["con"]);
            var cn = db.InvAstCntry.Find(id);
            cn.Cntry_No= Convert.ToInt16(TextBox1.Text) ;
            cn.Cntry_Nm=TextBox2.Text;
            cn.Cntry_NmAr= TextBox3.Text ;
            db.SaveChanges();
            Response.Redirect("country.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["con"]);
            var cn = db.InvAstCntry.Find(id);
            db.InvAstCntry.Remove(cn);
            db.SaveChanges();
            Response.Redirect("country.aspx");
        }
    }
}