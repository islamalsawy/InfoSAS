using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class main_branch_div : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataTextField = "Brn_NmAr";
            DropDownList1.DataValueField = "Brn_No";
            DropDownList1.DataSource =db.MainBranch.ToList();
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MainBranchDlv d = new MainBranchDlv()
            {

                Dlv_NmAr = TextBox2.Text,
                Dlv_NmEn=TextBox3.Text,
                Brn_No=Convert.ToInt32( DropDownList1.SelectedValue)

            };
            db.MainBranchDlv.Add(d);
            db.SaveChanges();
            Response.Redirect("mainbranchdiv.aspx");
        }
    }
}