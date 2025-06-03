using NexusStore.BLL;
using NexusStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexusStore.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public static string loggedIn;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            // Code to close this form
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Assign values from the form to the LoginBLL instance
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            // Checking the Login Credentials
            bool success = dal.loginCheck(l); // Pass the LoginBLL instance

            if (success == true)
            {
                // Login Successful 
                MessageBox.Show("Login Successful");
                loggedIn = l.username;
                // Need to open Respective Forms based on User Type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            // Display Admin Dashboard
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            // Display User Dashboard
                            frmUserDashboard user = new frmUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            // Display an error message
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }
            }
            else
            {
                // Login Failed
                MessageBox.Show("Login Failed. Try Again");
            }
        }
    }
}
