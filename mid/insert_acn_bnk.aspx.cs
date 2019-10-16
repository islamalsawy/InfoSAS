using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insert_acn_bnk : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GLAstAcnBnk g = new GLAstAcnBnk()
            {
             Acc_NmAr=TextBox2.Text,
             Acc_NmEn=TextBox3.Text,
            Acc_Bank_No=TextBox4.Text,
            Cash_Rpt=CheckBox1.Checked,
            Chk_Voucher=CheckBox2.Checked,
            Csh_voucher=CheckBox3.Checked,
            Rcp_Voucher=CheckBox4.Checked

            };
            db.GLAstAcnBnk.Add(g);
            db.SaveChanges();
            Response.Redirect("glastacnbnk.aspx");
        }
    }
}