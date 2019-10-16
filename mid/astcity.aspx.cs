using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class astcity : System.Web.UI.Page
    {
        ICDBTrdAEntities4 db = new ICDBTrdAEntities4();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox1.Text);
            var query = from p in db.InvAstCity
                        where p.City_No == id
                        select new
                        {
                            p.City_No,
                            p.City_NmAR,
                            p.City_NmEN



                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}