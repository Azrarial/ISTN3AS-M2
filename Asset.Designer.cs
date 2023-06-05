namespace ISTN3AS_M2
{
    partial class Asset
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
            this.pnlAsset = new System.Windows.Forms.Panel();
            this.btnDeleteAsset = new System.Windows.Forms.Button();
            this.dgvAsset = new System.Windows.Forms.DataGridView();
            this.assetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds360Box = new ISTN3AS_M2.ds360Box();
            this.assetTableAdapter = new ISTN3AS_M2.ds360BoxTableAdapters.AssetTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.AssNameLabel = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtAssName = new System.Windows.Forms.TextBox();
            this.txtAssetID = new System.Windows.Forms.TextBox();
            this.CostPrice = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateAsset = new System.Windows.Forms.Button();
            this.cmbUpdateCondition = new System.Windows.Forms.ComboBox();
            this.UpdateCondition = new System.Windows.Forms.Label();
            this.UpdateQuantity = new System.Windows.Forms.Label();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.pnlAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAsset
            // 
            this.pnlAsset.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAsset.Controls.Add(this.btnDeleteAsset);
            this.pnlAsset.Controls.Add(this.dgvAsset);
            this.pnlAsset.Location = new System.Drawing.Point(5, 4);
            this.pnlAsset.Name = "pnlAsset";
            this.pnlAsset.Size = new System.Drawing.Size(820, 179);
            this.pnlAsset.TabIndex = 0;
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.Location = new System.Drawing.Point(684, 61);
            this.btnDeleteAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(106, 56);
            this.btnDeleteAsset.TabIndex = 19;
            this.btnDeleteAsset.Text = "Delete Asset";
            this.btnDeleteAsset.UseVisualStyleBackColor = true;
            this.btnDeleteAsset.Click += new System.EventHandler(this.DeleteAsset_Click);
            // 
            // dgvAsset
            // 
            this.dgvAsset.AutoGenerateColumns = false;
            this.dgvAsset.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetIDDataGridViewTextBoxColumn,
            this.assetNameDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvAsset.DataSource = this.assetBindingSource;
            this.dgvAsset.Location = new System.Drawing.Point(12, 13);
            this.dgvAsset.Name = "dgvAsset";
            this.dgvAsset.Size = new System.Drawing.Size(645, 150);
            this.dgvAsset.TabIndex = 0;
            // 
            // assetIDDataGridViewTextBoxColumn
            // 
            this.assetIDDataGridViewTextBoxColumn.DataPropertyName = "AssetID";
            this.assetIDDataGridViewTextBoxColumn.HeaderText = "AssetID";
            this.assetIDDataGridViewTextBoxColumn.Name = "assetIDDataGridViewTextBoxColumn";
            // 
            // assetNameDataGridViewTextBoxColumn
            // 
            this.assetNameDataGridViewTextBoxColumn.DataPropertyName = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.HeaderText = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.Name = "assetNameDataGridViewTextBoxColumn";
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataMember = "Asset";
            this.assetBindingSource.DataSource = this.ds360Box;
            // 
            // ds360Box
            // 
            this.ds360Box.DataSetName = "ds360Box";
            this.ds360Box.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetTableAdapter
            // 
            this.assetTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAddAsset);
            this.panel1.Controls.Add(this.ConditionLabel);
            this.panel1.Controls.Add(this.AssNameLabel);
            this.panel1.Controls.Add(this.txtCondition);
            this.panel1.Controls.Add(this.txtAssName);
            this.panel1.Controls.Add(this.txtAssetID);
            this.panel1.Controls.Add(this.CostPrice);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtCostPrice);
            this.panel1.Controls.Add(this.btnGenerateID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 226);
            this.panel1.TabIndex = 1;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(288, 183);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(113, 35);
            this.btnAddAsset.TabIndex = 38;
            this.btnAddAsset.Text = "Add Asset";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(51, 156);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(59, 13);
            this.ConditionLabel.TabIndex = 37;
            this.ConditionLabel.Text = "Condition";
            // 
            // AssNameLabel
            // 
            this.AssNameLabel.AutoSize = true;
            this.AssNameLabel.Location = new System.Drawing.Point(44, 89);
            this.AssNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AssNameLabel.Name = "AssNameLabel";
            this.AssNameLabel.Size = new System.Drawing.Size(66, 13);
            this.AssNameLabel.TabIndex = 36;
            this.AssNameLabel.Text = "Asset Name";
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(135, 153);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(2);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(84, 22);
            this.txtCondition.TabIndex = 35;
            // 
            // txtAssName
            // 
            this.txtAssName.Location = new System.Drawing.Point(135, 95);
            this.txtAssName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssName.Name = "txtAssName";
            this.txtAssName.ReadOnly = true;
            this.txtAssName.Size = new System.Drawing.Size(84, 22);
            this.txtAssName.TabIndex = 34;
            // 
            // txtAssetID
            // 
            this.txtAssetID.Location = new System.Drawing.Point(135, 42);
            this.txtAssetID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAssetID.Name = "txtAssetID";
            this.txtAssetID.ReadOnly = true;
            this.txtAssetID.Size = new System.Drawing.Size(84, 22);
            this.txtAssetID.TabIndex = 33;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSize = true;
            this.CostPrice.Location = new System.Drawing.Point(262, 150);
            this.CostPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Size = new System.Drawing.Size(57, 13);
            this.CostPrice.TabIndex = 32;
            this.CostPrice.Text = "Cost Price";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(274, 98);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(30, 13);
            this.Type.TabIndex = 31;
            this.Type.Text = "Type";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(262, 45);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(51, 13);
            this.Quantity.TabIndex = 30;
            this.Quantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(333, 42);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(84, 22);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(333, 95);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(84, 22);
            this.txtType.TabIndex = 28;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(333, 147);
            this.txtCostPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(84, 22);
            this.txtCostPrice.TabIndex = 27;
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Location = new System.Drawing.Point(18, 39);
            this.btnGenerateID.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(113, 25);
            this.btnGenerateID.TabIndex = 26;
            this.btnGenerateID.Text = "Generate Asset ID";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Asset";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnUpdateAsset);
            this.panel2.Controls.Add(this.cmbUpdateCondition);
            this.panel2.Controls.Add(this.UpdateCondition);
            this.panel2.Controls.Add(this.UpdateQuantity);
            this.panel2.Controls.Add(this.txtUpdateQuantity);
            this.panel2.Location = new System.Drawing.Point(436, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 226);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdateAsset
            // 
            this.btnUpdateAsset.Location = new System.Drawing.Point(253, 76);
            this.btnUpdateAsset.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAsset.Name = "btnUpdateAsset";
            this.btnUpdateAsset.Size = new System.Drawing.Size(106, 56);
            this.btnUpdateAsset.TabIndex = 21;
            this.btnUpdateAsset.Text = "Update Asset";
            this.btnUpdateAsset.UseVisualStyleBackColor = true;
            this.btnUpdateAsset.Click += new System.EventHandler(this.btnUpdateAsset_Click);
            // 
            // cmbUpdateCondition
            // 
            this.cmbUpdateCondition.AutoCompleteCustomSource.AddRange(new string[] {
            "Excellent",
            "Good",
            "Bad",
            "Damaged"});
            this.cmbUpdateCondition.FormattingEnabled = true;
            this.cmbUpdateCondition.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Bad",
            "Damaged"});
            this.cmbUpdateCondition.Location = new System.Drawing.Point(131, 135);
            this.cmbUpdateCondition.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdateCondition.Name = "cmbUpdateCondition";
            this.cmbUpdateCondition.Size = new System.Drawing.Size(92, 21);
            this.cmbUpdateCondition.TabIndex = 20;
            // 
            // UpdateCondition
            // 
            this.UpdateCondition.AutoSize = true;
            this.UpdateCondition.Location = new System.Drawing.Point(20, 139);
            this.UpdateCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateCondition.Name = "UpdateCondition";
            this.UpdateCondition.Size = new System.Drawing.Size(100, 13);
            this.UpdateCondition.TabIndex = 19;
            this.UpdateCondition.Text = "Update Condition";
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.AutoSize = true;
            this.UpdateQuantity.Location = new System.Drawing.Point(20, 76);
            this.UpdateQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(92, 13);
            this.UpdateQuantity.TabIndex = 18;
            this.UpdateQuantity.Text = "Update Quantity";
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.Location = new System.Drawing.Point(134, 73);
            this.txtUpdateQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(92, 22);
            this.txtUpdateQuantity.TabIndex = 17;
            // 
            // Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(834, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAsset);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Asset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset";
            this.Load += new System.EventHandler(this.Asset_Load);
            this.pnlAsset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds360Box)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAsset;
        private System.Windows.Forms.DataGridView dgvAsset;
        private ds360Box ds360Box;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private ds360BoxTableAdapters.AssetTableAdapter assetTableAdapter;
        private System.Windows.Forms.Button btnDeleteAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label AssNameLabel;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtAssName;
        private System.Windows.Forms.TextBox txtAssetID;
        private System.Windows.Forms.Label CostPrice;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateAsset;
        private System.Windows.Forms.ComboBox cmbUpdateCondition;
        private System.Windows.Forms.Label UpdateCondition;
        private System.Windows.Forms.Label UpdateQuantity;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
    }
}