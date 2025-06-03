namespace NexusStore.UI
{
    partial class frmPurchaseAndSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlDeaCust = new System.Windows.Forms.Panel();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDeaCustTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.pnldataGridView = new System.Windows.Forms.Panel();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.lblDGVTitle = new System.Windows.Forms.Label();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblCalculationTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.pnlDeaCust.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnldataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.pnlCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 46);
            this.panel1.TabIndex = 4;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1230, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(42, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(515, 6);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(257, 32);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "PURCHASE AND SALES";
            // 
            // pnlDeaCust
            // 
            this.pnlDeaCust.Controls.Add(this.dtpBillDate);
            this.pnlDeaCust.Controls.Add(this.txtContact);
            this.pnlDeaCust.Controls.Add(this.txtName);
            this.pnlDeaCust.Controls.Add(this.txtAddress);
            this.pnlDeaCust.Controls.Add(this.txtEmail);
            this.pnlDeaCust.Controls.Add(this.txtSearch);
            this.pnlDeaCust.Controls.Add(this.lblBillDate);
            this.pnlDeaCust.Controls.Add(this.lblAddress);
            this.pnlDeaCust.Controls.Add(this.lblContact);
            this.pnlDeaCust.Controls.Add(this.lblEmail);
            this.pnlDeaCust.Controls.Add(this.lblName);
            this.pnlDeaCust.Controls.Add(this.lblSearch);
            this.pnlDeaCust.Controls.Add(this.lblDeaCustTitle);
            this.pnlDeaCust.Location = new System.Drawing.Point(13, 53);
            this.pnlDeaCust.Name = "pnlDeaCust";
            this.pnlDeaCust.Size = new System.Drawing.Size(1250, 120);
            this.pnlDeaCust.TabIndex = 5;
            this.pnlDeaCust.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeaCust_Paint);
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(1027, 37);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(220, 34);
            this.dtpBillDate.TabIndex = 13;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(395, 77);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(220, 34);
            this.txtContact.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(80, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 34);
            this.txtName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(710, 36);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 75);
            this.txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(395, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 34);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(80, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 34);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.Location = new System.Drawing.Point(936, 36);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(84, 28);
            this.lblBillDate.TabIndex = 7;
            this.lblBillDate.Text = "Bill Date";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(624, 36);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 28);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(309, 73);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(80, 28);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(309, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 28);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 28);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblDeaCustTitle
            // 
            this.lblDeaCustTitle.AutoSize = true;
            this.lblDeaCustTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCustTitle.Location = new System.Drawing.Point(4, 4);
            this.lblDeaCustTitle.Name = "lblDeaCustTitle";
            this.lblDeaCustTitle.Size = new System.Drawing.Size(283, 28);
            this.lblDeaCustTitle.TabIndex = 0;
            this.lblDeaCustTitle.Text = "Dealer and Customer Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtInventory);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtSearchProduct);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblRate);
            this.panel2.Controls.Add(this.lblInventory);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.lblProductSearch);
            this.panel2.Controls.Add(this.lblProductTitle);
            this.panel2.Location = new System.Drawing.Point(13, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 85);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1169, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(788, 38);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(158, 34);
            this.txtRate.TabIndex = 10;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1005, 38);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(158, 34);
            this.txtQty.TabIndex = 9;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(569, 39);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(158, 34);
            this.txtInventory.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(310, 39);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(158, 34);
            this.txtProductName.TabIndex = 7;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(80, 39);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(158, 34);
            this.txtSearchProduct.TabIndex = 6;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(951, 38);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(48, 28);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Qty.";
            this.lblQuantity.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(731, 38);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(51, 28);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Rate";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(472, 39);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(95, 28);
            this.lblInventory.TabIndex = 3;
            this.lblInventory.Text = "Inventory";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(243, 38);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(64, 28);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Name";
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.Location = new System.Drawing.Point(3, 38);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(70, 28);
            this.lblProductSearch.TabIndex = 1;
            this.lblProductSearch.Text = "Search";
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.Location = new System.Drawing.Point(4, 6);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(158, 28);
            this.lblProductTitle.TabIndex = 0;
            this.lblProductTitle.Text = "Product Details";
            // 
            // pnldataGridView
            // 
            this.pnldataGridView.Controls.Add(this.dgvAddedProducts);
            this.pnldataGridView.Controls.Add(this.lblDGVTitle);
            this.pnldataGridView.Location = new System.Drawing.Point(13, 300);
            this.pnldataGridView.Name = "pnldataGridView";
            this.pnldataGridView.Size = new System.Drawing.Size(618, 448);
            this.pnldataGridView.TabIndex = 7;
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(9, 40);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.RowHeadersWidth = 62;
            this.dgvAddedProducts.RowTemplate.Height = 28;
            this.dgvAddedProducts.Size = new System.Drawing.Size(597, 375);
            this.dgvAddedProducts.TabIndex = 1;
            // 
            // lblDGVTitle
            // 
            this.lblDGVTitle.AutoSize = true;
            this.lblDGVTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGVTitle.Location = new System.Drawing.Point(4, 4);
            this.lblDGVTitle.Name = "lblDGVTitle";
            this.lblDGVTitle.Size = new System.Drawing.Size(162, 28);
            this.lblDGVTitle.TabIndex = 0;
            this.lblDGVTitle.Text = "Added Products";
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.Controls.Add(this.btnSave);
            this.pnlCalculation.Controls.Add(this.txtReturnAmount);
            this.pnlCalculation.Controls.Add(this.txtPaidAmount);
            this.pnlCalculation.Controls.Add(this.txtGrandTotal);
            this.pnlCalculation.Controls.Add(this.txtVat);
            this.pnlCalculation.Controls.Add(this.txtDiscount);
            this.pnlCalculation.Controls.Add(this.txtSubTotal);
            this.pnlCalculation.Controls.Add(this.lblReturnAmount);
            this.pnlCalculation.Controls.Add(this.lblPaidAmount);
            this.pnlCalculation.Controls.Add(this.lblGrandTotal);
            this.pnlCalculation.Controls.Add(this.lblVat);
            this.pnlCalculation.Controls.Add(this.lblDiscount);
            this.pnlCalculation.Controls.Add(this.lblSubTotal);
            this.pnlCalculation.Controls.Add(this.lblCalculationTitle);
            this.pnlCalculation.Location = new System.Drawing.Point(642, 300);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(621, 448);
            this.pnlCalculation.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(275, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(247, 50);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtReturnAmount.Location = new System.Drawing.Point(202, 287);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.ReadOnly = true;
            this.txtReturnAmount.Size = new System.Drawing.Size(386, 55);
            this.txtReturnAmount.TabIndex = 12;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(202, 237);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(386, 34);
            this.txtPaidAmount.TabIndex = 11;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(202, 187);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(386, 34);
            this.txtGrandTotal.TabIndex = 10;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(202, 137);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(386, 34);
            this.txtVat.TabIndex = 9;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(202, 87);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(386, 34);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(202, 41);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(386, 34);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.Text = "0";
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmount.Location = new System.Drawing.Point(10, 290);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(145, 28);
            this.lblReturnAmount.TabIndex = 6;
            this.lblReturnAmount.Text = "Return Amount";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(10, 240);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(125, 28);
            this.lblPaidAmount.TabIndex = 5;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(10, 190);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(113, 28);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(10, 140);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(78, 28);
            this.lblVat.TabIndex = 3;
            this.lblVat.Text = "VAT (%)";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(10, 90);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(122, 28);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(10, 40);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(93, 28);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblCalculationTitle
            // 
            this.lblCalculationTitle.AutoSize = true;
            this.lblCalculationTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculationTitle.Location = new System.Drawing.Point(4, 4);
            this.lblCalculationTitle.Name = "lblCalculationTitle";
            this.lblCalculationTitle.Size = new System.Drawing.Size(190, 28);
            this.lblCalculationTitle.TabIndex = 0;
            this.lblCalculationTitle.Text = "Calculation Details";
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1275, 760);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.pnldataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDeaCust);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPurchaseAndSales";
            this.Load += new System.EventHandler(this.frmPurchaseAndSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.pnlDeaCust.ResumeLayout(false);
            this.pnlDeaCust.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnldataGridView.ResumeLayout(false);
            this.pnldataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlDeaCust;
        private System.Windows.Forms.Label lblDeaCustTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnldataGridView;
        private System.Windows.Forms.Label lblDGVTitle;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.Label lblCalculationTitle;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.Button btnSave;
    }
}