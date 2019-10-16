using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatebranches : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList2.DataValueField = "Cmp_No";
                DropDownList2.DataTextField = "Cmp_Nm";
                DropDownList2.DataSource = db.MainCmpnam.ToList();
                DropDownList2.DataBind();

                //DropDownList1.DataValueField = "Brn_No";
                //DropDownList1.DataTextField = "Brn_Nm";
                //DropDownList1.DataSource = db.MainBranch.ToList();
                //DropDownList1.DataBind();

                var id = int.Parse(Request.QueryString["Brn_No"]);
                var branch = db.MainBranch.Find(id);



                TextBox2.Text =branch.Brn_No.ToString();
                TextBox3.Text = branch.Brn_Adrs;
                TextBox4.Text = branch.Brn_Email;
                TextBox5.Text = branch.Brn_Tel;

                TextBox6.Text = branch.Acc_TaxExtraDb.ToString();
                TextBox7.Text = branch.Acc_TaxExtraCR.ToString();
                TextBox8.Text = branch.Acc_Sales.ToString();
                TextBox9.Text = branch.Acc_RetSal.ToString();
                TextBox10.Text = branch.Acc_Cashier.ToString();
                TextBox11.Text = branch.Acc_Customer.ToString();
                TextBox12.Text = branch.Cmp_RetPurchAcc.ToString();
                TextBox13.Text = branch.Csh_SalAcc.ToString();
                TextBox14.Text = branch.Acc_Suplier.ToString();
                TextBox15.Text = branch.Cmp_PurchaseAcc.ToString();
                TextBox16.Text = branch.Csh_RetsalAcc.ToString();
                TextBox17.Text = branch.Csh_SalAcc.ToString();
                TextBox18.Text = branch.Cmp_RetPurchAcc.ToString();
                TextBox19.Text = branch.Csh_PurAcc.ToString();
                TextBox20.Text = branch.Cost_SalInvt.ToString();
                TextBox21.Text = branch.Cost_INVt.ToString();
                TextBox22.Text = branch.Inv_Undprs.ToString();
                TextBox23.Text = branch.Cmp_CshPurDiscAcc.ToString();
                TextBox24.Text = branch.Agnt_CshPurDiscAcc.ToString();
                TextBox25.Text = branch.Agnt_BnusPurDiscAcc.ToString();
                TextBox26.Text = branch.Acc_Suplier2.ToString();
                TextBox27.Text = branch.Brn_NmAr.ToString();
                ////DropDownList1.SelectedValue = branch.Brn_No.ToString();
                DropDownList2.SelectedValue = branch.Cmp_No.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["Brn_No"]);
            var branch = db.MainBranch.Find(id);

            branch.Brn_No = int.Parse(TextBox2.Text);
            branch.Brn_Adrs = TextBox3.Text;
            branch.Brn_Email = TextBox4.Text;
            branch.Brn_Tel = TextBox5.Text;

            branch.Acc_TaxExtraDb = int.Parse(TextBox6.Text);
            branch.Acc_TaxExtraCR = int.Parse(TextBox7.Text);
            branch.Acc_Sales = int.Parse(TextBox8.Text);
            branch.Acc_RetSal = int.Parse(TextBox9.Text);
            branch.Acc_Cashier = int.Parse(TextBox10.Text);
            branch.Acc_Customer = int.Parse(TextBox11.Text);
            branch.Cmp_RetPurchAcc = int.Parse(TextBox12.Text);
            branch.Csh_SalAcc = int.Parse(TextBox13.Text);
            branch.Acc_Suplier = int.Parse(TextBox14.Text);
            branch.Cmp_PurchaseAcc = int.Parse(TextBox15.Text);
            branch.Csh_RetsalAcc = int.Parse(TextBox16.Text);
            branch.Csh_SalAcc = int.Parse(TextBox17.Text);
            branch.Cmp_RetPurchAcc = int.Parse(TextBox18.Text);
            branch.Csh_PurAcc = int.Parse(TextBox19.Text);
            branch.Cost_SalInvt = int.Parse(TextBox20.Text);
            //branch.Cost_INVt = int.Parse(TextBox21.Text);


            branch.Inv_Undprs = decimal.Parse(TextBox22.Text);
            branch.Cmp_CshPurDiscAcc = int.Parse(TextBox23.Text);
            branch.Agnt_CshPurDiscAcc = int.Parse(TextBox24.Text);
            branch.Agnt_BnusPurDiscAcc = int.Parse(TextBox25.Text);
            branch.Acc_Suplier2 = int.Parse(TextBox26.Text);
            //branch.Brn_No = int.Parse(Request.QueryString["Brn_No"]);//Convert.ToInt32(DropDownList1.SelectedValue);
            branch.Brn_NmAr = TextBox27.Text;
            branch.Cmp_No = Convert.ToInt32(DropDownList2.SelectedValue);
            db.SaveChanges();
            //db.updatebranchs(int.Parse(TextBox2.Text),int.Parse( DropDownList2.SelectedValue), DropDownList1.SelectedItem.ToString(), TextBox5.Text, TextBox3.Text,
            //TextBox4.Text, int.Parse(TextBox11.Text), int.Parse(TextBox14.Text), int.Parse(TextBox10.Text), int.Parse(TextBox26.Text),
            //int.Parse(TextBox8.Text), int.Parse(TextBox9.Text), int.Parse(TextBox13.Text), int.Parse(TextBox16.Text), int.Parse(TextBox15.Text),
            //int.Parse(TextBox18.Text), int.Parse(TextBox23.Text), int.Parse(TextBox24.Text), int.Parse(TextBox25.Text), int.Parse(TextBox19.Text),
            //decimal.Parse(TextBox22.Text), int.Parse(TextBox20.Text), int.Parse(TextBox21.Text), int.Parse(TextBox6.Text), int.Parse(TextBox7.Text)

            //    );
            Response.Redirect("branch.aspx");
        }
    }
}