using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class insertbranch : System.Web.UI.Page
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

               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MainBranch br = new MainBranch()
            {
                

               
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



            Inv_Undprs = decimal.Parse(TextBox22.Text),
            Cmp_CshPurDiscAcc = int.Parse(TextBox23.Text),
            Agnt_CshPurDiscAcc = int.Parse(TextBox24.Text),
            Agnt_BnusPurDiscAcc = int.Parse(TextBox25.Text),
            Acc_Suplier2 = int.Parse(TextBox26.Text),
            Brn_No = Convert.ToInt32(TextBox27.Text),
            Cmp_No = Convert.ToInt32(DropDownList2.SelectedValue),

        };
            db.MainBranch.Add(br);
            db.SaveChanges();
        }
    
        
    }
}