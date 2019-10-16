using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_department : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AstDprtmnt a = new AstDprtmnt()
            {
                Dpm_NmAr=TextBox2.Text,
                Dpm_Nm=TextBox3.Text,
                Nof_Emp=Convert.ToInt16( TextBox4.Text)


            };
            db.AstDprtmnt.Add(a);
            db.SaveChanges();
            Response.Redirect("department.aspx");
        }

    
    }
}