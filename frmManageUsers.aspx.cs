using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annual_Salary_Cost_Calculator
{
    public partial class frmManageUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.mdb"),
 txtUserName.Text, txtUserPassword.Text, ddlSecurityLevel.SelectedValue))
            {
                lblError.Text = "The user was successfully added!";
                grdUsers.DataBind();
            }
            else
            {
                lblError.Text = "The user was NOT successfully added!";
            }
        }
    }
}