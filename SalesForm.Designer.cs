namespace ISTN3AS_M2
{
    partial class SalesForm
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
            this.components = new System.ComponentModel.Container();
            this.dbGridInventory = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds360Box = new ISTN3AS_M2.ds360Box();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds360BoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new ISTN3AS_M2.ds360BoxTableAdapters.InventoryTableAdapter();
            this.saleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleItemTableAdapter = new ISTN3AS_M2.ds360BoxTableAdapters.SaleItemTableAdapter();
            this.saleTableAdapter = new ISTN3AS_M2.ds360BoxTableAdapters.SaleTableAdapter();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.ds360Box1 = new ISTN3AS_M2.ds360Box();
            this.saleTransactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.pnlConfirm = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtAmtTethered = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTethered = new System.Windows.Forms.Label();
            this.rbtnCard = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dbGridTransaction = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierOrderTableAdapter = new ISTN3AS_M2.ds360BoxTableAdapters.SupplierOrderTableAdapter();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleAmountTenderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePaymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTotalinclVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTotalexclVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360BoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleTransactionBindingSource1)).BeginInit();
            this.pnlConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGridInventory
            // 
            this.dbGridInventory.AutoGenerateColumns = false;
            this.dbGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dbGridInventory.DataSource = this.inventoryBindingSource;
            this.dbGridInventory.Location = new System.Drawing.Point(12, 32);
            this.dbGridInventory.Name = "dbGridInventory";
            this.dbGridInventory.Size = new System.Drawing.Size(743, 150);
            this.dbGridInventory.TabIndex = 0;
            this.dbGridInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.ds360Box;
            // 
            // ds360Box
            // 
            this.ds360Box.DataSetName = "ds360Box";
            this.ds360Box.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn1,
            this.saleTotalexclVATDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.saleTimeDataGridViewTextBoxColumn,
            this.saleTotalinclVATDataGridViewTextBoxColumn,
            this.salePaymentTypeDataGridViewTextBoxColumn,
            this.saleAmountTenderedDataGridViewTextBoxColumn,
            this.saleChangeDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.managerIDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.saleBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 424);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1045, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataMember = "Sale";
            this.saleBindingSource.DataSource = this.ds360Box;
            // 
            // saleTransactionBindingSource
            // 
            this.saleTransactionBindingSource.DataMember = "SaleTransaction";
            this.saleTransactionBindingSource.DataSource = this.ds360Box;
            // 
            // ds360BoxBindingSource
            // 
            this.ds360BoxBindingSource.DataSource = this.ds360Box;
            this.ds360BoxBindingSource.Position = 0;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // saleItemBindingSource
            // 
            this.saleItemBindingSource.DataMember = "SaleItem";
            this.saleItemBindingSource.DataSource = this.ds360Box;
            // 
            // saleItemTableAdapter
            // 
            this.saleItemTableAdapter.ClearBeforeFill = true;
            // 
            // saleTableAdapter
            // 
            this.saleTableAdapter.ClearBeforeFill = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(478, 270);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(142, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // ds360Box1
            // 
            this.ds360Box1.DataSetName = "ds360Box";
            this.ds360Box1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleTransactionBindingSource1
            // 
            this.saleTransactionBindingSource1.DataMember = "SaleTransaction";
            this.saleTransactionBindingSource1.DataSource = this.ds360Box1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Completed Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(444, 336);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(127, 23);
            this.btnConfirmOrder.TabIndex = 8;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // pnlConfirm
            // 
            this.pnlConfirm.Controls.Add(this.btnCancelOrder);
            this.pnlConfirm.Controls.Add(this.txtChange);
            this.pnlConfirm.Controls.Add(this.txtAmtTethered);
            this.pnlConfirm.Controls.Add(this.lblChange);
            this.pnlConfirm.Controls.Add(this.lblTethered);
            this.pnlConfirm.Controls.Add(this.rbtnCard);
            this.pnlConfirm.Controls.Add(this.rbtnCash);
            this.pnlConfirm.Controls.Add(this.btnConfirmPayment);
            this.pnlConfirm.Controls.Add(this.txtManagerID);
            this.pnlConfirm.Controls.Add(this.label6);
            this.pnlConfirm.Controls.Add(this.label5);
            this.pnlConfirm.Controls.Add(this.txtClientID);
            this.pnlConfirm.Location = new System.Drawing.Point(790, 59);
            this.pnlConfirm.Name = "pnlConfirm";
            this.pnlConfirm.Size = new System.Drawing.Size(293, 345);
            this.pnlConfirm.TabIndex = 9;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(85, 298);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(127, 23);
            this.btnCancelOrder.TabIndex = 18;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(125, 112);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(142, 20);
            this.txtChange.TabIndex = 17;
            this.txtChange.Text = "0";
            // 
            // txtAmtTethered
            // 
            this.txtAmtTethered.Location = new System.Drawing.Point(125, 73);
            this.txtAmtTethered.Name = "txtAmtTethered";
            this.txtAmtTethered.Size = new System.Drawing.Size(142, 20);
            this.txtAmtTethered.TabIndex = 16;
            this.txtAmtTethered.Text = "0";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(10, 112);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(110, 20);
            this.lblChange.TabIndex = 15;
            this.lblChange.Text = "Change Given";
            // 
            // lblTethered
            // 
            this.lblTethered.AutoSize = true;
            this.lblTethered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTethered.Location = new System.Drawing.Point(14, 73);
            this.lblTethered.Name = "lblTethered";
            this.lblTethered.Size = new System.Drawing.Size(106, 20);
            this.lblTethered.TabIndex = 14;
            this.lblTethered.Text = "Amt Tethered";
            // 
            // rbtnCard
            // 
            this.rbtnCard.AutoSize = true;
            this.rbtnCard.Location = new System.Drawing.Point(198, 40);
            this.rbtnCard.Name = "rbtnCard";
            this.rbtnCard.Size = new System.Drawing.Size(47, 17);
            this.rbtnCard.TabIndex = 13;
            this.rbtnCard.TabStop = true;
            this.rbtnCard.Text = "Card";
            this.rbtnCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Location = new System.Drawing.Point(31, 40);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(49, 17);
            this.rbtnCash.TabIndex = 12;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCash_CheckedChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(85, 264);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(127, 23);
            this.btnConfirmPayment.TabIndex = 11;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // txtManagerID
            // 
            this.txtManagerID.Location = new System.Drawing.Point(125, 213);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.ReadOnly = true;
            this.txtManagerID.Size = new System.Drawing.Size(142, 20);
            this.txtManagerID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Manager ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Client ID";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(125, 171);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(142, 20);
            this.txtClientID.TabIndex = 4;
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(444, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dbGridTransaction
            // 
            this.dbGridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dbGridTransaction.Location = new System.Drawing.Point(16, 230);
            this.dbGridTransaction.Name = "dbGridTransaction";
            this.dbGridTransaction.Size = new System.Drawing.Size(352, 150);
            this.dbGridTransaction.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ItemID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ItemName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "UnitCost";
            this.Column3.Name = "Column3";
            // 
            // supplierOrderBindingSource
            // 
            this.supplierOrderBindingSource.DataMember = "SupplierOrder";
            this.supplierOrderBindingSource.DataSource = this.ds360Box;
            // 
            // supplierOrderTableAdapter
            // 
            this.supplierOrderTableAdapter.ClearBeforeFill = true;
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "ManagerID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "ManagerID";
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // saleChangeDataGridViewTextBoxColumn
            // 
            this.saleChangeDataGridViewTextBoxColumn.DataPropertyName = "SaleChange";
            this.saleChangeDataGridViewTextBoxColumn.HeaderText = "SaleChange";
            this.saleChangeDataGridViewTextBoxColumn.Name = "saleChangeDataGridViewTextBoxColumn";
            // 
            // saleAmountTenderedDataGridViewTextBoxColumn
            // 
            this.saleAmountTenderedDataGridViewTextBoxColumn.DataPropertyName = "SaleAmountTendered";
            this.saleAmountTenderedDataGridViewTextBoxColumn.HeaderText = "SaleAmountTendered";
            this.saleAmountTenderedDataGridViewTextBoxColumn.Name = "saleAmountTenderedDataGridViewTextBoxColumn";
            // 
            // salePaymentTypeDataGridViewTextBoxColumn
            // 
            this.salePaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "SalePaymentType";
            this.salePaymentTypeDataGridViewTextBoxColumn.HeaderText = "SalePaymentType";
            this.salePaymentTypeDataGridViewTextBoxColumn.Name = "salePaymentTypeDataGridViewTextBoxColumn";
            // 
            // saleTotalinclVATDataGridViewTextBoxColumn
            // 
            this.saleTotalinclVATDataGridViewTextBoxColumn.DataPropertyName = "SaleTotal_inclVAT";
            this.saleTotalinclVATDataGridViewTextBoxColumn.HeaderText = "SaleTotal_inclVAT";
            this.saleTotalinclVATDataGridViewTextBoxColumn.Name = "saleTotalinclVATDataGridViewTextBoxColumn";
            // 
            // saleTimeDataGridViewTextBoxColumn
            // 
            this.saleTimeDataGridViewTextBoxColumn.DataPropertyName = "SaleTime";
            this.saleTimeDataGridViewTextBoxColumn.HeaderText = "SaleTime";
            this.saleTimeDataGridViewTextBoxColumn.Name = "saleTimeDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // saleTotalexclVATDataGridViewTextBoxColumn
            // 
            this.saleTotalexclVATDataGridViewTextBoxColumn.DataPropertyName = "SaleTotal_exclVAT";
            this.saleTotalexclVATDataGridViewTextBoxColumn.HeaderText = "SaleTotal_exclVAT";
            this.saleTotalexclVATDataGridViewTextBoxColumn.Name = "saleTotalexclVATDataGridViewTextBoxColumn";
            // 
            // saleIDDataGridViewTextBoxColumn1
            // 
            this.saleIDDataGridViewTextBoxColumn1.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn1.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn1.Name = "saleIDDataGridViewTextBoxColumn1";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 615);
            this.Controls.Add(this.dbGridTransaction);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlConfirm);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dbGridInventory);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.VisibleChanged += new System.EventHandler(this.SalesForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360BoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleTransactionBindingSource1)).EndInit();
            this.pnlConfirm.ResumeLayout(false);
            this.pnlConfirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGridInventory;
        private System.Windows.Forms.BindingSource ds360BoxBindingSource;
        private ds360Box ds360Box;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private ds360BoxTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource saleItemBindingSource;
        private ds360BoxTableAdapters.SaleItemTableAdapter saleItemTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private ds360BoxTableAdapters.SaleTableAdapter saleTableAdapter;
        private System.Windows.Forms.BindingSource saleTransactionBindingSource;
        private System.Windows.Forms.TextBox txtTotal;
        private ds360Box ds360Box1;
        private System.Windows.Forms.BindingSource saleTransactionBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Panel pnlConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtAmtTethered;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTethered;
        private System.Windows.Forms.RadioButton rbtnCard;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dbGridTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.BindingSource supplierOrderBindingSource;
        private ds360BoxTableAdapters.SupplierOrderTableAdapter supplierOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTotalexclVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTotalinclVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePaymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleAmountTenderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleChangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
    }
}