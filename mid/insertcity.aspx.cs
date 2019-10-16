using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertcity : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.DataTextField = "Cntry_NmAr";
                DropDownList1.DataValueField = "Cntry_No";
                DropDownList1.DataSource = db.InvAstCntry.ToList();
                DropDownList1.DataBind();
                DropDownList2.DataTextField = "Brn_NmAr";
                DropDownList2.DataValueField = "Brn_No";
                DropDownList2.DataSource = db.MainBranch.ToList();
                DropDownList2.DataBind();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InvAstCity n = new InvAstCity()
            {

                City_NmAR = TextBox2.Text,
                City_NmEN=TextBox3.Text,
                Cntry_No=Convert.ToInt16( DropDownList1.SelectedValue),
                Brn_No=Convert.ToInt16( DropDownList2.SelectedValue)

            };
            db.InvAstCity.Add(n);
            db.SaveChanges();
            Response.Redirect("invastcity.aspx");
  

        }
    }
}