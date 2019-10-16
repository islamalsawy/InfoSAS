using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelesupctg : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.Astsupctg.Find(id);
                TextBox1.Text = cn.Supctg_No.ToString();
                DropDownList1.SelectedValue = cn.Sup_Cstm.ToString();
                TextBox2.Text = cn.Supctg_Nmar;
                TextBox3.Text = cn.Supctg_Nmen;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.Astsupctg.Find(id);
            cn.Supctg_No=Convert.ToInt16(TextBox1.Text) ;
            cn.Sup_Cstm=Convert.ToInt16( DropDownList1.SelectedValue) ;
            cn.Supctg_Nmar= TextBox2.Text;
            cn.Supctg_Nmen=TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("astsupctg.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.Astsupctg.Find(id);
            db.Astsupctg.Remove(cn);
            db.SaveChanges();
            Response.Redirect("astsupctg.aspx");
        }
    }
}