﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mid
{
    public partial class astinvadj : System.Web.UI.Page
    {
        ICDBTrdAEntities db = new ICDBTrdAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from p in db.GLAstinvAdj
                        select new
                        {
                          الرقم =  p.ACC_No,
                           الإسم_بالعربي = p.Acc_NmAr,
                           الإسم_بالإنجليزي = p.Acc_NmEn
                        };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TextBox1.Text);
                var query = from p in db.GLAstinvAdj
                            where p.ACC_No == id
                            select new
                            {
                                الرقم = p.ACC_No,
                                الإسم_بالعربي = p.Acc_NmAr,
                                الإسم_بالإنجليزي = p.Acc_NmEn
                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            catch
            {

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("insertastinvadj.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                var query = from p in db.GLAstinvAdj
                            select new
                            {
                                الرقم = p.ACC_No,
                                الإسم_بالعربي = p.Acc_NmAr,
                                الإسم_بالإنجليزي = p.Acc_NmEn
                            };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else
            {
                try
                {
                    int id = int.Parse(TextBox1.Text);
                    var query = from p in db.GLAstinvAdj
                                where p.ACC_No == id
                                select new
                                {
                                    الرقم = p.ACC_No,
                                    الإسم_بالعربي = p.Acc_NmAr,
                                    الإسم_بالإنجليزي = p.Acc_NmEn
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
}