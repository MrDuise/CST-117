namespace Inventory_Project
{
    partial class addItemForm
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rchTxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtNumInStock = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addItemsBox = new System.Windows.Forms.GroupBox();
            this.addItemsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(370, 449);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(112, 31);
            this.btnAddItem.TabIndex = 21;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(235, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 22;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(235, 256);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 25;
            // 
            // rchTxtDescription
            // 
            this.rchTxtDescription.Location = new System.Drawing.Point(235, 140);
            this.rchTxtDescription.Name = "rchTxtDescription";
            this.rchTxtDescription.Size = new System.Drawing.Size(187, 96);
            this.rchTxtDescription.TabIndex = 26;
            this.rchTxtDescription.Text = "";
            // 
            // txtNumInStock
            // 
            this.txtNumInStock.Location = new System.Drawing.Point(235, 304);
            this.txtNumInStock.Name = "txtNumInStock";
            this.txtNumInStock.Size = new System.Drawing.Size(100, 22);
            this.txtNumInStock.TabIndex = 27;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(235, 359);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(100, 22);
            this.txtRating.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Number In Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rating:";
            // 
            // addItemsBox
            // 
            this.addItemsBox.Controls.Add(this.label6);
            this.addItemsBox.Controls.Add(this.label5);
            this.addItemsBox.Controls.Add(this.label4);
            this.addItemsBox.Controls.Add(this.label3);
            this.addItemsBox.Controls.Add(this.label2);
            this.addItemsBox.Controls.Add(this.label1);
            this.addItemsBox.Controls.Add(this.txtRating);
            this.addItemsBox.Controls.Add(this.txtNumInStock);
            this.addItemsBox.Controls.Add(this.rchTxtDescription);
            this.addItemsBox.Controls.Add(this.txtName);
            this.addItemsBox.Controls.Add(this.txtPrice);
            this.addItemsBox.Controls.Add(this.txtID);
            this.addItemsBox.Controls.Add(this.btnAddItem);
            this.addItemsBox.Location = new System.Drawing.Point(195, 23);
            this.addItemsBox.Name = "addItemsBox";
            this.addItemsBox.Size = new System.Drawing.Size(565, 486);
            this.addItemsBox.TabIndex = 0;
            this.addItemsBox.TabStop = false;
            this.addItemsBox.Text = "Add Items";
            // 
            // addItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 538);
            this.Controls.Add(this.addItemsBox);
            this.Name = "addItemForm";
            this.Text = "Add to Inventory";
            this.addItemsBox.ResumeLayout(false);
            this.addItemsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.RichTextBox rchTxtDescription;
        private System.Windows.Forms.TextBox txtNumInStock;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox addItemsBox;
    }
}