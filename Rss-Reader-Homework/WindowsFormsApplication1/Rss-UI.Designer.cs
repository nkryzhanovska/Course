namespace WindowsFormsApplication1
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
            this.addFeedBox = new System.Windows.Forms.GroupBox();
            this.addNewFeedUrlTestBox = new System.Windows.Forms.TextBox();
            this.getFeedButton = new System.Windows.Forms.Button();
            this.showFeedArticlesBox = new System.Windows.Forms.GroupBox();
            this.displayFeedItemsListBox = new System.Windows.Forms.ListBox();
            this.showFeedArticleContentBox = new System.Windows.Forms.GroupBox();
            this.feedItemDescritopnTextBox = new System.Windows.Forms.TextBox();
            this.addFeedBox.SuspendLayout();
            this.showFeedArticlesBox.SuspendLayout();
            this.showFeedArticleContentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addFeedBox
            // 
            this.addFeedBox.Controls.Add(this.addNewFeedUrlTestBox);
            this.addFeedBox.Controls.Add(this.getFeedButton);
            this.addFeedBox.Location = new System.Drawing.Point(13, 13);
            this.addFeedBox.Name = "addFeedBox";
            this.addFeedBox.Size = new System.Drawing.Size(845, 72);
            this.addFeedBox.TabIndex = 0;
            this.addFeedBox.TabStop = false;
            this.addFeedBox.Text = "Feed URL";
            // 
            // addNewFeedUrlTestBox
            // 
            this.addNewFeedUrlTestBox.Location = new System.Drawing.Point(7, 19);
            this.addNewFeedUrlTestBox.Name = "addNewFeedUrlTestBox";
            this.addNewFeedUrlTestBox.Size = new System.Drawing.Size(527, 20);
            this.addNewFeedUrlTestBox.TabIndex = 2;
            this.addNewFeedUrlTestBox.TextChanged += new System.EventHandler(this.addNewFeedUrlTestBox_TextChanged);
            // 
            // getFeedButton
            // 
            this.getFeedButton.Location = new System.Drawing.Point(553, 19);
            this.getFeedButton.Name = "getFeedButton";
            this.getFeedButton.Size = new System.Drawing.Size(75, 23);
            this.getFeedButton.TabIndex = 1;
            this.getFeedButton.Text = "Get Feed";
            this.getFeedButton.UseVisualStyleBackColor = true;
            this.getFeedButton.Click += new System.EventHandler(this.getFeedButton_Click);
            // 
            // showFeedArticlesBox
            // 
            this.showFeedArticlesBox.Controls.Add(this.displayFeedItemsListBox);
            this.showFeedArticlesBox.Location = new System.Drawing.Point(13, 92);
            this.showFeedArticlesBox.Name = "showFeedArticlesBox";
            this.showFeedArticlesBox.Size = new System.Drawing.Size(369, 430);
            this.showFeedArticlesBox.TabIndex = 1;
            this.showFeedArticlesBox.TabStop = false;
            this.showFeedArticlesBox.Text = "Latest Articles";
            // 
            // displayFeedItemsListBox
            // 
            this.displayFeedItemsListBox.FormattingEnabled = true;
            this.displayFeedItemsListBox.HorizontalScrollbar = true;
            this.displayFeedItemsListBox.Location = new System.Drawing.Point(6, 16);
            this.displayFeedItemsListBox.Name = "displayFeedItemsListBox";
            this.displayFeedItemsListBox.Size = new System.Drawing.Size(357, 394);
            this.displayFeedItemsListBox.TabIndex = 0;
            this.displayFeedItemsListBox.SelectedIndexChanged += new System.EventHandler(this.displayFeedItemsListBox_SelectedIndexChanged);
            this.displayFeedItemsListBox.DoubleClick += new System.EventHandler(this.displayFeedItemsListBox_DoubleClick);
            // 
            // showFeedArticleContentBox
            // 
            this.showFeedArticleContentBox.Controls.Add(this.feedItemDescritopnTextBox);
            this.showFeedArticleContentBox.Location = new System.Drawing.Point(388, 92);
            this.showFeedArticleContentBox.Name = "showFeedArticleContentBox";
            this.showFeedArticleContentBox.Size = new System.Drawing.Size(470, 430);
            this.showFeedArticleContentBox.TabIndex = 2;
            this.showFeedArticleContentBox.TabStop = false;
            this.showFeedArticleContentBox.Text = "Descritption";
            // 
            // feedItemDescritopnTextBox
            // 
            this.feedItemDescritopnTextBox.Location = new System.Drawing.Point(7, 16);
            this.feedItemDescritopnTextBox.Multiline = true;
            this.feedItemDescritopnTextBox.Name = "feedItemDescritopnTextBox";
            this.feedItemDescritopnTextBox.Size = new System.Drawing.Size(457, 394);
            this.feedItemDescritopnTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 534);
            this.Controls.Add(this.showFeedArticleContentBox);
            this.Controls.Add(this.showFeedArticlesBox);
            this.Controls.Add(this.addFeedBox);
            this.Name = "Form1";
            this.Text = "RSS-Reader";
            this.addFeedBox.ResumeLayout(false);
            this.addFeedBox.PerformLayout();
            this.showFeedArticlesBox.ResumeLayout(false);
            this.showFeedArticleContentBox.ResumeLayout(false);
            this.showFeedArticleContentBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addFeedBox;
        private System.Windows.Forms.TextBox addNewFeedUrlTestBox;
        private System.Windows.Forms.Button getFeedButton;
        private System.Windows.Forms.GroupBox showFeedArticlesBox;
        private System.Windows.Forms.GroupBox showFeedArticleContentBox;
        private System.Windows.Forms.ListBox displayFeedItemsListBox;
        private System.Windows.Forms.TextBox feedItemDescritopnTextBox;
    }
}

