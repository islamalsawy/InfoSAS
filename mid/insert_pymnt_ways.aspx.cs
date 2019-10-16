using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_pymnt_ways : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LcPymwys p = new LcPymwys()
            {
                Pym_Nm=TextBox2.Text,
                Pym_Nmar=TextBox3.Text

            };
            db.LcPymwys.Add(p);
            db.SaveChanges();
            Response.Redirect("lcpymwys.aspx");
        }
    }
}