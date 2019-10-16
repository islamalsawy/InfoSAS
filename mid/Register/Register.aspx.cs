using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid.Register
{
    public partial class Register : System.Web.UI.Page
    {
        ICDBTrdAEntities i = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = i.Sec_Roles.ToList();
                DropDownList1.DataValueField = "GroupId";
                DropDownList1.DataTextField = "GroupName";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
                i.register(TextBox1.Text, TextBox3.Text, TextBox2.Text,int.Parse(DropDownList1.SelectedValue));
            //string myScriptMsg = "function callMe() {alert('You have registered Successfully');}";

           // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "myScriptValue", myScriptMsg, true);

            Response.Redirect("../Login_v5/Login.aspx");
            //i.SaveChanges
        }
    }
}