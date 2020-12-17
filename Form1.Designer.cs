namespace Inventory_Project
{
    partial class mainScreen
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
            this.btnAddItemForm = new System.Windows.Forms.Button();
            this.dgvMainScreen = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnSearchForm = new System.Windows.Forms.Button();
            this.btnUpDateNumInStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItemForm
            // 
            this.btnAddItemForm.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemForm.Location = new System.Drawing.Point(994, 12);
            this.btnAddItemForm.Name = "btnAddItemForm";
            this.btnAddItemForm.Size = new System.Drawing.Size(89, 53);
            this.btnAddItemForm.TabIndex = 8;
            this.btnAddItemForm.Text = "Add";
            this.btnAddItemForm.UseVisualStyleBackColor = true;
            this.btnAddItemForm.Click += new System.EventHandler(this.btnAddItemForm_Click);
            // 
            // dgvMainScreen
            // 
            this.dgvMainScreen.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMainScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.itemId,
            this.itemName,
            this.itemDescription,
            this.itemPrice,
            this.itemNumInStock,
            this.itemRating});
            this.dgvMainScreen.Location = new System.Drawing.Point(5, -1);
            this.dgvMainScreen.Name = "dgvMainScreen";
            this.dgvMainScreen.RowHeadersWidth = 51;
            this.dgvMainScreen.RowTemplate.Height = 24;
            this.dgvMainScreen.Size = new System.Drawing.Size(958, 477);
            this.dgvMainScreen.TabIndex = 9;
            this.dgvMainScreen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainScreen_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 125;
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
            this.itemName.HeaderText = "Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.Width = 125;
            // 
            // itemDescription
            // 
            this.itemDescription.HeaderText = "Description";
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
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(994, 101);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(89, 50);
            this.btnDeleteItem.TabIndex = 10;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnSearchForm
            // 
            this.btnSearchForm.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchForm.Location = new System.Drawing.Point(1126, 62);
            this.btnSearchForm.Name = "btnSearchForm";
            this.btnSearchForm.Size = new System.Drawing.Size(105, 41);
            this.btnSearchForm.TabIndex = 11;
            this.btnSearchForm.Text = "Search";
            this.btnSearchForm.UseVisualStyleBackColor = true;
            this.btnSearchForm.Click += new System.EventHandler(this.btnSearchForm_Click);
            // 
            // btnUpDateNumInStock
            // 
            this.btnUpDateNumInStock.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpDateNumInStock.Location = new System.Drawing.Point(1114, 164);
            this.btnUpDateNumInStock.Name = "btnUpDateNumInStock";
            this.btnUpDateNumInStock.Size = new System.Drawing.Size(116, 81);
            this.btnUpDateNumInStock.TabIndex = 12;
            this.btnUpDateNumInStock.Text = "Update Number In  Stock";
            this.btnUpDateNumInStock.UseVisualStyleBackColor = true;
            this.btnUpDateNumInStock.Click += new System.EventHandler(this.btnUpDateNumInStock_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 515);
            this.Controls.Add(this.btnUpDateNumInStock);
            this.Controls.Add(this.btnSearchForm);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.dgvMainScreen);
            this.Controls.Add(this.btnAddItemForm);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "mainScreen";
            this.Text = "Inventory Screen";
            this.Load += new System.EventHandler(this.mainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddItemForm;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnSearchForm;
        public System.Windows.Forms.DataGridView dgvMainScreen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRating;
        private System.Windows.Forms.Button btnUpDateNumInStock;
    }
}

