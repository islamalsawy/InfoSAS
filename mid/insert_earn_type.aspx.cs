using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_earn_type : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HrAstErngtyp h = new HrAstErngtyp()
            {
                Earning_NmAr=TextBox1.Text,
                Earning_NmEn=TextBox2.Text

            };
            db.HrAstErngtyp.Add(h);
            db.SaveChanges();
            Response.Redirect("py_earn_type.aspx");
        }
    }
}