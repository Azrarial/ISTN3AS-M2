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
            this.btnAsset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.Black;
            this.btnLogOff.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(12, 475);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(115, 40);
            this.btnLogOff.TabIndex = 5;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = false;
            // 
            // btnAsset
            // 
            this.btnAsset.BackColor = System.Drawing.Color.Black;
            this.btnAsset.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsset.Location = new System.Drawing.Point(557, 108);
            this.btnAsset.Name = "btnAsset";
            this.btnAsset.Size = new System.Drawing.Size(303, 97);
            this.btnAsset.TabIndex = 6;
            this.btnAsset.Text = "Booking System ";
            this.btnAsset.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(557, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "Class System";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MenuC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISTN3AS_M2.Properties.Resources.Screenshot_2023_06_04_140239;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsset);
            this.Controls.Add(this.btnLogOff);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuC";
            this.Text = "MenuC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnAsset;
        private System.Windows.Forms.Button button1;
    }
}