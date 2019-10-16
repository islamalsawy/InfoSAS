using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_ast_status : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FixdAstStatus f = new FixdAstStatus()
            {
                AsetStat_NmAr = TextBox1.Text,
                AsetStat_NmEn=TextBox2.Text


            };
            db.FixdAstStatus.Add(f);
            db.SaveChanges();
            Response.Redirect("asets_status.aspx");
        }
    }
}