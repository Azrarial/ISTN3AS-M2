namespace ISTN3AS_M2
{
    partial class ManagerMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenuForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAssets = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Black;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(298, 52);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(202, 61);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "Booking System";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Black;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(147, 163);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(202, 61);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales System";
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.Black;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Location = new System.Drawing.Point(447, 163);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(202, 61);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "Supplier System";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Black;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(147, 265);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(202, 61);
            this.btnInventory.TabIndex = 4;
            this.btnInventory.Text = "Inventory System";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnAssets
            // 
            this.btnAssets.BackColor = System.Drawing.Color.Black;
            this.btnAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssets.ForeColor = System.Drawing.Color.White;
            this.btnAssets.Location = new System.Drawing.Point(447, 265);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Size = new System.Drawing.Size(202, 61);
            this.btnAssets.TabIndex = 5;
            this.btnAssets.Text = "Asset System";
            this.btnAssets.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log Off";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAssets);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagerMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Button button1;
    }
}