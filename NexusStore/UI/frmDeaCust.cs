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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // Write the code to close this form
            this.Hide();
        }

        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcDal = new DeaCustDAL();
        userDAL uDal = new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the values from Form
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            // Getting the ID to logged in user and passing its value in dealer or customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            // Creating boolean variable to check whether the dealer or customer is added or not
            bool success = dcDal.Insert(dc);

            if (success == true) 
            {
                // Dealer or Customer inserted successfully
                MessageBox.Show("Dealer or Customer inserted successfully");

                // Calling the Clear Method
                Clear();

                // Refreshing DataGridView
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                // Failed to Insert Dealer or customer
                MessageBox.Show("Failed to Insert Dealer or customer");
            }
        }
        public void Clear()
        {
            txtDeaCustID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            // Refreshing DataGridView
            DataTable dt = dcDal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Create integer variable to know which row was clicked
            int rowIndex = e.RowIndex;

            // Display the value on Respective Textboxes
            txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCust.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the values from Form
            dc.id = int.Parse(txtDeaCustID.Text);
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            // Getting the ID to logged in user and passing its value in dealer or customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            // Create boolean variable to check whether the dealer or cutomer is updated or not
            bool success = dcDal.Update(dc);

            if (success == true) 
            {
                // Dealer and Customer updated successfully
                MessageBox.Show("Dealer and Customer updated successfully");

                // Calling the Clear Method
                Clear();

                // Refresh the DataGridView
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                // Failed to update Dealer or Customer
                MessageBox.Show("Failed to Update Dealer or Customer");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the id of the user to be deleted from Form
            dc.id = int.Parse(txtDeaCustID.Text);

            // Create Boolean variable to check whether the dealer or customer is deleted or not
            bool success = dcDal.Delete(dc);

            if (success == true) 
            {
                // Dealer or Customer Deleted Successfully
                MessageBox.Show("Dealer or Customer Deleted Successfully");

                // Calling the Clear Method
                Clear();

                // Refreshing DataGridView
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                // Failed to Delete Dealer or Customer
                MessageBox.Show("Failed to Delete Dealer or Customer");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the keyword from textbox
            string keyword = txtSearch.Text;

            if (keyword != null)
            {
                // Search the Dealer or Customer
                DataTable dt = dcDal.Search(keyword);
                dgvDeaCust.DataSource= dt;
            }
            else
            {
                // Show all the Dealer or Customer
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
