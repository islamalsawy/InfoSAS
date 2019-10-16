using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_deduction_type : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            mid.HrAstdeductntyp d = new HrAstdeductntyp()
            {

                Deduc_NmAr = TextBox1.Text,
                Deduc_NmEn = TextBox2.Text
               

            };
            db.HrAstdeductntyp.Add(d);
            db.SaveChanges();
            Response.Redirect("deduction_type.aspx");
        }
    }
}