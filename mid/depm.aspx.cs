using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class depm : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.HrAstDeprtmnt.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.HrAstDeprtmnt
                            where p.Depm_No == id
                            select new
                            {
                                p.Depm_No,
                                p.Depm_NmAr,
                                p.Depm_NmEn,
                                p.Depm_Aprv


                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            catch
            {
                
            }
        }
    }
}