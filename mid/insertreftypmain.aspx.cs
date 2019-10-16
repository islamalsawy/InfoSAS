using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertreftypmain : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //var id = int.Parse(Request.QueryString["no"]);
            //var cn = db.InvAstRefTypMain.Find(id);

            InvAstRefTypMain cn = new mid.InvAstRefTypMain ();
            cn.RefTyp_NmAr = TextBox2.Text;
            cn.RefTyp_Nm = TextBox3.Text;
            db.InvAstRefTypMain.Add(cn);
            db.SaveChanges();
            Response.Redirect("reftypmain.aspx");
        }
    }
}