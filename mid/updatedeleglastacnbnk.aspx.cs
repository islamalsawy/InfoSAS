using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatedeleglastacnbnk : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["no"]);
                var cn = db.GLAstAcnBnk.Find(id);
                TextBox1.Text = cn.ACC_No.ToString();
                TextBox2.Text = cn.Acc_NmAr.ToString();
                TextBox3.Text = cn.Acc_NmEn.ToString();
                TextBox4.Text = cn.Acc_Bank_No;
                CheckBox4.Checked = cn.Rcp_Voucher.Value;
                CheckBox3.Checked = cn.Csh_voucher.Value;
                CheckBox2.Checked = cn.Chk_Voucher.Value;
                CheckBox1.Checked = cn.Cash_Rpt.Value;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstAcnBnk.Find(id);
            db.GLAstAcnBnk.Remove(cn);
            db.SaveChanges();
            Response.Redirect("glastacnbnk.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["no"]);
            var cn = db.GLAstAcnBnk.Find(id);
            //cn.ACC_No = long.Parse(TextBox1.Text);
            cn.Acc_NmAr = TextBox2.Text;
            cn.Acc_NmEn = TextBox3.Text;
            cn.Acc_Bank_No = TextBox4.Text;
            cn.Rcp_Voucher = CheckBox4.Checked;
            cn.Csh_voucher = CheckBox3.Checked;
            cn.Chk_Voucher = CheckBox2.Checked;
            cn.Cash_Rpt = CheckBox1.Checked;
            db.SaveChanges();
            Response.Redirect("glastacnbnk.aspx");
        }
    }
}