using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid.Login_v5
{
    public partial class Login : System.Web.UI.Page
    {
        ICDBTrdAEntities i = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          // login_check_Result y = (login_check_Result) i.login_check(TextBox1.Text, TextBox2.Text);
           if(i.login_check(TextBox1.Text, TextBox2.Text).Count()>0)
            {
                List <login_check_Result> y = i.login_check(TextBox1.Text, TextBox2.Text).ToList<login_check_Result>();
                Session.Add("username", y[0].UserName);
                Session.Add("id",y[0].UserID);
                Response.Redirect("../Dashboard.aspx");
            }
           else
            {
                Label1.Text = "wrong username or password";

            }
        }
    }
}