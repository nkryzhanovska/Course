namespace Lesson14
{
    partial class SpeedTest
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
            this.speedGroupBox = new System.Windows.Forms.GroupBox();
            this.selectNetBasedQueueCheckBox = new System.Windows.Forms.CheckBox();
            this.selectArrayBasedQueueCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.selectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.selectNetBasedStackCheckBox = new System.Windows.Forms.CheckBox();
            this.selectLinkedListStackCheckBox = new System.Windows.Forms.CheckBox();
            this.selectArrayBasedStackCheckBox = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.Label();
            this.selectType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.speedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // speedGroupBox
            // 
            this.speedGroupBox.Controls.Add(this.resultTextBox);
            this.speedGroupBox.Controls.Add(this.label1);
            this.speedGroupBox.Controls.Add(this.selectType);
            this.speedGroupBox.Controls.Add(this.title);
            this.speedGroupBox.Controls.Add(this.selectNetBasedQueueCheckBox);
            this.speedGroupBox.Controls.Add(this.selectArrayBasedQueueCheckBox);
            this.speedGroupBox.Controls.Add(this.button1);
            this.speedGroupBox.Controls.Add(this.selectTypeComboBox);
            this.speedGroupBox.Controls.Add(this.selectNetBasedStackCheckBox);
            this.speedGroupBox.Controls.Add(this.selectLinkedListStackCheckBox);
            this.speedGroupBox.Controls.Add(this.selectArrayBasedStackCheckBox);
            this.speedGroupBox.Location = new System.Drawing.Point(12, 12);
            this.speedGroupBox.Name = "speedGroupBox";
            this.speedGroupBox.Size = new System.Drawing.Size(385, 486);
            this.speedGroupBox.TabIndex = 0;
            this.speedGroupBox.TabStop = false;
            this.speedGroupBox.Text = "Settings";
            // 
            // selectNetBasedQueueCheckBox
            // 
            this.selectNetBasedQueueCheckBox.AutoSize = true;
            this.selectNetBasedQueueCheckBox.Location = new System.Drawing.Point(192, 216);
            this.selectNetBasedQueueCheckBox.Name = "selectNetBasedQueueCheckBox";
            this.selectNetBasedQueueCheckBox.Size = new System.Drawing.Size(158, 17);
            this.selectNetBasedQueueCheckBox.TabIndex = 9;
            this.selectNetBasedQueueCheckBox.Text = ".Net Implementations Based";
            this.selectNetBasedQueueCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectArrayBasedQueueCheckBox
            // 
            this.selectArrayBasedQueueCheckBox.AutoSize = true;
            this.selectArrayBasedQueueCheckBox.Location = new System.Drawing.Point(192, 193);
            this.selectArrayBasedQueueCheckBox.Name = "selectArrayBasedQueueCheckBox";
            this.selectArrayBasedQueueCheckBox.Size = new System.Drawing.Size(83, 17);
            this.selectArrayBasedQueueCheckBox.TabIndex = 8;
            this.selectArrayBasedQueueCheckBox.Text = "Array Based";
            this.selectArrayBasedQueueCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // selectTypeComboBox
            // 
            this.selectTypeComboBox.FormattingEnabled = true;
            this.selectTypeComboBox.Location = new System.Drawing.Point(19, 94);
            this.selectTypeComboBox.Name = "selectTypeComboBox";
            this.selectTypeComboBox.Size = new System.Drawing.Size(204, 21);
            this.selectTypeComboBox.TabIndex = 3;
            this.selectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTypeComboBox_SelectedIndexChanged);
            // 
            // selectNetBasedStackCheckBox
            // 
            this.selectNetBasedStackCheckBox.AutoSize = true;
            this.selectNetBasedStackCheckBox.Location = new System.Drawing.Point(19, 239);
            this.selectNetBasedStackCheckBox.Name = "selectNetBasedStackCheckBox";
            this.selectNetBasedStackCheckBox.Size = new System.Drawing.Size(158, 17);
            this.selectNetBasedStackCheckBox.TabIndex = 2;
            this.selectNetBasedStackCheckBox.Text = ".Net Implementations Based";
            this.selectNetBasedStackCheckBox.UseVisualStyleBackColor = true;
            this.selectNetBasedStackCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // selectLinkedListStackCheckBox
            // 
            this.selectLinkedListStackCheckBox.AutoSize = true;
            this.selectLinkedListStackCheckBox.Location = new System.Drawing.Point(19, 216);
            this.selectLinkedListStackCheckBox.Name = "selectLinkedListStackCheckBox";
            this.selectLinkedListStackCheckBox.Size = new System.Drawing.Size(110, 17);
            this.selectLinkedListStackCheckBox.TabIndex = 1;
            this.selectLinkedListStackCheckBox.Text = "Linked List Based";
            this.selectLinkedListStackCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectArrayBasedStackCheckBox
            // 
            this.selectArrayBasedStackCheckBox.AutoSize = true;
            this.selectArrayBasedStackCheckBox.Location = new System.Drawing.Point(19, 193);
            this.selectArrayBasedStackCheckBox.Name = "selectArrayBasedStackCheckBox";
            this.selectArrayBasedStackCheckBox.Size = new System.Drawing.Size(83, 17);
            this.selectArrayBasedStackCheckBox.TabIndex = 0;
            this.selectArrayBasedStackCheckBox.Text = "Array Based";
            this.selectArrayBasedStackCheckBox.UseVisualStyleBackColor = true;
            this.selectArrayBasedStackCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(47, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(244, 40);
            this.title.TabIndex = 11;
            this.title.Text = "Programm of speed comparison \r\nof the Queue and Stack Methods";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectType
            // 
            this.selectType.AutoSize = true;
            this.selectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectType.Location = new System.Drawing.Point(19, 74);
            this.selectType.Name = "selectType";
            this.selectType.Size = new System.Drawing.Size(169, 17);
            this.selectType.TabIndex = 12;
            this.selectType.Text = "Select Type of data order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select two Methods of adding data to \r\ncompare their speed:\r\n";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(6, 326);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(373, 58);
            this.resultTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 510);
            this.Controls.Add(this.speedGroupBox);
            this.Name = "Form1";
            this.Text = "Speed Comparison";
            this.speedGroupBox.ResumeLayout(false);
            this.speedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox speedGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox selectTypeComboBox;
        private System.Windows.Forms.CheckBox selectNetBasedStackCheckBox;
        private System.Windows.Forms.CheckBox selectLinkedListStackCheckBox;
        private System.Windows.Forms.CheckBox selectArrayBasedStackCheckBox;
        private System.Windows.Forms.CheckBox selectNetBasedQueueCheckBox;
        private System.Windows.Forms.CheckBox selectArrayBasedQueueCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectType;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

