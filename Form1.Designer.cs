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
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnSearchForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItemForm
            // 
            this.btnAddItemForm.Location = new System.Drawing.Point(687, 471);
            this.btnAddItemForm.Name = "btnAddItemForm";
            this.btnAddItemForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddItemForm.TabIndex = 8;
            this.btnAddItemForm.Text = "Add";
            this.btnAddItemForm.UseVisualStyleBackColor = true;
            this.btnAddItemForm.Click += new System.EventHandler(this.btnAddItemForm_Click);
            // 
            // dgvMainScreen
            // 
            this.dgvMainScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBox,
            this.ID,
            this.itemName,
            this.description,
            this.price,
            this.numInStock,
            this.rating});
            this.dgvMainScreen.Location = new System.Drawing.Point(5, -1);
            this.dgvMainScreen.Name = "dgvMainScreen";
            this.dgvMainScreen.RowHeadersWidth = 51;
            this.dgvMainScreen.RowTemplate.Height = 24;
            this.dgvMainScreen.Size = new System.Drawing.Size(1339, 225);
            this.dgvMainScreen.TabIndex = 9;
            this.dgvMainScreen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainScreen_CellContentClick);
            // 
            // checkBox
            // 
            this.checkBox.HeaderText = "";
            this.checkBox.MinimumWidth = 6;
            this.checkBox.Name = "checkBox";
            this.checkBox.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "Item ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // numInStock
            // 
            this.numInStock.HeaderText = "Number In Stock";
            this.numInStock.MinimumWidth = 6;
            this.numInStock.Name = "numInStock";
            this.numInStock.Width = 125;
            // 
            // rating
            // 
            this.rating.HeaderText = "Rating";
            this.rating.MinimumWidth = 6;
            this.rating.Name = "rating";
            this.rating.Width = 125;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(810, 471);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem.TabIndex = 10;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnSearchForm
            // 
            this.btnSearchForm.Location = new System.Drawing.Point(953, 471);
            this.btnSearchForm.Name = "btnSearchForm";
            this.btnSearchForm.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForm.TabIndex = 11;
            this.btnSearchForm.Text = "Search";
            this.btnSearchForm.UseVisualStyleBackColor = true;
            this.btnSearchForm.Click += new System.EventHandler(this.btnSearchForm_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 515);
            this.Controls.Add(this.btnSearchForm);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.dgvMainScreen);
            this.Controls.Add(this.btnAddItemForm);
            this.Name = "mainScreen";
            this.Text = "Inventory Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddItemForm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn numInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnSearchForm;
        public System.Windows.Forms.DataGridView dgvMainScreen;
    }
}

