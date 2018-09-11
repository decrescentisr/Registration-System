using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Annual_Salary_Cost_Calculator
{
    public partial class frmViewPersonnel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Declare the Dataset
                dsPersonnel myDataSet = new dsPersonnel();
                //Name value pair for the search value is passed as part of the request object.
                string strSearch = Request["txtSearch"];
                //Modifies the call of the GetPersonnel function
                //Fill the dataset with shat is returned from the method.
                myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), strSearch);
                //Set the DataGrid to the DataSource based on the table
                grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];
                //Bind the DataGrid
                grdViewPersonnel.DataBind();
            }

        }
    }
}