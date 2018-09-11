using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annual_Salary_Cost_Calculator
{
    public partial class frmPersonnelVerified : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtVerifiedInfo.Text = Session["txtFirstName"] +
                "\n" + Session["txtLastName"] +
                "\n" + Session["txtPayRate"] +
                "\n" + Session["txtStartDate"] +
                "\n" + Session["txtEndDate"];

            //Connects to the database to save data in the session
            if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.mdb"),
            Session["txtFirstName"].ToString(),
            Session["txtLastName"].ToString(),
            Session["txtPayRate"].ToString(),
            Session["txtStartDate"].ToString(),
            Session["txtEndDate"].ToString()))
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was successfully saved!";
            }
            else
            {
                txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was NOT saved.";
            }

        }
    }
}