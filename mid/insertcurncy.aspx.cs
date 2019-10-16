using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertcurncy : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InvAstCurncy cn = new InvAstCurncy(); 
            cn.Curncy_Nmar = TextBox2.Text;
            cn.Curncy_Nm = TextBox3.Text;
            cn.Curncy_Rate = decimal.Parse(TextBox4.Text);
            db.InvAstCurncy.Add(cn);
            db.SaveChanges();
            Response.Redirect("curncy.aspx");
        }
    }
}