namespace Lesson15
{
    partial class MainForm
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
            this.filterTabControl = new System.Windows.Forms.TabControl();
            this.generalConfig = new System.Windows.Forms.TabPage();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.startFiltering = new System.Windows.Forms.Button();
            this.browseOutputbutton = new System.Windows.Forms.Button();
            this.browseInputbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFiletextbox = new System.Windows.Forms.TextBox();
            this.inputFiletextbox = new System.Windows.Forms.TextBox();
            this.whiteListPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveToWhiteListButton = new System.Windows.Forms.Button();
            this.addItemToWhiteListButton = new System.Windows.Forms.Button();
            this.newWhiteListItemTextBox = new System.Windows.Forms.TextBox();
            this.whiteFilterListBox = new System.Windows.Forms.ListBox();
            this.whiteFilterFileButton = new System.Windows.Forms.Button();
            this.whiteListTextBox = new System.Windows.Forms.Label();
            this.whiteFilterFileTextBox = new System.Windows.Forms.TextBox();
            this.blackListTabPage = new System.Windows.Forms.TabPage();
            this.saveToBlackListButton = new System.Windows.Forms.Button();
            this.addItemToBlackListButton = new System.Windows.Forms.Button();
            this.newBlackListItemTextBox = new System.Windows.Forms.TextBox();
            this.blackFilterListBox = new System.Windows.Forms.ListBox();
            this.blackFilterFileButton = new System.Windows.Forms.Button();
            this.blackListTextBox = new System.Windows.Forms.Label();
            this.blackFilterFileTextBox = new System.Windows.Forms.TextBox();
            this.blackFilterBox = new System.Windows.Forms.GroupBox();
            this.filterTabControl.SuspendLayout();
            this.generalConfig.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.whiteListPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.blackListTabPage.SuspendLayout();
            this.blackFilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterTabControl
            // 
            this.filterTabControl.Controls.Add(this.generalConfig);
            this.filterTabControl.Controls.Add(this.whiteListPage);
            this.filterTabControl.Controls.Add(this.blackListTabPage);
            this.filterTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterTabControl.Location = new System.Drawing.Point(0, 0);
            this.filterTabControl.Name = "filterTabControl";
            this.filterTabControl.SelectedIndex = 0;
            this.filterTabControl.Size = new System.Drawing.Size(569, 364);
            this.filterTabControl.TabIndex = 0;
            // 
            // generalConfig
            // 
            this.generalConfig.Controls.Add(this.filesGroupBox);
            this.generalConfig.Location = new System.Drawing.Point(4, 22);
            this.generalConfig.Name = "generalConfig";
            this.generalConfig.Padding = new System.Windows.Forms.Padding(3);
            this.generalConfig.Size = new System.Drawing.Size(561, 338);
            this.generalConfig.TabIndex = 0;
            this.generalConfig.Text = "Options";
            this.generalConfig.UseVisualStyleBackColor = true;
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.startFiltering);
            this.filesGroupBox.Controls.Add(this.browseOutputbutton);
            this.filesGroupBox.Controls.Add(this.browseInputbutton);
            this.filesGroupBox.Controls.Add(this.label2);
            this.filesGroupBox.Controls.Add(this.label1);
            this.filesGroupBox.Controls.Add(this.outputFiletextbox);
            this.filesGroupBox.Controls.Add(this.inputFiletextbox);
            this.filesGroupBox.Location = new System.Drawing.Point(9, 7);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(319, 191);
            this.filesGroupBox.TabIndex = 0;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "I/O Settings";
            // 
            // startFiltering
            // 
            this.startFiltering.Location = new System.Drawing.Point(114, 97);
            this.startFiltering.Name = "startFiltering";
            this.startFiltering.Size = new System.Drawing.Size(75, 23);
            this.startFiltering.TabIndex = 6;
            this.startFiltering.Text = "Start";
            this.startFiltering.UseVisualStyleBackColor = true;
            this.startFiltering.Click += new System.EventHandler(this.startFiltering_Click);
            // 
            // browseOutputbutton
            // 
            this.browseOutputbutton.Location = new System.Drawing.Point(213, 45);
            this.browseOutputbutton.Name = "browseOutputbutton";
            this.browseOutputbutton.Size = new System.Drawing.Size(75, 23);
            this.browseOutputbutton.TabIndex = 5;
            this.browseOutputbutton.Text = "Browse";
            this.browseOutputbutton.UseVisualStyleBackColor = true;
            this.browseOutputbutton.Click += new System.EventHandler(this.browseOutputbutton_Click);
            // 
            // browseInputbutton
            // 
            this.browseInputbutton.Location = new System.Drawing.Point(213, 19);
            this.browseInputbutton.Name = "browseInputbutton";
            this.browseInputbutton.Size = new System.Drawing.Size(75, 23);
            this.browseInputbutton.TabIndex = 4;
            this.browseInputbutton.Text = "Browse";
            this.browseInputbutton.UseVisualStyleBackColor = true;
            this.browseInputbutton.Click += new System.EventHandler(this.browseInputbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File:";
            // 
            // outputFiletextbox
            // 
            this.outputFiletextbox.Location = new System.Drawing.Point(89, 45);
            this.outputFiletextbox.Name = "outputFiletextbox";
            this.outputFiletextbox.ReadOnly = true;
            this.outputFiletextbox.Size = new System.Drawing.Size(100, 20);
            this.outputFiletextbox.TabIndex = 1;
            // 
            // inputFiletextbox
            // 
            this.inputFiletextbox.Location = new System.Drawing.Point(89, 19);
            this.inputFiletextbox.Name = "inputFiletextbox";
            this.inputFiletextbox.ReadOnly = true;
            this.inputFiletextbox.Size = new System.Drawing.Size(100, 20);
            this.inputFiletextbox.TabIndex = 0;
            // 
            // whiteListPage
            // 
            this.whiteListPage.Controls.Add(this.groupBox1);
            this.whiteListPage.Location = new System.Drawing.Point(4, 22);
            this.whiteListPage.Name = "whiteListPage";
            this.whiteListPage.Padding = new System.Windows.Forms.Padding(3);
            this.whiteListPage.Size = new System.Drawing.Size(561, 338);
            this.whiteListPage.TabIndex = 1;
            this.whiteListPage.Text = "White List";
            this.whiteListPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveToWhiteListButton);
            this.groupBox1.Controls.Add(this.addItemToWhiteListButton);
            this.groupBox1.Controls.Add(this.newWhiteListItemTextBox);
            this.groupBox1.Controls.Add(this.whiteFilterListBox);
            this.groupBox1.Controls.Add(this.whiteFilterFileButton);
            this.groupBox1.Controls.Add(this.whiteListTextBox);
            this.groupBox1.Controls.Add(this.whiteFilterFileTextBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "White List Settings";
            // 
            // saveToWhiteListButton
            // 
            this.saveToWhiteListButton.Enabled = false;
            this.saveToWhiteListButton.Location = new System.Drawing.Point(154, 96);
            this.saveToWhiteListButton.Name = "saveToWhiteListButton";
            this.saveToWhiteListButton.Size = new System.Drawing.Size(75, 23);
            this.saveToWhiteListButton.TabIndex = 15;
            this.saveToWhiteListButton.Text = "Save";
            this.saveToWhiteListButton.UseVisualStyleBackColor = true;
            this.saveToWhiteListButton.TextChanged += new System.EventHandler(this.saveToWhiteListButton_TextChanged);
            this.saveToWhiteListButton.Click += new System.EventHandler(this.saveToWhiteListButton_Click);
            // 
            // addItemToWhiteListButton
            // 
            this.addItemToWhiteListButton.Enabled = false;
            this.addItemToWhiteListButton.Location = new System.Drawing.Point(271, 67);
            this.addItemToWhiteListButton.Name = "addItemToWhiteListButton";
            this.addItemToWhiteListButton.Size = new System.Drawing.Size(23, 23);
            this.addItemToWhiteListButton.TabIndex = 14;
            this.addItemToWhiteListButton.Text = "+";
            this.addItemToWhiteListButton.UseVisualStyleBackColor = true;
            this.addItemToWhiteListButton.Click += new System.EventHandler(this.addItemToWhiteListButton_Click);
            // 
            // newWhiteListItemTextBox
            // 
            this.newWhiteListItemTextBox.Location = new System.Drawing.Point(154, 70);
            this.newWhiteListItemTextBox.Name = "newWhiteListItemTextBox";
            this.newWhiteListItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.newWhiteListItemTextBox.TabIndex = 13;
            this.newWhiteListItemTextBox.TextChanged += new System.EventHandler(this.newWhiteListItem_TextChanged);
            // 
            // whiteFilterListBox
            // 
            this.whiteFilterListBox.FormattingEnabled = true;
            this.whiteFilterListBox.Location = new System.Drawing.Point(10, 70);
            this.whiteFilterListBox.Name = "whiteFilterListBox";
            this.whiteFilterListBox.Size = new System.Drawing.Size(138, 251);
            this.whiteFilterListBox.TabIndex = 12;
            // 
            // whiteFilterFileButton
            // 
            this.whiteFilterFileButton.Location = new System.Drawing.Point(205, 18);
            this.whiteFilterFileButton.Name = "whiteFilterFileButton";
            this.whiteFilterFileButton.Size = new System.Drawing.Size(75, 23);
            this.whiteFilterFileButton.TabIndex = 11;
            this.whiteFilterFileButton.Text = "Browse";
            this.whiteFilterFileButton.UseVisualStyleBackColor = true;
            this.whiteFilterFileButton.Click += new System.EventHandler(this.whiteFilterFileButton_Click);
            // 
            // whiteListTextBox
            // 
            this.whiteListTextBox.AutoSize = true;
            this.whiteListTextBox.Location = new System.Drawing.Point(7, 25);
            this.whiteListTextBox.Name = "whiteListTextBox";
            this.whiteListTextBox.Size = new System.Drawing.Size(59, 13);
            this.whiteListTextBox.TabIndex = 9;
            this.whiteListTextBox.Text = "Config File:";
            // 
            // whiteFilterFileTextBox
            // 
            this.whiteFilterFileTextBox.Location = new System.Drawing.Point(81, 18);
            this.whiteFilterFileTextBox.Name = "whiteFilterFileTextBox";
            this.whiteFilterFileTextBox.ReadOnly = true;
            this.whiteFilterFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.whiteFilterFileTextBox.TabIndex = 7;
            // 
            // blackListTabPage
            // 
            this.blackListTabPage.Controls.Add(this.blackFilterBox);
            this.blackListTabPage.Location = new System.Drawing.Point(4, 22);
            this.blackListTabPage.Name = "blackListTabPage";
            this.blackListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blackListTabPage.Size = new System.Drawing.Size(561, 338);
            this.blackListTabPage.TabIndex = 2;
            this.blackListTabPage.Text = "Black List";
            this.blackListTabPage.UseVisualStyleBackColor = true;
            // 
            // saveToBlackListButton
            // 
            this.saveToBlackListButton.Enabled = false;
            this.saveToBlackListButton.Location = new System.Drawing.Point(153, 89);
            this.saveToBlackListButton.Name = "saveToBlackListButton";
            this.saveToBlackListButton.Size = new System.Drawing.Size(75, 23);
            this.saveToBlackListButton.TabIndex = 22;
            this.saveToBlackListButton.Text = "Save";
            this.saveToBlackListButton.UseVisualStyleBackColor = true;
            this.saveToBlackListButton.TextChanged += new System.EventHandler(this.saveToBlackListButton_TextChanged);
            this.saveToBlackListButton.Click += new System.EventHandler(this.saveToBlackListButton_Click);
            // 
            // addItemToBlackListButton
            // 
            this.addItemToBlackListButton.Enabled = false;
            this.addItemToBlackListButton.Location = new System.Drawing.Point(272, 61);
            this.addItemToBlackListButton.Name = "addItemToBlackListButton";
            this.addItemToBlackListButton.Size = new System.Drawing.Size(23, 23);
            this.addItemToBlackListButton.TabIndex = 21;
            this.addItemToBlackListButton.Text = "+";
            this.addItemToBlackListButton.UseVisualStyleBackColor = true;
            this.addItemToBlackListButton.Click += new System.EventHandler(this.addItemToBlackListButton_Click);
            // 
            // newBlackListItemTextBox
            // 
            this.newBlackListItemTextBox.Location = new System.Drawing.Point(153, 63);
            this.newBlackListItemTextBox.Name = "newBlackListItemTextBox";
            this.newBlackListItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.newBlackListItemTextBox.TabIndex = 20;
            this.newBlackListItemTextBox.TextChanged += new System.EventHandler(this.newBlackListItemTextBox_TextChanged);
            // 
            // blackFilterListBox
            // 
            this.blackFilterListBox.FormattingEnabled = true;
            this.blackFilterListBox.Location = new System.Drawing.Point(9, 63);
            this.blackFilterListBox.Name = "blackFilterListBox";
            this.blackFilterListBox.Size = new System.Drawing.Size(138, 251);
            this.blackFilterListBox.TabIndex = 19;
            this.blackFilterListBox.SelectedIndexChanged += new System.EventHandler(this.blackFilterListBox_SelectedIndexChanged);
            // 
            // blackFilterFileButton
            // 
            this.blackFilterFileButton.Location = new System.Drawing.Point(195, 19);
            this.blackFilterFileButton.Name = "blackFilterFileButton";
            this.blackFilterFileButton.Size = new System.Drawing.Size(75, 23);
            this.blackFilterFileButton.TabIndex = 18;
            this.blackFilterFileButton.Text = "Browse";
            this.blackFilterFileButton.UseVisualStyleBackColor = true;
            this.blackFilterFileButton.Click += new System.EventHandler(this.blackFilterFileButton_Click);
            // 
            // blackListTextBox
            // 
            this.blackListTextBox.AutoSize = true;
            this.blackListTextBox.Location = new System.Drawing.Point(6, 26);
            this.blackListTextBox.Name = "blackListTextBox";
            this.blackListTextBox.Size = new System.Drawing.Size(59, 13);
            this.blackListTextBox.TabIndex = 17;
            this.blackListTextBox.Text = "Config File:";
            // 
            // blackFilterFileTextBox
            // 
            this.blackFilterFileTextBox.Location = new System.Drawing.Point(71, 19);
            this.blackFilterFileTextBox.Name = "blackFilterFileTextBox";
            this.blackFilterFileTextBox.ReadOnly = true;
            this.blackFilterFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.blackFilterFileTextBox.TabIndex = 16;
            this.blackFilterFileTextBox.TextChanged += new System.EventHandler(this.blackFilterFileTextBox_TextChanged);
            // 
            // blackFilterBox
            // 
            this.blackFilterBox.Controls.Add(this.blackListTextBox);
            this.blackFilterBox.Controls.Add(this.addItemToBlackListButton);
            this.blackFilterBox.Controls.Add(this.saveToBlackListButton);
            this.blackFilterBox.Controls.Add(this.newBlackListItemTextBox);
            this.blackFilterBox.Controls.Add(this.blackFilterFileTextBox);
            this.blackFilterBox.Controls.Add(this.blackFilterFileButton);
            this.blackFilterBox.Controls.Add(this.blackFilterListBox);
            this.blackFilterBox.Location = new System.Drawing.Point(8, 6);
            this.blackFilterBox.Name = "blackFilterBox";
            this.blackFilterBox.Size = new System.Drawing.Size(550, 336);
            this.blackFilterBox.TabIndex = 23;
            this.blackFilterBox.TabStop = false;
            this.blackFilterBox.Text = "Black List Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 364);
            this.Controls.Add(this.filterTabControl);
            this.Name = "MainForm";
            this.Text = "Filters";
            this.filterTabControl.ResumeLayout(false);
            this.generalConfig.ResumeLayout(false);
            this.filesGroupBox.ResumeLayout(false);
            this.filesGroupBox.PerformLayout();
            this.whiteListPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.blackListTabPage.ResumeLayout(false);
            this.blackFilterBox.ResumeLayout(false);
            this.blackFilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl filterTabControl;
        private System.Windows.Forms.TabPage generalConfig;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.Button startFiltering;
        private System.Windows.Forms.Button browseOutputbutton;
        private System.Windows.Forms.Button browseInputbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputFiletextbox;
        private System.Windows.Forms.TextBox inputFiletextbox;
        private System.Windows.Forms.TabPage whiteListPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button whiteFilterFileButton;
        private System.Windows.Forms.Label whiteListTextBox;
        private System.Windows.Forms.TextBox whiteFilterFileTextBox;
        private System.Windows.Forms.TabPage blackListTabPage;
        private System.Windows.Forms.ListBox whiteFilterListBox;
        private System.Windows.Forms.Button addItemToWhiteListButton;
        private System.Windows.Forms.TextBox newWhiteListItemTextBox;
        private System.Windows.Forms.Button saveToWhiteListButton;
        private System.Windows.Forms.Button saveToBlackListButton;
        private System.Windows.Forms.Button addItemToBlackListButton;
        private System.Windows.Forms.TextBox newBlackListItemTextBox;
        private System.Windows.Forms.ListBox blackFilterListBox;
        private System.Windows.Forms.Button blackFilterFileButton;
        private System.Windows.Forms.Label blackListTextBox;
        private System.Windows.Forms.TextBox blackFilterFileTextBox;
        private System.Windows.Forms.GroupBox blackFilterBox;
    }
}

