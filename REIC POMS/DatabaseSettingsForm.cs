using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Enables SqlConnectionStringBuilder

namespace REIC_POMS
{
    public partial class DatabaseSettingsForm : Form
    {
        private bool settingsChanged;

        public DatabaseSettingsForm()
        {
            InitializeComponent();

            ////Display current database settings --> Maybe no need.
            //SqlConnectionStringBuilder conString = ConnectionStringManager.GetMySqlConString();
            //txtServer.Text = conString.DataSource;
            //txtUsername.Text = conString.UserID;
            //txtPassword.Text = conString.Password;
            //txtDbName.Text = conString.InitialCatalog;
        }

        /// <summary>
        /// Signals the Main Screens whether or not to refresh its DataGridView contents.
        /// </summary>
        public bool SettingsChanged
        {
            get { return settingsChanged; }
            set { settingsChanged = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //---Validation
            if (string.IsNullOrWhiteSpace(txtServer.Text))
            {
                MessageBox.Show("Please enter the database host or server name.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter the database username.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDbName.Text))
            {
                MessageBox.Show("Please enter the database name.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //No validation for password, since some debug databases don't have passwords.

            //---Save Configuration
            ConnectionStringManager.SetMySQLConString(txtServer.Text, txtUsername.Text, txtPassword.Text, txtDbName.Text);
            SettingsChanged = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SettingsChanged = false;
            Close();
        }
    }
}
