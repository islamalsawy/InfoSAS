using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_pymnt_type : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HrAstPymntype h = new HrAstPymntype()
            {
             Pymnt_NmAr=TextBox1.Text,
                Pymnt_NmEn=TextBox2.Text

            };
            db.HrAstPymntype.Add(h);
            db.SaveChanges();
            Response.Redirect("pymnt_type.aspx");
        }
    }
}