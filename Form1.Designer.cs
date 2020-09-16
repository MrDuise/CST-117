namespace Hello_World_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.messageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeClassButton = new System.Windows.Forms.Button();
            this.pictureSpace = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(29, 27);
            this.messageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(100, 71);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "Display Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is a label. It labels stuff";
            // 
            // welcomeClassButton
            // 
            this.welcomeClassButton.Location = new System.Drawing.Point(29, 138);
            this.welcomeClassButton.Name = "welcomeClassButton";
            this.welcomeClassButton.Size = new System.Drawing.Size(154, 58);
            this.welcomeClassButton.TabIndex = 2;
            this.welcomeClassButton.Text = "CST-117";
            this.welcomeClassButton.UseVisualStyleBackColor = true;
            this.welcomeClassButton.Click += new System.EventHandler(this.welcomeClassButton_Click);
            // 
            // pictureSpace
            // 
            this.pictureSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSpace.BackgroundImage")));
            this.pictureSpace.Location = new System.Drawing.Point(759, 183);
            this.pictureSpace.Name = "pictureSpace";
            this.pictureSpace.Size = new System.Drawing.Size(237, 200);
            this.pictureSpace.TabIndex = 3;
            this.pictureSpace.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "This is an image taken by the Hubble satellite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureSpace);
            this.Controls.Add(this.welcomeClassButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "My First GUI Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button welcomeClassButton;
        private System.Windows.Forms.PictureBox pictureSpace;
        private System.Windows.Forms.Label label2;
    }
}

