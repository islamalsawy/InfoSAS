using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class updatecompanies : System.Web.UI.Page
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

                DropDownList1.DataValueField = "Brn_No";
                DropDownList1.DataTextField = "Brn_Nm";
                DropDownList1.DataSource = db.MainBranch.ToList();
                DropDownList1.DataBind();


                var id = int.Parse(Request.QueryString["cmp"]);
                var comp = db.MainCmpnam.Find(id);
                TextBox1.Text = comp.Cmp_No.ToString();
                TextBox2.Text = comp.Tax_No.ToString();
                DropDownList2.SelectedValue = comp.Cmp_No.ToString();
                TextBox4.Text = comp.Cmp_Enm.ToString();
                CheckBox1.Checked = Convert.ToBoolean( comp.Cshr_Spr);
                TextBox5.Text = comp.Cmp_Nm2.ToString();
                TextBox6.Text = comp.Cmp_Enm2.ToString();
                CheckBox2.Checked = Convert.ToBoolean(comp.Sal_Spr);
                TextBox7.Text = comp.Cmp_Add.ToString();
                TextBox8.Text = comp.Cmp_Eadd.ToString();
                CheckBox3.Checked = Convert.ToBoolean(comp.Pur_Spr);
                TextBox9.Text = comp.Cmp_Email.ToString();
                CheckBox4.Checked = Convert.ToBoolean(comp.Invty_Spr);
                TextBox10.Text = comp.Cmp_Tel.ToString();
                CheckBox5.Checked = Convert.ToBoolean(comp.Cshr_Status);
                TextBox11.Text = comp.Cmp_Fax.ToString();
                CheckBox6.Checked = Convert.ToBoolean(comp.Srv_Status);
                CheckBox7.Checked = Convert.ToBoolean(comp.Dnv_Status);

                CheckBox8.Checked = Convert.ToBoolean(comp.SalB_Dn);
                CheckBox9.Checked = Convert.ToBoolean(comp.SalInv_Cash);
                CheckBox10.Checked = Convert.ToBoolean(comp.PurB_Srv);
                CheckBox11.Checked = Convert.ToBoolean(comp.PurInv_Cash);
                CheckBox12.Checked = Convert.ToBoolean(comp.Dn_woCost);
                CheckBox13.Checked = Convert.ToBoolean(comp.JvAuto_Mnth);
                CheckBox14.Checked = Convert.ToBoolean(comp.Srv_woCost);
                CheckBox15.Checked = Convert.ToBoolean(comp.GL_NetSale);
                CheckBox16.Checked = Convert.ToBoolean(comp.Itm_SrchRef);
                CheckBox17.Checked = Convert.ToBoolean(comp.Date_Status);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var id = int.Parse(Request.QueryString["cmp"]);
            var comp = db.MainCmpnam.Find(id);
            comp.Cmp_No= Convert.ToInt16( TextBox1.Text) ;
            comp.Tax_No= TextBox2.Text ;
            comp.Cmp_No=Convert.ToInt16( DropDownList2.SelectedValue) ;
            comp.Cmp_Enm=TextBox4.Text ;
            comp.Cshr_Spr=Convert.ToInt16( CheckBox1.Checked) ;
            comp.Cmp_Nm2= TextBox5.Text ;
            comp.Cmp_Enm2=TextBox6.Text ;
            comp.Sal_Spr= Convert.ToInt16(CheckBox2.Checked) ;

            comp.Cmp_Add= TextBox7.Text ;
            comp.Cmp_Eadd= TextBox8.Text ;
            comp.Pur_Spr= Convert.ToInt16(CheckBox3.Checked) ;
            comp.Cmp_Email= TextBox9.Text ;
            comp.Invty_Spr= Convert.ToInt16( CheckBox4.Checked) ;
            comp.Cmp_Tel=TextBox10.Text ;
            comp.Cshr_Status= Convert.ToInt16(CheckBox5.Checked) ;
            comp.Cmp_Fax= TextBox11.Text ;
            comp.Srv_Status= Convert.ToInt16( CheckBox6.Checked) ;
            comp.Dnv_Status= Convert.ToInt16(CheckBox7.Checked);

            comp.SalB_Dn= Convert.ToInt16( CheckBox8.Checked);
            comp.SalInv_Cash= Convert.ToInt16( CheckBox9.Checked);
            comp.PurB_Srv= Convert.ToInt16( CheckBox10.Checked );
            comp.PurInv_Cash= Convert.ToInt16(CheckBox11.Checked) ;
            comp.Dn_woCost= Convert.ToInt16( CheckBox12.Checked) ;
            comp.JvAuto_Mnth= Convert.ToInt16( CheckBox13.Checked );
            comp.Srv_woCost= Convert.ToInt16(CheckBox14.Checked);
            comp.GL_NetSale = Convert.ToInt16(CheckBox15.Checked) ;
            comp.Itm_SrchRef= Convert.ToInt16( CheckBox16.Checked );
            comp.Date_Status = Convert.ToInt16(CheckBox17.Checked) ;
            db.SaveChanges();
            Response.Redirect("companies.aspx");
        }

    }
}