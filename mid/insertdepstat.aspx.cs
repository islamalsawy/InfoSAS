using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertdepstat : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FixdDepStat cn = new FixdDepStat();
            //cn.DeprSt_No = Convert.ToInt16(TextBox1.Text);
            cn.DeprSt_Nm = TextBox2.Text ;
            db.FixdDepStat.Add(cn);
            db.SaveChanges();
            Response.Redirect("depstat.aspx");
        }
    }
}