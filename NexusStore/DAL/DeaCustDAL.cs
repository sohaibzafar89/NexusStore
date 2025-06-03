using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NexusStore.BLL;

namespace NexusStore.DAL
{
    internal class DeaCustDAL
    {
        // Static String Method for Database Connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT Method for Dealer and Customer
        public DataTable Select()
        {
            // SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Datatable to hold the value from database and return it
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Select all the Data from Database
                string sql = "SELECT * FROM tbl_dea_cust";

                // Creating SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Creating SQL Data Adapter to Store Data from Database Temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open Database Connection
                conn.Open();

                // Passing the value from SQL Data Adapter to DataTable
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
        #region INSERT Method to Add details of Dealer or Customer
        public bool Insert(DeaCustBLL dc)
        {
            // Creating SQL Connection First
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Create Boolean value and set its default value to false
            bool isSuccess = false;

            try
            {
                // Write SQL Query to Insert Details of Dealer or Customer
                string sql = "INSERT INTO tbl_dea_cust (type, name, email, contact, address, added_by, added_date) VALUES (@type, @name, @email, @contact, @address, @added_by, @added_date)";

                // SQL Command to Pass the values to query and execute
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing the values using parameters
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

                // Open Database Connection
                conn.Open();

                // Int variable to check whether the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                // If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
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
        #region UPDATE Method for Dealer and Customer Module
        public bool Update(DeaCustBLL dc)
        {
            // SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Create Boolean variable and set its default value to false
            bool isSuccess = false;

            try
            {
                // SQL Query to Update Data in Database
                string sql = "UPDATE tbl_dea_cust SET type=@type, name=@name, email=@email, contact=@contact, address=@address, added_date=@added_date, added_by=@added_by WHERE id=@id";

                // SQL Command to pass the value in sql
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing the values through Parameters
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

                // Open Database Connection
                conn.Open();

                // Int variable to check if the query executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                // If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
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
        #region DELETE Method for Dealer and Customer Module
        public bool Delete(DeaCustBLL dc)
        {
            // SQLConnection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Create a Boolean variable and set its default value to false
            bool isSuccess = false;

            try
            {
                // SQL Query to Delete Data from Database
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

                // SQL Command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing the values
                cmd.Parameters.AddWithValue("@id", dc.id);

                // Open the Database Connection
                conn.Open();

                // Int variable to check whether the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                // If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
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
        #region SEARCH Method for Dealer and Customer Module
        public DataTable Search(string keyword)
        {
            // Create a Sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Creating a Datatable and returning its value
            DataTable dt = new DataTable();

            try
            {
                // Write the Query to Search Dealer or Customer based in id, type and name
                string sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                // Sql Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Sql DataAdapter to hold the data from Database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open Database Connection
                conn.Open();

                // Passing the value from adapter to data value
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
        #region Method to SEARCH for DEALER and CUSTOMER for Transaction Module
        public DeaCustBLL SearchDealerCustomerForTransaction(string keyword) 
        {
            // Create an object for DeaCustBLL class
            DeaCustBLL dc = new DeaCustBLL();

            // Create a Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Create a DataTable to hold the value temporarily
            DataTable dt = new DataTable();

            try
            {
                // Write a SQL Query to Search Dealer or Customer on Keywords
                string sql = "SELECT name, email, contact, address from tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                
                // Create a Sql Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                // Open the Database Connection
                conn.Open();

                // Transfer the data from Sql DataAdapter to DataTable
                adapter.Fill(dt);

                // If we have values on dt we need to save it in dealerCustomer BLL
                if(dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();  
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

            return dc;
        }
        #endregion
        #region Method to Get ID of the Dealer or Customer Based on Name
        public DeaCustBLL GetDeaCustIDFromName(string name) 
        {
            // First Create an Object of DeaCust BLL and Return it
            DeaCustBLL dc = new DeaCustBLL();

            // SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // DataTable to hold the data temporarily
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Get id Based on Name
                string sql = "SELECT id FROM tbl_dea_cust WHERE name = '" + name + "'";

                // Create the SQL DataAdapter to Execute the Query
                SqlDataAdapter adapter= new SqlDataAdapter(sql, conn);

                // Open Database Connection
                conn.Open();

                // Passing the value from adapter to data value
                adapter.Fill(dt);

                // If we have values on dt we need to save it in dealerCustomer BLL
                if (dt.Rows.Count > 0)
                {
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return dc;
        }
        #endregion
    }
}
