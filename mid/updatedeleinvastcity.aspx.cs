using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedeleinvastcity : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            // set country data for dropdownlist 1 

            var query = from p in db.InvAstCntry
                        select new
                        {
                            p.Cntry_No,
                            p.Cntry_NmAr
                        };
            DropDownList1.DataTextField = "Cntry_NmAr";
            DropDownList1.DataValueField = "Cntry_No";
            DropDownList1.DataSource = query.ToList();
            DropDownList1.DataBind();

            // set country data for dropdownlist 2

            var query1 = from p in db.MainBranch
                        select new
                        {
                            p.Brn_No,
                            p.Brn_NmAr
                        };
            DropDownList2.DataTextField = "Brn_NmAr";
            DropDownList2.DataValueField = "Brn_No";
            DropDownList2.DataSource = query1.ToList();
            DropDownList2.DataBind();

            //  fill data for fields
            
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstCity.Find(id);
            TextBox1.Text = cn.City_No.ToString();
            TextBox2.Text = cn.City_NmAR.ToString();
            TextBox3.Text = cn.City_NmEN.ToString();
            DropDownList1.SelectedValue = cn.Cntry_No.Value.ToString();
            DropDownList2.SelectedValue = cn.Brn_No.Value.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstCity.Find(id);
            //cn.Dlv_Stor = int.Parse(TextBox1.Text);
            cn.City_NmAR = TextBox2.Text;
            cn.City_NmEN = TextBox3.Text;
            cn.Cntry_No = short.Parse(DropDownList1.SelectedValue);
            cn.Brn_No = short.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("invastcity.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.InvAstCity.Find(id);
            db.InvAstCity.Remove(cn);
            db.SaveChanges();
            Response.Redirect("invastcity.aspx");
        }

       
    }
}