using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertastcompany : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AstCompany cn = new AstCompany();
            //cn.Cmp_No = Convert.ToInt16(TextBox1.Text);
            cn.Cmp_NmAr = TextBox2.Text;
            cn.Cmp_NmEn = TextBox3.Text;
            db.AstCompany.Add(cn);
            db.SaveChanges();
            Response.Redirect("astcompany.aspx");
        }
    }
}