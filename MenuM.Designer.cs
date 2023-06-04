namespace ISTN3AS_M2
{
    partial class MenuM
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
            this.btnAsset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsset
            // 
            this.btnAsset.BackColor = System.Drawing.Color.Black;
            this.btnAsset.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsset.Location = new System.Drawing.Point(747, 75);
            this.btnAsset.Name = "btnAsset";
            this.btnAsset.Size = new System.Drawing.Size(303, 97);
            this.btnAsset.TabIndex = 7;
            this.btnAsset.Text = "Booking System ";
            this.btnAsset.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(582, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 97);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sales System ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(582, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 97);
            this.button2.TabIndex = 9;
            this.button2.Text = "Inventory System ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(906, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 97);
            this.button3.TabIndex = 10;
            this.button3.Text = "Supplier System ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(906, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 97);
            this.button4.TabIndex = 11;
            this.button4.Text = "Asset System ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.Black;
            this.btnLogOff.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.Color.White;
            this.btnLogOff.Location = new System.Drawing.Point(12, 536);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(115, 40);
            this.btnLogOff.TabIndex = 12;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = false;
            // 
            // MenuM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISTN3AS_M2.Properties.Resources.Screenshot_2023_06_04_140239;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 588);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsset);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuM";
            this.Text = "MenuM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogOff;
    }
}