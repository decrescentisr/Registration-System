using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annual_Salary_Cost_Calculator
{
    public partial class frmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            linkbtnCalculator.Visible = true;
            imgbtnCalculator.Visible = true;
            linkbtnViewPersonnel.Visible = true;
            imgbtnViewPersonnel.Visible = true;
            linkbtnSearch.Visible = true;
            imgbtnSearch.Visible = true;

            //Turn off controls
            if (Session["SecurityLevel"] == "A")
            {
                linkbtnNewEmployee.Visible = true;
                imgbtnNewEmployee.Visible = true;
                linkbtnViewUserActivity.Visible = true;
                imgbtnViewUserActivity.Visible = true;
                linkbtnEditEmployees.Visible = true;
                imgbtnEditEmployees.Visible = true;
                linkbtnEditUsers.Visible = true;
                imgbtnEditUsers.Visible = true;

            }
            // Add your comments here
            clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel");
        }
    }
}