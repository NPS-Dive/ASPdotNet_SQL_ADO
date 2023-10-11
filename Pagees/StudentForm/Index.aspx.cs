using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session29_SQL01.Pagees.StudentForm
    {
    public partial class Index : System.Web.UI.Page
        {
        protected void Page_Load ( object sender, EventArgs e )
            {
            GetList();
            }
        private void GetList ()
            {
            StudentBusiness StuBiz = new StudentBusiness();
            GridViewStudent.DataSource = StuBiz.GetList();
            GridViewStudent.DataBind();
            }

        protected void GridViewStudent_RowDataBound ( object sender, GridViewRowEventArgs e )
            {
            if (e.Row.RowIndex % 2 == 1)
                {
                e.Row.CssClass = "gridRows";
                }
            }

        protected void GridViewStudent_PageIndexChanging ( object sender, GridViewPageEventArgs e )
            {
            GridViewStudent.PageIndex = e.NewPageIndex;
            }
        }
    }