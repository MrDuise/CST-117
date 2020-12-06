namespace Inventory_Project
{
    partial class searchInventory
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
            this.txtItemIdSearch = new System.Windows.Forms.TextBox();
            this.txtItemPriceSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchPage = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemIdSearch
            // 
            this.txtItemIdSearch.Location = new System.Drawing.Point(191, 50);
            this.txtItemIdSearch.Name = "txtItemIdSearch";
            this.txtItemIdSearch.Size = new System.Drawing.Size(133, 22);
            this.txtItemIdSearch.TabIndex = 0;
            // 
            // txtItemPriceSearch
            // 
            this.txtItemPriceSearch.Location = new System.Drawing.Point(191, 106);
            this.txtItemPriceSearch.Name = "txtItemPriceSearch";
            this.txtItemPriceSearch.Size = new System.Drawing.Size(133, 22);
            this.txtItemPriceSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(129, 207);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtItemPriceSearch);
            this.groupBox1.Controls.Add(this.txtItemIdSearch);
            this.groupBox1.Location = new System.Drawing.Point(662, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 273);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Number";
            // 
            // dgvSearchPage
            // 
            this.dgvSearchPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.itemName,
            this.itemDescription,
            this.itemPrice,
            this.itemNumInStock,
            this.itemRating});
            this.dgvSearchPage.Location = new System.Drawing.Point(12, 3);
            this.dgvSearchPage.Name = "dgvSearchPage";
            this.dgvSearchPage.RowHeadersWidth = 51;
            this.dgvSearchPage.RowTemplate.Height = 24;
            this.dgvSearchPage.Size = new System.Drawing.Size(644, 494);
            this.dgvSearchPage.TabIndex = 11;
            // 
            // itemId
            // 
            this.itemId.HeaderText = "Item ID";
            this.itemId.MinimumWidth = 6;
            this.itemId.Name = "itemId";
            this.itemId.Width = 125;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.Width = 125;
            // 
            // itemDescription
            // 
            this.itemDescription.HeaderText = "Item Description";
            this.itemDescription.MinimumWidth = 6;
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Width = 125;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.MinimumWidth = 6;
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Width = 125;
            // 
            // itemNumInStock
            // 
            this.itemNumInStock.HeaderText = "Number In Stock";
            this.itemNumInStock.MinimumWidth = 6;
            this.itemNumInStock.Name = "itemNumInStock";
            this.itemNumInStock.Width = 125;
            // 
            // itemRating
            // 
            this.itemRating.HeaderText = "Rating";
            this.itemRating.MinimumWidth = 6;
            this.itemRating.Name = "itemRating";
            this.itemRating.Width = 125;
            // 
            // searchInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 565);
            this.Controls.Add(this.dgvSearchPage);
            this.Controls.Add(this.groupBox1);
            this.Name = "searchInventory";
            this.Text = "Search Inventory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemIdSearch;
        private System.Windows.Forms.TextBox txtItemPriceSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSearchPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRating;
    }
}