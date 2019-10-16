using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertasetsloc : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FixdAsetsLoc cn = new FixdAsetsLoc();
            //cn.Loc_No = Convert.ToInt16(TextBox1.Text);
            cn.Loc_Nm = TextBox2.Text;
            cn.Acc_DB = Convert.ToInt32(TextBox3.Text);
            cn.Acc_CR = Convert.ToInt32(TextBox4.Text);
            db.FixdAsetsLoc.Add(cn);
            db.SaveChanges();
            Response.Redirect("asets_loc.aspx");
        }
    }
}