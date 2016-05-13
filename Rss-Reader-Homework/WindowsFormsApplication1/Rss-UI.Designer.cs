namespace RssReaderHomework
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
            this.removeFeedButton = new System.Windows.Forms.Button();
            this.saveFeedsToFileButton = new System.Windows.Forms.Button();
            this.refreshFeedsButton = new System.Windows.Forms.Button();
            this.feedLatestArticles = new System.Windows.Forms.Label();
            this.dispalyRssFeedsListBox = new System.Windows.Forms.ListBox();
            this.displayFeedItemsListBox = new System.Windows.Forms.ListBox();
            this.showFeedArticleContentBox = new System.Windows.Forms.GroupBox();
            this.feedDescriptionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.rssLinkLable = new System.Windows.Forms.LinkLabel();
            this.rssLoadFromFileButton = new System.Windows.Forms.Button();
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
            this.addFeedBox.Size = new System.Drawing.Size(926, 72);
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
            this.showFeedArticlesBox.Controls.Add(this.rssLoadFromFileButton);
            this.showFeedArticlesBox.Controls.Add(this.removeFeedButton);
            this.showFeedArticlesBox.Controls.Add(this.saveFeedsToFileButton);
            this.showFeedArticlesBox.Controls.Add(this.refreshFeedsButton);
            this.showFeedArticlesBox.Controls.Add(this.feedLatestArticles);
            this.showFeedArticlesBox.Controls.Add(this.dispalyRssFeedsListBox);
            this.showFeedArticlesBox.Controls.Add(this.displayFeedItemsListBox);
            this.showFeedArticlesBox.Location = new System.Drawing.Point(13, 92);
            this.showFeedArticlesBox.Name = "showFeedArticlesBox";
            this.showFeedArticlesBox.Size = new System.Drawing.Size(403, 430);
            this.showFeedArticlesBox.TabIndex = 1;
            this.showFeedArticlesBox.TabStop = false;
            this.showFeedArticlesBox.Text = "Added Feeds";
            // 
            // removeFeedButton
            // 
            this.removeFeedButton.Location = new System.Drawing.Point(101, 179);
            this.removeFeedButton.Name = "removeFeedButton";
            this.removeFeedButton.Size = new System.Drawing.Size(88, 23);
            this.removeFeedButton.TabIndex = 3;
            this.removeFeedButton.Text = "Remove Feed";
            this.removeFeedButton.UseVisualStyleBackColor = true;
            this.removeFeedButton.Click += new System.EventHandler(this.removeFeedButton_Click);
            // 
            // saveFeedsToFileButton
            // 
            this.saveFeedsToFileButton.Location = new System.Drawing.Point(195, 179);
            this.saveFeedsToFileButton.Name = "saveFeedsToFileButton";
            this.saveFeedsToFileButton.Size = new System.Drawing.Size(88, 23);
            this.saveFeedsToFileButton.TabIndex = 3;
            this.saveFeedsToFileButton.Text = "Save URLs";
            this.saveFeedsToFileButton.UseVisualStyleBackColor = true;
            this.saveFeedsToFileButton.Click += new System.EventHandler(this.saveFeedsToFileButton_Click);
            // 
            // refreshFeedsButton
            // 
            this.refreshFeedsButton.Location = new System.Drawing.Point(7, 179);
            this.refreshFeedsButton.Name = "refreshFeedsButton";
            this.refreshFeedsButton.Size = new System.Drawing.Size(88, 23);
            this.refreshFeedsButton.TabIndex = 3;
            this.refreshFeedsButton.Text = "Refresh Feeds";
            this.refreshFeedsButton.UseVisualStyleBackColor = true;
            this.refreshFeedsButton.Click += new System.EventHandler(this.refreshFeedsButton_Click);
            // 
            // feedLatestArticles
            // 
            this.feedLatestArticles.AutoSize = true;
            this.feedLatestArticles.Location = new System.Drawing.Point(7, 205);
            this.feedLatestArticles.Name = "feedLatestArticles";
            this.feedLatestArticles.Size = new System.Drawing.Size(73, 13);
            this.feedLatestArticles.TabIndex = 2;
            this.feedLatestArticles.Text = "Latest Articles";
            // 
            // dispalyRssFeedsListBox
            // 
            this.dispalyRssFeedsListBox.FormattingEnabled = true;
            this.dispalyRssFeedsListBox.Location = new System.Drawing.Point(7, 16);
            this.dispalyRssFeedsListBox.Name = "dispalyRssFeedsListBox";
            this.dispalyRssFeedsListBox.Size = new System.Drawing.Size(390, 160);
            this.dispalyRssFeedsListBox.TabIndex = 1;
            this.dispalyRssFeedsListBox.SelectedIndexChanged += new System.EventHandler(this.dispalyRssFeedsListBox_SelectedIndexChanged);
            // 
            // displayFeedItemsListBox
            // 
            this.displayFeedItemsListBox.FormattingEnabled = true;
            this.displayFeedItemsListBox.HorizontalScrollbar = true;
            this.displayFeedItemsListBox.Location = new System.Drawing.Point(6, 224);
            this.displayFeedItemsListBox.Name = "displayFeedItemsListBox";
            this.displayFeedItemsListBox.Size = new System.Drawing.Size(391, 173);
            this.displayFeedItemsListBox.TabIndex = 0;
            this.displayFeedItemsListBox.SelectedIndexChanged += new System.EventHandler(this.displayFeedItemsListBox_SelectedIndexChanged);
            this.displayFeedItemsListBox.DoubleClick += new System.EventHandler(this.displayFeedItemsListBox_DoubleClick);
            // 
            // showFeedArticleContentBox
            // 
            this.showFeedArticleContentBox.Controls.Add(this.feedDescriptionWebBrowser);
            this.showFeedArticleContentBox.Controls.Add(this.rssLinkLable);
            this.showFeedArticleContentBox.Location = new System.Drawing.Point(422, 92);
            this.showFeedArticleContentBox.Name = "showFeedArticleContentBox";
            this.showFeedArticleContentBox.Size = new System.Drawing.Size(517, 430);
            this.showFeedArticleContentBox.TabIndex = 2;
            this.showFeedArticleContentBox.TabStop = false;
            this.showFeedArticleContentBox.Text = "Descritption";
            // 
            // feedDescriptionWebBrowser
            // 
            this.feedDescriptionWebBrowser.Location = new System.Drawing.Point(9, 16);
            this.feedDescriptionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.feedDescriptionWebBrowser.Name = "feedDescriptionWebBrowser";
            this.feedDescriptionWebBrowser.Size = new System.Drawing.Size(502, 381);
            this.feedDescriptionWebBrowser.TabIndex = 2;
            // 
            // rssLinkLable
            // 
            this.rssLinkLable.AutoSize = true;
            this.rssLinkLable.Location = new System.Drawing.Point(6, 400);
            this.rssLinkLable.Name = "rssLinkLable";
            this.rssLinkLable.Size = new System.Drawing.Size(40, 13);
            this.rssLinkLable.TabIndex = 1;
            this.rssLinkLable.TabStop = true;
            this.rssLinkLable.Text = "Go To:";
            this.rssLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rssLinkLable_LinkClicked);
            // 
            // rssLoadFromFileButton
            // 
            this.rssLoadFromFileButton.Location = new System.Drawing.Point(290, 179);
            this.rssLoadFromFileButton.Name = "rssLoadFromFileButton";
            this.rssLoadFromFileButton.Size = new System.Drawing.Size(88, 23);
            this.rssLoadFromFileButton.TabIndex = 3;
            this.rssLoadFromFileButton.Text = "Load URLs";
            this.rssLoadFromFileButton.UseVisualStyleBackColor = true;
            this.rssLoadFromFileButton.Click += new System.EventHandler(this.rssLoadFromFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 536);
            this.Controls.Add(this.showFeedArticleContentBox);
            this.Controls.Add(this.showFeedArticlesBox);
            this.Controls.Add(this.addFeedBox);
            this.Name = "Form1";
            this.Text = "RSS-Reader";
            this.addFeedBox.ResumeLayout(false);
            this.addFeedBox.PerformLayout();
            this.showFeedArticlesBox.ResumeLayout(false);
            this.showFeedArticlesBox.PerformLayout();
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
        private System.Windows.Forms.LinkLabel rssLinkLable;
        private System.Windows.Forms.WebBrowser feedDescriptionWebBrowser;
        private System.Windows.Forms.ListBox dispalyRssFeedsListBox;
        private System.Windows.Forms.Button saveFeedsToFileButton;
        private System.Windows.Forms.Button refreshFeedsButton;
        private System.Windows.Forms.Label feedLatestArticles;
        private System.Windows.Forms.Button removeFeedButton;
        private System.Windows.Forms.Button rssLoadFromFileButton;
    }
}

