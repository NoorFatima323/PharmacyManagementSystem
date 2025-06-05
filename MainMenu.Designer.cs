namespace PharmacyManagementSystem
{
    partial class MainMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGroupMembers = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPharmacist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(87, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pharmacy Management System";
            // 
            // lblGroupMembers
            // 
            this.lblGroupMembers.AutoSize = true;
            this.lblGroupMembers.Location = new System.Drawing.Point(87, 91);
            this.lblGroupMembers.Name = "lblGroupMembers";
            this.lblGroupMembers.Size = new System.Drawing.Size(170, 52);
            this.lblGroupMembers.TabIndex = 1;
            this.lblGroupMembers.Text = "Group Members:\r\n1. Noor Fatima – 4th M1 – BSSE\r\n2. Hina Fatima – 4th M1 – BSSE\r\n3" +
    ". Marium Fatima – 4th M1 – BSSE";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(90, 195);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(108, 23);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Open Admin Panel";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPharmacist
            // 
            this.btnPharmacist.Location = new System.Drawing.Point(90, 234);
            this.btnPharmacist.Name = "btnPharmacist";
            this.btnPharmacist.Size = new System.Drawing.Size(132, 23);
            this.btnPharmacist.TabIndex = 3;
            this.btnPharmacist.Text = "OpenPharmacistPanel";
            this.btnPharmacist.UseVisualStyleBackColor = true;
            this.btnPharmacist.Click += new System.EventHandler(this.btnPharmacist_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPharmacist);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblGroupMembers);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGroupMembers;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPharmacist;
    }
}