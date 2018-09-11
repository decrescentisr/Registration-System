using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annual_Salary_Cost_Calculator
{
    public partial class frmSalaryCostCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare variables to be used in calculations.
            double hours = 0.0; //Will hold the numeric value of hours from text box
            double rate = 0.0; //Will hold the numeric value of rate from the text box
            double salary = 0.0; //Will be the salary after the hours and rate are calculated

            //Extract values from the textboxes
            hours = Double.Parse(txtAnnualHours.Text);
            rate = Double.Parse(txtPayRate.Text);

            //Perform calculations using the numeric variables, which now hold values from text boxes
            salary = hours * rate;

            //Display results by assigning values to labels on the form.
            lblAnnualSalary.Text = "Annual Salary is: " + salary.ToString("C"); //C formats for currency
        }
    }
}