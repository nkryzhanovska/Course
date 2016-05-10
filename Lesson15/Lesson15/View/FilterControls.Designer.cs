namespace Lesson15
{
    partial class FilterControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.commonListTextBox = new System.Windows.Forms.Label();
            this.commonFilterFileTextBox = new System.Windows.Forms.TextBox();
            this.commonFilterBox = new System.Windows.Forms.GroupBox();
            this.removeItemFromCommonListButton = new System.Windows.Forms.Button();
            this.addItemToCommonListButton = new System.Windows.Forms.Button();
            this.saveToCommonListButton = new System.Windows.Forms.Button();
            this.newCommonListItemTextBox = new System.Windows.Forms.TextBox();
            this.commonFilterFileButton = new System.Windows.Forms.Button();
            this.commonFilterListBox = new System.Windows.Forms.ListBox();
            this.commonFilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // commonListTextBox
            // 
            this.commonListTextBox.AutoSize = true;
            this.commonListTextBox.Location = new System.Drawing.Point(6, 26);
            this.commonListTextBox.Name = "commonListTextBox";
            this.commonListTextBox.Size = new System.Drawing.Size(59, 13);
            this.commonListTextBox.TabIndex = 17;
            this.commonListTextBox.Text = "Config File:";
            // 
            // commonFilterFileTextBox
            // 
            this.commonFilterFileTextBox.Location = new System.Drawing.Point(71, 19);
            this.commonFilterFileTextBox.Name = "commonFilterFileTextBox";
            this.commonFilterFileTextBox.ReadOnly = true;
            this.commonFilterFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.commonFilterFileTextBox.TabIndex = 16;
            // 
            // commonFilterBox
            // 
            this.commonFilterBox.Controls.Add(this.removeItemFromCommonListButton);
            this.commonFilterBox.Controls.Add(this.commonListTextBox);
            this.commonFilterBox.Controls.Add(this.addItemToCommonListButton);
            this.commonFilterBox.Controls.Add(this.saveToCommonListButton);
            this.commonFilterBox.Controls.Add(this.newCommonListItemTextBox);
            this.commonFilterBox.Controls.Add(this.commonFilterFileTextBox);
            this.commonFilterBox.Controls.Add(this.commonFilterFileButton);
            this.commonFilterBox.Controls.Add(this.commonFilterListBox);
            this.commonFilterBox.Location = new System.Drawing.Point(21, 15);
            this.commonFilterBox.Name = "commonFilterBox";
            this.commonFilterBox.Size = new System.Drawing.Size(474, 302);
            this.commonFilterBox.TabIndex = 24;
            this.commonFilterBox.TabStop = false;
            this.commonFilterBox.Text = "Settings";
            // 
            // removeItemFromCommonListButton
            // 
            this.removeItemFromCommonListButton.Enabled = false;
            this.removeItemFromCommonListButton.Location = new System.Drawing.Point(301, 61);
            this.removeItemFromCommonListButton.Name = "removeItemFromCommonListButton";
            this.removeItemFromCommonListButton.Size = new System.Drawing.Size(23, 23);
            this.removeItemFromCommonListButton.TabIndex = 23;
            this.removeItemFromCommonListButton.Text = "-";
            this.removeItemFromCommonListButton.UseVisualStyleBackColor = true;
            this.removeItemFromCommonListButton.Click += new System.EventHandler(this.removeItemFromCommonListButton_Click);
            // 
            // addItemToCommonListButton
            // 
            this.addItemToCommonListButton.Enabled = false;
            this.addItemToCommonListButton.Location = new System.Drawing.Point(272, 61);
            this.addItemToCommonListButton.Name = "addItemToCommonListButton";
            this.addItemToCommonListButton.Size = new System.Drawing.Size(23, 23);
            this.addItemToCommonListButton.TabIndex = 21;
            this.addItemToCommonListButton.Text = "+";
            this.addItemToCommonListButton.UseVisualStyleBackColor = true;
            this.addItemToCommonListButton.Click += new System.EventHandler(this.addItemToCommonListButton_Click);
            // 
            // saveToCommonListButton
            // 
            this.saveToCommonListButton.Enabled = false;
            this.saveToCommonListButton.Location = new System.Drawing.Point(153, 89);
            this.saveToCommonListButton.Name = "saveToCommonListButton";
            this.saveToCommonListButton.Size = new System.Drawing.Size(75, 23);
            this.saveToCommonListButton.TabIndex = 22;
            this.saveToCommonListButton.Text = "Save";
            this.saveToCommonListButton.UseVisualStyleBackColor = true;
            // 
            // newCommonListItemTextBox
            // 
            this.newCommonListItemTextBox.Location = new System.Drawing.Point(153, 63);
            this.newCommonListItemTextBox.Name = "newCommonListItemTextBox";
            this.newCommonListItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.newCommonListItemTextBox.TabIndex = 20;
            this.newCommonListItemTextBox.TextChanged += new System.EventHandler(this.newCommonListItemTextBox_TextChanged);
            // 
            // commonFilterFileButton
            // 
            this.commonFilterFileButton.Location = new System.Drawing.Point(195, 19);
            this.commonFilterFileButton.Name = "commonFilterFileButton";
            this.commonFilterFileButton.Size = new System.Drawing.Size(75, 23);
            this.commonFilterFileButton.TabIndex = 18;
            this.commonFilterFileButton.Text = "Browse";
            this.commonFilterFileButton.UseVisualStyleBackColor = true;
            this.commonFilterFileButton.Click += new System.EventHandler(this.commonFilterFileButton_Click);
            // 
            // commonFilterListBox
            // 
            this.commonFilterListBox.FormattingEnabled = true;
            this.commonFilterListBox.Location = new System.Drawing.Point(9, 63);
            this.commonFilterListBox.Name = "commonFilterListBox";
            this.commonFilterListBox.Size = new System.Drawing.Size(138, 225);
            this.commonFilterListBox.TabIndex = 19;
            this.commonFilterListBox.SelectedIndexChanged += new System.EventHandler(this.commonFilterListBox_SelectedIndexChanged);
            // 
            // FilterControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.commonFilterBox);
            this.Name = "FilterControls";
            this.Size = new System.Drawing.Size(562, 367);
            this.commonFilterBox.ResumeLayout(false);
            this.commonFilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label commonListTextBox;
        private System.Windows.Forms.TextBox commonFilterFileTextBox;
        private System.Windows.Forms.GroupBox commonFilterBox;
        private System.Windows.Forms.Button addItemToCommonListButton;
        private System.Windows.Forms.Button saveToCommonListButton;
        private System.Windows.Forms.TextBox newCommonListItemTextBox;
        private System.Windows.Forms.Button commonFilterFileButton;
        private System.Windows.Forms.ListBox commonFilterListBox;
        private System.Windows.Forms.Button removeItemFromCommonListButton;
    }
}
