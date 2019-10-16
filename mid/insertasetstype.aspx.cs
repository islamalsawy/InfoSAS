using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertasetstype : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FixdAsetstype cn = new FixdAsetstype();
            //cn.Ac_No1 = Convert.ToInt16(TextBox1.Text);
            cn.Ac_Nm1 = TextBox2.Text;
            cn.Dep_Prcnt = Convert.ToInt16(TextBox3.Text);
            cn.Cr_Acc = TextBox4.Text;
            db.FixdAsetstype.Add(cn);
            db.SaveChanges();
            Response.Redirect("asets_type.aspx");
        }
    }
}