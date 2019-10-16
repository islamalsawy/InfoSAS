using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertastarea : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.DataValueField = "Cntry_No";
                DropDownList1.DataTextField = "Cntry_NmAr";
                DropDownList1.DataSource = db.InvAstCntry.ToList();
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InvAstArea cn = new InvAstArea();
            //cn.Area_No = Convert.ToInt16(TextBox1.Text);
            cn.Area_NmAR = TextBox2.Text;
            cn.Area_NmEN = TextBox3.Text;
            cn.Cntry_No = Convert.ToInt16(DropDownList1.SelectedValue);
            db.InvAstArea.Add(cn);
            db.SaveChanges();
            Response.Redirect("astarea.aspx");
        }
    }
}