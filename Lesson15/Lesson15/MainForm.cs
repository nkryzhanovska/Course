using Lesson15.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson15
{
    public partial class MainForm : Form
    {
        FilterViewControl controller;
        public MainForm()
        {
            InitializeComponent();
            controller = new FilterViewControl();
            controller.AttachView(newFilterControl);
        }

        private void browseInputbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "(*.txt)";
            DialogResult result = fileDialog.ShowDialog();

            
            if (result == DialogResult.OK)
            {
                inputFiletextbox.Text = fileDialog.FileName;
            }
        }

        private void browseOutputbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "(*.txt)";
            DialogResult result = fileDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                outputFiletextbox.Text = fileDialog.FileName;
            }
        }

        private void startFiltering_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(inputFiletextbox.Text))
            {
                MessageBox.Show("Please choose input file.");
                return;
            }

            if (String.IsNullOrEmpty(outputFiletextbox.Text))
            {
                MessageBox.Show("Please choose input file.");
                return;
            }

            if (inputFiletextbox.Text.Equals(outputFiletextbox.Text, StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Choose different file!");
                return;
            }
        }

        private void whiteFilterFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "(*.txt)";
            DialogResult result = fileDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                whiteFilterFileTextBox.Text = fileDialog.FileName;
            }

            using (StreamReader reader = new StreamReader(whiteFilterFileTextBox.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    whiteFilterListBox.Items.Add(line);
                }
            }

        }

        private void newWhiteListItem_TextChanged(object sender, EventArgs e)
        {
            addItemToWhiteListButton.Enabled = !String.IsNullOrEmpty(newWhiteListItemTextBox.Text);
        }

        private void addItemToWhiteListButton_Click(object sender, EventArgs e)
        {
            whiteFilterListBox.Items.Add(newWhiteListItemTextBox.Text);
            saveToWhiteListButton.Enabled = !String.IsNullOrEmpty(whiteFilterFileTextBox.Text);
        }

        private void saveToWhiteListButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(whiteFilterFileTextBox.Text))
                {
                    foreach (string whiteListItem in whiteFilterListBox.Items)
                    {
                        writer.WriteLine(whiteListItem);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File is read only!");            
            }
        }

        private void saveToWhiteListButton_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void whiteFilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void whiteListTextBox_Click(object sender, EventArgs e)
        {

        }

        private void whiteFilterFileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void blackFilterFileTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void blackFilterFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Filter = "(*.txt)";
            DialogResult result = fileDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                blackFilterFileTextBox.Text = fileDialog.FileName;
            }

            using (StreamReader reader = new StreamReader(blackFilterFileTextBox.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    blackFilterListBox.Items.Add(line);
                }
            }
        }

        private void newBlackListItemTextBox_TextChanged(object sender, EventArgs e)
        {
            addItemToBlackListButton.Enabled = !String.IsNullOrEmpty(newBlackListItemTextBox.Text);
        }

        private void blackFilterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addItemToBlackListButton_Click(object sender, EventArgs e)
        {
            blackFilterListBox.Items.Add(newBlackListItemTextBox.Text);
            saveToBlackListButton.Enabled = !String.IsNullOrEmpty(blackFilterFileTextBox.Text);
        }

        private void saveToBlackListButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(blackFilterFileTextBox.Text))
                {
                    foreach (string blackListItem in blackFilterListBox.Items)
                    {
                        writer.WriteLine(blackListItem);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File is read only!");
            }
        }

        private void saveToBlackListButton_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
