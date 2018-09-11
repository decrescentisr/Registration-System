using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annual_Salary_Cost_Calculator
{
    public partial class frmPersonnel : System.Web.UI.Page
    {
        private bool validatedState;

        protected void Page_Load(object sender, EventArgs e)
        {

            // Tests the security level and makes sure the user has a "A" clearance
            if (Session["SecurityLevel"] == "A")
            {
                btnSubmit.Visible = true;
                //Lists the menu contents if the user has a "A" clearance level
            }
            else
            {
                btnSubmit.Visible = false;
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool allCorrect = true;
            lblError.Text = "";
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            txtEndDate.BackColor = System.Drawing.Color.Yellow;

            if (Request["txtFirstName"].ToString().Trim() == "")
            {
                allCorrect = false;
                txtFirstName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "First Name is required <br/>";
            }
            if (Request["txtLastName"].ToString().Trim() == "")
            {
                allCorrect = false;
                txtLastName.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Last Name is required <br/>";
            }
            if (Request["txtPayRate"].ToString().Trim() == "")
            {
                allCorrect = false;
                txtPayRate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Pay Rate is required <br/>";
            }
            if (Request["txtStartDate"].ToString().Trim() == "")
            {
                allCorrect = false;
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "Start Date is required <br/>";
            }
            if (Request["txtEndDate"].ToString().Trim() == "")
            {
                allCorrect = false;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = lblError.Text + "End Date is required <br/>";
            }

            if (allCorrect)
            {
                DateTime myStartDate = DateTime.Parse(txtStartDate.Text);
                DateTime myEndDate = DateTime.Parse(txtEndDate.Text);
                if (DateTime.Compare(myStartDate, myEndDate) > 0)
                {
                    allCorrect = false;
                    txtStartDate.BackColor = System.Drawing.Color.Yellow;
                    txtEndDate.BackColor = System.Drawing.Color.Yellow;
                    lblError.Text = lblError.Text + "Start Date must be earlier than the End Date <br/>";
                    //The Msg text will be displayed in lblError.Text after all the error messages are concatenated
                    validatedState = false;
                    //Boolean value - test each textbox to see if the data entered is valid, if not set validState=false. 
                    //If after testing each validation rule, the validatedState value is true, then submit to frmPersonnelVerified.aspx, if not, then display error message
                
                }
                else
                {
                    txtStartDate.BackColor = System.Drawing.Color.White;
                    txtEndDate.BackColor = System.Drawing.Color.White;
                }
            }

            if (allCorrect)
            {
                Session["txtFirstName"] = txtFirstName.Text;
                Session["txtLastName"] = txtLastName.Text;
                Session["txtPayRate"] = txtPayRate.Text;
                Session["txtStartDate"] = txtStartDate.Text;
                Session["txtEndDate"] = txtEndDate.Text;
                //Need to set session variables for all text boxes
                Response.Redirect("frmPersonnelVerified.aspx");
            }

            // Prevents an invalid date from causing a server error for Start and End Dates
            try
            {
                DateTime.Parse(txtStartDate.Text);
            }
            catch
            {
                txtStartDate.Text = DateTime.Today.ToShortDateString();
            }
            try
            {
                DateTime.Parse(txtEndDate.Text);
            }
            catch
            {
                txtEndDate.Text = DateTime.Today.ToLongDateString();
            }

            
        }
    }
}