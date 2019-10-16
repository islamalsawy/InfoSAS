using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertbranches : System.Web.UI.Page
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


                Label1.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ////TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox16.Text = "";
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            TextBox20.Text = "";
            TextBox21.Text = "";
            TextBox22.Text = "";
            TextBox23.Text = "";
            TextBox24.Text = "";
            TextBox25.Text = "";
            TextBox26.Text = "";
            TextBox27.Text = "";
            //DropDownList1.SelectedIndex = -1;
            DropDownList2.SelectedIndex = -1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox27.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox4.Text) ||
                string.IsNullOrEmpty(TextBox5.Text) || string.IsNullOrEmpty(TextBox6.Text) || string.IsNullOrEmpty(TextBox7.Text) ||
                string.IsNullOrEmpty(TextBox8.Text) || string.IsNullOrEmpty(TextBox9.Text) || string.IsNullOrEmpty(TextBox10.Text) || string.IsNullOrEmpty(TextBox11.Text) || string.IsNullOrEmpty(TextBox12.Text) || string.IsNullOrEmpty(TextBox13.Text) || string.IsNullOrEmpty(TextBox14.Text) || string.IsNullOrEmpty(TextBox15.Text) ||
                string.IsNullOrEmpty(TextBox16.Text) || string.IsNullOrEmpty(TextBox17.Text) || string.IsNullOrEmpty(TextBox18.Text) || string.IsNullOrEmpty(TextBox19.Text) || string.IsNullOrEmpty(TextBox20.Text) ||
                string.IsNullOrEmpty(TextBox21.Text) || string.IsNullOrEmpty(TextBox22.Text) || string.IsNullOrEmpty(TextBox21.Text) || string.IsNullOrEmpty(TextBox22.Text) || string.IsNullOrEmpty(TextBox23.Text) ||
                string.IsNullOrEmpty(TextBox24.Text) || string.IsNullOrEmpty(TextBox25.Text) || string.IsNullOrEmpty(TextBox26.Text))
            {
                Label1.Text = "من فضلك إملأ الحقول بالبيانات الملائمة";
            }
            else
            {
                try
                {
                    MainBranch branch = new MainBranch()
                    {
                        //Brn_No = Convert.ToInt32(DropDownList1.SelectedValue),
                        Cmp_No = Convert.ToInt32(DropDownList2.SelectedValue),

                        Brn_Adrs = TextBox3.Text,
                        Brn_Email = TextBox4.Text,
                        Brn_Tel = TextBox5.Text,

                        Acc_TaxExtraDb = int.Parse(TextBox6.Text),
                        Acc_TaxExtraCR = int.Parse(TextBox7.Text),
                        Acc_Sales = int.Parse(TextBox8.Text),
                        Acc_RetSal = int.Parse(TextBox9.Text),
                        Acc_Cashier = int.Parse(TextBox10.Text),
                        Acc_Customer = int.Parse(TextBox11.Text),
                        Cmp_RetPurchAcc = int.Parse(TextBox12.Text),
                        Csh_SalAcc = int.Parse(TextBox13.Text),
                        Acc_Suplier = int.Parse(TextBox14.Text),
                        Cmp_PurchaseAcc = int.Parse(TextBox15.Text),
                        Csh_RetsalAcc = int.Parse(TextBox16.Text),
                        Csh_PurAcc = int.Parse(TextBox19.Text),
                        Cost_SalInvt = int.Parse(TextBox20.Text),
                        Cost_INVt = int.Parse(TextBox21.Text),


                    Inv_Undprs = decimal.Parse(TextBox22.Text),
                        Cmp_CshPurDiscAcc = int.Parse(TextBox23.Text),
                        Agnt_CshPurDiscAcc = int.Parse(TextBox24.Text),
                        Agnt_BnusPurDiscAcc = int.Parse(TextBox25.Text),
                        Acc_Suplier2 = int.Parse(TextBox26.Text),
                        Brn_NmAr = TextBox27.Text
                    };
                    db.MainBranch.Add(branch);
                    db.SaveChanges();
                    Response.Redirect("branch.aspx");
                }
                catch
                {

                }
            }
        }
    }
}