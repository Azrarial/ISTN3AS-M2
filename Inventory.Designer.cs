namespace ISTN3AS_M2
{
    partial class Inventory
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
            this.btnUpdateAsset = new System.Windows.Forms.Button();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateSelling = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.UpdateQuantity = new System.Windows.Forms.Label();
            this.btnAddInv = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.AssNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemDescr = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.CostPrice = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAsset = new System.Windows.Forms.Panel();
            this.btnDeleteInv = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds360Box = new ISTN3AS_M2.ds360Box();
            this.inventoryTableAdapter = new ISTN3AS_M2.ds360BoxTableAdapters.InventoryTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateAsset
            // 
            this.btnUpdateAsset.Location = new System.Drawing.Point(260, 82);
            this.btnUpdateAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAsset.Name = "btnUpdateAsset";
            this.btnUpdateAsset.Size = new System.Drawing.Size(72, 43);
            this.btnUpdateAsset.TabIndex = 21;
            this.btnUpdateAsset.Text = "Update Item";
            this.btnUpdateAsset.UseVisualStyleBackColor = true;
            this.btnUpdateAsset.Click += new System.EventHandler(this.btnUpdateAsset_Click);
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.Location = new System.Drawing.Point(141, 38);
            this.txtUpdateQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(92, 20);
            this.txtUpdateQuantity.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtUpdateSelling);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.btnUpdateAsset);
            this.panel2.Controls.Add(this.UpdateQuantity);
            this.panel2.Controls.Add(this.txtUpdateQuantity);
            this.panel2.Location = new System.Drawing.Point(534, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 226);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Update Selling Price";
            // 
            // txtUpdateSelling
            // 
            this.txtUpdateSelling.Location = new System.Drawing.Point(141, 96);
            this.txtUpdateSelling.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateSelling.Name = "txtUpdateSelling";
            this.txtUpdateSelling.Size = new System.Drawing.Size(92, 20);
            this.txtUpdateSelling.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Update Cost Price";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(141, 154);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(92, 20);
            this.txtCost.TabIndex = 22;
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.AutoSize = true;
            this.UpdateQuantity.Location = new System.Drawing.Point(28, 41);
            this.UpdateQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(84, 13);
            this.UpdateQuantity.TabIndex = 18;
            this.UpdateQuantity.Text = "Update Quantity";
            // 
            // btnAddInv
            // 
            this.btnAddInv.Location = new System.Drawing.Point(386, 173);
            this.btnAddInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(75, 43);
            this.btnAddInv.TabIndex = 38;
            this.btnAddInv.Text = "Add Item";
            this.btnAddInv.UseVisualStyleBackColor = true;
            this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(101, 139);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(83, 13);
            this.ConditionLabel.TabIndex = 37;
            this.ConditionLabel.Text = "Item Description";
            // 
            // AssNameLabel
            // 
            this.AssNameLabel.AutoSize = true;
            this.AssNameLabel.Location = new System.Drawing.Point(101, 98);
            this.AssNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssNameLabel.Name = "AssNameLabel";
            this.AssNameLabel.Size = new System.Drawing.Size(58, 13);
            this.AssNameLabel.TabIndex = 36;
            this.AssNameLabel.Text = "Item Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSellingPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddInv);
            this.panel1.Controls.Add(this.ConditionLabel);
            this.panel1.Controls.Add(this.AssNameLabel);
            this.panel1.Controls.Add(this.txtItemDescr);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.txtItemID);
            this.panel1.Controls.Add(this.CostPrice);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtCostPrice);
            this.panel1.Controls.Add(this.btnGenerateID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 226);
            this.panel1.TabIndex = 4;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(188, 179);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(84, 20);
            this.txtSellingPrice.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Selling Price";
            // 
            // txtItemDescr
            // 
            this.txtItemDescr.Location = new System.Drawing.Point(188, 137);
            this.txtItemDescr.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemDescr.Name = "txtItemDescr";
            this.txtItemDescr.Size = new System.Drawing.Size(84, 20);
            this.txtItemDescr.TabIndex = 35;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(188, 95);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(84, 20);
            this.txtItemName.TabIndex = 34;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(188, 56);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(84, 20);
            this.txtItemID.TabIndex = 33;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSize = true;
            this.CostPrice.Location = new System.Drawing.Point(327, 102);
            this.CostPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Size = new System.Drawing.Size(55, 13);
            this.CostPrice.TabIndex = 32;
            this.CostPrice.Text = "Cost Price";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(327, 140);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 31;
            this.Type.Text = "Type";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(327, 61);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 30;
            this.Quantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(386, 58);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(84, 20);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(386, 136);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(84, 20);
            this.txtType.TabIndex = 28;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(386, 98);
            this.txtCostPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(84, 20);
            this.txtCostPrice.TabIndex = 27;
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Location = new System.Drawing.Point(17, 49);
            this.btnGenerateID.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(150, 25);
            this.btnGenerateID.TabIndex = 26;
            this.btnGenerateID.Text = "Generate Item ID";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Inventory";
            // 
            // pnlAsset
            // 
            this.pnlAsset.Controls.Add(this.btnDeleteInv);
            this.pnlAsset.Controls.Add(this.dgvInventory);
            this.pnlAsset.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAsset.Location = new System.Drawing.Point(0, 0);
            this.pnlAsset.Name = "pnlAsset";
            this.pnlAsset.Size = new System.Drawing.Size(935, 183);
            this.pnlAsset.TabIndex = 3;
            // 
            // btnDeleteInv
            // 
            this.btnDeleteInv.Location = new System.Drawing.Point(776, 63);
            this.btnDeleteInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteInv.Name = "btnDeleteInv";
            this.btnDeleteInv.Size = new System.Drawing.Size(72, 56);
            this.btnDeleteInv.TabIndex = 19;
            this.btnDeleteInv.Text = "Delete Item";
            this.btnDeleteInv.UseVisualStyleBackColor = true;
            this.btnDeleteInv.Click += new System.EventHandler(this.btnDeleteInv_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AutoGenerateColumns = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvInventory.DataSource = this.inventoryBindingSource;
            this.dgvInventory.Location = new System.Drawing.Point(12, 21);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(748, 150);
            this.dgvInventory.TabIndex = 0;
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
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 418);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAsset);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAsset;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UpdateQuantity;
        private System.Windows.Forms.Button btnAddInv;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label AssNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtItemDescr;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label CostPrice;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAsset;
        private System.Windows.Forms.Button btnDeleteInv;
        private System.Windows.Forms.DataGridView dgvInventory;
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
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdateSelling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
    }
}