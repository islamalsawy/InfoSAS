using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class editdeleastarea : System.Web.UI.Page
    {
        ICDBTrdAEntities4 db = new ICDBTrdAEntities4();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.DataValueField = "Cntry_No";
                DropDownList1.DataTextField = "Cntry_NmAr";
                DropDownList1.DataSource = db.InvAstCntry.ToList();
                DropDownList1.DataBind();
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.InvAstArea.Find(id);
                TextBox1.Text = cn.Area_No.ToString();
                TextBox2.Text = cn.Area_NmAR;
                TextBox3.Text = cn.Area_NmEN;
                DropDownList1.SelectedValue = cn.Cntry_No.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstArea.Find(id);
            cn.Area_No = Convert.ToInt16(TextBox1.Text);
            cn.Area_NmAR = TextBox2.Text;
            cn.Area_NmEN = TextBox3.Text;
            cn.Cntry_No = Convert.ToInt16(DropDownList1.SelectedValue);
            db.SaveChanges();
            Response.Redirect("astarea.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstArea.Find(id);
            db.InvAstArea.Remove(cn);
            db.SaveChanges();
            Response.Redirect("astarea.aspx");
        }
    }
}