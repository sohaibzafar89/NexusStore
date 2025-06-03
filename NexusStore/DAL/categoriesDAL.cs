using NexusStore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexusStore.DAL
{
    internal class categoriesDAL
    {
        // Static String Method for Database Connection String
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method
        public DataTable Select()
        {
            // Creating Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                // Write SQL Query to get all the data from Database
                string sql = "SELECT * FROM tbl_categories";

                //Creating SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open Database Connection
                conn.Open();

                // Adding the value from adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region Insert New Category
        public bool Insert (categoriesBLL c)
        {
            // Creatign a Boolean Variable and set its default value to False
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Writing Query to Add new Category
                string sql = "INSERT INTO tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by)";

                // Creating SQL Command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing Values through the parameter
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

                // Open Database Connection
                conn.Open();

                // Creating the int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                // If the query is executed successfully then its value will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    // Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    // Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); 
            }
            return isSuccess;
        }
        #endregion
        #region Update Method
        public bool Update(categoriesBLL c)
        {
            // Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            // Creating SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Query to Update Category
                string sql = "UPDATE tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

                // SQL Command to Pass the value on Sql Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing Value using cmd
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                // Open Database Connection
                conn.Open();

                // Create Int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                // If the query is successfully executed then the value will be greater than zero
                if (rows > 0)
                {
                    // Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    // Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Delete Category Method
        public bool Delete(categoriesBLL c)
        {
            // Create a Boolean variable and set its value to false
            bool isSuccess = false;

            // Creating SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL Query to Delete from Database
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                // SQL Command to Pass the value on Sql Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing the value using cmd
                cmd.Parameters.AddWithValue("@id", c.id);

                // Open Sql Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                // If the Query is executed successfully than the value of rows will be greater than zero else it will be less than zero
                if (rows > 0)
                {
                    // Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    // Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); 
            }

            return isSuccess;
        }
        #endregion
        #region Method for Search Functionality
        public DataTable Search(string keywords)
        {
            // SQL Conneciton For Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Creating DataTable to hold the data from Database temporarily
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Search Categories from the Database
                string sql = "SELECT * FROM tbl_categories Where id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" +keywords + "%'";

                // Creating SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Getting Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open Database Connection
                conn.Open();

                // Passing the values from adapter to DataTable
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion

    }
}
