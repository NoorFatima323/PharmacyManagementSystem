namespace PharmacyManagementSystem
{
    partial class AdminForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPillsPerLeaf = new System.Windows.Forms.Label();
            this.txtPillsPerLeaf = new System.Windows.Forms.TextBox();
            this.txtLeafsPerBox = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblLeafsPerBox = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Medicine Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(43, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(145, 43);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 20);
            this.txtCategory.TabIndex = 3;
            // 
            // lblPillsPerLeaf
            // 
            this.lblPillsPerLeaf.AutoSize = true;
            this.lblPillsPerLeaf.Location = new System.Drawing.Point(43, 122);
            this.lblPillsPerLeaf.Name = "lblPillsPerLeaf";
            this.lblPillsPerLeaf.Size = new System.Drawing.Size(67, 13);
            this.lblPillsPerLeaf.TabIndex = 4;
            this.lblPillsPerLeaf.Text = "Pills per Strip";
            // 
            // txtPillsPerLeaf
            // 
            this.txtPillsPerLeaf.Location = new System.Drawing.Point(145, 119);
            this.txtPillsPerLeaf.Name = "txtPillsPerLeaf";
            this.txtPillsPerLeaf.Size = new System.Drawing.Size(100, 20);
            this.txtPillsPerLeaf.TabIndex = 5;
            // 
            // txtLeafsPerBox
            // 
            this.txtLeafsPerBox.Location = new System.Drawing.Point(145, 145);
            this.txtLeafsPerBox.Name = "txtLeafsPerBox";
            this.txtLeafsPerBox.Size = new System.Drawing.Size(100, 20);
            this.txtLeafsPerBox.TabIndex = 6;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(43, 179);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(61, 13);
            this.lblExpiry.TabIndex = 7;
            this.lblExpiry.Text = "Expiry Date";
            // 
            // lblLeafsPerBox
            // 
            this.lblLeafsPerBox.AutoSize = true;
            this.lblLeafsPerBox.Location = new System.Drawing.Point(40, 148);
            this.lblLeafsPerBox.Name = "lblLeafsPerBox";
            this.lblLeafsPerBox.Size = new System.Drawing.Size(72, 13);
            this.lblLeafsPerBox.TabIndex = 8;
            this.lblLeafsPerBox.Text = "Strips per Box";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(43, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(145, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(145, 93);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(43, 96);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(145, 173);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(200, 20);
            this.dtpExpiry.TabIndex = 14;
            this.dtpExpiry.Value = new System.DateTime(2025, 6, 5, 0, 59, 14, 0);
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(-24, 264);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(833, 150);
            this.dgvInventory.TabIndex = 15;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tnUpdate
            // 
            this.tnUpdate.Location = new System.Drawing.Point(145, 209);
            this.tnUpdate.Name = "tnUpdate";
            this.tnUpdate.Size = new System.Drawing.Size(75, 23);
            this.tnUpdate.TabIndex = 17;
            this.tnUpdate.Text = "Update";
            this.tnUpdate.UseVisualStyleBackColor = true;
            this.tnUpdate.Click += new System.EventHandler(this.tnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(338, 209);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 19;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 52);
            this.label8.TabIndex = 20;
            this.label8.Text = "Group Members:\r\n1. Noor Fatima – 4th M1 – BSSE\r\n2. Hina Fatima – 4th M1 – BSSE\r\n3" +
    ". Marium Fatima – 4th M1 – BSSE";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblLeafsPerBox);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.txtLeafsPerBox);
            this.Controls.Add(this.txtPillsPerLeaf);
            this.Controls.Add(this.lblPillsPerLeaf);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPillsPerLeaf;
        private System.Windows.Forms.TextBox txtPillsPerLeaf;
        private System.Windows.Forms.TextBox txtLeafsPerBox;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblLeafsPerBox;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button tnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Label label8;
    }
}