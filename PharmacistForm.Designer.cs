namespace PharmacyManagementSystem
{
    partial class PharmacistForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSellQty = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.numSellQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(64, 73);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Medicine";
            // 
            // lblSellQty
            // 
            this.lblSellQty.AutoSize = true;
            this.lblSellQty.Location = new System.Drawing.Point(349, 73);
            this.lblSellQty.Name = "lblSellQty";
            this.lblSellQty.Size = new System.Drawing.Size(66, 13);
            this.lblSellQty.TabIndex = 1;
            this.lblSellQty.Text = "Sell Quantity";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(67, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(352, 115);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(67, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(-8, 226);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.Size = new System.Drawing.Size(796, 150);
            this.dgvSearchResults.TabIndex = 5;
            // 
            // numSellQuantity
            // 
            this.numSellQuantity.Location = new System.Drawing.Point(352, 89);
            this.numSellQuantity.Name = "numSellQuantity";
            this.numSellQuantity.Size = new System.Drawing.Size(120, 20);
            this.numSellQuantity.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(78, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Pharmacist Panel";
            // 
            // PharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.numSellQuantity);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSellQty);
            this.Controls.Add(this.lblSearch);
            this.Name = "PharmacistForm";
            this.Text = "PharmacistForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSellQty;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.NumericUpDown numSellQuantity;
        private System.Windows.Forms.Label lblTitle;
    }
}