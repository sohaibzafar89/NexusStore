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
    internal class productsDAL
    {
        // Creating Static String Method for Database Connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method for Product Module
        public DataTable Select()
        {
            // Create Sql Connection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Datatable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                // Writing the Query to Select all the products from Database
                string sql = "SELECT * FROM tbl_products";

                // Creating SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // SQL Data Adapter to hold the data from Database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open Database Connection
                conn.Open();

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
        #region Method to Insert Product in Database
        public bool Insert(productsBLL p)
        {
            // Creating Boolean Variable and set it's default value to false
            bool isSuccess = false;

            // Sql Connection for Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL Query to Insert product into database
                string sql = "INSERT INTO tbl_products (name, category, description, rate, qty, added_date, added_by)VALUES (@name, @category, @description, @rate, @qty, @added_date, @added_by)";

                // Creating SQL Command to pass the values
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing the values through parameters
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                // Opening the Database Connection
                conn.Open();

                // **ExecuteNonQuery returns the no. of rows effected after executing the query**
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
        #region Method to Update Product in Database
        public bool Update(productsBLL p)
        {
            // Create a boolean variable and set its initial value to false
            bool isSuccess = false;

            // Create SQL Connection for Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // SQL Query to Update data in Database
                string sql = "UPDATE tbl_products SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id";

                // Create Command to pass the value to query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                // Open the Database Connection
                conn.Open();

                // Create the int variable to check the query is executed successfully or not
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally 
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Method to Delete Product from Database
        public bool delete(productsBLL p)
        {
            // Create Boolean Variable and set its default value to false
            bool isSuccess = false;

            // SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Write Query Product from Database
                string sql = "DELETE FROM tbl_products WHERE id=@id";

                // SQL Command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Passing the values using cmd
                cmd.Parameters.AddWithValue("@id", p.id);

                // Open Database Connection
                conn.Open();

                // Create the int variable to check the query is executed successfully or not
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
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Search Method for Product Module
        public DataTable Search(string keywords)
        {
            // SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Creating Datatable to hold value from Database
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to select product
                string sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";

                // SQL Command to execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // SQL Data Adapter to hold the data from database temporarily
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
        #region Method to SEARCH Product in Transaction Module
        public productsBLL GetProductsForTransaction(string keyword)
        {
            // Create an object of productsBLL and return it
            productsBLL p = new productsBLL();

            // SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Datatable to store data temporarily
            DataTable dt = new DataTable();

            try
            {
                // Write the Query to get the Detail
                string sql = "SELECT name, rate, qty from tbl_products WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                // Create a Sql Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                // Open the Database Connection
                conn.Open();

                // Transfer the data from Sql DataAdapter to DataTable
                adapter.Fill(dt);

                // If we have values on dt we need to save it in productsBLL
                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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

            return p;
        }
        #endregion
        #region Method to Get Product ID Based on Product Name
        public productsBLL GetProductIDFromName(string ProductName)
        {
            // First Create an Object of DeaCust BLL and Return it
            productsBLL p = new productsBLL();

            // SQL Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // DataTable to hold the data temporarily
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Get id Based on Name
                string sql = "SELECT id FROM tbl_products WHERE name = '" + ProductName + "'";

                // Create the SQL DataAdapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                // Open Database Connection
                conn.Open();

                // Passing the value from adapter to data value
                adapter.Fill(dt);

                // If we have values on dt we need to save it in dealerCustomer BLL
                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return p;
        }
        #endregion
        #region Method to Get the Current Quantity from the Database based on Product ID
        public decimal GetProductQty(int ProductID) 
        {
            // SQL Query for Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Create a Decimal Variable and set its default value to 0
            decimal qty = 0;

            // Create DataTable to save the data from Database temporarily
            DataTable dt = new DataTable();

            try
            {
                // Write SQL Query to Get Quantity from Database
                string sql = "SELECT qty FROM tbl_products WHERE id = " + ProductID;

                // Create a SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Create a SQL DataAdapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open Datatbase Connection
                conn.Open();

                // Pass the value from DataAdapter to Database
                adapter.Fill(dt);

                // Lets check if the datatable has value or not
                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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

            return qty;
        }
        #endregion
        #region Method to Update Quantity
        public bool UpdateQuantity(int ProductID, decimal Qty) 
        {
            // Create a Boolean Variable and Set its value to false
            bool success = false;

            // SQL Connection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Write te SQL Query to Update Qty
                string sql = "UPDATE tbl_products SET qty=@qty WHERE id=@id";

                // Create SQL Command to Pass the value into Query
                SqlCommand cmd = new SqlCommand (sql, conn);

                // Passing the values throught Parameters
                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);

                // Open Database Connection
                conn.Open();

                // Create Int Variable and check whether the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                // If the Query is Executed successfully or not
                if (rows > 0) 
                {
                    // Query Executed Successfully
                    success = true;
                }
                else
                {
                    // Failed to Execute Successfully
                    success = false;
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

            return success;
        }
        #endregion
        #region Method to Increase Product
        public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
        {
            // Create a Boolean Variable and Set its value to False
            bool success = false;

            // Create SQL Connection To Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                // Get the Current Qty from Database based on id 
                decimal currentQty = GetProductQty(ProductID);

                // Increase the Current Quantity by the qty purchased from Dealer
                decimal NewQty = currentQty + IncreaseQty;

                // Update the Product Quantity Now
                success = UpdateQuantity(ProductID, NewQty);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
        #endregion#
        #region Method to Decrease Product
        public bool DecreaseProduct(int ProductID, decimal Qty)
        {
            // Create a Boolean Variable and Set its value to False
            bool success = false;

            // Create a Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try 
            {
                // Select the Product Quantity
                decimal currentQty = GetProductQty(ProductID);

                // Decrease the Product Quantity based on Product Sales
                decimal NewQty = currentQty - Qty;

                // Update Product in Database
                success = UpdateQuantity(ProductID, NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
        #endregion
        #region Display Products Based on Categories
        public DataTable DisplayProductsByCategory(string category) 
        {
            // SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            // Creating Datatable to hold value from Database
            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Display the Product Based on Category
                string sql = "SELECT * FROM tbl_products WHERE category='" + category + "'";

                // SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                // SqlDataAdapter to Hold the data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Open the Database Connection
                conn.Open();

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
    }
}
