using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class countris : System.Web.UI.Page
    {
        ICDBTrdAEntities1 db = new ICDBTrdAEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox1.Text);
            var query = from p in db.MainBranch
                        where p.Brn_No == id
                        select new
                        {
                            p.Brn_No,
                            p.Brn_Nm,
                            p.Brn_Adrs,
                            p.Brn_Email,
                          
                          
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}