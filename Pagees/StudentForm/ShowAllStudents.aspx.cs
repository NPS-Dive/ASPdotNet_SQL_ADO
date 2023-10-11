using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session29_SQL01.Pagees.StudentForm
    {
    public partial class ShowAllStudents : System.Web.UI.Page
        {
        protected void Page_Load ( object sender, EventArgs e )
            {
            GetList();
            }

        private void GetList ()
            {
            StudentBusiness stuBiz = new StudentBusiness();
            myGrid.DataSource = stuBiz.GetList();
            myGrid.DataBind();
            }
        }
    }