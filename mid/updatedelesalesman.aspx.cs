using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedelesalesman : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                DropDownList1.DataValueField = "Brn_No";
                DropDownList1.DataTextField = "Brn_Nm";
                DropDownList1.DataSource = db.MainBranch.ToList();
                DropDownList1.DataBind();
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.InvAstSalesman.Find(id);
                TextBox1.Text = cn.Slm_No.ToString();
                TextBox2.Text = cn.Slm_NmAr;
                TextBox3.Text = cn.Slm_NmEn;
                TextBox4.Text = cn.Fbal_Db.ToString();
               
                TextBox5.Text = cn.Fbal_CR.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstSalesman.Find(id);
            cn.Slm_No=Convert.ToUInt16(TextBox1.Text) ;
            cn.Slm_NmAr=TextBox2.Text;
            cn.Slm_NmEn= TextBox3.Text;
            cn.Fbal_Db=Convert.ToDecimal( TextBox4.Text) ;
            cn.Brn_No = Convert.ToInt16(DropDownList1.SelectedValue);
            cn.Fbal_CR=Convert.ToDecimal(TextBox5.Text );
            db.SaveChanges();
            Response.Redirect("salesman.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstSalesman.Find(id);
            db.InvAstSalesman.Remove(cn);
            db.SaveChanges();
            Response.Redirect("salesman.aspx");
        }
    }
}