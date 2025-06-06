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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // Creating Datatable to hold the categories from Database
            DataTable categoriesDT = cdal.Select();

            // Specify DataSource for Category Combobox
            cmbCategory.DataSource = categoriesDT;

            // Specify Display Memeber and Value Member for Combobox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            // Load all the products in DataGridView
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get all the values from Product Form
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            // Getting username of logged in user
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            // Create Boolean variable to check if the product is added successfully or not
            bool success = pdal.Insert(p);

            // If the product is added successfully then the value of success will be true else it will be false
            if (success == true) 
            {
                // Product Inserted Successfully
                MessageBox.Show("Product Added Successfully");

                // Calling the Clear Method
                Clear();

                // Refreshing DataGridView
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                // Failed to Add New Product
                MessageBox.Show("Failed to Add New Product");
            }
        }
        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Create integer variable to know which product was clicked
            int rowIndex = e.RowIndex;

            // Display the value on Respective Textboxes
            txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the Values from UI or Product Form
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            // Getting username of logged in user for added by
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            // Create a boolean variable to check if the product is updated or not
            bool success = pdal.Update(p);

            // If the product is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                // Product Updated Successfully
                MessageBox.Show("Product Updated Successfully");

                // Calling the Clear Method
                Clear();

                // Refresh the DataGridView
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                // Failed to Update Product
                MessageBox.Show("Failed to Update Product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the ID of the product to be deleted
            p.id = int.Parse(txtID.Text);

            // Create Bool Variable to check if the product is deleted or not
            bool success = pdal.delete(p);

            // If the product is deleted successfully then the value of the success will be true else it will be false
            if (success == true) 
            {
                // Product Successfully Deleted
                MessageBox.Show("Product Successfully Deleted");
                
                // Calling the Clear Method
                Clear();

                // Refresh the DataGridView
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                // Failed to Delete Product
                MessageBox.Show("Failed to Delete Product");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the Keywords from form
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                // Search the products
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                // Display all the products
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
