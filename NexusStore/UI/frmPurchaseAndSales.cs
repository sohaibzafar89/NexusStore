using DGVPrinterHelper;
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
using System.Transactions;
using System.Windows.Forms;

namespace NexusStore.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DeaCustDAL dcDAL = new DeaCustDAL();
        productsDAL pDAL = new productsDAL();
        userDAL uDAL = new userDAL();
        transactionDAL tDAL = new transactionDAL();
        transactionDetailDAL tdDAL = new transactionDetailDAL();

        DataTable transactionDT = new DataTable();

        private void pnlDeaCust_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            // Get the transactionType value from frmUserDashboard 
            string type = frmUserDashboard.transactionType;

            // Set the value on lblTop
            lblTop.Text = type;

            // Specify Columns for our TransactionDataTable
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Qty");
            transactionDT.Columns.Add("Total");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the Keyword from textbox
            string keyword = txtSearch.Text;

            if (keyword == "")
            {
                // Clear all the textboxes
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }
            
            // Write the code to get the details and set the value on the textboxes
            DeaCustBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);

            // Now transfer or set the value from DeaCustBLL to textboxes
            txtName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            // Get the keyword from productsearch textbox
            string keyword = txtSearchProduct.Text;

            // Check if we have value to txtSearchProduct or not
            if(keyword == "")
            {
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";
                return;
            }

            // Search the product and display on respective textboxes
            productsBLL p = pDAL.GetProductsForTransaction(keyword);

            txtProductName.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get Product Name, Rate and Qty Cutomer wants to buy
            string productName = txtProductName.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQty.Text);

            decimal Total = Rate * Qty;  // Total = RatexQty

            // Display the Subtotal in textbox
            // Get the total value from textbox
            decimal subtotal = decimal.Parse(txtSubTotal.Text);
            subtotal = subtotal + Total;

            // Check whether the product is selected or not
            if (productName == "")
            {
                // Display Error Message
                MessageBox.Show("Select the product first. Try Again.");
            }
            else
            {
                // Add Product to the DataGridView
                transactionDT.Rows.Add(productName, Rate, Qty, Total);

                // Show in DataGridView
                dgvAddedProducts.DataSource = transactionDT;

                // Display the Subtotal in Textbox
                txtSubTotal.Text = subtotal.ToString();

                // Clear the Textboxes
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "0.00";
                txtRate.Text = "0.00";
                txtQty.Text = "0.00";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            // Get the value for discount textbox
            string value = txtDiscount.Text;

            if (value == "")
            {
                // Display Error Message
                MessageBox.Show("Please Add Discount First");
            }
            else
            {
                // Get the Discount in decimal value
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);

                // Calculate the grandtotal based on discount
                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                // Display the GrandTotal in Textbox
                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            // Check if the grandTotal has value or not if it has not value then calculate the discount first
            string check = txtGrandTotal.Text;

            if (check == "")
            {
                // Display the error message to calculate discount
                MessageBox.Show("Calculate the discount and set the Grand Total First.");
            }
            else
            {
                // Calculate VAT
                // Getting the VAT Percent first
                decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                decimal vat = decimal.Parse(txtVat.Text);
                decimal grandTotalWithVAT = (100 + vat) / 100 * previousGT;

                // Displaying new grand total with vat
                txtGrandTotal.Text = grandTotalWithVAT.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            // Get the paid amount and grand Total
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            // Display the return amount as well
            txtReturnAmount.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the values from PurchaseSales Form First
            transactionsBLL transaction = new transactionsBLL();

            transaction.type = lblTop.Text;

            // Get the ID of Dealer or Customer here
            // Lets get name of the dealer or customer first
            string deacustName = txtName.Text;
            DeaCustBLL dc = dcDAL.GetDeaCustIDFromName(deacustName);

            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtVat.Text);
            transaction.discount = decimal.Parse(txtDiscount.Text);

            //Get the Username of the Logged in user
            string username = frmLogin.loggedIn;
            userBLL u = uDAL.GetIDFromUsername(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            // Lets Create a Boolean Variable and set its value to false
            bool success = false;

            // Actual Code to Insert Transactin and Transaction Details
            using(TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                // Create a boolean value and insert transaction
                bool w = tDAL.Insert_Transaction(transaction, out transactionID);

                // Use for loop to insert Transaction Details 
                for (int i = 0; i < transactionDT.Rows.Count; i++) 
                {
                    // Get all the details of the product
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();

                    // Get the Product name and convert it to id
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDAL.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;

                    // Increase Or Decrease Product Quantity based on Purchase or Sales
                    string transactionType = lblTop.Text;

                    // Check whether we are on Purchase or Sales
                    bool x = false;
                    if (transactionType == "Purchase")
                    {
                        // Increase the Product
                        x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {
                        // Decrease the Product
                        x = pDAL.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }

                    // Insert Transaction Details inside the database
                    bool y = tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;
                }
                
                if (success == true)
                {
                    // Transaction Complete
                    scope.Complete();

                    // Code to Print Bill
                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n\r\n NEXUSSTORE PVT. LTD. \r\n\r\n";
                    printer.SubTitle = "Lahore, Pakistan \r\n Phone: 0335-04XXXXX \r\n\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount: " + txtDiscount.Text + "% \r\n" + "VAT: " + txtVat.Text + "% \r\n" + "Grand Total: " + txtGrandTotal.Text + "\r\n\r\n" + "Thank you for doing buiness with us";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dgvAddedProducts);

                    MessageBox.Show("Transaction Completed Successfully");

                    // Clear the DataGridView and Clear all the Textboxes
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtSearchProduct.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQty.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVat.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";
                }
                else
                {
                    // Transaction Failed
                    MessageBox.Show("Transaction Failed");
                }
            }

        }
    }
}
