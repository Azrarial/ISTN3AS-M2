namespace ISTN3AS_M2
{
    partial class MenuC
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
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.Black;
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(9, 386);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(86, 32);
            this.btnLogOff.TabIndex = 5;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Black;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBooking.Location = new System.Drawing.Point(418, 88);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(227, 79);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "Booking System ";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnAsset_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.Black;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClass.Location = new System.Drawing.Point(418, 239);
            this.btnClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(227, 79);
            this.btnClass.TabIndex = 7;
            this.btnClass.Text = "Class System";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // MenuC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISTN3AS_M2.Properties.Resources.Screenshot_2023_06_04_140239;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 428);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnLogOff);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnClass;
    }
}