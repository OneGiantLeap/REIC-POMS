﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REIC_POMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TESTING OUT CODE; MAY NOT BE PART OF SYSTEM, REALLY.
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close(); //Exit the program
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //JUST TO TRANSITION TO THE MAIN SCREEN
            if ((txtUsername.Text == "wennie") && (txtPassword.Text == "1234"))
            {
                ItemsMainScreen ims = new ItemsMainScreen();
                ims.ShowDialog();
                Close(); //Close the Log-in Screen
            }
            else
                MessageBox.Show("The username or password you entered is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

    }
}