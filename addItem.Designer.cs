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
            this.addItemsBox = new System.Windows.Forms.GroupBox();
            this.txtNumInStock = new System.Windows.Forms.TextBox();
            this.rchTxtDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBoxSelectItemType = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGameGenre = new System.Windows.Forms.TextBox();
            this.txtGameLength = new System.Windows.Forms.TextBox();
            this.txtMovieLength = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtNumOfPages = new System.Windows.Forms.TextBox();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblGameGenre = new System.Windows.Forms.Label();
            this.lblGameLength = new System.Windows.Forms.Label();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.lblMaturityLevel = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblNumOfPages = new System.Windows.Forms.Label();
            this.lstBoxMaturityLevel = new System.Windows.Forms.ListBox();
            this.lstBoxAgeRating = new System.Windows.Forms.ListBox();
            this.addItemsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addItemsBox
            // 
            this.addItemsBox.Controls.Add(this.lstBoxAgeRating);
            this.addItemsBox.Controls.Add(this.lstBoxMaturityLevel);
            this.addItemsBox.Controls.Add(this.lblNumOfPages);
            this.addItemsBox.Controls.Add(this.lblGenre);
            this.addItemsBox.Controls.Add(this.lblMaturityLevel);
            this.addItemsBox.Controls.Add(this.lblMovieLength);
            this.addItemsBox.Controls.Add(this.lblGameLength);
            this.addItemsBox.Controls.Add(this.lblGameGenre);
            this.addItemsBox.Controls.Add(this.lblAgeRating);
            this.addItemsBox.Controls.Add(this.txtNumOfPages);
            this.addItemsBox.Controls.Add(this.txtGenre);
            this.addItemsBox.Controls.Add(this.txtMovieLength);
            this.addItemsBox.Controls.Add(this.txtGameLength);
            this.addItemsBox.Controls.Add(this.txtGameGenre);
            this.addItemsBox.Controls.Add(this.label7);
            this.addItemsBox.Controls.Add(this.lstBoxSelectItemType);
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
            this.addItemsBox.Location = new System.Drawing.Point(12, 12);
            this.addItemsBox.Name = "addItemsBox";
            this.addItemsBox.Size = new System.Drawing.Size(834, 486);
            this.addItemsBox.TabIndex = 0;
            this.addItemsBox.TabStop = false;
            this.addItemsBox.Text = "Add Items";
            // 
            // txtNumInStock
            // 
            this.txtNumInStock.Location = new System.Drawing.Point(235, 304);
            this.txtNumInStock.Name = "txtNumInStock";
            this.txtNumInStock.Size = new System.Drawing.Size(100, 22);
            this.txtNumInStock.TabIndex = 27;
            // 
            // rchTxtDescription
            // 
            this.rchTxtDescription.Location = new System.Drawing.Point(235, 140);
            this.rchTxtDescription.Name = "rchTxtDescription";
            this.rchTxtDescription.Size = new System.Drawing.Size(187, 96);
            this.rchTxtDescription.TabIndex = 26;
            this.rchTxtDescription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(235, 256);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(235, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 22;
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
            // lstBoxSelectItemType
            // 
            this.lstBoxSelectItemType.FormattingEnabled = true;
            this.lstBoxSelectItemType.ItemHeight = 16;
            this.lstBoxSelectItemType.Items.AddRange(new object[] {
            "Video Games",
            "Books",
            "Movies",
            "Other"});
            this.lstBoxSelectItemType.Location = new System.Drawing.Point(426, 51);
            this.lstBoxSelectItemType.Name = "lstBoxSelectItemType";
            this.lstBoxSelectItemType.Size = new System.Drawing.Size(120, 68);
            this.lstBoxSelectItemType.TabIndex = 35;
            this.lstBoxSelectItemType.SelectedIndexChanged += new System.EventHandler(this.lstBoxSelectItemType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Select the Item Type";
            // 
            // txtGameGenre
            // 
            this.txtGameGenre.Location = new System.Drawing.Point(680, 173);
            this.txtGameGenre.Name = "txtGameGenre";
            this.txtGameGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGameGenre.TabIndex = 38;
            // 
            // txtGameLength
            // 
            this.txtGameLength.Location = new System.Drawing.Point(680, 225);
            this.txtGameLength.Name = "txtGameLength";
            this.txtGameLength.Size = new System.Drawing.Size(100, 22);
            this.txtGameLength.TabIndex = 39;
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Location = new System.Drawing.Point(680, 270);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(100, 22);
            this.txtMovieLength.TabIndex = 40;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(680, 392);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGenre.TabIndex = 42;
            // 
            // txtNumOfPages
            // 
            this.txtNumOfPages.Location = new System.Drawing.Point(680, 434);
            this.txtNumOfPages.Name = "txtNumOfPages";
            this.txtNumOfPages.Size = new System.Drawing.Size(100, 22);
            this.txtNumOfPages.TabIndex = 43;
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(582, 110);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(82, 17);
            this.lblAgeRating.TabIndex = 44;
            this.lblAgeRating.Text = "Age Rating:";
            // 
            // lblGameGenre
            // 
            this.lblGameGenre.AutoSize = true;
            this.lblGameGenre.Location = new System.Drawing.Point(574, 173);
            this.lblGameGenre.Name = "lblGameGenre";
            this.lblGameGenre.Size = new System.Drawing.Size(94, 17);
            this.lblGameGenre.TabIndex = 45;
            this.lblGameGenre.Text = "Game Genre:";
            // 
            // lblGameLength
            // 
            this.lblGameLength.AutoSize = true;
            this.lblGameLength.Location = new System.Drawing.Point(574, 230);
            this.lblGameLength.Name = "lblGameLength";
            this.lblGameLength.Size = new System.Drawing.Size(98, 17);
            this.lblGameLength.TabIndex = 46;
            this.lblGameLength.Text = "Game Length:";
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Location = new System.Drawing.Point(571, 273);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(97, 17);
            this.lblMovieLength.TabIndex = 47;
            this.lblMovieLength.Text = "Movie Length:";
            // 
            // lblMaturityLevel
            // 
            this.lblMaturityLevel.AutoSize = true;
            this.lblMaturityLevel.Location = new System.Drawing.Point(567, 328);
            this.lblMaturityLevel.Name = "lblMaturityLevel";
            this.lblMaturityLevel.Size = new System.Drawing.Size(100, 17);
            this.lblMaturityLevel.TabIndex = 48;
            this.lblMaturityLevel.Text = "Maturity Level:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(574, 392);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(93, 17);
            this.lblGenre.TabIndex = 49;
            this.lblGenre.Text = "Movie Genre:";
            // 
            // lblNumOfPages
            // 
            this.lblNumOfPages.AutoSize = true;
            this.lblNumOfPages.Location = new System.Drawing.Point(542, 437);
            this.lblNumOfPages.Name = "lblNumOfPages";
            this.lblNumOfPages.Size = new System.Drawing.Size(122, 17);
            this.lblNumOfPages.TabIndex = 50;
            this.lblNumOfPages.Text = "Number of Pages:";
            // 
            // lstBoxMaturityLevel
            // 
            this.lstBoxMaturityLevel.FormattingEnabled = true;
            this.lstBoxMaturityLevel.ItemHeight = 16;
            this.lstBoxMaturityLevel.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this.lstBoxMaturityLevel.Location = new System.Drawing.Point(680, 302);
            this.lstBoxMaturityLevel.Name = "lstBoxMaturityLevel";
            this.lstBoxMaturityLevel.Size = new System.Drawing.Size(120, 68);
            this.lstBoxMaturityLevel.TabIndex = 51;
            // 
            // lstBoxAgeRating
            // 
            this.lstBoxAgeRating.FormattingEnabled = true;
            this.lstBoxAgeRating.ItemHeight = 16;
            this.lstBoxAgeRating.Items.AddRange(new object[] {
            "E",
            "E-10",
            "Teen",
            "Mature"});
            this.lstBoxAgeRating.Location = new System.Drawing.Point(680, 83);
            this.lstBoxAgeRating.Name = "lstBoxAgeRating";
            this.lstBoxAgeRating.Size = new System.Drawing.Size(120, 68);
            this.lstBoxAgeRating.TabIndex = 52;
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

        private System.Windows.Forms.GroupBox addItemsBox;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox rchTxtDescription;
        private System.Windows.Forms.TextBox txtNumInStock;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstBoxSelectItemType;
        private System.Windows.Forms.ListBox lstBoxAgeRating;
        private System.Windows.Forms.ListBox lstBoxMaturityLevel;
        private System.Windows.Forms.Label lblNumOfPages;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblMaturityLevel;
        private System.Windows.Forms.Label lblMovieLength;
        private System.Windows.Forms.Label lblGameLength;
        private System.Windows.Forms.Label lblGameGenre;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.TextBox txtNumOfPages;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtMovieLength;
        private System.Windows.Forms.TextBox txtGameLength;
        private System.Windows.Forms.TextBox txtGameGenre;
    }
}