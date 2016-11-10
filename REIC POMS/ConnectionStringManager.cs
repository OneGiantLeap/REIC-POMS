using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Enables SqlConnectionStringBuilder
using MySql.Data.MySqlClient;

namespace REIC_POMS
{
    class ConnectionStringManager
    {
        //Global variables: To access them in other .cs files, simply type "ConnectionStringManager." then the variable name.
        public static MySqlConnection reicpomsConnection;

        public ConnectionStringManager()
        {

        }

        // FOR ACTUAL IMPLEMENTATION PURPOSES
        ///// <summary>
        ///// Database connection settings applied when the application is opened.
        ///// Has two kinds of settings: default settings (when the application is run for the first time)
        ///// and saved settings from the previous session.
        ///// </summary>
        ///// <param name="isFirstTime">Value of the "FirstRun" key under appSettings in App.config.</param>
        //public static void SetDefaultConStrings(bool isFirstTime)
        //{
        //    if (isFirstTime == true)
        //    {
        //        SetMySQLConString("localhost", "root", "", "reicpoms");
        //    }
        //    else
        //    {
        //        reicpomsConnectionString = Properties.Settings.Default.reicpomsConnectionString;
        //    }
        //}

        /// <summary>
        /// Builds, sets, and saves the MySQL Server database connection string.
        /// </summary>
        public static void SetMySQLConString(string server, string userID, string password, string database)
        {
            reicpomsConnection = new MySqlConnection(
                "Server=" + server + ";" +
                "Database=" + database + ";" +
                "User=" + userID + ";" +
                "Password=" + password + ";" +
                "Allow User Variables=True;" +
                "Convert Zero Datetime=True;" +
                "Allow Zero Datetime=True;");
            Properties.Settings.Default.reicpomsConnectionString = reicpomsConnection.ConnectionString;
            Properties.Settings.Default.Save();
        }

        ///// <summary>
        ///// Fetches the values of the current MySQL database connection settings.
        ///// </summary>
        //public static SqlConnectionStringBuilder GetMySqlConString()
        //{
        //    SqlConnectionStringBuilder conString = new SqlConnectionStringBuilder(reicpomsConnectionString.ConnectionString);
        //    return conString;
        //}
    }
}
