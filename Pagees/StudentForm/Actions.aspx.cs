using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session29_SQL01.Pagees.StudentForm
    {
    public partial class Actions : System.Web.UI.Page
        {
        protected void Page_Load ( object sender, EventArgs e )
            {
            if (Request.QueryString["ID"] == null)
                {
                Response.Redirect("Index.aspx");
                return;
                }
            string strID = Request.QueryString["ID"];
            if (strID == "-1")
                {
                btnUpdate.Visible = false;
                btnDel.Visible = false;
                }
            else
                {
                if (!IsPostBack)
                    {
                    btnInsert.Visible = false;
                    Student student = new Student()
                        {
                        ID = Convert.ToInt64(strID)
                        };
                    StudentBusiness stuBiz = new StudentBusiness();
                    DataTable dt = stuBiz.Details(student);

                    if (dt.Rows.Count > 0)
                        {
                        txtName.Value = dt.Rows[0].Field<string>("Name");
                        txtFamily.Value = dt.Rows[0].Field<string>("LastName");
                        }
                    else
                        {
                        Response.Redirect("Index.aspx");
                        return;
                        }
                    }
                }
            }

        protected void btnInsert_Click ( object sender, EventArgs e )
            {
            Student student = new Student();
            student.Name = txtName.Value;
            student.Lastname = txtFamily.Value;
            if (txtName.Value.Trim() != string.Empty && txtName.Value.Trim() != null
                && txtFamily.Value.Trim() != string.Empty && txtFamily.Value.Trim() != null)
                {
                new StudentBusiness().Insert(student);
                //JS tag to refreshthe main page
                ScriptManager.RegisterStartupScript(Page, typeof(Page),
                    "myScript", "window.opener.location.reload();", true);
                }
            }

        protected void btnUpdate_Click ( object sender, EventArgs e )
            {
            Student student = new Student()
                {
                ID = Convert.ToInt64(Request.QueryString["ID"]),
                Name = txtName.Value,
                Lastname = txtFamily.Value
                };
            new StudentBusiness().Update(student);
            //JS tag to refreshthe main page
            ScriptManager.RegisterStartupScript(Page, typeof(Page),
                    "myScript", " window.close(); window.opener.location.reload();", true);
            txtName.Value = string.Empty;
            txtFamily.Value = string.Empty;
            }

        protected void btnDel_Click ( object sender, EventArgs e )
            {
            Student student = new Student()
                {
                ID = Convert.ToInt64(Request.QueryString["ID"])
                };
            new StudentBusiness().Delete(student);
            //JS tag to refreshthe main page
            ScriptManager.RegisterStartupScript(Page, typeof(Page),
                    "myScript", " window.close(); window.opener.location.reload();", true);
            }
        }
    }