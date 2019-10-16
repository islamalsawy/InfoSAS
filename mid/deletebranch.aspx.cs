using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class deletebranch : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        { 
            var name = Request.QueryString["nm"];
            Label1.Text = name.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var number = int.Parse(Request.QueryString["no"]);
            var branch = db.MainBranch.Find(number);
            db.MainBranch.Remove(branch);
            db.SaveChanges();
            Response.Redirect("branch.aspx");
        }
    }
}