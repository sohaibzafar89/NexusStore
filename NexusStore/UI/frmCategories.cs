﻿using NexusStore.BLL;
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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the values from Category Form
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            // Getting ID in Added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            // Passing the id of Logged in User in added by field
            c.added_by = usr.id;

            // Creating Boolean Method To insert data into Database
            bool success = dal.Insert(c);

            // If the category is inserted successfully then the value of the success will be true else it will be false
            if(success == true)
            {
                // NewCategory Inserted Successfully
                MessageBox.Show("New Category Inserted Successfully");
                Clear();

                // Refresh DataGridView
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                // Failed to Insert New Category
                MessageBox.Show("Failed to Insert New Category");
            }
        }
        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            // Here write the code to display all the categories in the DataGridView
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Finding the Row Index of the Row Clicked on DataGridView
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the values from the Category form
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            // Getting ID in Added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            // Passing the id of Logged in User in added by field
            c.added_by = usr.id;

            // Creating Boolean variable to update categories and check
            bool success = dal.Update(c);

            // If the category is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                // Category updated successfully
                MessageBox.Show("Category Updated Successfully");
                Clear();

                // Refresh DataGridView
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                // Failed to update Category
                MessageBox.Show("Failed to Update Category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the ID of the Category which we want to Delete
            c.id = int.Parse(txtCategoryID.Text);

            // Creating Boolean variable to Delete the Category
            bool success = dal.Delete(c);

            // If the Category is Deleted Successfully then the value of success will be true else it will be false
            if (success == true)
            {
                // Category Deleted Successfully
                MessageBox.Show("Category Deleted Successfully");
                Clear();

                // Refreshing DataGridView
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                // Failed to Delete Category
                MessageBox.Show("Failed to Delete Category");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the Keywords
            string keywords = txtSearch.Text;

            // Filter the Categories based on Keywords
            if (keywords != null)
            {
                // Use Search Method to Display Categories 
                DataTable dt = dal.Search(keywords);
                dgvCategories.DataSource = dt;
            }
            else
            {
                //Use select Method to Display all Categories
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
