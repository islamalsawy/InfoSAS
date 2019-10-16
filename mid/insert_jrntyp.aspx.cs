using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_jrntyp : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GLAstJrntyp g = new GLAstJrntyp()
            {
                Jrty_Nm = TextBox2.Text,
                Jrty_NmEn=TextBox3.Text


            };
            db.GLAstJrntyp.Add(g);
            db.SaveChanges();
            Response.Redirect("gljrntyp.aspx");
        }
    }
}