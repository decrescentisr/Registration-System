using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Net;
using System.Data;

namespace Annual_Salary_Cost_Calculator
{
    public class clsDataLayer
    {

        public static bool SaveUser(string Database, string UserName, string Password,
string SecurityLevel)
        {
            try
            {

                // Connects to the database to save the information
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; " +
                "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;
                strSQL = "Insert into tblUserLogin (UserName, UserPassword, SecurityLevel) values ('" +
                UserName + "', '" + Password + "', '" + SecurityLevel + "')";
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                conn.Close();


                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public clsDataLayer() //Constructor
        {

        }
        // This function gets the user activity from the tblUserActivity
        public static userActivity GetUserActivity(string Database)
        {
            // Opens the userActivity Data Set
            userActivity DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // Connects to the database
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; " + "Data Source=" + Database);
            // Selects from the tblUserActivity table
            sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
            // Creates a new User Activity
            DS = new userActivity();
            // Fills the table with data
            sqlDA.Fill(DS.tblUserActivity);
            // Returns the data to the data set
            return DS;
        }
        // This function saves the user activity
        public static void SaveUserActivity(string Database, string FormAccessed)
        {
            // Connects to the database to save the information
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; " +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;
            strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            command.ExecuteNonQuery();
            conn.Close();
        }
        // This function gets the IP Address
        public static string GetIP4Address()
        {
            string IP4Address = string.Empty;
            foreach (IPAddress IPA in
            Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            if (IP4Address != string.Empty)
            {
                return IP4Address;
            }
            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily.ToString() == "InterNetwork")
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }
            return IP4Address;
        }


        // This function saves the personnel data
        public static bool SavePersonnel(string Database, string FirstName, string LastName,
        string PayRate, string StartDate, string EndDate)
        {
            //Opens the transaction and sets it to null
            OleDbTransaction myTransaction = null;

            bool recordSaved;
            try
            {
                // Allows the SavePersonnel from the frmPersonnelVerified.aspx page to connect to the database and save data.
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;

                //Begins the transaction after connecting to the database
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;

                // Inserts data into tblPersonnel
                strSQL = "Insert into tblPersonnel " +
        "(FirstName, LastName) values ('" +
        FirstName + "', '" + LastName + "')";
                // Creates a command type
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // Creates a command to execute a non query
                command.ExecuteNonQuery();

                //Commits the transaction
                myTransaction.Commit();

                // Updates tblPersonnel with information
                strSQL = "Update tblPersonnel " +
                "Set PayRate=" + PayRate + ", " +
                "StartDate='" + StartDate + "', " +
                "EndDate='" + EndDate + "' " +
                "Where ID=(Select Max(ID) From tblPersonnel)";
                // Creates a command type
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // Creates a command to execute a non query
                command.ExecuteNonQuery();
                // Closes the connection and saves the record
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                //Rolls the transaction back to original state
                myTransaction.Rollback();
                recordSaved = false;
            }
            return recordSaved;
        }
        // This function gets the user activity from the tblPersonnel
        public static dsPersonnel GetPersonnel(string Database, string strSearch)
        {
            // Opens the userActivity Data Set
            dsPersonnel DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            // Connects to the database
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0; " + "Data Source=" + Database);
            // Selects from the tblPersonnel table

            if (strSearch == null || strSearch.Trim() == "")
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
            }
            else
            {
                sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
            }
            // Creates a new activity in table personnel
            DS = new dsPersonnel();
            // Fills the table with data
            sqlDA.Fill(DS.tblPersonnel);
            // Returns the data to the data set
            return DS;
        }

        // This function verifies a user in the tblUser table
        public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
        {
            //Initializes connection to the dsUser data set
            dsUser DS;
            OleDbConnection sqlConn;
            OleDbDataAdapter sqlDA;
            //Creates new connection to the dsUser data set
            sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);
            // Connects to the UserLogin database
            sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
            "where UserName like '" + UserName + "' " +
            "and UserPassword like '" + UserPassword + "'", sqlConn);
            // Adds new user to the dataset
            DS = new dsUser();
            // Fills the data into the table
            sqlDA.Fill(DS.tblUserLogin);
            // Returns the data set
            return DS;
        }
    }
}