using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class deletecompanies : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
          string name = Request.QueryString["cn"];

            Label1.Text = name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var number = int.Parse(Request.QueryString["co"]);
            var branch = db.MainCmpnam.Find(number);
            db.MainCmpnam.Remove(branch);
            db.SaveChanges();
            Response.Redirect("companies.aspx");
        }
    }
}